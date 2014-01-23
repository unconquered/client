using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CommonTools;

namespace UItems
{
   
    public partial class MoveableForm : Form
    {
        [DllImport("gdi32.dll")]
        public static extern int CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);
        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hwnd,int hRgn,Boolean bReDraw);
        [DllImport("gdi32.dll", EntryPoint = "DeleteObject", CharSet = CharSet.Ansi)]
        public static extern int DeleteObject(int hObject);


        public bool CanResize { get; set; }
        private bool m_bMoveFlag;
        private Int32 m_nX;
        private Int32 m_nY;

        public MoveableForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            m_bMoveFlag = false;
        }
       public static void SetFormRoundRectRgn(Form form, int radius)
        {
            int rgn = 0;
            rgn = CreateRoundRectRgn(0, 0, form.Width + 1, form.Height + 1, radius, radius);
            SetWindowRgn(form.Handle, rgn, true);
            DeleteObject(rgn);
        }

        protected override void OnSizeChanged(EventArgs e)
       {
           base.OnSizeChanged(e);
           SetFormRoundRectRgn(this,10);
       }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            if (m_bMoveFlag && (e.Button == MouseButtons.Left))
                this.SetBounds(Left + e.X - m_nX, Top + e.Y - m_nY, this.Width, this.Height);
            base.OnMouseMove(e);
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            if (!m_bMoveFlag && e.Clicks >= 1)
                m_bMoveFlag = true;
            m_nX = e.X;
            m_nY = e.Y;
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            if (m_bMoveFlag)
                m_bMoveFlag = false;
            base.OnMouseUp(e);

        }

    }
}
