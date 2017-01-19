using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Path.Combine((new DirectoryInfo(Directory.GetCurrentDirectory())).FullName, "data.txt");
            string content = ReadFile(file);
            string[] split = content.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(split[split.Length-1]);
            Console.ReadLine();
        }
        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
