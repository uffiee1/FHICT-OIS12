namespace Blog_Applicatie
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblText = new System.Windows.Forms.Label();
            this.txbText = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.cbxAuthor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(9, 62);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(39, 17);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text:";
            // 
            // txbText
            // 
            this.txbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbText.Location = new System.Drawing.Point(12, 82);
            this.txbText.Multiline = true;
            this.txbText.Name = "txbText";
            this.txbText.Size = new System.Drawing.Size(948, 166);
            this.txbText.TabIndex = 5;
            this.txbText.Text = "Write here the text.";
            // 
            // btnPost
            // 
            this.btnPost.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPost.Location = new System.Drawing.Point(12, 457);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(101, 54);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lblContent
            // 
            this.lblContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(9, 251);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(61, 17);
            this.lblContent.TabIndex = 4;
            this.lblContent.Text = "Content:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(119, 457);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 54);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 271);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(951, 180);
            this.listBox1.TabIndex = 7;
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(15, 29);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(629, 22);
            this.txbTitle.TabIndex = 8;
            this.txbTitle.Text = "Write here a Title.";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title:";
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUsers.Location = new System.Drawing.Point(226, 457);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(101, 54);
            this.btnUsers.TabIndex = 10;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(700, 9);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 17);
            this.lblAuthor.TabIndex = 11;
            this.lblAuthor.Text = "Author:";
            // 
            // cbxAuthor
            // 
            this.cbxAuthor.FormattingEnabled = true;
            this.cbxAuthor.Items.AddRange(new object[] {
            "Jan, Jean de Bonheur",
            "Bea, Bea_for_president",
            "Cora, Cora2001",
            "Ufuk, Ufukk1"});
            this.cbxAuthor.Location = new System.Drawing.Point(703, 29);
            this.cbxAuthor.Name = "cbxAuthor";
            this.cbxAuthor.Size = new System.Drawing.Size(257, 24);
            this.cbxAuthor.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 523);
            this.Controls.Add(this.cbxAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txbTitle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txbText);
            this.Controls.Add(this.lblText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Blog-O-Matic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txbText;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cbxAuthor;
    }
}

