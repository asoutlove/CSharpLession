using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFolderHandling
{
    class MoveFileClass
    {
        public static void MoveFile(string sourceFileName, string destPath)
        {
            if (File.Exists(sourceFileName)) {
                try
                {
                    File.Move(sourceFileName, destPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                Console.WriteLine("來源路徑無指定檔案");
            }


        }
    }
}
