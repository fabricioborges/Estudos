using System.Linq;
using Prova1.Domain.Exceptions;
using Prova1.Domain.Features.Products;
using Prova1.Domain.Products;

namespace Prova1.Application.Features.Products
{
    /// <summary>
    /// Serviço de gerenciamento de products
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repositoryProduct;

        public ProductService(IProductRepository repositoryProduct)
        {
            _repositoryProduct = repositoryProduct;
        }

        public int Add(Product product)
        {
            // Poderia ter validações ? Sim (vamos ver formas de fazer isso nas próximas unidades)
            var newproduct = _repositoryProduct.Add(product);

            return newproduct.Id;
        }

        public IQueryable<Product> GetAll()
        {
            return _repositoryProduct.GetAll();
        }

        public Product GetById(int id)
        {
            return _repositoryProduct.GetById(id);
        }

        public bool Remove(Product product)
        {
            return _repositoryProduct.Remove(product.Id);
        }

        public bool Update(Product product)
        {
            // Obtém o produto do banco
            var productDb = _repositoryProduct.GetById(product.Id);
            if (productDb == null)
                throw new NotFoundException();
            // Mapeia para o objeto do banco que está tracking pelo EF
            // Aqui talvez poderia usar o Attach, alterar o State ou whatever para indexar
            // mas acredito ser mais ideal ter o controle (explicitamente) de quais propriedades estão sendo atualizadas 
            productDb.IsAvailable = product.IsAvailable;
            productDb.Sale = product.Sale;
            productDb.Expense = product.Expense;
            productDb.Expiration = product.Expiration;
            productDb.Name = product.Name;
            productDb.Manufacture = product.Manufacture;
            // Salva alterações
            return _repositoryProduct.Update(productDb);
        }
    }
}
