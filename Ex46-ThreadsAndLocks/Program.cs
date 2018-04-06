using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex46_ThreadsAndLocks
{
    class Program
    {
        public static void ThreadProc()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("A Hello world!");
                Thread.Sleep(1);
            }
            
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>(){ "Hello World", "Hello World", "Hello World", "Hello World" };

            Thread t = new Thread();
            
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("B Hello world!");
                Thread.Sleep(1);
            }

            t.Join();

            list.ForEach(i=>
            {
                Console.WriteLine(i);
            });



        }
    }
}
