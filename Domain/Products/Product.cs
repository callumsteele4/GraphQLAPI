﻿using System;
using HotChocolate;

namespace GraphQLApi.Domain.Products
{
    public class Product
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public int Price { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }
    }
}