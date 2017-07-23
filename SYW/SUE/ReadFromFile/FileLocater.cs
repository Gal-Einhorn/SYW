using System.IO;
using System.Linq;

namespace SYW.SUE.ReadFromFile
{
    public class FileLocater
    {
        public string Locate(string folder)
        {
            var Folder = new DirectoryInfo(folder);
            var fileName = Folder.GetFiles().OrderByDescending(file => file.LastWriteTime).First();
            return (fileName.Name);
        }
    }
}