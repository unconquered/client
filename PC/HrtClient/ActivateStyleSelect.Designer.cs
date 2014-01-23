namespace HrtClient
{
    partial class ActivateModeSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivateModeSelect));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSelectActive = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxBankCard = new System.Windows.Forms.PictureBox();
            this.pictureBoxActivateCard = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBankCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivateCard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.labelSelectActive);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 30);
            this.panel1.TabIndex = 0;
            // 
            // labelSelectActive
            // 
            this.labelSelectActive.AutoSize = true;
            this.labelSelectActive.Location = new System.Drawing.Point(4, 9);
            this.labelSelectActive.Name = "labelSelectActive";
            this.labelSelectActive.Size = new System.Drawing.Size(77, 12);
            this.labelSelectActive.TabIndex = 1;
            this.labelSelectActive.Text = "选择激活方式";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 17);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxBankCard);
            this.panel2.Controls.Add(this.pictureBoxActivateCard);
            this.panel2.Location = new System.Drawing.Point(23, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 149);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxBankCard
            // 
            this.pictureBoxBankCard.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBoxBankCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBankCard.BackgroundImage")));
            this.pictureBoxBankCard.Location = new System.Drawing.Point(0, 75);
            this.pictureBoxBankCard.Name = "pictureBoxBankCard";
            this.pictureBoxBankCard.Size = new System.Drawing.Size(308, 72);
            this.pictureBoxBankCard.TabIndex = 0;
            this.pictureBoxBankCard.TabStop = false;
            // 
            // pictureBoxActivateCard
            // 
            this.pictureBoxActivateCard.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBoxActivateCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxActivateCard.BackgroundImage")));
            this.pictureBoxActivateCard.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxActivateCard.Name = "pictureBoxActivateCard";
            this.pictureBoxActivateCard.Size = new System.Drawing.Size(308, 70);
            this.pictureBoxActivateCard.TabIndex = 0;
            this.pictureBoxActivateCard.TabStop = false;
            // 
            // ActivateModeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(358, 271);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivateModeSelect";
            this.Text = "请选择激活方式";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBankCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActivateCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSelectActive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxBankCard;
        private System.Windows.Forms.PictureBox pictureBoxActivateCard;
    }
}