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
    public partial class NotificationForm : Form
    {
        public NotificationForm(string currentEmail)
        {
            InitializeComponent();
            /*using (var db=new DbContext())
            {
                db.GetNotifications(currentEmail);
            }*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
