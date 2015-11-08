namespace _02.TraverseTheDirectory
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // Please test this to directories that allowed reading.
            TraverseTheDirectory(@"C:\WINDOWS");
        }

        public static void TraverseTheDirectory(string path)
        {
            var directories = Directory.GetDirectories(path);
            List<string> filePaths = Directory.GetFiles(path).Where(x => x.EndsWith(".exe")).Select(y => Path.GetFileName(y)).ToList();
            filePaths.ForEach(x => Console.WriteLine(x));

            foreach (var k in directories)
            {
                TraverseTheDirectory(k);
            }
        }
    }
}
