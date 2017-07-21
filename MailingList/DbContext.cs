using MailingList.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MailingList
{
    public class DbContext : IDisposable
    {
        public static readonly string ConnectionString = @"server=(localdb)\MSSQLLocalDB;database=MailingList;user=user;password=qwerty";
        private SqlConnection connection = new SqlConnection(DbContext.ConnectionString);

        public DataTable GetInboxContent(string email)
        {
            var query = @"select Emails.EmailId, GroupName , Subject,Body,ReceiveDate,Sender  from Emails join Email_Users on Emails.EmailId=Email_Users.EmailId
 join Group_Emails on Group_Emails.EmailId=Emails.EmailId
 join Groups on Groups.GroupId = Group_Emails.GroupId
 where Email_Users.UserEmail=@UserEmail";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserEmail", email);


            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            ada.Fill(dt);
            return dt;
        }

       /* public List<Notification> GetNotifications(string currentEmail)
        {
            throw new NotImplementedException();
        }
        */
        public DataTable GetSentMail(string email)
        {
            var query = @"select GroupName , Subject,Body,SendDate,Sender  from Emails join Group_Emails on Group_Emails.EmailId=Emails.EmailId
 join Groups on Groups.GroupId = Group_Emails.GroupId
 where Emails.Sender=@UserEmail";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserEmail", email);


            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ada.Fill(dt);
            return dt;
        }

        public DbContext()
        {
            connection.Open();
        }

        public void AddNewUser(RegisterUser user)
        {
            string query = @"insert into Users (Email,Password, FirstName,LastName,PhoneNumber,Gender,BirthDate,RegisterDate)
values
(@Email,@Password,@FirstName,@LastName,@PhoneNumber,@Gender,@BirthDate,GETDATE())";

            //.FormatReplace(nameof(user.Email), nameof(user.Password), user.FirstName, user.LastName, user.PhoneNumber, (int)user.Gender, user.BirthDate, DateTime.Now);

            SqlCommand cmd = new SqlCommand(query, connection);
            foreach(var p in user.GetType().GetProperties())
            {
                var pName = "@" + p.Name;
                var value = p.GetValue(user);
                cmd.Parameters.AddWithValue(pName, value);
            }

            int RowAffectedCount = cmd.ExecuteNonQuery();
        }

        public List<User> GroupMembers(int selectedGroupId)
        {
            string query = @"select * from Users join Group_Users on Group_Users.UserEmail=Users.Email where GroupId=@GroupId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@GroupId", selectedGroupId);

            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            var result = dt.AsEnumerable().Select(a =>
                  new User
                  {
                      Email = (string)a["Email"],
                    //Password = (string)a["Password"],
                    //PhoneNumber = (string)a["PhoneNumber"],
                    //BirthDate = (DateTime)a["BirthDate"],
                      Firstname = (string)a["FirstName"],
                      Lastname=(string)a["LastName"],
                      Gender=(Gender)a["Gender"]
                  }).ToList();
            return result;
        }

        public void DeleteMember(int selectedGroup, string selectedMember)
        {
            string query = @"delete from Group_Users where GroupId=@GroupId and UserEmail=@Email";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", selectedMember);
            cmd.Parameters.AddWithValue("@GroupId", selectedGroup);

            cmd.ExecuteNonQuery();
        }

        public  List<Group> CreatedGroups(string currentEmail)
        {
            string query = @"select * from Groups where Admin=@Email";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", currentEmail);

            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            var result = dt.AsEnumerable().Select(a =>
                  new Group
                  {
                      Admin = (string)a["Admin"],
                      CreateDate = (DateTime)a["CreateDate"],
                      GroupId = (int)a["GroupId"],
                      GroupName = (string)a["GroupName"],
                      IamAdmin = (string)a["Admin"] == currentEmail
                  }).ToList();
            return result;
        }

        public void SetRead(int emailId,string userEmail)
        {
            string query = @"update Email_Users set UnRead=0 where UserEmail=@Email and EmailId=@EmailId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", userEmail );
            cmd.Parameters.AddWithValue("@EmailId", emailId);
            cmd.ExecuteNonQuery();
            //System.Windows.Forms.MessageBox.Show("read");
        }

        public  List<Group> GetNotJoinedGroups(string currentEmail)
        {
            string query= @"select * from Groups left join Group_Users
on Groups.GroupId=Group_Users.GroupId and UserEmail=@Email where UserEmail is null";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", currentEmail);

            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            var result = dt.AsEnumerable().Select(a =>
                  new Group
                  {
                      Admin = (string)a["Admin"],
                      CreateDate = (DateTime)a["CreateDate"],
                      GroupId = (int)a["GroupId"],
                      GroupName = (string)a["GroupName"],
                      IamAdmin = (string)a["Admin"] == currentEmail
                  }).ToList();
            return result;
        }

        public int SendEmail(Email email,Group group)
        {
            //Fill Emails table
            string query = @"insert into Emails(Sender,Subject,Body,Attachment,CreateDate,SendDate)
values(@Admin,@Subject,@Body,@Attachment,GETDATE(),@SendDate)";

            SqlCommand cmd = new SqlCommand(query, connection);
            foreach (var p in email.GetType().GetProperties())
            {
                var pName = "@" + p.Name;
                var value = p.GetValue(email);
                cmd.Parameters.AddWithValue(pName, value);
            }

            cmd.Parameters.AddWithValue("@Admin", group.Admin);
            cmd.ExecuteNonQuery();

            query = @"select EmailId from Emails order by EmailId DESC";
            cmd.CommandText=query;
            cmd.ExecuteNonQuery();
            var rdr = cmd.ExecuteReader();
            rdr.Read();
            var result = rdr["EmailId"];
            email.EmailId=(int)result;
            connection.Close();
            //return email.EmailId;
            //Fill Group_Emails table

            connection.Open();
            query = @"insert into Group_Emails(GroupId,EmailId)values(@GroupId,@EmailId)";
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@GroupId", group.GroupId);
            cmd.Parameters.AddWithValue("@EmailId", email.EmailId);
            cmd.ExecuteNonQuery();

            //Fill Email_Users
            query = @"insert into Email_Users (UserEmail,EmailId,ReceiveDate,ReceiveSMS,ReceiveHTML,UnRead)
select A.UserEmail,@EmailId,GETDATE() as [RecieveDate] , A.ReceiveSMS,A.ReceiveHTML,1 from Group_Users A where A.GroupId=@GroupId";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@EmailId", email.EmailId);
            cmd.Parameters.AddWithValue("@GroupId", group.GroupId);
            cmd.ExecuteNonQuery();

            return 0;

        }

        public void JoinGroup(string currentEmail, Group selectedGroup, bool receiveSMS, bool receiveHTML,bool visible)
        {
            string query = @"insert into Group_Users (UserEmail,GroupId,RegisterDate,ReceiveHTML,ReceiveSMS,Visible)
values (@Email,@selectedGroupId,GETDATE(),@ReceiveHTML,@ReceiveSMS,@Visible)";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", currentEmail);
            cmd.Parameters.AddWithValue("@selectedGroupId", selectedGroup.GroupId);
            cmd.Parameters.AddWithValue("@ReceiveHTML", receiveHTML);
            cmd.Parameters.AddWithValue("@ReceiveSMS", receiveSMS);
            cmd.Parameters.AddWithValue("@Visible", visible);
            cmd.ExecuteNonQuery();
        }

        public void DeleteGroup(string currentEmail, Group selectedGroup)
        {
            string query = @"delete from Group_Users where UserEmail=@Email and GroupId=@selectedGroupId";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", currentEmail);
            cmd.Parameters.AddWithValue("@selectedGroupId", selectedGroup.GroupId);

            cmd.ExecuteNonQuery();
        }

        public List<Group> GetJoinedGroups(string currentEmail)
        {
            string query = @"select * from Groups  join Group_Users
on Groups.GroupId=Group_Users.GroupId where UserEmail=@Email";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", currentEmail);

            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            ada.Fill(dt);

            var result = dt.AsEnumerable().Select(a =>
                new Group
                {
                    Admin = (string)a["Admin"],
                    CreateDate = (DateTime)a["CreateDate"],
                    GroupId = (int)a["GroupId"],
                    GroupName = (string)a["GroupName"],
                    IamAdmin = (string)a["Admin"] == currentEmail
                }).ToList();

            return result;
        }

        public User LoginUser( LoginUser login)
        {
            string query = @"select * from Users where Email=@Email and Password=@Password";
            SqlCommand cmd = new SqlCommand(query, connection);
            foreach(var p in login.GetType().GetProperties())
            {
                var pName = "@" + p.Name;
                var value = p.GetValue(login);
                cmd.Parameters.AddWithValue(pName, value);
            }

            var rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                User result = new User();
                foreach(var p in result.GetType().GetProperties())
                {
                    var value = rdr[p.Name];
                    p.SetValue(result, value);
                }

                return result;
            }
            else
            {
                throw new Exception("user not found.");
            }
        }
        public void CreateGroup(string adminemail,string groupname)
        {
            string query = @"insert into [Groups] (Admin,GroupName,CreateDate)
values(@Admin,@GroupName,GETDATE())";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Admin", adminemail);
            cmd.Parameters.AddWithValue("@GroupName", groupname);

            cmd.ExecuteNonQuery();
        }
        public void Dispose()
        {
            connection.Close();
        }
    }
}