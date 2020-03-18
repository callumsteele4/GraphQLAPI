using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLApi.Domain.Products
{
    public class ProductsRepository
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product(), new Product()
        };

        public Product Add()
        {
            var product = new Product();
            _products.Add(product);
            return GetById(product.Id);
        }

        public Product GetById(Guid id) =>
            _products.SingleOrDefault(product => product.Id == id);

        public IEnumerable<Product> Get() => _products;
    }
}