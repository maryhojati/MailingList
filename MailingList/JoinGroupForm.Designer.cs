namespace MailingList
{
    partial class JoinGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinGroupForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.lstJoinedGroups = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpSMS = new System.Windows.Forms.GroupBox();
            this.rdoNoSMS = new System.Windows.Forms.RadioButton();
            this.rdoYesSMS = new System.Windows.Forms.RadioButton();
            this.grpHTML = new System.Windows.Forms.GroupBox();
            this.rdoNoHTML = new System.Windows.Forms.RadioButton();
            this.rdoYesHTML = new System.Windows.Forms.RadioButton();
            this.grpVisibility = new System.Windows.Forms.GroupBox();
            this.rdoUnvisible = new System.Windows.Forms.RadioButton();
            this.rdoVisible = new System.Windows.Forms.RadioButton();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJoinGroup = new System.Windows.Forms.Button();
            this.lstNotJoinedGroups = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpSMS.SuspendLayout();
            this.grpHTML.SuspendLayout();
            this.grpVisibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteGroup);
            this.groupBox1.Controls.Add(this.lstJoinedGroups);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joined Groups";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteGroup.Image")));
            this.btnDeleteGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGroup.Location = new System.Drawing.Point(197, 314);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteGroup.TabIndex = 2;
            this.btnDeleteGroup.Text = "Delete Group";
            this.btnDeleteGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // lstJoinedGroups
            // 
            this.lstJoinedGroups.FormattingEnabled = true;
            this.lstJoinedGroups.Location = new System.Drawing.Point(6, 19);
            this.lstJoinedGroups.MultiColumn = true;
            this.lstJoinedGroups.Name = "lstJoinedGroups";
            this.lstJoinedGroups.Size = new System.Drawing.Size(185, 316);
            this.lstJoinedGroups.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grpSMS);
            this.groupBox2.Controls.Add(this.grpHTML);
            this.groupBox2.Controls.Add(this.grpVisibility);
            this.groupBox2.Controls.Add(this.txtFilter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnJoinGroup);
            this.groupBox2.Controls.Add(this.lstNotJoinedGroups);
            this.groupBox2.Location = new System.Drawing.Point(314, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 343);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not Joined Groups";
            // 
            // grpSMS
            // 
            this.grpSMS.Controls.Add(this.rdoNoSMS);
            this.grpSMS.Controls.Add(this.rdoYesSMS);
            this.grpSMS.Location = new System.Drawing.Point(197, 267);
            this.grpSMS.Name = "grpSMS";
            this.grpSMS.Size = new System.Drawing.Size(96, 45);
            this.grpSMS.TabIndex = 6;
            this.grpSMS.TabStop = false;
            this.grpSMS.Text = "Receiving SMS";
            // 
            // rdoNoSMS
            // 
            this.rdoNoSMS.AutoSize = true;
            this.rdoNoSMS.Location = new System.Drawing.Point(56, 22);
            this.rdoNoSMS.Name = "rdoNoSMS";
            this.rdoNoSMS.Size = new System.Drawing.Size(39, 17);
            this.rdoNoSMS.TabIndex = 0;
            this.rdoNoSMS.Text = "No";
            this.rdoNoSMS.UseVisualStyleBackColor = true;
            // 
            // rdoYesSMS
            // 
            this.rdoYesSMS.AutoSize = true;
            this.rdoYesSMS.Checked = true;
            this.rdoYesSMS.Location = new System.Drawing.Point(7, 20);
            this.rdoYesSMS.Name = "rdoYesSMS";
            this.rdoYesSMS.Size = new System.Drawing.Size(43, 17);
            this.rdoYesSMS.TabIndex = 0;
            this.rdoYesSMS.TabStop = true;
            this.rdoYesSMS.Text = "Yes";
            this.rdoYesSMS.UseVisualStyleBackColor = true;
            // 
            // grpHTML
            // 
            this.grpHTML.Controls.Add(this.rdoNoHTML);
            this.grpHTML.Controls.Add(this.rdoYesHTML);
            this.grpHTML.Location = new System.Drawing.Point(197, 216);
            this.grpHTML.Name = "grpHTML";
            this.grpHTML.Size = new System.Drawing.Size(96, 45);
            this.grpHTML.TabIndex = 6;
            this.grpHTML.TabStop = false;
            this.grpHTML.Text = "Receiving HTML";
            // 
            // rdoNoHTML
            // 
            this.rdoNoHTML.AutoSize = true;
            this.rdoNoHTML.Location = new System.Drawing.Point(57, 20);
            this.rdoNoHTML.Name = "rdoNoHTML";
            this.rdoNoHTML.Size = new System.Drawing.Size(39, 17);
            this.rdoNoHTML.TabIndex = 0;
            this.rdoNoHTML.Text = "No";
            this.rdoNoHTML.UseVisualStyleBackColor = true;
            // 
            // rdoYesHTML
            // 
            this.rdoYesHTML.AutoSize = true;
            this.rdoYesHTML.Checked = true;
            this.rdoYesHTML.Location = new System.Drawing.Point(7, 20);
            this.rdoYesHTML.Name = "rdoYesHTML";
            this.rdoYesHTML.Size = new System.Drawing.Size(43, 17);
            this.rdoYesHTML.TabIndex = 0;
            this.rdoYesHTML.TabStop = true;
            this.rdoYesHTML.Text = "Yes";
            this.rdoYesHTML.UseVisualStyleBackColor = true;
            // 
            // grpVisibility
            // 
            this.grpVisibility.Controls.Add(this.rdoUnvisible);
            this.grpVisibility.Controls.Add(this.rdoVisible);
            this.grpVisibility.Location = new System.Drawing.Point(197, 165);
            this.grpVisibility.Name = "grpVisibility";
            this.grpVisibility.Size = new System.Drawing.Size(96, 45);
            this.grpVisibility.TabIndex = 5;
            this.grpVisibility.TabStop = false;
            this.grpVisibility.Text = "Visiblity";
            // 
            // rdoUnvisible
            // 
            this.rdoUnvisible.AutoSize = true;
            this.rdoUnvisible.Location = new System.Drawing.Point(56, 19);
            this.rdoUnvisible.Name = "rdoUnvisible";
            this.rdoUnvisible.Size = new System.Drawing.Size(39, 17);
            this.rdoUnvisible.TabIndex = 0;
            this.rdoUnvisible.Text = "No";
            this.rdoUnvisible.UseVisualStyleBackColor = true;
            // 
            // rdoVisible
            // 
            this.rdoVisible.AutoSize = true;
            this.rdoVisible.Checked = true;
            this.rdoVisible.Location = new System.Drawing.Point(7, 20);
            this.rdoVisible.Name = "rdoVisible";
            this.rdoVisible.Size = new System.Drawing.Size(43, 17);
            this.rdoVisible.TabIndex = 0;
            this.rdoVisible.TabStop = true;
            this.rdoVisible.Text = "Yes";
            this.rdoVisible.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(41, 19);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(150, 20);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter";
            // 
            // btnJoinGroup
            // 
            this.btnJoinGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnJoinGroup.Image")));
            this.btnJoinGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJoinGroup.Location = new System.Drawing.Point(197, 315);
            this.btnJoinGroup.Name = "btnJoinGroup";
            this.btnJoinGroup.Size = new System.Drawing.Size(95, 23);
            this.btnJoinGroup.TabIndex = 2;
            this.btnJoinGroup.Text = "Join Group";
            this.btnJoinGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJoinGroup.UseVisualStyleBackColor = true;
            this.btnJoinGroup.Click += new System.EventHandler(this.btnJoinGroup_Click);
            // 
            // lstNotJoinedGroups
            // 
            this.lstNotJoinedGroups.FormattingEnabled = true;
            this.lstNotJoinedGroups.Location = new System.Drawing.Point(6, 45);
            this.lstNotJoinedGroups.Name = "lstNotJoinedGroups";
            this.lstNotJoinedGroups.Size = new System.Drawing.Size(185, 290);
            this.lstNotJoinedGroups.TabIndex = 1;
            // 
            // JoinGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "JoinGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Join Group Form";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.JoinGroupForm_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpSMS.ResumeLayout(false);
            this.grpSMS.PerformLayout();
            this.grpHTML.ResumeLayout(false);
            this.grpHTML.PerformLayout();
            this.grpVisibility.ResumeLayout(false);
            this.grpVisibility.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJoinGroup;
        private System.Windows.Forms.ListBox lstNotJoinedGroups;
        private System.Windows.Forms.ListBox lstJoinedGroups;
        private System.Windows.Forms.GroupBox grpVisibility;
        private System.Windows.Forms.RadioButton rdoVisible;
        private System.Windows.Forms.GroupBox grpSMS;
        private System.Windows.Forms.RadioButton rdoNoSMS;
        private System.Windows.Forms.RadioButton rdoYesSMS;
        private System.Windows.Forms.GroupBox grpHTML;
        private System.Windows.Forms.RadioButton rdoNoHTML;
        private System.Windows.Forms.RadioButton rdoYesHTML;
        private System.Windows.Forms.RadioButton rdoUnvisible;
    }
}