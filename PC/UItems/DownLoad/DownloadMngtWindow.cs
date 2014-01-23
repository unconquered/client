using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UItems.DownLoad
{
    public partial class DownloadMngtWindow : UserControl
    {
        public DownloadMngtWindow()
        {
            InitializeComponent();
        }

        //InitDataGridView(this.grid);


        private void InitDataGridView(DataGridView grid)
        {
            CollapseDataGridViewRow collapseRow = new CollapseDataGridViewRow();
            collapseRow.IsCollapse = true;

            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            cell.Value = "2121";
            collapseRow.Cells.Add(cell);

            cell = new DataGridViewTextBoxCell();
            cell.Value = "212";
            collapseRow.Cells.Add(cell);

            DataGridViewRow row = new DataGridViewRow();
            cell = new DataGridViewTextBoxCell();
            cell.Value = "323";
            row.Cells.Add(cell);

            cell = new DataGridViewTextBoxCell();
            cell.Value = "2121";
            row.Cells.Add(cell);

            collapseRow.Rows.Add(row);

            CollapseDataGridViewRow collapseRow1 = new CollapseDataGridViewRow();
            collapseRow1.IsCollapse = true;

            cell = new DataGridViewTextBoxCell();
            cell.Value = "2121";
            collapseRow1.Cells.Add(cell);

            cell = new DataGridViewTextBoxCell();
            cell.Value = "212";
            collapseRow1.Cells.Add(cell);

            CollapseDataGridViewRow collapseRow2 = new CollapseDataGridViewRow();
            collapseRow2.IsCollapse = true;

            cell = new DataGridViewTextBoxCell();
            cell.Value = "2121";
            collapseRow2.Cells.Add(cell);

          
            cell = new DataGridViewTextBoxCell();
            cell.Value = "212";
            collapseRow2.Cells.Add(cell);

            DataGridViewRow row1 = new DataGridViewRow();
            row1 = new DataGridViewRow();
            cell = new DataGridViewTextBoxCell();
            cell.Value = "323";
            row1.Cells.Add(cell);

            cell = new DataGridViewTextBoxCell();
            cell.Value = "2121";
            row1.Cells.Add(cell);

            collapseRow2.Rows.Add(row1);
            collapseRow1.Rows.Add(collapseRow2);
            collapseRow.Rows.Add(collapseRow1);
            grid.Rows.Add(collapseRow);

        }
    }
}
