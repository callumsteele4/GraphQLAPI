using GraphQLApi.Domain.Products;
using HotChocolate;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ProductsRepository>();
            services.AddSingleton<PriceRepository>();
            services.AddSingleton<StockRepository>();

            services.AddGraphQL(sp => SchemaBuilder.New()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .AddServices(sp)
                .Create());
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseGraphQL();
            app.UsePlayground();
        }
    }
}
