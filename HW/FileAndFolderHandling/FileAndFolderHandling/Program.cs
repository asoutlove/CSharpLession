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
            string userCheck ="y";
            //string userCheck = Console.ReadLine();//用來確認使用者是否要繼續使用系統
            string continueToUse = "y";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//引用stopwatch物件計算程式總共執行時間
            string swresult = "";//後面用來顯示總共程式執行時間
            sw.Reset();
            Console.WriteLine($"Welcome to \"File And Folder Handling\" system.");//進入程式的提示文字

            do //此do-while是用來確認使用者是否要繼續使用程式
            {
                
                Console.WriteLine($"請輸入要使用的功能(英文 不區分大小寫):");//給客戶功能選項
                Console.WriteLine("1.MoveFile 2.CopyFile 3.ReadFile 4.DeleteFile 5.CreateFolder 6.DeleteFolder");
                string userChoice = Console.ReadLine();//讓客戶選擇使用選項
                userChoice = userChoice.ToUpper();//將客戶輸入選項轉大寫文字 以利不用區分大小寫
                
                Console.Write("是否確認執行?(Y/N)");
                userCheck = Console.ReadLine();
                if (userCheck == "N" || userCheck == "n")
                {
                    Console.WriteLine("取消處理.....再見");
                    sw.Stop();//停止計時總使用時間
                    swresult = sw.Elapsed.TotalSeconds.ToString();//計算總共使用時間(秒)
                    Console.WriteLine($"本次總共檔案處理時間: {swresult}");//輸出總共的單純檔案處理時間
                    Console.ReadLine();
                    break;

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
                        sw.Start();//開始計算總使用時間
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
                        sw.Start();//開始計算總使用時間
                        CopyFileClass.CopyFile(fileComeFrom, fileTo);
                        break;
                    #endregion

                    #region ---使用者要讀取檔案---
                    case "READFILE":
                        Console.WriteLine("請輸入要讀取的來源檔案路徑:");
                        fileComeFrom = @"C:\Temp\aaa.txt";
                        fileComeFrom = Console.ReadLine();
                        sw.Start();//開始計算總使用時間
                        ReadFileClass.ReadFile(fileComeFrom);
                        break;
                    #endregion

                    #region ---使用者要刪除檔案---
                    case "DELETEFILE":
                        Console.WriteLine("請輸入要刪除的來源檔案路徑:");
                        fileComeFrom = @"C:\Temp\aaa.txt";
                        fileComeFrom = Console.ReadLine();
                        sw.Start();//開始計算總使用時間
                        DeleteFileClass.DeleteFile(fileComeFrom);
                        break;
                    #endregion

                    #region ---使用者要建立資料夾---
                    case "CREATEFOLDER":
                        Console.Write("請輸入要建立資料夾的路徑:");
                        fileTo = "";
                        fileTo = Console.ReadLine();
                        sw.Start();//開始計算總使用時間
                        CreateFolderClass.CreateFolder(fileTo);
                        break;
                    #endregion

                    #region ---使用者要刪除資料夾---
                    case "DELETEFOLDER":
                        Console.Write("請輸入要刪除的資料夾路徑:");
                        fileTo = "";
                        fileTo = Console.ReadLine();
                        sw.Start();//開始計算總使用時間
                        DeleteFolderClass.DeleteFolder(fileTo);
                        break;
                    #endregion

                    default:
                        Console.WriteLine("未選擇正確功能,結束使用");
                        break;
                }
            

            sw.Stop();//停止計算總使用時間

                Console.Write("是否繼續使用系統?(Y/N)");
                continueToUse = Console.ReadLine();
                
            } while (continueToUse == "y" || continueToUse == "Y");

            Console.Write("結束使用系統");
            swresult = sw.Elapsed.TotalSeconds.ToString();//計算使用時間(秒)
            Console.WriteLine($"本次總共檔案處理時間: {swresult}");//輸出單純檔案處理時間
            Console.ReadLine();
        }

    
    }
}
