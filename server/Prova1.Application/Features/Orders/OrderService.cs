using Prova1.Domain.Exceptions;
using Prova1.Domain.Features.Orders;
using Prova1.Domain.Features.Products;
using Prova1.Domain.Orders;
using System.Linq;

namespace Prova1.Application.Features.Orders
{
    /// <summary>
    /// Serviço de gerenciamento de orders
    /// </summary>
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repositoryOrder;
        private readonly IProductRepository _repositoryProduct;


        public OrderService(IOrderRepository repositoryOrder, IProductRepository repositoryProduct)
        {
            _repositoryOrder = repositoryOrder;
            _repositoryProduct = repositoryProduct;
        }

        public int Add(Order order)
        {
            // obtém a entidade do banco
            order.Product = _repositoryProduct.GetById(order.Product.Id) ?? throw new NotFoundException();
            var neworder = _repositoryOrder.Add(order);

            return neworder.Id;
        }

        public bool Remove(Order order)
        {
            return _repositoryOrder.Remove(order.Id);
        }

        public IQueryable<Order> GetAll()
        {
            return _repositoryOrder.GetAll();
        }

        public Order GetById(int id)
        {
            return _repositoryOrder.GetById(id);
        }

        public bool Update(Order order)
        {
            // Obtém a entidade Indexada pelo EF e valida
            var orderDb = _repositoryOrder.GetById(order.Id) ?? throw new NotFoundException();
            var product = _repositoryProduct.GetById(order.Product.Id) ?? throw new NotFoundException();
            // Mapeia para o objeto do banco (depois vamos ver formas melhores de fazer isso)
            orderDb.Customer = order.Customer;
            orderDb.Quantity = order.Quantity;
            orderDb.Product = product;
            orderDb.ProductId = product.Id;
            // Realiza o update no objeto do banco
            return _repositoryOrder.Update(orderDb);
        }
    }
}