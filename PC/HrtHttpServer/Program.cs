using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrtHttpServer;

namespace HrtHttpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Config config = new Config();
            config.load();
            ProxyServer proxy = new ProxyServer(config.IP,config.PORT);
            try
            {
                proxy.start();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
