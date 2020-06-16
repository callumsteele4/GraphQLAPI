using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLApi.Domain.Products
{
    public class ProductsRepository
    {
        private readonly PriceRepository _priceRepository;

        private readonly List<Product> _products = new List<Product>
        {
            new Product(), new Product()
        };

        public ProductsRepository(PriceRepository priceRepository)
        {
            _priceRepository = priceRepository;
        }

        public Product Add()
        {
            var product = new Product();
            _products.Add(product);
            return GetById(product.Id);
        }

        public Product GetById(Guid id)
        {
            var product = _products.SingleOrDefault(p => p.Id == id);
            if (product == null) return null;
            product.Price = _priceRepository.GetPriceForProduct(product.Id);
            return product;
        }

        public IEnumerable<Product> Get()
        {
            var products = _products;
            foreach (var product in products)
            {
                product.Price = _priceRepository.GetPriceForProduct(product.Id);
            }

            return products;
        }
    }
}