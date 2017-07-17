using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace SYW.GB.WriteToFile
{
    public class FileContentCreator
    {
        public FileCreator FileCreator = new FileCreator();

        public void Write(List<Product> products)
        {
            var path = FileCreator.Create();
            using (var sw = new StreamWriter(path))
            {
                var writer = new CsvWriter(sw);
                writer.WriteHeader<Product>();
                foreach (var product in products)
                {
                    writer.WriteRecord(product);
                }
            }
        }
    }
}