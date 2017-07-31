using SYW.SUE.DataBase;
using SYW.SUE.ReadFromFile;

namespace SYW.SUE
{
    public class SUE
    {
        public FileLocater FileLocater { get; set; }
        public ProductsFromFileParser ProductsFromFileParser { get; set; }
        public ProductMapper ProductMapper { get; set; }
        public SessionFactoryInitializer SessionFactoryInitializer { get; set; }

        public void Run(FileLocater fileLocater, ProductsFromFileParser productsFromFileParser, ProductMapper productMapper, SessionFactoryInitializer sessionFactoryInitializer)
        {
            FileLocater = fileLocater;
            ProductsFromFileParser = productsFromFileParser;
            ProductMapper = productMapper;
            SessionFactoryInitializer = sessionFactoryInitializer;

            var products = ProductsFromFileParser.Parse(FileLocater);
        }
    }
}