using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            Console.WriteLine("Program start.");
            sw.Start();
            SleepHelper.SleepAWhile(3);
            sw.Stop();

            sw.Start();
            SleepHelper.SleepAWhile(6);
            sw.Stop();

            Console.WriteLine("Program End. Total use " + sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
