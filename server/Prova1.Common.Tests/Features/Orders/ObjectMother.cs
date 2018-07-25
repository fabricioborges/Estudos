using Prova1.Domain.Orders;
using Prova1.Domain.Products;
using System;

namespace Prova1.Common.Tests.Features.ObjectMothers
{
    public static partial class ObjectMother
    {
        public static Order GetOrderValid()
        {
            return new Order()
            {
                Id = 2,
                Quantity = 10,
                ProductId = 2,
                Customer = "teste",
                Product = new Product() {
                    Id = 2,
                    Name = "test 3",
                    IsAvailable = false,
                    Expense = 20,
                    Expiration = DateTime.Now,
                    Manufacture = DateTime.Now.AddMonths(-1),
                    Sale = 50
                }
            };
        }

        public static Order GetOrder(Product product)
        {
            return new Order()
            {
                Id = 2,
                Quantity = 10,
                Customer= "teste",
                Product = product
            };
        }

        public static Order GetOrderValidToRegister()
        {
            return new Order()
            {
                Quantity = 20,
                ProductId = 2,
                Customer = "teste2",
                Product = new Product()
                {
                    Id = 2,
                    Name = "test",
                    IsAvailable = false,
                    Expense = 20,
                    Expiration = DateTime.Now,
                    Manufacture = DateTime.Now.AddMonths(-1),
                    Sale = 50
                }
            };
        }

        public static Order GetOrderValidToRemove()
        {
            return new Order()
            {
                Id = 1,
            };
        }

        public static Order GetOrderValidToUpdate()
        {
            return new Order()
            {
                Id = 1,
                Quantity = 30,
                ProductId = 1,
                Customer = "teste3",
                Product = new Product()
                {
                    Id = 1,
                    Name = "test",
                    IsAvailable = false,
                    Expense = 20,
                    Expiration = DateTime.Now,
                    Manufacture = DateTime.Now.AddMonths(-1),
                    Sale = 50
                }
            };
        }
    }
}
