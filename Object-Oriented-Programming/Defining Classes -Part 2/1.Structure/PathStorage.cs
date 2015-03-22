using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    public class PathStorage
    {

       public static void SavePathInFile(Path path)
       {
           IFormatter formatter = new BinaryFormatter();
           Stream stream = new FileStream("paths.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
           formatter.Serialize(stream, path);
           stream.Close();
       }
       public static Path LoadPathFromFile()
       {
           IFormatter formatter = new BinaryFormatter();
           Stream stream = new FileStream("paths.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
           Path path = (Path)formatter.Deserialize(stream);
           stream.Close();
           return path;
       }
    }
}
