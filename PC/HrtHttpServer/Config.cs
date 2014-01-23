using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HrtHttpServer
{
    class Config
    {
        private string _configPath;
        public string IP
        {
            get
            {
                if (m_strIP == string.Empty)
                {
                    return "127.0.0.1";
                }
                return m_strIP;
            }
            set
            {
                m_strIP = value;
            }
        }
        public int PORT
        {
            get
            {
                if (0 == m_nPort)
                {
                    return 8880;
                }
                return m_nPort;
            }
            set
            {
                m_nPort = value;
            }
        }

        private string m_strIP;
        private int m_nPort;


        public Config(string configPath = "param.json")
        {
            _configPath = configPath;
        }

        public void load()
        {
            StreamReader reader = new StreamReader(_configPath);
            if (null != reader)
            {
                string jsonConfig = reader.ReadToEnd();
                jsonConfig = RespCreator.preProcess(jsonConfig);
                JObject obj = JObject.Parse(jsonConfig);
                 
                m_strIP = getValue(obj, "ip");
                string port = getValue(obj, "port");
                m_nPort = (port == string.Empty ? 0 : Convert.ToInt32(getValue(obj, "port")));
            }
        }
        string getValue(JObject obj,string propertyName)
        {
            if (null != obj)
            {
                JToken token = obj.GetValue(propertyName);
                if (null != token)
                {
                    return token.ToString();
                }
            }
            return string.Empty;
        }
    }
}
