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
using UItems.TrainingDoc;

namespace HrtClient
{
    public partial class MainForm : MoveableForm
    {
        private Registe reg;
        private TrainingTestItem item;
        public MainForm()
        {
            //item = new TrainingTestItem();
            InitializeComponent();
            //tabPageTrainingTest.Controls.Add(item);

            

            FlowLayoutPanel data = ptlExamAll.getFlpData();
            FlowLayoutPanel indexData = this.ptlcTraningPlanIndex.getFlpData();

            int pageSizeTest = 2;

            //if (data.RowCount != pageSizeTest)
            //{
            //    data.RowCount = pageSizeTest;
            //}

            TrainingDocItem item;
            List<TrainingDocItem> testItems = new List<TrainingDocItem>();
            for (int i = 0; i < pageSizeTest; i++)
            {
                item = new TrainingDocItem();
                item.Name = "trainingDocItem" + i;
                testItems.Add(item);
                //item.learnOrPayClick += new pictureBoxLearnOrPay_ClickEventHander(item_learnOrPayClick);
                data.Controls.Add(testItems[i]);
                //data.SetRow(testItems[i], i);
                //data.SetColumn(testItems[i], 0);


                item.Dock = DockStyle.Fill;
                indexData.Controls.Add(testItems[i]);
                //indexData.SetRow(testItems[i], i);
                //indexData.SetColumn(testItems[i], 0);


            }
            //data.Show();


            GetAllInitInfo(tabControlCenter);

        }

        protected void item_learnOrPayClick(object sender, EventArgs e)
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
            int x = tabControlCenter.Width;
            int y = tabControlCenter.Height;
            this.WindowState = FormWindowState.Maximized;

            ControlsChangeInit(tabControlCenter);
            ControlsChange(tabControlCenter);

            //float x_change_ratio = tabControlCenter.Width / x;
            //float y_change_ratio = tabControlCenter.Height / y;
            //foreach (Control control in tabControlCenter.Controls)
            //{
            //    if (control is UserControl)
            //    {

            //    }
            //}
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




        #region 控件缩放
        double formWidth;//窗体原始宽度
        double formHeight;//窗体原始高度
        double scaleX;//水平缩放比例
        double scaleY;//垂直缩放比例
        Dictionary<string, string> controlInfo = new Dictionary<string, string>();//控件中心Left,Top,控件Width,控件Height,控件字体Size
        /// <summary>
        /// 获取所有原始数据
        /// </summary>
        private void GetAllInitInfo(Control CrlContainer)
        {
            //if (CrlContainer.Parent == this)
            if (CrlContainer.Parent == this.tableLayoutPanelAll)
            {
                formWidth = Convert.ToDouble(CrlContainer.Width);
                formHeight = Convert.ToDouble(CrlContainer.Height);
            }

            //if (CrlContainer.Name.Contains("panelTDCI") || CrlContainer.Name.Contains("trainingDocItem"))
            //{
            //    MessageBox.Show("Hello~~~~" + "--" + CrlContainer.Name);
            //}
            foreach (Control item in CrlContainer.Controls)
            {

                
                if (item.Name.Trim() != "" && !controlInfo.ContainsKey(item.Name))
                    controlInfo.Add(item.Name, (item.Left + item.Width / 2) + "," + (item.Top + item.Height / 2) + "," + item.Width + "," + item.Height + "," + item.Font.Size);
                if (item.Controls.Count > 0)
                    GetAllInitInfo(item);
            }
        }
        private void ControlsChangeInit(Control CrlContainer)
        {
            scaleX = (Convert.ToDouble(CrlContainer.Width) / formWidth);
            scaleY = (Convert.ToDouble(CrlContainer.Height) / formHeight);
            //MessageBox.Show("Hello~~~~" + scaleX + "--" + scaleY);
        }
        private void ControlsChange(Control CrlContainer)
        {
           // MessageBox.Show("Hello~~~~" + scaleX + "--" + CrlContainer.Name);
            double[] pos = new double[5];//pos数组保存当前控件中心Left,Top,控件Width,控件Height,控件字体Size
            foreach (Control item in CrlContainer.Controls)
            {
                if (item.Name.Trim() != "")
                {
                    if (item.Controls.Count > 0)
                        ControlsChange(item);
                    string[] strs = controlInfo[item.Name].Split(',');
                    for (int j = 0; j < 5; j++)
                    {
                        pos[j] = Convert.ToDouble(strs[j]);
                    }
                    double itemWidth = pos[2] * scaleX;
                    double itemHeight = pos[3] * scaleY;
                    item.Left = Convert.ToInt32(pos[0] * scaleX - itemWidth / 2);
                    item.Top = Convert.ToInt32(pos[1] * scaleY - itemHeight / 2);
                    item.Width = Convert.ToInt32(itemWidth);
                    item.Height = Convert.ToInt32(itemHeight);
                    item.Font = new Font(item.Font.Name, float.Parse((pos[4] * Math.Min(scaleX, scaleY)).ToString()));
                }
            }
        }
        #endregion

        /// <summary>
        /// 在窗体的Load事件中调用GetAllInitInfo方法，代码如下：
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form_Load(object sender, EventArgs e)
        {
            GetAllInitInfo(tabControlCenter);
        }
        /// <summary>
        /// 在窗体的Resize事件中调用ControlsChangeInit和ControlsChange方法，代码如下：
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form_Resize(object sender, EventArgs e)
        {
            ControlsChangeInit(tabControlCenter);
            ControlsChange(tabControlCenter);
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

        private void pbUserPic_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
