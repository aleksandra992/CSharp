namespace TraverseDirectories
{
    using System;
    using System.IO;
    using System.Linq;

    public class Stratup
    {

        public static void Main()
        {
            var directories = Directory.GetDirectories(@"C:\Windows");
            foreach (var directory in directories)
            {
                Traverse(directory, "");
            }
        }

        private static void Traverse(string directory, string space)
        {
            var files = Directory.GetFiles(directory);
            var directories = Directory.GetDirectories(directory);

            foreach (var file in files)
            {
                if (file.Contains(".exe"))
                {
                    Console.WriteLine(space + file);
                }
            }

            foreach (var dir in directories)
            {
                Traverse(dir, space + "  ");
            }
        }
    }
}
