using SYW.GB.WriteToFile;

namespace SYW.GB
{
    public class GreenBox
    {
        public QueryFetcher QueryFetcher = new QueryFetcher();
        public CallsInvoker CallsInvoker = new CallsInvoker();
        public RequestSyntaxCreator RequestSyntaxCreator = new RequestSyntaxCreator();
        public ProductsParser ProductsParser = new ProductsParser();
        public FileContentCreator FileContentCreator = new FileContentCreator();

        public void Run()
        {

            var query = QueryFetcher.GetQuery();
            var uri = RequestSyntaxCreator.BuildUriFromQuery(query);
            var response = CallsInvoker.Invoke(uri);

            var products = ProductsParser.Parse(response);
            
            FileContentCreator.Write(products);

        }
    }
}