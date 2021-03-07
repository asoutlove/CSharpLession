using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteInfo();
            WriteInfo();

            try
            {
                 Console.WriteLine(Ret(1, 0));
            }
            catch
            {
                Console.WriteLine("出現錯誤");
            }


            Console.WriteLine(Add2(200, 7));

            int result = MathCore.Add(7, 9);
            Console.WriteLine($"從MathLibrary呼叫7+9:{result}");

            int result3 = MyMath.Add(3, 4);
            Console.WriteLine($"從MyMath呼叫3+4:{result3}");


            //MyMath mathUer = new MyMath;
            //int result2 = mathUer(6, 8);
            //Console.WriteLine (result2);


            Console.ReadLine();
        }
        static void WriteInfo()
        {
            Console.WriteLine("Hi ");
        }
        static int Add2(int a, int b)
        {

            return a + b;
        }
        static int Ret(int a, int b)
        {
            return a / b;

        }

    }
}
