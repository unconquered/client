using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using UItems.Properties;
using System.ComponentModel;

namespace UItems.DownLoad
{

    public class CollapseDataGridView : DataGridView
    {
        public CollapseDataGridView()
            : base()
        {
            this.RowHeadersVisible = true;
            this.RowHeadersWidth = 20;
        }

        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            base.OnRowPostPaint(e);

            DataGridViewRow row = this.Rows[e.RowIndex];
            if (row is CollapseDataGridViewRow && (row as CollapseDataGridViewRow).Rows.Count != 0)
            {
                Rectangle rect = new Rectangle(e.RowBounds.Location.X + 4, e.RowBounds.Location.Y + 4, 9, 9);
                Image img = null;
                if ((row as CollapseDataGridViewRow).IsCollapse)
                {
                    img = Resources.plus;
                }
                else
                {
                    img = Resources.minus;
                }
                e.Graphics.DrawImage(img, rect);
            }
        }

        protected override void OnRowHeaderMouseClick(DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.Rows[e.RowIndex];
            if (row is CollapseDataGridViewRow)
            {
                if ((row as CollapseDataGridViewRow).IsCollapse == true)
                {
                    (row as CollapseDataGridViewRow).IsCollapse = false;

                    if ((row as CollapseDataGridViewRow).Rows.Count != 0)
                    {
                        for (int i = 0; i < (row as CollapseDataGridViewRow).Rows.Count; i++)
                        {
                            this.Rows.Insert(e.RowIndex + 1 + i, (row as CollapseDataGridViewRow).Rows[i]);
                        }
                    }
                }
                else
                {
                    if ((row as CollapseDataGridViewRow).Rows.Count != 0)
                    {
                        RemoveAllSubRow((CollapseDataGridViewRow)row, this, false);
                    }
                    (row as CollapseDataGridViewRow).IsCollapse = true;
                }
            }
            base.OnRowHeaderMouseClick(e);
        }
        private void RemoveAllSubRow(CollapseDataGridViewRow row, DataGridView grid, bool flag)
        {
            if (row.Rows.Count != 0)
            {
                if (!row.IsCollapse)
                {
                    for (int i = 0; i < row.Rows.Count; i++)
                    {
                        if (row.Rows[i] is CollapseDataGridViewRow)
                        {
                            RemoveAllSubRow((CollapseDataGridViewRow)row.Rows[i], grid, true);
                        }
                        else
                        {
                            grid.Rows.Remove(row.Rows[i]);
                        }
                    }
                }
                if (flag)
                {
                    row.IsCollapse = true;
                    grid.Rows.Remove(row);
                }
            }
        }
    }
    public class CollapseDataGridViewRow : DataGridViewRow
    {
        private CollapseDataGridViewRowCollection m_rowCollection = new CollapseDataGridViewRowCollection();
        private bool m_isCollapse = false;

        #region Property
        /// <summary>
        /// 是否折叠显示
        /// </summary>
        public bool IsCollapse
        {
            get { return m_isCollapse; }
            set { m_isCollapse = value; }
        }
        /// <summary>
        /// 折叠控件的集合
        /// </summary>
        public CollapseDataGridViewRowCollection Rows
        {
            get { return m_rowCollection; }
            set { m_rowCollection = value; }
        }
        #endregion


    }
    public class CollapseDataGridViewRowCollection : IEnumerable<DataGridViewRow>, ICollection<DataGridViewRow>
    {
        private List<DataGridViewRow> m_list = new List<DataGridViewRow>();

        public DataGridViewRow this[int index]
        {
            get
            {
                if (index >= m_list.Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                return m_list[index];
            }
        }

        #region IEnumerable<DataGridViewRow> 成员

        public IEnumerator<DataGridViewRow> GetEnumerator()
        {
            if (m_list.Count == 0)
            {
                throw new ArgumentOutOfRangeException("collection is null");
            }
            for (int i = 0; i < m_list.Count; i++)
            {
                yield return m_list[i];
            }
        }

        #endregion

        #region IEnumerable 成员

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            if (m_list.Count == 0)
            {
                throw new ArgumentOutOfRangeException("collection is null");
            }
            for (int i = 0; i < m_list.Count; i++)
            {
                yield return m_list[i];
            }
        }

        #endregion

        #region ICollection<DataGridViewRow> 成员

        public void Add(DataGridViewRow item)
        {
            m_list.Add(item);
        }

        public void Clear()
        {
            m_list.Clear();
        }

        public bool Contains(DataGridViewRow item)
        {
            return m_list.Contains(item);
        }

        public void CopyTo(DataGridViewRow[] array, int arrayIndex)
        {
            m_list.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return m_list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(DataGridViewRow item)
        {
            return m_list.Remove(item);
        }

        #endregion
    }
}
