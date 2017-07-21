namespace MailingList
{
    partial class NewEmail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rchText = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAttachment = new System.Windows.Forms.Button();
            this.cboReceipt = new System.Windows.Forms.ComboBox();
            this.txtAttachedFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject :";
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(53, 51);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(374, 20);
            this.txtSubject.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(354, 400);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 32);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rchText
            // 
            this.rchText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchText.Location = new System.Drawing.Point(10, 77);
            this.rchText.Name = "rchText";
            this.rchText.Size = new System.Drawing.Size(417, 317);
            this.rchText.TabIndex = 4;
            this.rchText.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::MailingList.Properties.Resources.dialog_close;
            this.pictureBox2.Location = new System.Drawing.Point(409, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 38);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnAttachment
            // 
            this.btnAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttachment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachment.Image = global::MailingList.Properties.Resources.paperclip4_black;
            this.btnAttachment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttachment.Location = new System.Drawing.Point(257, 400);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(89, 32);
            this.btnAttachment.TabIndex = 3;
            this.btnAttachment.Text = "Attachment";
            this.btnAttachment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAttachment.UseVisualStyleBackColor = false;
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // cboReceipt
            // 
            this.cboReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboReceipt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboReceipt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboReceipt.FormattingEnabled = true;
            this.cboReceipt.Location = new System.Drawing.Point(53, 24);
            this.cboReceipt.Name = "cboReceipt";
            this.cboReceipt.Size = new System.Drawing.Size(353, 21);
            this.cboReceipt.TabIndex = 7;
            // 
            // txtAttachedFile
            // 
            this.txtAttachedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAttachedFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAttachedFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAttachedFile.Location = new System.Drawing.Point(11, 405);
            this.txtAttachedFile.Name = "txtAttachedFile";
            this.txtAttachedFile.Size = new System.Drawing.Size(239, 13);
            this.txtAttachedFile.TabIndex = 8;
            this.txtAttachedFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAttachedFile.TextChanged += new System.EventHandler(this.txtAttachedFile_TextChanged);
            // 
            // NewEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 444);
            this.Controls.Add(this.txtAttachedFile);
            this.Controls.Add(this.cboReceipt);
            this.Controls.Add(this.rchText);
            this.Controls.Add(this.btnAttachment);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Email";
            this.Load += new System.EventHandler(this.NewEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAttachment;
        private System.Windows.Forms.RichTextBox rchText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cboReceipt;
        private System.Windows.Forms.TextBox txtAttachedFile;
    }
}