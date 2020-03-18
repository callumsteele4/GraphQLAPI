using System;
using System.Collections.Generic;
using GraphQLApi.Domain.Products;

public class Query
{
    private readonly ProductsRepository _productsRepository;

    public Query(ProductsRepository productsRepository)
    {
        _productsRepository = productsRepository;
    }

    public IEnumerable<Product> GetProducts() => _productsRepository.Get();

    public Product GetProduct(Guid id) => _productsRepository.GetById(id);
}