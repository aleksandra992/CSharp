namespace _03.FilesAndFoldersTree
{
    using System;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public const string directory = @"C:\WINDOWS";

        public static void Main()
        {
            var name = directory.Split('\\').Last();

            Folder root = new Folder(name);

            BuildTreeFromRootDirectory(directory, root);

            var totalSize = CalculateTotalSizeUsingDFS(root);
            Console.WriteLine("Total size: "+totalSize+" bytes");
            Console.WriteLine("Total directories: " + root.Info.CountOfFolders);
            Console.WriteLine("Total files: " + root.Info.CountOfFiles);
        }

        public static void BuildTreeFromRootDirectory(string path, Folder rootFolder)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            rootFolder.Name = directoryInfo.Name;

            FileInfo[] files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                Console.WriteLine("------File " + file.Name);
                rootFolder.Files.Add(new File(file.Name, file.Length));
            }


            var directories = directoryInfo.GetDirectories();

            foreach (var k in directories)
            {
                Folder p = new Folder(k.Name);
                Console.WriteLine("Directory " + p.Name);
                rootFolder.ChildFolders.Add(p);
                BuildTreeFromRootDirectory(k.FullName, p);
            }
        }

        public static ulong CalculateTotalSizeUsingDFS(Folder root)
        {
            if (root.ChildFolders.Count == 0)
            {
                root.Info.CountOfFolders = 0;
                root.Info.CountOfFiles = root.Files.Count;
                return root.GetFilesSize;
            }

            ulong result = 0;
            foreach (var child in root.ChildFolders)
            {
                result += CalculateTotalSizeUsingDFS(child);
                root.Info.CountOfFiles += child.Info.CountOfFiles;
                root.Info.CountOfFolders += child.Info.CountOfFolders;
            }

            root.Info.CountOfFiles += root.Files.Count;
            root.Info.CountOfFolders += root.ChildFolders.Count;

            return result + root.GetFilesSize;
        }
    }
}
