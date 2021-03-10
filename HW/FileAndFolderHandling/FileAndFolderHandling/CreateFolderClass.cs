using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFolderHandling
{
    class CreateFolderClass
    {
        public static void CreateFolder(string destPath)
        {
            if (Directory.Exists(destPath))
            {
                Console.WriteLine($"此資料夾{destPath}已存在。");
            }
            else
            {
                System.IO.Directory.CreateDirectory(destPath);
                Console.WriteLine($"{destPath}資料夾已建立。");
            }

        }
    }
}
