using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileConsole
{
    class TestFolderReader
    {
        public static void ListAllFile(string path)
        {
            if (!System.IO.Directory.Exists(path))
            {
                Console.WriteLine($"{path} doesn't exist;");
                Console.ReadLine();
                return;
            }

            string[] folderItems = System.IO.Directory.GetFileSystemEntries(path);

            foreach (string item in folderItems)
            {
                Console.WriteLine(item);
            }
        }
        public static void CreateFolder(string path)
        {
            if (System.IO.Directory.Exists(path))
                return;

            System.IO.Directory.CreateDirectory(path);
        }
        public static void DeliteFolder(string path)
        {
            if (!System.IO.Directory.Exists(path))
                return;

            System.IO.Directory.Delete(path);
        }
        
    }
}
