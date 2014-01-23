﻿namespace UItems.PageControl
{
    partial class PageTableLayoutControl
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
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtPageNum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelContent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPage = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelData
            // 
            this.tableLayoutPanelData.AutoSize = true;
            this.tableLayoutPanelData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelData.ColumnCount = 1;
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelData.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 2;
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelData.Size = new System.Drawing.Size(768, 0);
            this.tableLayoutPanelData.TabIndex = 0;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(138, 8);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(60, 23);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "上一页";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(321, 8);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(60, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "下一页";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(75, 7);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(17, 12);
            this.lblTotalCount.TabIndex = 2;
            this.lblTotalCount.Text = "17";
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(26, 6);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(11, 12);
            this.lblPageCount.TabIndex = 3;
            this.lblPageCount.Text = "4";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(460, 7);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(57, 23);
            this.btnGo.TabIndex = 50;
            this.btnGo.Text = "确定";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtPageNum
            // 
            this.txtPageNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPageNum.Location = new System.Drawing.Point(417, 8);
            this.txtPageNum.Name = "txtPageNum";
            this.txtPageNum.Size = new System.Drawing.Size(37, 21);
            this.txtPageNum.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.labelContent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotalCount);
            this.panel1.Controls.Add(this.lblPageCount);
            this.panel1.Location = new System.Drawing.Point(537, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 26);
            this.panel1.TabIndex = 51;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(98, 7);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(41, 12);
            this.labelContent.TabIndex = 2;
            this.labelContent.Text = "门考试";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "页";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "共";
            // 
            // panelPage
            // 
            this.panelPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPage.Controls.Add(this.btnGo);
            this.panelPage.Controls.Add(this.panel1);
            this.panelPage.Controls.Add(this.buttonPrev);
            this.panelPage.Controls.Add(this.button1);
            this.panelPage.Controls.Add(this.txtPageNum);
            this.panelPage.Controls.Add(this.button2);
            this.panelPage.Controls.Add(this.buttonNext);
            this.panelPage.Controls.Add(this.button4);
            this.panelPage.Location = new System.Drawing.Point(4, 249);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(761, 38);
            this.panelPage.TabIndex = 52;
            // 
            // PageTableLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelData);
            this.Controls.Add(this.panelPage);
            this.Name = "PageTableLayoutControl";
            this.Size = new System.Drawing.Size(768, 290);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPage.ResumeLayout(false);
            this.panelPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtPageNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPage;
    }
}
