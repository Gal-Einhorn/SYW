using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
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
                foreach (var product in products)
                {
                    writer.WriteRecord(product);
                }
            }
        }
    }
}