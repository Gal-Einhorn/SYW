using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace SYW.GB
{
    public class ProductsParser
    {
        /// <summary>
        /// Deserialize /products/get's response to a list of products
        /// </summary>
        /// <param name="apiResponse">the API's response string</param>
        /// <returns>List of products</returns>
        public List<Product> Parse(string apiResponse)
        {
            var responseJason = new JavaScriptSerializer();
            var deserializedProducts = responseJason.Deserialize<PlatformResponse>(apiResponse);

            var products = deserializedProducts.Products.ToList();

            return (products);
        }
    }
}