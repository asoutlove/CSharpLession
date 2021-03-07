using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepHelper2
{
    class SleepHelper
    {
        public static void SleepAWhile(int second)
        {

                int ms = second * 1000;
                Random ren = new Random();
                int inser = ren.Next(2, 5);
                ms += inser;
                System.Threading.Thread.Sleep(ms);



         }
    }
}
