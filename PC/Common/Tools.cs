using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CommonTools
{
    public class Tools
    {
        public static Stream ToStream(byte[] bytes)
        {
            Stream stream = new MemoryStream(bytes);
            return stream;
        }
        public static byte[] ToBytes(Stream stream)
        {
            byte[] bytes = new byte[stream.Length];

            stream.Read(bytes, 0, bytes.Length);

            //设置当前流的位置为流的开始
            stream.Seek(0, SeekOrigin.Begin);

            return bytes;
        }
        public static string ParseFileName(string resURI)
        {

            int indexSlash = resURI.LastIndexOf("/") + 1;
            if (resURI.Length > indexSlash)
            {
                return resURI.Substring(indexSlash, resURI.Length - indexSlash);
            }
            return string.Empty;
        }
        public static string MD5(string srcContent)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Provider =
                new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] contentCrypt = System.Text.Encoding.Unicode.GetBytes(srcContent);
            byte[] resultContent = md5Provider.ComputeHash(contentCrypt);
            return System.Text.Encoding.Unicode.GetString(resultContent);
        }

       
    }
}
