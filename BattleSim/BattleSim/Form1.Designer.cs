namespace BattleSim
{
    partial class BattleSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleSim));
            this.pcbxRight = new System.Windows.Forms.PictureBox();
            this.pcbxLeft = new System.Windows.Forms.PictureBox();
            this.BtnAttackLeft = new System.Windows.Forms.Button();
            this.BtnAttackRight = new System.Windows.Forms.Button();
            this.lblHpLeft = new System.Windows.Forms.Label();
            this.lblHpRight = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxRight
            // 
            this.pcbxRight.Image = ((System.Drawing.Image)(resources.GetObject("pcbxRight.Image")));
            this.pcbxRight.Location = new System.Drawing.Point(502, 47);
            this.pcbxRight.Name = "pcbxRight";
            this.pcbxRight.Size = new System.Drawing.Size(214, 229);
            this.pcbxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxRight.TabIndex = 0;
            this.pcbxRight.TabStop = false;
            // 
            // pcbxLeft
            // 
            this.pcbxLeft.Image = ((System.Drawing.Image)(resources.GetObject("pcbxLeft.Image")));
            this.pcbxLeft.Location = new System.Drawing.Point(75, 47);
            this.pcbxLeft.Name = "pcbxLeft";
            this.pcbxLeft.Size = new System.Drawing.Size(214, 229);
            this.pcbxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxLeft.TabIndex = 1;
            this.pcbxLeft.TabStop = false;
            // 
            // BtnAttackLeft
            // 
            this.BtnAttackLeft.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnAttackLeft.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnAttackLeft.Location = new System.Drawing.Point(75, 282);
            this.BtnAttackLeft.Name = "BtnAttackLeft";
            this.BtnAttackLeft.Size = new System.Drawing.Size(214, 51);
            this.BtnAttackLeft.TabIndex = 2;
            this.BtnAttackLeft.Text = ">> ATTACK! >>";
            this.BtnAttackLeft.UseVisualStyleBackColor = false;
            this.BtnAttackLeft.Click += new System.EventHandler(this.BtnAttackLeft_Click);
            // 
            // BtnAttackRight
            // 
            this.BtnAttackRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAttackRight.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnAttackRight.Location = new System.Drawing.Point(502, 282);
            this.BtnAttackRight.Name = "BtnAttackRight";
            this.BtnAttackRight.Size = new System.Drawing.Size(214, 51);
            this.BtnAttackRight.TabIndex = 3;
            this.BtnAttackRight.Text = "<< ATTACK! <<";
            this.BtnAttackRight.UseVisualStyleBackColor = false;
            this.BtnAttackRight.Click += new System.EventHandler(this.BtnAttackRight_Click);
            // 
            // lblHpLeft
            // 
            this.lblHpLeft.AutoSize = true;
            this.lblHpLeft.Location = new System.Drawing.Point(72, 353);
            this.lblHpLeft.Name = "lblHpLeft";
            this.lblHpLeft.Size = new System.Drawing.Size(87, 17);
            this.lblHpLeft.TabIndex = 4;
            this.lblHpLeft.Text = "Player 1 HP:";
            // 
            // lblHpRight
            // 
            this.lblHpRight.AutoSize = true;
            this.lblHpRight.Location = new System.Drawing.Point(499, 353);
            this.lblHpRight.Name = "lblHpRight";
            this.lblHpRight.Size = new System.Drawing.Size(87, 17);
            this.lblHpRight.TabIndex = 5;
            this.lblHpRight.Text = "Player 2 HP:";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(165, 353);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(0, 17);
            this.lblLeft.TabIndex = 6;
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(592, 353);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(0, 17);
            this.lblRight.TabIndex = 7;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(295, 404);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 17);
            this.lblText.TabIndex = 8;
            // 
            // BattleSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblHpRight);
            this.Controls.Add(this.lblHpLeft);
            this.Controls.Add(this.BtnAttackRight);
            this.Controls.Add(this.BtnAttackLeft);
            this.Controls.Add(this.pcbxLeft);
            this.Controls.Add(this.pcbxRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BattleSim";
            this.Text = "BattleSim Light";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxRight;
        private System.Windows.Forms.PictureBox pcbxLeft;
        private System.Windows.Forms.Button BtnAttackLeft;
        private System.Windows.Forms.Button BtnAttackRight;
        private System.Windows.Forms.Label lblHpLeft;
        private System.Windows.Forms.Label lblHpRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblText;
    }
}

