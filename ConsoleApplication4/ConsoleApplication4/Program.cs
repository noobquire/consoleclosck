using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;


namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("EXE path: {0}", path);

            string cfgpath = path + "time.cfg";
            Console.WriteLine("CFG path: {0}", cfgpath);

            const string quote = "\"";

            while (true)
            {

                StringBuilder sb = new StringBuilder();

                File.WriteAllText(cfgpath, string.Empty);

                sb.Append("alias currenttime " + quote + "echo " + quote + "Current time: " + DateTime.Now.ToString("HH:mm:ss") + quote + quote + Environment.NewLine);
                File.WriteAllText(cfgpath, sb.ToString());

                sb.Clear();

                Thread.Sleep(1000);
            }
        }
    }
}
    
