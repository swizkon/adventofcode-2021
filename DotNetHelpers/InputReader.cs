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

        public static string GetInputRaw(string path, string folderName = null, string fileName = "input.txt")
        {
            if (path == null)
            {
                return string.Empty;
            }

            if(!string.IsNullOrWhiteSpace(folderName))
            {
                var filePath2 = Path.Combine(path, folderName, fileName);
                if (File.Exists(filePath2))
                {
                    return File.ReadAllText(filePath2);
                }
            }

            var filePath = Path.Combine(path, fileName);
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }

            var folder = new DirectoryInfo(path);
            return GetInputRaw(folder.Parent?.FullName, folderName: folderName, fileName: fileName);
        }
    }
}
