using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multithreading
{
    public class ThreadClass
    {
        public static void ThreadOne()
        {
            var threadOne = Thread.CurrentThread;
            threadOne.Name = "Thread One";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"This {threadOne.Name} runs " + i);
                if(i == 6) Thread.Sleep(9000);
            }
        }
        public static void ThreadTwo()
        {
            var threadOne = Thread.CurrentThread;
            threadOne.Name = "Thread Two";
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"This {threadOne.Name} runs " + i);
                if(i == 6) Thread.Sleep(1000);
            }
        }
    }
}