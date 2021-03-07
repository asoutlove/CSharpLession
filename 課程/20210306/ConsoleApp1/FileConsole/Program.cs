using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\CSharp\\";
            string fileName = "AAA.txt";


            if (!System.IO.File.Exists(path + fileName))
            {
                Console.WriteLine($"{path}{fileName} doesn't exist;");
                Console.ReadLine();
                return;
            }

            string content = System.IO.File.ReadAllText(path + fileName);

            Console.WriteLine(content);
            Console.ReadLine();



        }
    }
}
