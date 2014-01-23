using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrtHttpServer
{
    class APIConfig
    {
        public string api { get; set; }
        public string resp { get; set; }
        private string _content;


        public APIConfig(string content)
        {
            _content = content;
        }

        public void decoding()
        {

        }

        public string apiResult()
        {
            return _content;
        }
    }
}
