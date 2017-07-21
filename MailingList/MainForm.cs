using MailingList.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace MailingList
{
    public partial class MainForm : Form
    {
        public User LoggedInUser { get; set; } = null;

        public MainForm()
        {
            InitializeComponent();

        }
        private void RefreshInbox()
        {
            using (var db=new DbContext())
            {
                DataTable result=db.GetInboxContent(LoggedInUser.Email);
                lstEmails.DataSource = result;
                lstEmails.Columns["EmailId"].Visible = false;
            }
        }

        private void RefreshSentMails()
        {
            using (var db=new DbContext())
            {
                DataTable result = db.GetSentMail(LoggedInUser.Email);
                lstEmails.DataSource = result;
                //lstEmails.Columns["EmailId"].Visible = false;
            }
        }
        private void btnJoinedGroups_Click_1(object sender, EventArgs e)
        {
            using (var frm = new CreateGroupForm(LoggedInUser.Email))
            {
                frm.ShowDialog();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                /*System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                this.Close();

                */
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
        }

        private void createNewGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateGroupForm frm = new CreateGroupForm(LoggedInUser.Email))
            {
                frm.ShowDialog();
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {


            using (LoginForm frm = new LoginForm())
            {
                frm.ShowDialog();
                this.LoggedInUser = frm.LoggedInUser;
                if (LoggedInUser != null)
                {
                    txtEmail.Text = LoggedInUser.Email;
                    txtFullName.Text = LoggedInUser.Firstname + ' ' + LoggedInUser.Lastname;
                    btnLogin.Visible = false;
                }
            }
            lstBoxLabels.SetSelected(0,true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnLogin.PerformClick();
        }

        private void myGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new CreatedGroupsForm(LoggedInUser.Email))
            {
                frm.ShowDialog();
            }
        }

        private void joinGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new JoinGroupForm(LoggedInUser.Email))
            {
                frm.ShowDialog();
            }
        }


        private void lstEmails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var email = new Email
            {
                EmailId = (int)lstEmails.SelectedRows[0].Cells["EmailId"].Value,
                Body = (string)lstEmails.SelectedRows[0].Cells["Body"].Value,
                SendDate = (DateTime)lstEmails.SelectedRows[0].Cells["ReceiveDate"].Value,
                CreateDate = (DateTime)lstEmails.SelectedRows[0].Cells["ReceiveDate"].Value,
                Sender = (string)lstEmails.SelectedRows[0].Cells["Sender"].Value,
                Subject = (string)lstEmails.SelectedRows[0].Cells["Subject"].Value,
            };
            /* DataTable dt = new DataTable();
             //dt = lstEmails.Rows.;
             DataGridViewRow selectedEmail;
             //lstEmails.SelectedRows.CopyTo(selectedEmail, 0);
             DataGridViewRow row = lstEmails.SelectedRows.;
             */

            //DataTable dt = new DataTable();
            

            var frm = new OpenEmailForm(email);

            frm.TopLevel = false;
            pnlInner.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.Show();
            RefreshInbox();
            lstBoxLabels.SetSelected(0, true);
            using (var db=new DbContext())
            {
               db.SetRead(email.EmailId,LoggedInUser.Email);
            }

        }

        private void lstBoxLabels_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lstEmails.BringToFront();
            if (lstBoxLabels.SelectedIndex==0)
            {
                RefreshInbox();
            }
            else if(lstBoxLabels.SelectedIndex==1)
            {
                RefreshSentMails();
            }
        }

        private void btnCompose_Click(object sender, EventArgs e)
        {

            lstBoxLabels.SelectedIndex = -1;

            NewEmail frm = new NewEmail(LoggedInUser.Email);

            frm.TopLevel = false;
            pnlInner.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.Show();
            RefreshInbox();
            lstBoxLabels.SetSelected(0, true);
        }

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new NotificationForm(LoggedInUser.Email);

            frm.TopLevel = false;
            pnlMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.Show();
            //RefreshInbox();
            //lstBoxLabels.SetSelected(0, true);
        }
    }
}