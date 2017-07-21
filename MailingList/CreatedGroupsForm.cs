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
    public partial class CreatedGroupsForm : Form
    {
        public string CurrentEmail { get; set; }
        public CreatedGroupsForm(string currentEmail)
        {
            InitializeComponent();
            this.CurrentEmail = currentEmail;
        }


        private void RefreshMemberList(int selectedGroup)
        {
            using (var db = new DbContext())
            {
                lstMembers.DataSource = db.GroupMembers(selectedGroup);
            }
        }
        private void lstCreatedGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGroup = ((Group)lstCreatedGroups.SelectedItem).GroupId;
            RefreshMemberList(selectedGroup);
            lstMembers.SelectedIndex = -1;
        }

        private void CreatedGroupsForm_Load_1(object sender, EventArgs e)
        {
            using (var db = new DbContext())
            {

                lstCreatedGroups.DataSource = db.CreatedGroups(CurrentEmail);

            }

        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            var selectedMember = ((User)lstMembers.SelectedItem).Email;
            var selectedGroup = ((Group)lstCreatedGroups.SelectedItem).GroupId;
            using (var db = new DbContext())
            {

                db.DeleteMember(selectedGroup,selectedMember);

            }
            RefreshMemberList(selectedGroup);
            lstMembers.SelectedIndex = -1;

        }
    }
}
