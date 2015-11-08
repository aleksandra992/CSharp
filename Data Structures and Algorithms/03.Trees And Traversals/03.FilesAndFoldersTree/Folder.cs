namespace _03.FilesAndFoldersTree
{
    using System.Collections.Generic;

    public class Folder
    {
        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
            this.Info = new DirectoryInformation();
        }

        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> ChildFolders { get; set; }

        public DirectoryInformation Info { get; set; }

        public ulong GetFilesSize
        {
            get
            {
                ulong result = 0;
                this.Files.ForEach(x => result += (ulong)x.Size);
                return result;
            }
        }
    }
}
