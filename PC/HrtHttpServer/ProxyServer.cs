using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace HrtHttpServer
{
	class ProxyServer
	{
		#region memberlist
		private int m_nPort;
		private string m_strIP;
		private bool _isAlive;
		private ClientReq _client;
		private HttpListener m_httpListener;

        private string baseFolder;
        
		#endregion
		public ProxyServer(string ipaddr, int port = 80)
		{
			m_nPort = port;
			m_strIP = ipaddr;
			ThreadPool.SetMaxThreads(10, 50);
			ThreadPool.SetMaxThreads(10, 10);
			m_httpListener = new HttpListener();
			m_httpListener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
			m_httpListener.Prefixes.Add("http://" + m_strIP + ":" + m_nPort.ToString() + "/");
            //m_httpListener.Prefixes.Add("http://127.0.0.1:8880/");
            baseFolder = @"./json/";
            _isAlive = true;
            RespCreator.load();
		}
		public void redirect(string request)
		{
		}

		public void start()
		{
			if (null != m_httpListener)
			{
				m_httpListener.Start();
				while (_isAlive)
				{
					try
					{
						HttpListenerContext listenContext = m_httpListener.GetContext();
						listenContext.Response.StatusCode = 200;
                        ThreadPool.QueueUserWorkItem(RequestProcess,listenContext);
						Console.WriteLine(listenContext.Request.Headers.ToString());
						Console.WriteLine();
					}
					catch (HttpListenerException ex)
					{
						Console.WriteLine("http lisltener exception:{0}", ex.Message);
						break;
					}
					catch (InvalidOperationException ex)
					{
						Console.WriteLine("invalidate operation excep,msg :{0}", ex.Message);
						break;
					}


				}
			}
		}
		private void Stop()
		{
			if ((null != m_httpListener) && (m_httpListener.IsListening))
			{
				m_httpListener.Stop();
			}
		}
		private void RequestProcess(object listenerContext)
		{
			try
			{
				var context = (HttpListenerContext)listenerContext;
                if (null == context)
                {
                    return;
                }
                string param = context.Request.RawUrl;
                RespCreator respCreator = new RespCreator(param);
                string result = respCreator.getResult();

                /*string filename = Path.GetFileName(context.Request.RawUrl);
                filename = "login.json";
                string path = Path.Combine(this.baseFolder, filename);
                byte[] msg;
                if (context.Request.HasEntityBody)
                {
                }
                if (!File.Exists(path))
                { 
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound; 
                    msg = Encoding.UTF8.GetBytes("Sorry, that page does not exist"); 
                } 
                else 
                { 
                    context.Response.StatusCode = (int)HttpStatusCode.OK; 
                    msg = File.ReadAllBytes(path);
                } */
                byte[] msg = Encoding.UTF8.GetBytes(result);
                context.Response.ContentLength64 = msg.Length;
                using (Stream s = context.Response.OutputStream) 
                {
                    s.Write(msg, 0, msg.Length);
                }
			}
			catch (Exception ex)
            { 
                Console.WriteLine("Request error: " + ex); 
            }
		}
	}
}
