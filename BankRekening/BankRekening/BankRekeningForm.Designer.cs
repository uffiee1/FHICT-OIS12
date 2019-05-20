namespace BankRekening
{
    partial class BankRekeningForm
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
            this.lblRekeningLinks = new System.Windows.Forms.Label();
            this.lblRekeningUfuk = new System.Windows.Forms.Label();
            this.lblUfuk = new System.Windows.Forms.Label();
            this.lblNaamLinks = new System.Windows.Forms.Label();
            this.lblEuroLinks = new System.Windows.Forms.Label();
            this.lblSaldoLinks = new System.Windows.Forms.Label();
            this.btnNaarRechts = new System.Windows.Forms.Button();
            this.btnNaarLinks = new System.Windows.Forms.Button();
            this.btnOpnemenLinks = new System.Windows.Forms.Button();
            this.btnStortenLinks = new System.Windows.Forms.Button();
            this.btnOpnemenRechts = new System.Windows.Forms.Button();
            this.btnStortenRechts = new System.Windows.Forms.Button();
            this.txtbxEuroLinks = new System.Windows.Forms.TextBox();
            this.txtbxEuroCentLinks = new System.Windows.Forms.TextBox();
            this.txtbxEuroCentRechts = new System.Windows.Forms.TextBox();
            this.txtbxEuroRechts = new System.Windows.Forms.TextBox();
            this.lblEuroRechts = new System.Windows.Forms.Label();
            this.lblSaldoRechts = new System.Windows.Forms.Label();
            this.lblSiy = new System.Windows.Forms.Label();
            this.lblNaamRechts = new System.Windows.Forms.Label();
            this.lblRekeningSiy = new System.Windows.Forms.Label();
            this.lblRekeningRechts = new System.Windows.Forms.Label();
            this.lblKomma1 = new System.Windows.Forms.Label();
            this.lblKomma2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRekeningLinks
            // 
            this.lblRekeningLinks.AutoSize = true;
            this.lblRekeningLinks.Location = new System.Drawing.Point(19, 38);
            this.lblRekeningLinks.Name = "lblRekeningLinks";
            this.lblRekeningLinks.Size = new System.Drawing.Size(85, 17);
            this.lblRekeningLinks.TabIndex = 0;
            this.lblRekeningLinks.Text = "Rekeningnr:";
            // 
            // lblRekeningUfuk
            // 
            this.lblRekeningUfuk.AutoSize = true;
            this.lblRekeningUfuk.Location = new System.Drawing.Point(110, 38);
            this.lblRekeningUfuk.Name = "lblRekeningUfuk";
            this.lblRekeningUfuk.Size = new System.Drawing.Size(40, 17);
            this.lblRekeningUfuk.TabIndex = 1;
            this.lblRekeningUfuk.Text = "2001";
            // 
            // lblUfuk
            // 
            this.lblUfuk.AutoSize = true;
            this.lblUfuk.Location = new System.Drawing.Point(110, 66);
            this.lblUfuk.Name = "lblUfuk";
            this.lblUfuk.Size = new System.Drawing.Size(81, 17);
            this.lblUfuk.TabIndex = 3;
            this.lblUfuk.Text = "Ufuk Angay";
            // 
            // lblNaamLinks
            // 
            this.lblNaamLinks.AutoSize = true;
            this.lblNaamLinks.Location = new System.Drawing.Point(19, 66);
            this.lblNaamLinks.Name = "lblNaamLinks";
            this.lblNaamLinks.Size = new System.Drawing.Size(49, 17);
            this.lblNaamLinks.TabIndex = 2;
            this.lblNaamLinks.Text = "Naam:";
            // 
            // lblEuroLinks
            // 
            this.lblEuroLinks.AutoSize = true;
            this.lblEuroLinks.Location = new System.Drawing.Point(110, 98);
            this.lblEuroLinks.Name = "lblEuroLinks";
            this.lblEuroLinks.Size = new System.Drawing.Size(36, 17);
            this.lblEuroLinks.TabIndex = 5;
            this.lblEuroLinks.Text = "0.00";
            // 
            // lblSaldoLinks
            // 
            this.lblSaldoLinks.AutoSize = true;
            this.lblSaldoLinks.Location = new System.Drawing.Point(19, 98);
            this.lblSaldoLinks.Name = "lblSaldoLinks";
            this.lblSaldoLinks.Size = new System.Drawing.Size(48, 17);
            this.lblSaldoLinks.TabIndex = 4;
            this.lblSaldoLinks.Text = "Saldo:";
            // 
            // btnNaarRechts
            // 
            this.btnNaarRechts.Location = new System.Drawing.Point(261, 53);
            this.btnNaarRechts.Name = "btnNaarRechts";
            this.btnNaarRechts.Size = new System.Drawing.Size(75, 23);
            this.btnNaarRechts.TabIndex = 12;
            this.btnNaarRechts.Text = ">>";
            this.btnNaarRechts.UseVisualStyleBackColor = true;
            this.btnNaarRechts.Click += new System.EventHandler(this.btnNaarRechts_Click);
            // 
            // btnNaarLinks
            // 
            this.btnNaarLinks.Location = new System.Drawing.Point(261, 92);
            this.btnNaarLinks.Name = "btnNaarLinks";
            this.btnNaarLinks.Size = new System.Drawing.Size(75, 23);
            this.btnNaarLinks.TabIndex = 13;
            this.btnNaarLinks.Text = "<<";
            this.btnNaarLinks.UseVisualStyleBackColor = true;
            this.btnNaarLinks.Click += new System.EventHandler(this.btnNaarLinks_Click);
            // 
            // btnOpnemenLinks
            // 
            this.btnOpnemenLinks.Location = new System.Drawing.Point(188, 160);
            this.btnOpnemenLinks.Name = "btnOpnemenLinks";
            this.btnOpnemenLinks.Size = new System.Drawing.Size(85, 43);
            this.btnOpnemenLinks.TabIndex = 14;
            this.btnOpnemenLinks.Text = "Opnemen";
            this.btnOpnemenLinks.UseVisualStyleBackColor = true;
            this.btnOpnemenLinks.Click += new System.EventHandler(this.btnOpnemenLinks_Click);
            // 
            // btnStortenLinks
            // 
            this.btnStortenLinks.Location = new System.Drawing.Point(188, 209);
            this.btnStortenLinks.Name = "btnStortenLinks";
            this.btnStortenLinks.Size = new System.Drawing.Size(85, 43);
            this.btnStortenLinks.TabIndex = 15;
            this.btnStortenLinks.Text = "Storten";
            this.btnStortenLinks.UseVisualStyleBackColor = true;
            this.btnStortenLinks.Click += new System.EventHandler(this.btnStortenLinks_Click);
            // 
            // btnOpnemenRechts
            // 
            this.btnOpnemenRechts.Location = new System.Drawing.Point(573, 160);
            this.btnOpnemenRechts.Name = "btnOpnemenRechts";
            this.btnOpnemenRechts.Size = new System.Drawing.Size(85, 43);
            this.btnOpnemenRechts.TabIndex = 16;
            this.btnOpnemenRechts.Text = "Opnemen";
            this.btnOpnemenRechts.UseVisualStyleBackColor = true;
            this.btnOpnemenRechts.Click += new System.EventHandler(this.btnOpnemenRechts_Click);
            // 
            // btnStortenRechts
            // 
            this.btnStortenRechts.Location = new System.Drawing.Point(573, 209);
            this.btnStortenRechts.Name = "btnStortenRechts";
            this.btnStortenRechts.Size = new System.Drawing.Size(85, 43);
            this.btnStortenRechts.TabIndex = 17;
            this.btnStortenRechts.Text = "Storten";
            this.btnStortenRechts.UseVisualStyleBackColor = true;
            this.btnStortenRechts.Click += new System.EventHandler(this.btnStortenRechts_Click);
            // 
            // txtbxEuroLinks
            // 
            this.txtbxEuroLinks.Location = new System.Drawing.Point(22, 181);
            this.txtbxEuroLinks.Name = "txtbxEuroLinks";
            this.txtbxEuroLinks.Size = new System.Drawing.Size(64, 22);
            this.txtbxEuroLinks.TabIndex = 18;
            this.txtbxEuroLinks.Text = "0";
            this.txtbxEuroLinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbxEuroCentLinks
            // 
            this.txtbxEuroCentLinks.Location = new System.Drawing.Point(110, 181);
            this.txtbxEuroCentLinks.MaxLength = 2;
            this.txtbxEuroCentLinks.Name = "txtbxEuroCentLinks";
            this.txtbxEuroCentLinks.Size = new System.Drawing.Size(40, 22);
            this.txtbxEuroCentLinks.TabIndex = 19;
            this.txtbxEuroCentLinks.Text = "00";
            // 
            // txtbxEuroCentRechts
            // 
            this.txtbxEuroCentRechts.Location = new System.Drawing.Point(502, 181);
            this.txtbxEuroCentRechts.MaxLength = 2;
            this.txtbxEuroCentRechts.Name = "txtbxEuroCentRechts";
            this.txtbxEuroCentRechts.Size = new System.Drawing.Size(40, 22);
            this.txtbxEuroCentRechts.TabIndex = 27;
            this.txtbxEuroCentRechts.Text = "00";
            // 
            // txtbxEuroRechts
            // 
            this.txtbxEuroRechts.Location = new System.Drawing.Point(414, 181);
            this.txtbxEuroRechts.Name = "txtbxEuroRechts";
            this.txtbxEuroRechts.Size = new System.Drawing.Size(64, 22);
            this.txtbxEuroRechts.TabIndex = 26;
            this.txtbxEuroRechts.Text = "0";
            this.txtbxEuroRechts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEuroRechts
            // 
            this.lblEuroRechts.AutoSize = true;
            this.lblEuroRechts.Location = new System.Drawing.Point(502, 98);
            this.lblEuroRechts.Name = "lblEuroRechts";
            this.lblEuroRechts.Size = new System.Drawing.Size(36, 17);
            this.lblEuroRechts.TabIndex = 33;
            this.lblEuroRechts.Text = "0.00";
            // 
            // lblSaldoRechts
            // 
            this.lblSaldoRechts.AutoSize = true;
            this.lblSaldoRechts.Location = new System.Drawing.Point(411, 98);
            this.lblSaldoRechts.Name = "lblSaldoRechts";
            this.lblSaldoRechts.Size = new System.Drawing.Size(48, 17);
            this.lblSaldoRechts.TabIndex = 32;
            this.lblSaldoRechts.Text = "Saldo:";
            // 
            // lblSiy
            // 
            this.lblSiy.AutoSize = true;
            this.lblSiy.Location = new System.Drawing.Point(502, 66);
            this.lblSiy.Name = "lblSiy";
            this.lblSiy.Size = new System.Drawing.Size(92, 17);
            this.lblSiy.TabIndex = 31;
            this.lblSiy.Text = "Siy Nadiroglu";
            // 
            // lblNaamRechts
            // 
            this.lblNaamRechts.AutoSize = true;
            this.lblNaamRechts.Location = new System.Drawing.Point(411, 66);
            this.lblNaamRechts.Name = "lblNaamRechts";
            this.lblNaamRechts.Size = new System.Drawing.Size(49, 17);
            this.lblNaamRechts.TabIndex = 30;
            this.lblNaamRechts.Text = "Naam:";
            // 
            // lblRekeningSiy
            // 
            this.lblRekeningSiy.AutoSize = true;
            this.lblRekeningSiy.Location = new System.Drawing.Point(502, 38);
            this.lblRekeningSiy.Name = "lblRekeningSiy";
            this.lblRekeningSiy.Size = new System.Drawing.Size(40, 17);
            this.lblRekeningSiy.TabIndex = 29;
            this.lblRekeningSiy.Text = "2002";
            // 
            // lblRekeningRechts
            // 
            this.lblRekeningRechts.AutoSize = true;
            this.lblRekeningRechts.Location = new System.Drawing.Point(411, 38);
            this.lblRekeningRechts.Name = "lblRekeningRechts";
            this.lblRekeningRechts.Size = new System.Drawing.Size(85, 17);
            this.lblRekeningRechts.TabIndex = 28;
            this.lblRekeningRechts.Text = "Rekeningnr:";
            // 
            // lblKomma1
            // 
            this.lblKomma1.AutoSize = true;
            this.lblKomma1.Location = new System.Drawing.Point(92, 188);
            this.lblKomma1.Name = "lblKomma1";
            this.lblKomma1.Size = new System.Drawing.Size(12, 17);
            this.lblKomma1.TabIndex = 34;
            this.lblKomma1.Text = ",";
            // 
            // lblKomma2
            // 
            this.lblKomma2.AutoSize = true;
            this.lblKomma2.Location = new System.Drawing.Point(484, 188);
            this.lblKomma2.Name = "lblKomma2";
            this.lblKomma2.Size = new System.Drawing.Size(12, 17);
            this.lblKomma2.TabIndex = 35;
            this.lblKomma2.Text = ",";
            // 
            // BankRekeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 356);
            this.Controls.Add(this.lblKomma2);
            this.Controls.Add(this.lblKomma1);
            this.Controls.Add(this.lblEuroRechts);
            this.Controls.Add(this.lblSaldoRechts);
            this.Controls.Add(this.lblSiy);
            this.Controls.Add(this.lblNaamRechts);
            this.Controls.Add(this.lblRekeningSiy);
            this.Controls.Add(this.lblRekeningRechts);
            this.Controls.Add(this.txtbxEuroCentRechts);
            this.Controls.Add(this.txtbxEuroRechts);
            this.Controls.Add(this.txtbxEuroCentLinks);
            this.Controls.Add(this.txtbxEuroLinks);
            this.Controls.Add(this.btnStortenRechts);
            this.Controls.Add(this.btnOpnemenRechts);
            this.Controls.Add(this.btnStortenLinks);
            this.Controls.Add(this.btnOpnemenLinks);
            this.Controls.Add(this.btnNaarLinks);
            this.Controls.Add(this.btnNaarRechts);
            this.Controls.Add(this.lblEuroLinks);
            this.Controls.Add(this.lblSaldoLinks);
            this.Controls.Add(this.lblUfuk);
            this.Controls.Add(this.lblNaamLinks);
            this.Controls.Add(this.lblRekeningUfuk);
            this.Controls.Add(this.lblRekeningLinks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BankRekeningForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Bankzaken";
            this.Load += new System.EventHandler(this.BankRekeningForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRekeningLinks;
        private System.Windows.Forms.Label lblRekeningUfuk;
        private System.Windows.Forms.Label lblUfuk;
        private System.Windows.Forms.Label lblNaamLinks;
        private System.Windows.Forms.Label lblEuroLinks;
        private System.Windows.Forms.Label lblSaldoLinks;
        private System.Windows.Forms.Button btnNaarRechts;
        private System.Windows.Forms.Button btnNaarLinks;
        private System.Windows.Forms.Button btnOpnemenLinks;
        private System.Windows.Forms.Button btnStortenLinks;
        private System.Windows.Forms.Button btnOpnemenRechts;
        private System.Windows.Forms.Button btnStortenRechts;
        private System.Windows.Forms.TextBox txtbxEuroLinks;
        private System.Windows.Forms.TextBox txtbxEuroCentLinks;
        private System.Windows.Forms.TextBox txtbxEuroCentRechts;
        private System.Windows.Forms.TextBox txtbxEuroRechts;
        private System.Windows.Forms.Label lblEuroRechts;
        private System.Windows.Forms.Label lblSaldoRechts;
        private System.Windows.Forms.Label lblSiy;
        private System.Windows.Forms.Label lblNaamRechts;
        private System.Windows.Forms.Label lblRekeningSiy;
        private System.Windows.Forms.Label lblRekeningRechts;
        private System.Windows.Forms.Label lblKomma1;
        private System.Windows.Forms.Label lblKomma2;
    }
}

