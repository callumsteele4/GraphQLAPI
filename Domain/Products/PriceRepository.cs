using System;

namespace GraphQLApi.Domain.Products
{
    public class PriceRepository
    {
        private readonly Random _randomPriceGenerator = new Random();

        public int GetPriceForProduct(Guid id)
        {
            return _randomPriceGenerator.Next(1, 1000);
        }
    }
}