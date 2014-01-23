using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Xsl;

namespace HrtHttpServer
{
    class RespCreator
    {
        //resp creator
        private string _strReqParam;
        private string _resultJson;
        private static Dictionary<string, RespItem> _dicApiJson;
       
        public static void load()
        {
             StreamReader jsonConfig = new StreamReader(@".\json\config.json");
             _dicApiJson = new Dictionary<string, RespItem>();
             string jsonText = jsonConfig.ReadToEnd();
             jsonText = preProcess(jsonText);
             JObject obj = JObject.Parse(jsonText);
            foreach (JToken tmpToken in obj["RespCreator"].Children())
            {
                string resp = tmpToken["resp"].ToString(),api = tmpToken["api"].ToString();
                parseItem(api,resp);
                Console.WriteLine("api = {0},resp = {1}", api, resp);
            }
        }
        public static void parseItem(string api,string josnFile)
        {
            string path = string.Empty;
            path = path + @".\json\"+ josnFile;
            StreamReader reader = new StreamReader(path);
            string content = reader.ReadToEnd();
            content = preProcess(content);
            if (string.Empty == content)
            {
                return;
            }
            JObject obj = JObject.Parse(content);
            
            RespItem respItem = new RespItem();
            if (null == obj || (null == obj["Situ"]))
            {
                return;
            }
            foreach (JToken tmpToken in obj["Situ"].Children())
            {
                respItem.add(tmpToken.ToString());
            }
            _dicApiJson.Add(api,respItem);
        }
        public static string preProcess(string strJson)
        {
              strJson = strJson.Replace("\r\n", "");
              strJson = strJson.Replace("\t", "");
             // strJson = strJson.Replace(@"\", "");
              return strJson;
        }

        private void loadAllJson()
        {

        }

        public RespCreator(string strParam) 
        {
            _strReqParam = strParam;
        }
        public string getResult()
        {
            parse();
            return _resultJson;
        }

        private void parse() 
        {
            ReqParam reqParam = new ReqParam(_strReqParam);
            reqParam.parse();
            RespItem respItem = null;

            bool bResult = _dicApiJson.TryGetValue(reqParam.API, out  respItem);

            if (!bResult || (null == respItem))
            {
                Console.WriteLine("api result error,api = {0}",reqParam.API);
                //throw new LogicException(1001, "api not found");
                _resultJson = "{\"RET\":1001,\"MSG\":\"api not found\"}";
                //_resultJson = String.Format("{\"RET\":{0},\"MSG\":{1}}",1001,"api not found");
                return;
            }
            _resultJson = respItem.pickup();
            _resultJson = preProcess(_resultJson);
            _resultJson = "{\"RET\":0," + _resultJson + "}";
        }
    }
}
