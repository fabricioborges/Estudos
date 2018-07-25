using Prova1.Domain.Orders;
using System.Linq;

namespace Prova1.Application.Features.Orders
{
    public interface IOrderService
    {
         int Add(Order order);

        bool Update(Order order);

        Order GetById(int id);

        IQueryable<Order>  GetAll();

        bool Remove(Order cmd);
    }
}
