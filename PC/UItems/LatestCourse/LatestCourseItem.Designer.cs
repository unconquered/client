namespace UItems.LatestCourse
{
    partial class LatestCourseItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLatCI = new System.Windows.Forms.Panel();
            this.labelProgressing = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLatCI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLatCI
            // 
            this.panelLatCI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLatCI.BackgroundImage = global::UItems.Properties.Resources.down_line_bg;
            this.panelLatCI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLatCI.Controls.Add(this.labelProgressing);
            this.panelLatCI.Controls.Add(this.labelTitle);
            this.panelLatCI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLatCI.Location = new System.Drawing.Point(0, 0);
            this.panelLatCI.Margin = new System.Windows.Forms.Padding(0);
            this.panelLatCI.Name = "panelLatCI";
            this.panelLatCI.Size = new System.Drawing.Size(335, 59);
            this.panelLatCI.TabIndex = 0;
            // 
            // labelProgressing
            // 
            this.labelProgressing.AutoSize = true;
            this.labelProgressing.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProgressing.Location = new System.Drawing.Point(20, 36);
            this.labelProgressing.Name = "labelProgressing";
            this.labelProgressing.Size = new System.Drawing.Size(126, 14);
            this.labelProgressing.TabIndex = 1;
            this.labelProgressing.Text = "进度：第1章第25节";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(131)))), ((int)(((byte)(81)))));
            this.labelTitle.Location = new System.Drawing.Point(18, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(259, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "提高公务员廉政道德从政水平";
            // 
            // LatestCourseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLatCI);
            this.Name = "LatestCourseItem";
            this.Size = new System.Drawing.Size(335, 59);
            this.panelLatCI.ResumeLayout(false);
            this.panelLatCI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLatCI;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelProgressing;
    }
}
