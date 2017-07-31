using SYW.GB;
using SYW.GB.WriteToFile;
using SYW.SUE.DataBase;
using SYW.SUE.ReadFromFile;

namespace SYW
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var queryFetcher = new QueryFetcher();
            var callsInvoker = new CallsInvoker();
            var requestSyntaxCreator = new RequestSyntaxCreator();
            var productsParser = new ProductsParser();
            var fileContentCreator = new FileContentCreator();
            var fileCreator = new FileCreator();

            var fileLocater = new FileLocater();
            var productsFromFileParser  =new ProductsFromFileParser();
            var productMapper = new ProductMapper();
            var sessionFactoryInitializer = new SessionFactoryInitializer();

            var greenBox = new GreenBox();
            var sue = new SUE.SUE();

            greenBox.Run(queryFetcher, callsInvoker, requestSyntaxCreator, productsParser, fileContentCreator, fileCreator); 
            sue.Run(fileLocater, productsFromFileParser, productMapper, sessionFactoryInitializer);
        }
    }
}
