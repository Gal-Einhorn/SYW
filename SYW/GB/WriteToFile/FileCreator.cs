using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace SYW.GB.WriteToFile
{
    public class FileCreator
    {
        public void Write(List<Product> products)
        {
            var path = @"C:\Products\products.csv";
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