namespace MailingList
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lstBoxLabels = new System.Windows.Forms.ListBox();
            this.pnlInner = new System.Windows.Forms.Panel();
            this.lstEmails = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.editInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCompose = new System.Windows.Forms.Button();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.pnlInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstEmails)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lstBoxLabels);
            this.pnlMain.Controls.Add(this.pnlInner);
            this.pnlMain.Controls.Add(this.btnCompose);
            this.pnlMain.Controls.Add(this.menuStrip1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(706, 462);
            this.pnlMain.TabIndex = 8;
            // 
            // lstBoxLabels
            // 
            this.lstBoxLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxLabels.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstBoxLabels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBoxLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxLabels.FormattingEnabled = true;
            this.lstBoxLabels.ItemHeight = 16;
            this.lstBoxLabels.Items.AddRange(new object[] {
            "Inbox",
            "Sent Mail"});
            this.lstBoxLabels.Location = new System.Drawing.Point(5, 62);
            this.lstBoxLabels.Name = "lstBoxLabels";
            this.lstBoxLabels.Size = new System.Drawing.Size(78, 448);
            this.lstBoxLabels.TabIndex = 17;
            this.lstBoxLabels.SelectedIndexChanged += new System.EventHandler(this.lstBoxLabels_SelectedIndexChanged);
            // 
            // pnlInner
            // 
            this.pnlInner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInner.Controls.Add(this.lstEmails);
            this.pnlInner.Location = new System.Drawing.Point(89, 24);
            this.pnlInner.Name = "pnlInner";
            this.pnlInner.Size = new System.Drawing.Size(617, 438);
            this.pnlInner.TabIndex = 16;
            // 
            // lstEmails
            // 
            this.lstEmails.AllowUserToAddRows = false;
            this.lstEmails.AllowUserToDeleteRows = false;
            this.lstEmails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lstEmails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEmails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.lstEmails.Location = new System.Drawing.Point(0, 0);
            this.lstEmails.Name = "lstEmails";
            this.lstEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstEmails.Size = new System.Drawing.Size(617, 438);
            this.lstEmails.TabIndex = 0;
            this.lstEmails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstEmails_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupsToolStripMenuItem,
            this.notificationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUser.Controls.Add(this.groupBox1);
            this.pnlUser.Controls.Add(this.btnLogin);
            this.pnlUser.Controls.Add(this.menuStrip2);
            this.pnlUser.Location = new System.Drawing.Point(709, 2);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(279, 460);
            this.pnlUser.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 76);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User information";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(75, 45);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(131, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(131, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(131, 106);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInformationToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(279, 24);
            this.menuStrip2.TabIndex = 21;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // editInformationToolStripMenuItem
            // 
            this.editInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editInformationToolStripMenuItem.Image")));
            this.editInformationToolStripMenuItem.Name = "editInformationToolStripMenuItem";
            this.editInformationToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.editInformationToolStripMenuItem.Text = "edit information";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.logoutToolStripMenuItem.Text = "logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnCompose
            // 
            this.btnCompose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCompose.Image = ((System.Drawing.Image)(resources.GetObject("btnCompose.Image")));
            this.btnCompose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompose.Location = new System.Drawing.Point(5, 30);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(78, 30);
            this.btnCompose.TabIndex = 13;
            this.btnCompose.Text = "Compose";
            this.btnCompose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompose.UseVisualStyleBackColor = false;
            this.btnCompose.Click += new System.EventHandler(this.btnCompose_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewGroupToolStripMenuItem,
            this.myGroupsToolStripMenuItem,
            this.joinGroupsToolStripMenuItem});
            this.groupsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("groupsToolStripMenuItem.Image")));
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // createNewGroupToolStripMenuItem
            // 
            this.createNewGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewGroupToolStripMenuItem.Image")));
            this.createNewGroupToolStripMenuItem.Name = "createNewGroupToolStripMenuItem";
            this.createNewGroupToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.createNewGroupToolStripMenuItem.Text = "Create New Group";
            this.createNewGroupToolStripMenuItem.Click += new System.EventHandler(this.createNewGroupToolStripMenuItem_Click);
            // 
            // myGroupsToolStripMenuItem
            // 
            this.myGroupsToolStripMenuItem.Name = "myGroupsToolStripMenuItem";
            this.myGroupsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.myGroupsToolStripMenuItem.Text = "Created Groups";
            this.myGroupsToolStripMenuItem.Click += new System.EventHandler(this.myGroupsToolStripMenuItem_Click);
            // 
            // joinGroupsToolStripMenuItem
            // 
            this.joinGroupsToolStripMenuItem.Name = "joinGroupsToolStripMenuItem";
            this.joinGroupsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.joinGroupsToolStripMenuItem.Text = "Joined/Not Joined Groups";
            this.joinGroupsToolStripMenuItem.Click += new System.EventHandler(this.joinGroupsToolStripMenuItem_Click);
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notificationsToolStripMenuItem.Image")));
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            this.notificationsToolStripMenuItem.Click += new System.EventHandler(this.notificationsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 462);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailingList";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlInner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstEmails)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joinGroupsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
        private System.Windows.Forms.Button btnCompose;
        private System.Windows.Forms.Panel pnlInner;
        private System.Windows.Forms.DataGridView lstEmails;
        private System.Windows.Forms.ListBox lstBoxLabels;
    }
}