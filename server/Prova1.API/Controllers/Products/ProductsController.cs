using Prova1.API.Controllers.Common;
using Prova1.Application.Features.Products;
using Prova1.Domain.Products;
using Prova1.Infra.ORM.Contexts;
using Prova1.Infra.ORM.Features.Products;
using System.Web.Http;

namespace Prova1.API.Controllers.Products
{
    /// <summary>
    /// Controlador de Products
    /// 
    /// Essa classe é responsável por prover os dados relacionados a entidade Product.
    /// </summary>
    [RoutePrefix("api/products")]
    public class ProductsController : ApiControllerBase
    {
        public IProductService _productService;
        
        public ProductsController() : base()
        {
            var context = new Prova1DbContext();
            var repository = new ProductRepository(context);
            _productService = new ProductService(repository);
        }

        #region HttpGet
        /// <summary>
        /// Interface para obter uma lista geral de products
        /// </summary>
        /// <returns>Retorna uma lista de products</returns>
        [HttpGet]
        public IHttpActionResult Get()
        {
            var query = _productService.GetAll();

            return HandleQueryable<Product>(query);
        }

        /// <summary>
        /// Interface para obter uma product específico pelo id
        /// </summary>
        /// <param name="id">É o id da product para realizar a pesquisa. Provém diretamente da url pela configuração do Route</param>
        /// <returns>Retorna o product com id correspondente ao paramêtro productId</returns>
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            return HandleCallback(() => _productService.GetById(id));
        }
        #endregion HttpGet

        #region HttpPost
        /// <summary>
        /// Interface para cadastro de products
        /// </summary>
        /// <param name="product">É a product que será cadastrado no banco de dados. Provém do corpo da requisição (body)</param>
        /// <returns>Retorna um objeto com os erros acontecidos na operação. Em caso de sucesso, não há propriedades. </returns>
        [HttpPost]
        public IHttpActionResult Post(Product product)
        {
            return HandleCallback(() => _productService.Add(product));
        }

        #endregion HttpPost

        #region HttpPut
        /// <summary>
        /// Interface para editar uma product
        /// </summary>
        /// <param name="product">É o product que será atualizada no banco de dados. Provém do corpo da requisição (body)</param>
        /// <returns>Retorna um objeto com os erros acontecidos na operação. Em caso de sucesso, não há propriedades. </returns>
        [HttpPut]
        public IHttpActionResult Update(Product product)
        {
            return HandleCallback(() => _productService.Update(product));
        }

        #endregion HttpPut

        #region HttpDelete
        /// <summary>
        /// Interface para remover um product
        /// </summary>
        /// <param name="product">É o product que será removido no banco de dados. Provém do corpo da requisição (body)</param>
        /// <returns>Retorna um objeto com os erros acontecidos na operação. Em caso de sucesso, não há propriedades. </returns>
        [HttpDelete]
        public IHttpActionResult Delete(Product product)
        {
            return HandleCallback(() => _productService.Remove(product));
        }

        #endregion HttpDelete
    }
}