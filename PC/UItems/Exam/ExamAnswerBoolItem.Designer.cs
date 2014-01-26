namespace UItems.Exam
{
    partial class ExamAnswerBoolItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonY = new System.Windows.Forms.RadioButton();
            this.radioButtonN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonY
            // 
            this.radioButtonY.AutoSize = true;
            this.radioButtonY.Location = new System.Drawing.Point(28, 6);
            this.radioButtonY.Name = "radioButtonY";
            this.radioButtonY.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonY.Size = new System.Drawing.Size(47, 16);
            this.radioButtonY.TabIndex = 0;
            this.radioButtonY.TabStop = true;
            this.radioButtonY.Text = "正确";
            this.radioButtonY.UseVisualStyleBackColor = true;
            // 
            // radioButtonN
            // 
            this.radioButtonN.AutoSize = true;
            this.radioButtonN.Location = new System.Drawing.Point(81, 6);
            this.radioButtonN.Name = "radioButtonN";
            this.radioButtonN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonN.Size = new System.Drawing.Size(47, 16);
            this.radioButtonN.TabIndex = 1;
            this.radioButtonN.TabStop = true;
            this.radioButtonN.Text = "错误";
            this.radioButtonN.UseVisualStyleBackColor = true;
            // 
            // ExamAnswerOptionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButtonN);
            this.Controls.Add(this.radioButtonY);
            this.Name = "ExamAnswerOptionItem";
            this.Size = new System.Drawing.Size(225, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonY;
        private System.Windows.Forms.RadioButton radioButtonN;

    }
}
