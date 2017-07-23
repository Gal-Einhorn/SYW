using System;
using System.IO;

namespace SYW.GB.WriteToFile
{
    public class FileCreator
    {
        public string Create()
        {
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            var path = @"C:\temp\" +timestamp + ".csv" ;
            var file = File.Create(path);
            file.Close();
            return (path);
        }
    }
}