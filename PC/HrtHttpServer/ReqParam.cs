using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;


namespace HrtHttpServer
{
    class ReqParam
    {
        public string API {  get; set; }
        public string CallID{ get; set; }
        public string SessionKey{ get; set; }
        public string Sig{ get; set; }
        public Dictionary<string, string> m_dicParam;

        private string _strReqParam;
        public  ReqParam(string param) 
        {
            _strReqParam = param;
            m_dicParam = new Dictionary<string, string>();
        }

        public void parse()
        {
            string[] paramList = _strReqParam.Split('&');
            if (paramList.Length >= 1)
            {
                API = paramList[0].Remove(0,1);
            }
            for (int index = 1;index < paramList.Length;index++)
            {
                string[] keyValue = paramList[index].Split('=');
                if (2 == keyValue.Length)
                {
                    switch (keyValue[0])
                    {
                        case "callid":
                            CallID = keyValue[1];
                            break;

                        case "sessionkey":
                            SessionKey = keyValue[1];
                            break;

                        case "sig":
                            Sig = keyValue[1];
                            break;

                        default:
                            m_dicParam.Add(keyValue[0], keyValue[1]);
                            break;

                    }
                }
             //  Debug.Assert(keyValue.Length == 2);
            //    System.Console.WriteLine("key = {0},value = {1}",keyValue[0],keyValue[1]);
            }
        }
    }
}
