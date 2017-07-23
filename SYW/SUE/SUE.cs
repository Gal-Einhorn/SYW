using SYW.SUE.DataAcess;
using SYW.SUE.ReadFromFile;

namespace SYW.SUE
{
    public class SUE
    {
        public FileLocater FileLocater = new FileLocater();
        public ProductsFromFileParser ProductsFromFileParser = new ProductsFromFileParser();
        public ProductMapper ProductMapper = new ProductMapper();
        public SessionFactoryInitializer SessionFactoryInitializer = new SessionFactoryInitializer();

        public void Run()
        {
            var products = ProductsFromFileParser.Parse();
        }
    }
}