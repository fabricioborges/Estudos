using Prova1.API.Controllers.Common;
using Prova1.Application.Features.Orders;
using Prova1.Domain.Orders;
using Prova1.Infra.ORM.Contexts;
using Prova1.Infra.ORM.Features.Orders;
using Prova1.Infra.ORM.Features.Products;
using System.Web.Http;

namespace Prova1.API.Controllers.Orders
{
    /// <summary>
    /// Controlador de Orders
    /// 
    /// Essa classe é responsável por prover os dados relacionados a entidade Order.
    /// 
    /// </summary>
    [RoutePrefix("api/orders")]
    public class OrdersController : ApiControllerBase
    {
        public IOrderService _ordersService;

        public OrdersController() : base()
        {
            var context = new Prova1DbContext();
            var repository = new OrderRepository(context);
            var repositoryProduct = new ProductRepository(context);
            _ordersService = new OrderService(repository, repositoryProduct);
        }

        #region HttpGet

        /// <summary>
        /// Interface para obter uma lista geral de orders
        /// </summary>
        /// <returns>Retorna uma lista de orders</returns>
        [HttpGet]
        public IHttpActionResult Get()
        {
            var query = _ordersService.GetAll();
            return HandleQueryable<Order>(query);
        }

        /// <summary>
        /// Interface para obter uma order específico pelo id
        /// </summary>
        /// <param name="id">É o id da order para realizar a pesquisa. Provém diretamente da url pela configuração do Route</param>
        /// <returns>Retorna o order com id correspondente ao paramêtro orderId</returns>
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            return HandleCallback(() => _ordersService.GetById(id));
        }
        #endregion HttpGet

        #region HttpPost
        /// <summary>
        /// Interface para cadastro de orders
        /// </summary>
        /// <param name="order">É a order que será cadastrado no banco de dados. Provém do corpo da requisição (body)</param>
        /// <returns>Retorna um objeto com os erros acontecidos na operação. Em caso de sucesso, não há propriedades. </returns>
        [HttpPost]
        public IHttpActionResult Post(Order order)
        {
            return HandleCallback(() => _ordersService.Add(order));
        }

        #endregion HttpPost

        #region HttpPut
        /// <summary>
        /// Interface para editar uma order
        /// </summary>
        /// <param name="order">É o order que será atualizada no banco de dados. Provém do corpo da requisição (body)</param>
        /// <returns>Retorna um objeto com os erros acontecidos na operação. Em caso de sucesso, não há propriedades. </returns>
        [HttpPut]
        public IHttpActionResult Update(Order order)
        {
            return HandleCallback(() =>_ordersService.Update(order));
        }

        #endregion HttpPut

        #region HttpDelete
        /// <summary>
        /// Interface para remover uma order
        /// </summary>
        /// <param name="order">É a order que será removido no banco de dados. Provém do corpo da requisição (body)</param>
        /// <returns>Retorna um objeto com os erros acontecidos na operação. Em caso de sucesso, não há propriedades. </returns>
        [HttpDelete]
        public IHttpActionResult Delete(Order order)
        {
            return HandleCallback(() => _ordersService.Remove(order));
        }

        #endregion HttpDelete
    }
}