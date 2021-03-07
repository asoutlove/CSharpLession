using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 32, 31, 30, 0, 11, 8 };
            //Process(array);

            foreach(string item in args)
            {
                Console.WriteLine($"{item}");
            }


            Console.ReadLine();
        }

        static void Process(int[] arr)
        {
                if (arr != null)
            {
                for (int k = 0; k < arr.Length; k++)
                {

                    Console.WriteLine(" " + arr[k]);
                }
            }
        }

    }
}
