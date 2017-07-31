using FluentNHibernate.Mapping;

namespace SYW.SUE.DataBase
{
    public class ProductMapper : ClassMap<Product>
    {
        public ProductMapper()
        {
            Id(product => product.Id);
            Map(product => product.Name);
            Map(product => product.Description);
            Map(product => product.ImageUrl);
            Map(product => product.Price);
        }
    }
}