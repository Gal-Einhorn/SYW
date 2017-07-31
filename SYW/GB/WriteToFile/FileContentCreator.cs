using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace SYW.GB.WriteToFile
{
    public class FileContentCreator
    {
        public FileCreator FileCreator { get; set; } 

        public void Write(FileCreator fileCreator, List<Product> products)
        {
            FileCreator = fileCreator;
            var path = FileCreator.Create();
            using (var sw = new StreamWriter(path))
            {
                var writer = new CsvWriter(sw);
                writer.WriteHeader<Product>();
                writer.WriteRecords(products);
               
            }
        }
    }
}