using System;

namespace GraphQLApi.Domain.Products
{
    public class StockRepository
    {
        public bool CheckProductIsInStock(Guid id)
        {
            return true;
        }
    }
}