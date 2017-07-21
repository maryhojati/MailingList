using MailingList.Model;
using System;
using System.Windows.Forms;

namespace MailingList
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // filling the User Object
                RegisterUser user = new RegisterUser();
                user.Email = txtEmail.Text+txtDomain.Text;
                user.Password = txtPassword.Text;            
                user.RePassword = txtRePassword.Text;
                user.PhoneNumber = txtPhone.Text;
                user.Firstname = txtFirstName.Text;
                user.Lastname = txtLastName.Text;
                user.BirthDate = dtBirthDate.Value;
                if(rdoFemale.Checked)
                {
                    user.Gender = Gender.Female;
                }
                else
                {
                    user.Gender = Gender.Male;
                }


                
                //Validate the input informations
                var error = user.GetValidationError();
                if(error!=null)
                {
                    throw new Exception(error);
                }

                //store to database
                using(var db = new DbContext())
                {
                    db.AddNewUser(user);                    
                }

                //successfull registeration
                MessageBox.Show("Account {0} Created Successfully!".FormatReplace(user.Email));
                this.Close(); //closing the form
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}