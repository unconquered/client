using System;
using System.Net;

namespace CommonTools
{
     public class HttpException :  Exception
    {

        public HttpException(HttpStatusCode code, string errMsg)
            : base(errMsg)
        {
            Code = code;
        }

        protected HttpException(HttpStatusCode code, string errMsg, Exception inner)
            : base(errMsg, inner)
        {
            Code = code;
        }

        public HttpStatusCode Code { get; private set; }
    }
}
