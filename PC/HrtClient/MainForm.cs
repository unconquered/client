using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UItems.TrainingTestItem;
using UItems;

namespace HrtClient
{
    public partial class MainForm : MoveableForm
    {
        private Registe reg ;
        private TrainingTestItem item;
        public MainForm()
        {
            item = new TrainingTestItem();
            InitializeComponent();
            tabPageTrainingTest.Controls.Add(item);

            
            TableLayoutPanel data = pageTableLayoutControlTest.getTableLayoutPanelData();

            int pageSizeTest = 3;

            if (data.RowCount != pageSizeTest)
            {
                data.RowCount = pageSizeTest;
            }
            List<TrainingTestItem> testItems = new List<TrainingTestItem>();
            for(int i=0;i<pageSizeTest;i++)
            {
                testItems.Add(new TrainingTestItem());
                item.learnOrPayClick += new pictureBoxLearnOrPay_ClickEventHander(item_learnOrPayClick);
                data.Controls.Add(testItems[i]);
                data.SetRow(testItems[i], i);
                data.SetColumn(testItems[i], 0);
            }
            //data.Show();
           
        }

         void item_learnOrPayClick(object sender, EventArgs e)
        {
            if (true)
            {
                ActivateModeSelect active = new ActivateModeSelect();
                active.Show();
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxMaxmize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message message)
        {
            //             if (message.Msg == 0x0201)
            //             {
            //                 message.Msg = 0x00A1;
            //                 message.LParam = IntPtr.Zero;
            //                 message.WParam = new IntPtr(2);
            //             }
            base.WndProc(ref message);
        }

        private void pictureBoxMyTask_Click(object sender, EventArgs e)
        {
            selectTab(1);
        }

        private void pictureBoxMyExam_Click(object sender, EventArgs e)
        {
            selectTab(2);
            //TableLayoutPanel data = pageTableLayoutControlTest.getTableLayoutPanelData();
            //foreach(Control item in data.Controls){
            //    item.Show();
            //}
            //data.Show();
        }

        private void pictureBoxMyDoc_Click(object sender, EventArgs e)
        {
            selectTab(3);
        }

        private void pictureBoxDownload_Click(object sender, EventArgs e)
        {
            selectTab(4);
        }

        private void pictureBoxUserCenter_Click(object sender, EventArgs e)
        {
            selectTab(5);
        }
        private void selectTab(int index)
        {
            tabControlCenter.SelectTab(index);
            int alpha = 60;
            pictureBoxMyTask.BackColor = Color.FromArgb(alpha, 23, 48, 26);
            pictureBoxMyExam.BackColor = Color.FromArgb(alpha, 23, 48, 26);
            pictureBoxMyDoc.BackColor = Color.FromArgb(alpha, 23, 48, 26);
            pictureBoxDownload.BackColor = Color.FromArgb(alpha, 23, 48, 26);
            pictureBoxUserCenter.BackColor = Color.FromArgb(alpha, 23, 48, 26);

            alpha = 0;
            if (index == 1)
            {
                pictureBoxMyTask.BackColor = Color.FromArgb(alpha, 23, 48, 26);
            }
            else if (index == 2)
            {
                pictureBoxMyExam.BackColor = Color.FromArgb(alpha, 23, 48, 26);
            }
            else if (index == 3)
            {

                pictureBoxMyDoc.BackColor = Color.FromArgb(alpha, 23, 48, 26);
            }
            else if (index == 4)
            {
                pictureBoxDownload.BackColor = Color.FromArgb(alpha, 23, 48, 26);
            }
            else if (index == 5)
            {
                pictureBoxUserCenter.BackColor = Color.FromArgb(alpha, 23, 48, 26);
            }
        }
        private void selectTab(string tabName)
        {
            tabControlCenter.SelectTab(tabName);
            pictureBoxMyDoc.BackColor = Color.FromArgb(23, 48, 26);
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSetting_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
