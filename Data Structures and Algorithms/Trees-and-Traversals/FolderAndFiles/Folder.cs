namespace FolderAndFiles
{
    public class Folder
    {
        public string Name { get; set; }

        public File[] files { get; set; }

        public Folder[] childFolders { get; set; }
    }
}
