namespace MailingList
{
    partial class CreatedGroupsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCreatedGroups = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMembers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Members = new System.Windows.Forms.GroupBox();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbMembers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Members.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCreatedGroups
            // 
            this.lstCreatedGroups.FormattingEnabled = true;
            this.lstCreatedGroups.Location = new System.Drawing.Point(-1, 23);
            this.lstCreatedGroups.Name = "lstCreatedGroups";
            this.lstCreatedGroups.Size = new System.Drawing.Size(194, 290);
            this.lstCreatedGroups.TabIndex = 2;
            this.lstCreatedGroups.SelectedIndexChanged += new System.EventHandler(this.lstCreatedGroups_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Created Groups";
            // 
            // tbMembers
            // 
            this.tbMembers.Controls.Add(this.tabPage1);
            this.tbMembers.Controls.Add(this.tabPage2);
            this.tbMembers.Location = new System.Drawing.Point(192, 3);
            this.tbMembers.Name = "tbMembers";
            this.tbMembers.SelectedIndex = 0;
            this.tbMembers.Size = new System.Drawing.Size(378, 308);
            this.tbMembers.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Members);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Members";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Members
            // 
            this.Members.Controls.Add(this.lstMembers);
            this.Members.Controls.Add(this.btnDeleteMember);
            this.Members.Location = new System.Drawing.Point(3, 6);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(361, 273);
            this.Members.TabIndex = 11;
            this.Members.TabStop = false;
            this.Members.Text = "Group Members";
            // 
            // lstMembers
            // 
            this.lstMembers.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.Location = new System.Drawing.Point(6, 16);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(174, 251);
            this.lstMembers.TabIndex = 7;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(193, 241);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(157, 23);
            this.btnDeleteMember.TabIndex = 8;
            this.btnDeleteMember.Text = "Delete Selected Member";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Group Name";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CreatedGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 310);
            this.Controls.Add(this.tbMembers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCreatedGroups);
            this.Name = "CreatedGroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Created Groups Form";
            this.Load += new System.EventHandler(this.CreatedGroupsForm_Load_1);
            this.tbMembers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Members.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCreatedGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbMembers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox Members;
        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.TabPage tabPage2;
    }
}