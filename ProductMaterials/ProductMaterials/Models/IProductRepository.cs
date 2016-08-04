using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductMaterials.Models
{
    public interface IProductRepository
    {
        ProductViewModel GetProduct(string ProdNum);
        IEnumerable<product> GetAllProducts();
    }
}