using System.Web.Http;
using System.Net.Http;
using ProductMaterials.Models;
using System.Web.Http.Cors;

namespace ProductMaterials.Controllers
{
    public class ValuesController : ApiController
    {
        private IProductRepository productRepository;
        public ValuesController()
        {
            productRepository = new ProductRepository(new ProductMaterialEntities());
        }

        [Route("Product/GetProduct/{prodNum}")]
        [HttpPost]
        // Access via: http://xxxxxxxxx/Product/GetProduct/02130
        public IHttpActionResult GetProduct(string prodNum)
        {
            var productInfo = productRepository.GetProduct(prodNum);                                                                                                                                          

            if (productInfo.ProdID <= 0)
            {
                return NotFound();
            }
            return Ok(productInfo);
        }   
    }
}
