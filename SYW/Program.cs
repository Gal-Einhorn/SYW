using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYW.GB;

namespace SYW
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsFromPlatformFetcher = new ProductsFromPlatformFetcher();
            productsFromPlatformFetcher.Run();
        }
    }
}
