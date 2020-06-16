using System;
using HotChocolate;

namespace GraphQLApi.Domain.Products
{
    public class Product
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public int GetPrice([Service] PriceRepository priceRepository)
            => priceRepository.GetPriceForProduct(Id);

        public bool GetInStock([Service] StockRepository stockRepository)
            => stockRepository.CheckProductIsInStock(Id);

        public Product()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }
    }
}