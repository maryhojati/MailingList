using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MailingList.Model;

namespace MailingList
{
    public partial class JoinGroupForm : Form
    {
        public List<Group> NotJoinedGroups { get; set; }
        public string CurrentEmail { get; set; }
        public JoinGroupForm(string email)
        {
            InitializeComponent();
            this.CurrentEmail = email;
            using (var db = new DbContext())
            {

                var notJoinedGroups = db.GetNotJoinedGroups(CurrentEmail);
                RefreshJoined(db.GetJoinedGroups(CurrentEmail));
                RefreshNotJoined(notJoinedGroups);
                this.NotJoinedGroups = notJoinedGroups;
            }
            lstJoinedGroups.SelectedIndex = -1;
            lstNotJoinedGroups.SelectedIndex = -1;
        }
        private void RefreshJoined(List<Group> Groups)
        {
            lstJoinedGroups.DataSource = Groups;
        }
        private void RefreshNotJoined(List<Group> Groups)
        {
            lstNotJoinedGroups.DataSource = Groups;
        }
        private void JoinGroupForm_Load(object sender, EventArgs e)
        {
            //lstJoinedGroups.SetSelected(0,false);

        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            try
            {

                var selectedGroup = (Group)lstJoinedGroups.SelectedItem;
                using (var db = new DbContext())
                {
                    db.DeleteGroup(CurrentEmail, selectedGroup);
                    RefreshJoined(db.GetJoinedGroups(CurrentEmail));
                    RefreshNotJoined(db.GetNotJoinedGroups(CurrentEmail));
                }
                lstJoinedGroups.SelectedIndex = -1;
                lstNotJoinedGroups.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJoinGroup_Click(object sender, EventArgs e)
        {
            try
            {

                var selectedGroup = (Group)lstNotJoinedGroups.SelectedItem;
                using (var db = new DbContext())
                {
                    bool receiveHTML = true, receiveSMS = true, visible = true;
                    if (rdoYesHTML.Checked)
                    {
                        receiveHTML = true;
                    }
                    else
                    {
                        receiveHTML = false;

                    }

                    if (rdoYesSMS.Checked)
                    {
                        receiveSMS = true;
                    }
                    else
                    {
                        receiveSMS = false;
                    }

                    if (rdoVisible.Checked)
                    {
                        visible = true;
                    }
                    else
                    {
                        visible = false;
                    }


                    db.JoinGroup(CurrentEmail, selectedGroup, receiveSMS, receiveHTML, visible);
                    RefreshNotJoined(db.GetNotJoinedGroups(CurrentEmail));
                    RefreshJoined(db.GetJoinedGroups(CurrentEmail));

                }
                lstJoinedGroups.SelectedIndex = -1;
                lstNotJoinedGroups.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }


        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            string filter = txtFilter.Text;
            List<Group> filteredList = new List<Group> { };
            if (string.IsNullOrWhiteSpace(filter))
            {
                RefreshNotJoined(NotJoinedGroups);
            }
            else
            {
                for (int i = 0; i < NotJoinedGroups.Count; i++)
                {

                    if (NotJoinedGroups[i].GroupName.Contains(filter))
                    {
                        filteredList.Add(NotJoinedGroups[i]);
                    }
                }
                RefreshNotJoined(filteredList);
            }

            lstJoinedGroups.SelectedIndex = -1;
            lstNotJoinedGroups.SelectedIndex = -1;
        }





        private void JoinGroupForm_MouseClick(object sender, MouseEventArgs e)
        {
            lstJoinedGroups.SelectedIndex = -1;
            lstNotJoinedGroups.SelectedIndex = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
