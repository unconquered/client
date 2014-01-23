using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrtHttpServer
{
    class LogicException : Exception
    {
        private int m_errCode;

        public LogicException(int errorCode, string errMsg)
            : base(errMsg)
        {
            m_errCode = errorCode;
        }
    }
}
