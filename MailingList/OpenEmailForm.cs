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
    public partial class OpenEmailForm : Form
    {
        public OpenEmailForm(Email email)
        {
            InitializeComponent();
            txtBody.Text = email.Body;
            txtSubject.Text = email.Subject;
            txtSender.Text = email.Sender;
            txtDate.Text = email.SendDate.ToShortDateString();
            //this.Row = row;
            
        }

        //public DataRow Row { get; private set; }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenEmailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
