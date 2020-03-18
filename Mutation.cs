using GraphQLApi.Domain.Products;

public class Mutation
{
    private readonly ProductsRepository _productsRepository;

    public Mutation(ProductsRepository productsRepository)
    {
        _productsRepository = productsRepository;
    }

    public Product AddProduct() => _productsRepository.Add();
}