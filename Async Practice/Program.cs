using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Async_Practice
{
    class Program
    {
        static void Main1(string[] args)
        {
            Myfunc();
            Console.WriteLine("Main thread over.");
            Thread.Sleep(15000);
        }
        public static void Myfunc()
        {
            Console.WriteLine("Calling Function LongWaited()");
            Task.Run( new Action(LongWait));
            //LongWait();
            Console.WriteLine("Function LongWaited() called");
            int i = 9;
            i++;
        }
        public static async void Myasyncfunc()
        {
            Console.WriteLine("Calling Function LongWait()");
            await Task.Run( new Action(LongWait));
            //LongWait();
            Console.WriteLine("Function LongWait () called");
        }
        public static void LongWait()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Task Complete");
        }
    }
}
