using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFolderHandling
{
    class DeleteFolderClass
    {
        public static void DeleteFolder(string destPath) //用來刪除指定資料夾
        {
            

            if (Directory.Exists(destPath))//確認資料夾是否存在&列舉目錄
            {
                foreach (string d in Directory.GetFileSystemEntries(destPath))
                {
                    if (System.IO.File.Exists(d))
                    {
                        FileInfo fi = new FileInfo(d);
                        if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                            fi.Attributes = FileAttributes.Normal;
                        System.IO.File.Delete(d);//刪除文件
                    }
                    else
                        DeleteFolder(d);//刪除子資料夾
                }
                Directory.Delete(destPath);//删除空資料夾
            }
            else
            {
                Console.WriteLine($"此資料夾{destPath}不存在。");
            }

        }
    }
}
