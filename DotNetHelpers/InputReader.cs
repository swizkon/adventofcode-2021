using System.Collections.Generic;
using System.IO;

namespace DotNetHelpers
{
    public class InputReader
    {
        public static string[] GetInput(string path, string fileName = "input.txt")
        {
            if (path == null)
            {
                return new List<string>().ToArray();
            }

            var filePath = Path.Combine(path, fileName);
            if (File.Exists(filePath))
            {
                //Console.WriteLine("Found " + filePath);
                return File.ReadAllLines(filePath);
            }

            var folder = new DirectoryInfo(path);
            return GetInput(folder.Parent?.FullName, fileName);
        }
    }
}
