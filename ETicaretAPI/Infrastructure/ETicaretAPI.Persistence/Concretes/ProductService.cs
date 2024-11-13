using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()  //nesnenin türünü belirtmeden nesne oluşturabilmeyi sağlar
            {
                new() { Id = Guid.NewGuid(), Name = "Product 1", price = 100, Stock = 10 }, //Guid türünde bir nesne oluşturmak için
                new() { Id = Guid.NewGuid(), Name = "Product 2", price = 200, Stock = 10 },
                new() { Id = Guid.NewGuid(), Name = "Product 3", price = 300, Stock = 10 },
                new() { Id = Guid.NewGuid(), Name = "Product 4", price = 400, Stock = 10 },
                new() { Id = Guid.NewGuid(), Name = "Product 5", price = 500, Stock = 10 }
            };
    }
}
