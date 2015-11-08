namespace FolderAndFiles
{
    using System;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            Folder folder = new Folder();

            var directories = Directory.GetDirectories(@"E:\Git hub");
            foreach (var directory in directories)
            {
                Traverse(directory,folder);
            }

        }
        private static void Traverse(string directory,Folder folder)
        {
            var files = Directory.GetFiles(directory);
            var directories = Directory.GetDirectories(directory);

            foreach (var file in files)
            {
               folder.files 
                    Array.
            }

            foreach (var dir in directories)
            {
                Traverse(dir, space + "  ");
            }
        }
    }
}
