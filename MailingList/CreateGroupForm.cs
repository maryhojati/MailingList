using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailingList.Model
{
    public partial class CreateGroupForm : Form
    {

        public string AdminEmail{ get; set; }
        public CreateGroupForm(string adminemail)
        {
            InitializeComponent();

            this.AdminEmail = adminemail;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using(var db = new DbContext())           
                {
                    db.CreateGroup(AdminEmail, txtGroupName.Text);
                                         
                }

                MessageBox.Show("Group "+txtGroupName.Text+" Created.");
                //this.Close();
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = !string.IsNullOrWhiteSpace(txtGroupName.Text);
        }
    }
}
