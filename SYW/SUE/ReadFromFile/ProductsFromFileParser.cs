using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace SYW.SUE.ReadFromFile
{
    public class ProductsFromFileParser
    {
        public FileLocater FileLocater { get; set; }

        public List<Product> Parse(FileLocater fileLocater)
        {
            FileLocater = fileLocater;
            var Folder = @"C:\temp\";
            var FileName = FileLocater.Locate(Folder);
            //var Products = new List<Product>();
            using (TextReader fileReader = File.OpenText(Folder + FileName))
            {
                var csv = new CsvReader(fileReader);
                csv.Configuration.HasHeaderRecord = true;
                var products = csv.GetRecords<Product>().ToList();
                return (products);
            }
        }

    }
}