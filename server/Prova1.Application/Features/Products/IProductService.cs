using Prova1.Domain.Products;
using System.Linq;

namespace Prova1.Application.Features.Products
{
    public interface IProductService
    {
        int Add(Product product);

        bool Update(Product product);

        Product GetById(int id);

        IQueryable<Product> GetAll();

        bool Remove(Product cmd);
    }
}
