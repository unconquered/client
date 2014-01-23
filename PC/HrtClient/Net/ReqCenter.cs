using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using Newtonsoft;
using Newtonsoft.Json;

namespace HrtClient.Net
{
    class ReqCenter
    {
        
        private string m_strSessionKey;
        private UInt32 m_nCount;
        private string m_strSecretKey;

        private string m_strIP;
        private string m_nPort;

         public ReqCenter()
        {
        }
        public string Req(string api)
        {
            return string.Empty;
        }
        public string getResp(string api, Dictionary<string,string> paramList)
        {
            return string.Empty;
        }
        public string getRespAsync()
        {
            return string.Empty;
        }


        /// <summary>
        /// format:api?call_id=xxx &sig=xxx&session_key=xxx&业务参数。
        /// </summary>
        /// <param name="api"></param>
        /// <param name="paramList"></param>
        /// <returns></returns>
        private string formatParam(string api, Dictionary<string, string> paramList)
        {
            string strResult = api + "?" + "call_id=" + m_nCount.ToString() + "&sig=" + 
                getSig(api,paramList) + "&session_key=" + m_strSessionKey + "&"  + getBussinessParam(paramList);
            m_nCount++;
            return string.Empty;
           
        }
        private string getBussinessParam(Dictionary<string, string> paramList)
        {
            string result = string.Empty;
            foreach (KeyValuePair<string, string> itemParam in paramList)
            {
                result +=  itemParam.Key + "=" + itemParam.Value + "&";
            }
            return result.Remove(result.Length - 1);
        }
        private string getSig(string api, Dictionary<string, string> paramList)
        {
            string strPreProcess = api;
            foreach (KeyValuePair<string,string> itemParam in paramList)
            {
                strPreProcess += itemParam.Key + itemParam.Value;
            }
            strPreProcess += m_strSecretKey;
            string strResult = null;
            strResult = CommonTools.Tools.MD5(strPreProcess);
            return strResult.ToLower();
        }
        private string RespPreProcess(string resp)
        {
           // JObject jobject = new JObject(resp);
            return string.Empty;

        }
        public string SESSIONKEY 
        {
            set
            {
                m_strSessionKey = value;
            }
            get 
            {
                return m_strSessionKey;
            }
        }
    }
}
