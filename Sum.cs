using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    internal class Sum
    {
        public static readonly Logger logger =
            LogManager.GetCurrentClassLogger();

        public void Add(int a,int b)
        {
            if(a==0 || b == 0)
            {
                Console.WriteLine("a and b values are zero");
                logger.Error("a and b values are zero");
            }
            else
            {
                int c = a + b;
                Console.WriteLine("Addition=" + c);
                logger.Info("Addition=" + c);
            }
        }
    }
}
