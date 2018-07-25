using Prova1.Domain;
using Prova1.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1.Common.Tests.Features.ObjectMothers
{
    public static partial class ObjectMother
    {
        public static Product GetProductValid()
        {
            return new Product()
            {
                Id = 1,
                Name = "test",
                IsAvailable = false,
                Expense = 20,
                Expiration = DateTime.Now,
                Manufacture = DateTime.Now.AddMonths(-1),
                Sale = 50
            };
        }

        public static Product GetProductValidToRegister()
        {
            return new Product()
            {
                Name = "test",
                IsAvailable = false,
                Expense = 20,
                Expiration = DateTime.Now,
                Manufacture = DateTime.Now.AddMonths(-1),
                Sale = 50
            };
        }

        public static Product GetProductValidToRemove()
        {
            return new Product()
            {
                Id = 1,
            };
        }

        public static Product GetProductValidToUpdate()
        {
            return new Product()
            {
                Id = 1,
                Name = "test",
                IsAvailable = false,
                Expense = 20,
                Expiration = DateTime.Now,
                Manufacture = DateTime.Now.AddMonths(-1),
                Sale = 50
            };
        }
    }
}
