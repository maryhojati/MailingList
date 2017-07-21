using MailingList.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailingList
{
    public partial class LoginForm : Form
    {
        public User LoggedInUser { get; set; } = null;
        public LoginForm()
        {
            InitializeComponent();
#if DEBUG
            txtPassword.Text = "123";
            txtEmail.Text = "maryamhojati@db.com";
#endif
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                LoginUser login = new LoginUser();
                login.Email = txtEmail.Text;
                login.Password = (string)txtPassword.Text;


                using(var db=new DbContext())
                {
                    this.LoggedInUser = db.LoginUser(login);
                    this.Close();
                }



            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();

            }
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            btnLogin.Enabled = !string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text);
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(RegisterForm frm=new RegisterForm())
            {
                frm.ShowDialog();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.LoggedInUser==null)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
