using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.WebSockets;
using System.IO;
using UItems;
namespace HrtClient
{
    public partial class Login : MoveableForm
    {
        private Registe reg = null;
        public Login()
        {
            InitializeComponent();

        }
        private void Login_Load(object sender, EventArgs e)
        {
        }
        public bool Success()
        {
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = cmbAccount.SelectedText;
            string password = txtPassword.Text;

//             MainForm frm= new MainForm();
//             frm.Show();
            try
            {
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:8880/login?username=xxx&password=xxx");
                Stream rs = webReq.GetResponse().GetResponseStream();
                StreamReader reader = new StreamReader(rs);
                Console.WriteLine(reader.ReadToEnd());
            }
            catch (System.Exception ex)
            {
            	
            }
            this.Close();
            
        }

        private void Minimize_Click(object sender, EventArgs e)
        {

        }
        private void remberPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRemberPassword.Checked)
            {
                chkRememberUserName.CheckState = chkRemberPassword.CheckState;
            }
        }

        private void lnkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // if(reg == null)
            {
                reg = new Registe();
            }
            reg.Show();
        }

        private void lnkLabelPasswordRetrieve_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    
        private void pbClosing_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void chkRememberUserName_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkRememberUserName.Checked)
            {
                chkRemberPassword.CheckState = chkRememberUserName.CheckState;
            }
        }

        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
