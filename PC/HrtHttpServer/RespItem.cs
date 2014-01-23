using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HrtHttpServer
{
    class RespItem
    {
        public ArrayList m_arrayList;

        public RespItem()
        {
            m_arrayList = new ArrayList();
        }
        public void add(string result)
        {
            m_arrayList.Add(result);
        }
        public string pickup()
        {
            Random rand = new Random();
            if ( 0 == m_arrayList.Count)
            {
                return string.Empty;
            }
            int randValue = rand.Next(m_arrayList.Count);
            return m_arrayList[randValue].ToString();
        }
    }
}
