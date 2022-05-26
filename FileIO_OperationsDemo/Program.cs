using System;

namespace FileIO_OperationsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Change World Through Coding");
            Program program = new Program();
            program.FileExist();
            program.ReadAllLines();
            program.ReadAllText();
            program.CopyFile();
            program.DeleteFilePath();
            program.UsingStreamReader();


        }
        string filePath = @"H:\Assignments\FileIO_Operations\FileIO_OperationsDemo\IOTextFile.txt";
        string copyFilePath = @"H:\Assignments\FileIO_Operations\FileIO_OperationsDemo\IOTextFile.txt";
        public void FileExist()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Exists");
                return;
            }
            File.Create(filePath);
        }
        public void ReadAllLines()
        {
            string[] arr = File.ReadAllLines(filePath);
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        public void ReadAllText()
        {
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
        public void CopyFile()
        {
            File.Copy(filePath, copyFilePath);
        }
        public void DeleteFilePath()
        {
            File.Delete(copyFilePath);
        }
        public void UsingStreamReader()
        {
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath);
                try
                {
                    string str = " ";
                    while ((str = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
        }
    }
}
