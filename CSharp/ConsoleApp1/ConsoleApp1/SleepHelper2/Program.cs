using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepHelper2
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

            sw.Reset();

            sw.Start();
            SleepHelper.SleepAWhile(8);
            sw.Stop();

            Console.WriteLine("Program End. Total use " + sw.ElapsedMilliseconds);
            Console.ReadLine();


        }
    }
}
