using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace HrtClient
{
    class Config
    {
        private string m_strIP;
        private int m_nPort;

        private string configFile;

        public Config()
        {
            configFile = "config.json";
        }

        private void load()
        {
            try
            {
                StreamReader reader = new StreamReader(configFile);
                string strContent = reader.ReadToEnd();
            }
            catch (System.Exception ex)
            {
            	
            }
            
        }
    }
}
