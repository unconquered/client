using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;

namespace HrtHttpServer
{
    class ClientReq
    {
        private ProxyServer _proxyServer;
        private TcpClient _tcpClient;

        private StreamReader _ioSockReader;
        private StreamReader _ioSockWritter;

        private String _reqType;
        private String _reqRelativePath;
        private String _reqProtoVersion;
        private string _domainName;

        public ClientReq(TcpClient tcpClient, ProxyServer proxyServer)
        {
            _tcpClient = tcpClient;
            _proxyServer = proxyServer;
            _domainName = "http://www.baidu.com";
            RespCreator.load();
        }
        public void processCenter()
        {

        }

        public void Request() 
        {
//             if (null == _ioSockReader)
//             {
            NetworkStream networkStream = _tcpClient.GetStream();
            if (networkStream.CanRead)
            {
                _ioSockReader = new StreamReader(networkStream);
            }
            if (_ioSockReader == null)
            {
                return;
            }

            String request = readStream(_ioSockReader); //_ioSockReader.ReadToEnd();
            if (null == request || string.Empty == request.Trim())
            {
                //Console.WriteLine("received a empty string");
                return;
            }
            
            Console.WriteLine("request line:{0}",request);
            string[] tokens = request.Split(' ');
            if (tokens.Length != 3)
            {
                //throw new Exception("Invalidate Request!");
                Console.WriteLine("Invalidate Request!");
                return;
            }
            _reqType = tokens[0].ToUpper();
            _reqRelativePath = tokens[1];
            _reqProtoVersion = tokens[2];


            Console.WriteLine("new request:");
            Console.WriteLine("type:{0},relativepath:{1},version:{2}",
                _reqType,_reqRelativePath,_reqProtoVersion);
            Console.WriteLine("**************************\r\n");
            createResponse();
            _ioSockReader.Close();
        }
        private string readStream(StreamReader streamReader)
        {
            //byte[] buffer = new byte[100];
            string result = string.Empty;
            int index = 0;
            while(!streamReader.EndOfStream)
            {
               result += streamReader.ReadLine() + " ";
               index++;
               if (3 == index)
                {
                   break;
                }
            }
            if (result != string.Empty)
            {
                result.Remove(result.Length - 1);
            }
            return result;
        }
        private void createResponse()
        {
            RespCreator resp = new RespCreator(_reqRelativePath);
            string result = resp.getResult();
            byte[] respArray = System.Text.UTF8Encoding.UTF8.GetBytes(result);
            _tcpClient.Client.Send(respArray);
            Console.WriteLine("response:{0}", result);
        }

        private void ReqDispatcher()
        {
            switch (_reqType)
            {
                case "POST":
                case "GET":
                    Redirect();
                    break;
                case "PUT": break;
                case "DELETE": break;
                case "TRACE": break;
                case "CONNECT": break;
                case "OPTIONS": break;
                case "HEAD": break;
                default:
                    Debug.Assert(false);
                    break;
            }
        }
        private void Redirect()
        {
            WebRequest webReq = WebRequest.Create(_domainName + _reqRelativePath);
            //wait for server response
            WebResponse webResp = webReq.GetResponse();
            Stream ioStream = webResp.GetResponseStream();

            System.Console.WriteLine(ioStream.ToString());

            int size = _tcpClient.Client.Send(CommonTools.Tools.ToBytes(ioStream));
        }

        void ReqPost()
        {

        }
    }
}
