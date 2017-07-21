using MailingList.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MailingList
{
    public partial class NewEmail : Form
    {
        public List<Group> MyGroups { get; set; }
        public string CurrentEmail { get; set; }
        public byte[] Attachment { get; private set; } = null;

        public NewEmail(string currentEmail)
        {
            InitializeComponent();
            this.CurrentEmail = currentEmail;
            using (var db = new DbContext())
            {
                MyGroups = db.CreatedGroups(currentEmail);
            }
            cboReceipt.DataSource = MyGroups;
            //txtRecipient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            //source.AddRange(JoinedGroups.Select(g => g.GroupName).ToArray());
            //txtRecipient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtRecipient.AutoCompleteCustomSource = source;
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog()== DialogResult.OK)
            {
                this.Attachment = System.IO.File.ReadAllBytes(op.FileName);
                txtAttachedFile.Text = op.FileName;
            }
            else
            {
                this.Attachment = null;
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void NewEmail_Load(object sender, EventArgs e)
        {

            //// Create the list to use as the custom source. 
            //var source = new AutoCompleteStringCollection();
            //source.AddRange(JoinedGroups.Select(a=> a.GroupName).ToArray());

            //this.Controls.Remove(this.txtRecipient);
            //// Create and initialize the text box.
            //this.txtRecipient = new TextBox
            //{
            //    AutoCompleteCustomSource = source,
            //    AutoCompleteMode =
            //                      AutoCompleteMode.SuggestAppend,
            //    AutoCompleteSource =
            //                      AutoCompleteSource.CustomSource,
            //    Location = new Point(20, 20),
            //    Width = ClientRectangle.Width - 40,
            //    Visible = true
            //};


            

            //// 
            //// txtRecipient
            //// 
            ////this.txtRecipient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            ////| System.Windows.Forms.AnchorStyles.Right)));
            ////this.txtRecipient.Location = new System.Drawing.Point(53, 28);
            ////this.txtRecipient.Multiline = true;
            ////this.txtRecipient.Name = "txtRecipient";
            ////this.txtRecipient.Size = new System.Drawing.Size(374, 20);
            ////this.txtRecipient.TabIndex = 1;
            ////this.txtRecipient.TextChanged += new System.EventHandler(this.txtRecipient_TextChanged);

            //// Add the text box to the form.
            //Controls.Add(this.txtRecipient);
            //// Create the list to use as the custom source. 

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var email = new Email
            {
                Attachment = this.Attachment,
                Body = rchText.Text,
                SendDate = DateTime.Now,
                CreateDate = DateTime.Now,
                Sender = CurrentEmail,
                Subject = txtSubject.Text,                
            };
            using (var db=new DbContext())
            {
                email.EmailId=db.SendEmail(email,(Group)cboReceipt.SelectedItem);
            }
            this.Close();
        }

        private void txtAttachedFile_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
