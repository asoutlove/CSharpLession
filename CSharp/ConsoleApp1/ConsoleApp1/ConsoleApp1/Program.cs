using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string soucePath = ConfigurationManager.AppSettings["SouceFilePath"];
            string targetPath = ConfigurationManager.AppSettings["TargetFilePath"];

            Console.WriteLine(" " + soucePath);
            Console.WriteLine(" " + targetPath);

            Console.ReadLine();
        }
    }
}
