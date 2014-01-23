using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrtClient
{
    public partial class Registe : Form
    {

        int reg_progress = 0;
        Dictionary<String, int> provinces = new Dictionary<string, int>();


        public Registe()
        {
            InitializeComponent();
        }

        private void Registe_Load(object sender, EventArgs e)
        {
            reSize();
            loadProvinces();
        }

        private void loadProvinces(){
            if (provinces.Count == 0)
            {
                for (int i = 0; i < 33; i++)
                {
                    provinces["xx省" + i] = i;
                }
            }
            Button provinceBtn;
            for (int i = 0; i < provinces.Count; i++)
            {
                provinceBtn = new Button();
                provinceBtn.Text = (string)provinces.ElementAt(i).Key;
                provinceBtn.Click += new System.EventHandler(loadPlatform);
                this.reg1AreaPanel.Controls.Add(provinceBtn);
                
            }
        }

        private void loadPlatform(object sender, EventArgs e)
        {
            foreach(Control control in reg1AreaPanel.Controls){
                ((Button)control).BackColor = Color.Transparent;
            }
            Button btn = (Button)sender;
            btn.BackColor = Color.Green;
            this.reg1PFComboBox.Items.Clear();
            this.reg1PFComboBox.Items.AddRange(getPlatForm(provinces[btn.Text]).ToArray());
        }

        private List<string> getPlatForm(int provinceId)
        {
            List<string> pfs = new List<string>();
            pfs.Add("p1_" + provinceId);
            pfs.Add("p2_" + provinceId);
            return pfs;
        }

        private void reSize()
        {
            this.regTabControl.Height = 274;
            tlpReg.Size = new Size(593, 450);
            tlpReg.RowStyles[0].Height = 274;
            this.SetClientSizeCore(735, 555);
            if (reg_progress == 0)
            {
                
            }
            else if (reg_progress == 1)
            {
                
            }
            else if (reg_progress == 2)
            {
                tlpReg.Size = new Size(735, 550);
                this.regTabControl.Height = 540;
                this.SetClientSizeCore(735, 600);
            }
            else if (reg_progress == 3)
            {
                
            }
        }

        private void nextStep()
        {
            reg_progress++;
            if (reg_progress == 2)
            {
                this.regTabControl.Height = 540;
                this.SetClientSizeCore(593, 600);
                reg1NextBtn.Text = "完成";
            }
            else  
            {
                this.regTabControl.Height = 274;
                this.SetClientSizeCore(593, 364);
                this.CenterToScreen();
            }
            
            if (reg_progress > 3)
            {
                this.Close();
                return;
            }
            regTabControl.SelectedTab = regTabControl.TabPages[reg_progress];
        }

        private void pbRegClose_Click(object sender, EventArgs e)
        {
            this.Close();
           // this.DestroyHandle();
        }

        private void pbRegMin_Click(object sender, EventArgs e)
        {
            
        }

        private void reg1NextBtn_Click(object sender, EventArgs e)
        {
            nextStep();
        }

    }
}
