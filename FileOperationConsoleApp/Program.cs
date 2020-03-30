using System;

namespace FileOperationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            File file = new File();
        repeat:
            Console.WriteLine("File Operation");
            Console.WriteLine("Choose Any One:");
            Console.WriteLine("1. Create File");
            Console.WriteLine("2. Display Content of File");
            Console.WriteLine("3. Copy File");
            Console.WriteLine("4. Rename File");
            Console.WriteLine("5. Concate File");
            Console.WriteLine("6. Exit");

            int choice = Int32.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    file.CreateFile();
                    goto repeat;

                case 2:
                    file.DisplayData();
                    goto repeat;

                case 3:
                    file.CopyData();
                    goto repeat;

                case 4:
                    file.RenameFile();
                    goto repeat;

                case 5:
                    file.ConcateFile();
                    goto repeat;

                case 6:
                    break;

                default:
                    Console.WriteLine("Choose from the above only");
                    goto repeat;



            }
        }
    }
}
