using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace HrtClient
{
    static class Program
    {

        public static Process m_pHttpServer;
        private static string m_strHttpServerName = "HrtHttpServer";
        private static string m_strClientName = "HrtClient";
        private static Mutex m_mutexClient;
        private static Mutex m_mutexHttpServer;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (isAppRun(m_strClientName))
            {
                MessageBox.Show("客户端已经在运行！");
                return;
            }else{
                m_mutexClient = new Mutex(true,m_strClientName);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            runHttpServer();
            Login login = new Login();
            login.ShowDialog();
            if (login.Success())
            {
                Application.Run(new MainForm());
            }
            httpServerExit();
        }   
        private static void runHttpServer()
        {
            Process[] processList = Process.GetProcessesByName(m_strHttpServerName);
            if (1 < processList.Length)
            {
                Console.WriteLine("程序错误,多个实例在运行");
                return;
            }
            else if (1 == processList.Length)
            {
                Console.WriteLine("HttpServer已经在运行");
                m_pHttpServer = processList[0];
                return;
            }

            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = m_strHttpServerName + ".exe";
            info.WorkingDirectory = ".";
            try
            {
                m_pHttpServer = Process.Start(info);
                m_mutexHttpServer = new Mutex(true,m_strHttpServerName);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                Console.WriteLine("没有找到HttpServer服务器程序");
                return;
            }
        }
        private static bool isAppRun(string strName)
        {
            Mutex httpServer = null;
            return Mutex.TryOpenExisting(strName, out httpServer);
        }

        private static bool httpServerExit()
        {
            if (isAppRun(m_strHttpServerName))
            {
                if ((null != m_pHttpServer)&&(!m_pHttpServer.HasExited))
                {
                    m_pHttpServer.Kill();
                }
            }
            return true;
        }
    }
}
