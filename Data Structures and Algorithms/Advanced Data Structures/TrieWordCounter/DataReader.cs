namespace TrieWordCounter
{
    using System.IO;

    public class DataReader
    {
        static int loopCount = 1;
        private TrieNode root;
        private string path;

        public DataReader(string path, ref TrieNode root)
        {
            this.root = root;
            this.path = path;
        }

        public void BuildTrie()
        {
            for (int i = 0; i < loopCount; i++) // fake large data set buy parsing smaller file multiple times
            {
                using (FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sreader = new StreamReader(fstream))
                    {
                        string line;
                        while ((line = sreader.ReadLine()) != null)
                        {
                            string[] chunks = line.Split(null);
                            foreach (string chunk in chunks)
                            {
                                root.AddWord(chunk.Trim());
                            }
                        }
                    }
                }
            }
        }
    }
}
