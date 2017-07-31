using SYW.GB.WriteToFile;

namespace SYW.GB
{
    public class GreenBox
    {
        public QueryFetcher QueryFetcher { get; set; }
        public CallsInvoker CallsInvoker { get; set; } 
        public RequestSyntaxCreator RequestSyntaxCreator { get; set; }
        public ProductsParser ProductsParser { get; set; } 
        public FileContentCreator FileContentCreator { get; set; }
        public FileCreator FileCreator { get; set; }

        public void Run(QueryFetcher queryFetcher, CallsInvoker callsInvoker, RequestSyntaxCreator requestSyntaxCreator, ProductsParser productsParser, FileContentCreator fileContentCreato, FileCreator fileCreator)
        {
            QueryFetcher = queryFetcher;
            CallsInvoker = callsInvoker;
            RequestSyntaxCreator = requestSyntaxCreator;
            ProductsParser = productsParser;
            FileContentCreator = fileContentCreato;
            FileCreator = fileCreator;

            var query = QueryFetcher.GetQuery();
            var uri = RequestSyntaxCreator.BuildUriFromQuery(query);
            var response = CallsInvoker.Invoke(uri);

            var products = ProductsParser.Parse(response);
            
            FileContentCreator.Write(FileCreator, products);

        }
    }
}