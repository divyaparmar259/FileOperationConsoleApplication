using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileOperationConsoleApp
{
    public class File
    {
        public void CreateFile()
        {
            Console.WriteLine("Enter FileName:");
            string fn = Console.ReadLine();
            FileStream f = new FileStream(@"C:\Test\Files\" + fn + ".txt", FileMode.Create);
            Console.WriteLine("File Created..");
            f.Close();
        }           
        public void DisplayData()
        {
            Console.WriteLine("Enter FileName");
            string fn = Console.ReadLine();
            
            string[] lines = System.IO.File.ReadAllLines(@"C:\Test\Files\" + fn + ".txt");

            System.Console.WriteLine("Contents of File = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

        }

        public void CopyData()
        {
            Console.WriteLine("Enter First FileName");
            string fn1 = Console.ReadLine();
            Console.WriteLine("Enter Second FileName");
            string fn2 = Console.ReadLine();
            string content = System.IO.File.ReadAllText(@"C:\Test\Files\" + fn1 + ".txt");
            System.IO.File.AppendAllText(@"C:\Test\Files\" + fn2 + ".txt", content);
            Console.WriteLine("Content Copied from OneFile to Another");

        }
        public void RenameFile()
        {
            Console.WriteLine("Enter File To Rename");
            string fn1 = Console.ReadLine();
            Console.WriteLine("Enter New File Name");
            string fn2 = Console.ReadLine();
            string sourceFile = @"C:\Test\Files\" + fn1 + ".txt";
            FileInfo fi = new FileInfo(sourceFile);
            if (fi.Exists)
            {
                
                fi.MoveTo(@"C:\Test\Files\" + fn2 + ".txt");
                Console.WriteLine("File Renamed.");
            }
        }
        public void ConcateFile()
        {
            Console.WriteLine("Enter First FileName");
            string fn1 = Console.ReadLine();
            Console.WriteLine("Enter Second FileName");
            string fn2 = Console.ReadLine();
            Console.WriteLine("Enter Target FileName");
            string fn3 = Console.ReadLine();
            System.IO.File.WriteAllText((@"C:\Test\Files\" + fn3 + ".txt"), System.IO.File.ReadAllText(@"C:\Test\Files\" + fn1 + ".txt") + System.IO.File.ReadAllText(@"C:\Test\Files\" + fn2 + ".txt"));
            Console.WriteLine("Content Copied to target File..");

        }

    }
}
