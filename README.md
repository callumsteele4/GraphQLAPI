# GraphQL API

An example repository for setting up GraphQL in ASP.NET Core with HotChocolate.

## Schema

The schema provided by this GraphQL API.

```
schema {
  query: Query
  mutation: Mutation
}

type Mutation {
  addProduct: Product
}

type Product {
  createdAt: DateTime!
  id: Uuid!
}

type Query {
  product(id: Uuid!): Product
  products: [Product]
}

"The `DateTime` scalar represents an ISO-8601 compliant date time type."
scalar DateTime

scalar Uuid
```

## Links

This repository is intended to act as a reference for a [series of blog posts](https://blog.callumsteele.com/tag/graphql) that cover [GraphQL](https://graphql.org), [HotChocolate](https://hotchocolate.io), and [ASP.NET Core 2.1](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.1).

1. [GraphQL in ASP.NET Core](https://blog.callumsteele.com/graphql-in-asp-net-core)