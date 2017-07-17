using System;
using SYW.GB.WriteToFile;

namespace SYW.GB
{
    public class ProductsFromPlatformFetcher
    {
        public QueryFetcher QueryFetcher { get; set; }
        public CallsInvoker CallsInvoker { get; set; }
        public RequestSyntaxCreator RequestSyntaxCreator { get; set; }
        public ProductsParser ProductsParser { get; set; }
        public FileCreator FileCreator { get; set; }
  
        public void Run()
        {
            QueryFetcher = new QueryFetcher();
            CallsInvoker = new CallsInvoker();
            RequestSyntaxCreator = new RequestSyntaxCreator();
            ProductsParser = new ProductsParser();
            FileCreator = new FileCreator();

            var query = QueryFetcher.GetQuery();
            var uri = RequestSyntaxCreator.BuildUriFromQuery(query);
            var response = CallsInvoker.Invoke(uri);

            var products = ProductsParser.Parse(response);
            
            FileCreator.Write(products);

        }
    }
}