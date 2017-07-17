using System;
using System.Runtime.InteropServices;

namespace SYW.GB
{
    public class QueryFetcher
    {
        public string query { get; set; }
        public string GetQuery()
        {
            Console.WriteLine("What would you like to search?");
            return (Console.ReadLine());
        }
    }
}