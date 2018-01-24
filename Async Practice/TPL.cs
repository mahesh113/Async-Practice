using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Practice
{
    // Task parallel library. Function will optimally use the core of the machines.
    class TPL
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 1000000, (x) => RunMillionIterations());
        }
        public static void RunMillionIterations()
        {
            string x = "";
            for(int i=0;i<1000000;i++)
            {
                x = x + "s";
            }
        }
    }
}
