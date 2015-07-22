using System;

namespace CohesionAndCoupling
{
    public class File
    {
        public File(string fileName)
        {
            this.FileName = fileName;
        }

        public string FileName { get; set; }

        public string GetFileExtension()
        {
            int indexOfLastDot = this.FileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = this.FileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public string GetFileNameWithoutExtension()
        {
            int indexOfLastDot = this.FileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return this.FileName;
            }

            string extension = this.FileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
