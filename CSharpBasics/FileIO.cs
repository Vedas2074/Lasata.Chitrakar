using System;
using System.IO;
namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
            string fileContent = File.ReadAllText(@"C:\Users\DeLL\Desktop\lasata\dotnet\vedas\Test.txt");
            Console.WriteLine(fileContent);
        }
         public void LearnFileWriting()
        {
            
            File.WriteAllText("A.txt", "I am new file just created.");
            File.WriteAllText("A.html", "I am new file just created.");
        }
        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("A.html");
            var x = fileInfo.Length;
            var y = fileInfo.CreationTime;
            var z = fileInfo.DirectoryName;

            Console.WriteLine($"File Size: {x} bytes");
            Console.WriteLine($"Created: {y} ");
            Console.WriteLine($"Directory: {z} ");

        }

        internal void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");
            File.WriteAllText(@"ABC\a.lasata", "This is my own file.");
        }

        void LearnDirectoryInfo()
        {
            string folderPath = @"E:\lasata";
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            var files = directory.GetFiles();
            Console.WriteLine("File count: " + files.Length);
        }

    }
}