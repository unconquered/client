using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UItems.TrainingTestItem
{  
    public delegate void pictureBoxLearnOrPay_ClickEventHander(object sender, EventArgs e);

    public partial class TrainingTestItem : UserControl
    {

    public event pictureBoxLearnOrPay_ClickEventHander learnOrPayClick;

        public TrainingTestItem()
        {
            InitializeComponent();
        }

        private void TrainingTestItem_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxLearnOrPay_Click(object sender, EventArgs e)
        {
            if (learnOrPayClick != null)
            {
                learnOrPayClick(this, e);
            }
        }
    }
}
