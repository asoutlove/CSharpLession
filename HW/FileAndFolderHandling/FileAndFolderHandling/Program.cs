using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFolderHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to \"File And Folder Handling\" system.");//程式啟動提示文字
            Console.WriteLine($"請輸入要使用的功能(英文 不區分大小寫):");//給客戶功能選項
            Console.WriteLine("1.MoveFile 2.CopyFile 3.ReadFile 4.DeleteFile 5.CreateFolder 6.DeleteFolder");
            string userChoice = Console.ReadLine();
            userChoice = userChoice.ToUpper();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件
            string swresult = "";

            

            Console.Write("是否確認執行?(Y/N)");
            sw.Reset();

            string userCheck = Console.ReadLine();
            sw.Start();//開始計時
            if (userCheck =="N" || userCheck == "n") {
                Console.WriteLine("取消處理.....再見");
                sw.Stop();//停止計時
                swresult = sw.Elapsed.TotalSeconds.ToString();//計算使用時間(秒)
                Console.WriteLine($"本次使用耗時: {swresult}");//輸出使用時間
                Console.ReadLine();

            }  

            switch (userChoice)
                {

                #region ---使用者要移動檔案---
                case "MOVEFILE":
                    Console.WriteLine("請輸入來源檔案路徑:");
                    string fileComeFrom = @"C:\Temp\aaa.txt";
                    fileComeFrom = Console.ReadLine();
                    Console.Write("請輸入要移動到的路徑:");
                    string fileTo = "";
                    fileTo = Console.ReadLine();
                    MoveFileClass.MoveFile(fileComeFrom, fileTo);

                    break;
                #endregion

                #region ---使用者要拷貝檔案---
                case "COPYFILE":
                    Console.WriteLine("請輸入來源檔案路徑:");
                     fileComeFrom = @"C:\Temp\aaa.txt";
                    fileComeFrom = Console.ReadLine();
                    Console.Write("請輸入要拷貝到的路徑:");
                     fileTo = "";
                    fileTo = Console.ReadLine();
                    CopyFileClass.CopyFile(fileComeFrom, fileTo);
                    break;
                #endregion

                #region ---使用者要讀取檔案---
                case "READFILE":
                    Console.WriteLine("請輸入要讀取的來源檔案路徑:");
                    fileComeFrom = @"C:\Temp\aaa.txt";
                    fileComeFrom = Console.ReadLine();
                    ReadFileClass.ReadFile(fileComeFrom);
                    break;
                    #endregion

                #region ---使用者要刪除檔案---
                case "DELETEFILE":
                    Console.WriteLine("請輸入要刪除的來源檔案路徑:");
                    fileComeFrom = @"C:\Temp\aaa.txt";
                    fileComeFrom = Console.ReadLine();
                    DeleteFileClass.DeleteFile(fileComeFrom);
                    break;
                #endregion

                #region ---使用者要建立資料夾---
                case "CREATEFOLDER":
                    Console.Write("請輸入要建立資料夾的路徑:");
                    fileTo = "";
                    fileTo = Console.ReadLine();
                    CreateFolderClass.CreateFolder(fileTo);
                    break;
                #endregion

                #region ---使用者要刪除資料夾---
                case "DELETEFOLDER":
                    Console.Write("請輸入要刪除的資料夾路徑:");
                    fileTo = "";
                    fileTo = Console.ReadLine();
                    DeleteFolderClass.DeleteFolder(fileTo);
                    break; 
                #endregion

                default:
                        Console.WriteLine("未選擇正確功能,結束使用");
                        break;
                }

            sw.Stop();//停止計時
            swresult = sw.Elapsed.TotalSeconds.ToString();//計算使用時間(秒)
            Console.WriteLine($"本次使用耗時: {swresult}");//輸出使用時間
            Console.ReadLine();



        }
    }
}
