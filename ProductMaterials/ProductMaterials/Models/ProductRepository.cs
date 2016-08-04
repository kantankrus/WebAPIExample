using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductMaterials.Models
{
    public class ProductRepository : IProductRepository
    {
        private ProductMaterialEntities pd;

        public ProductRepository(ProductMaterialEntities product)
        {
            pd = product;
        }

        public IEnumerable<product> GetAllProducts()
        {
            return pd.products.Where(x=>x.Commodity == "Materials").ToList();
        }
        public ProductViewModel GetProduct(string prodNum)
        {
            var result1 = pd.products.Where(x => x.ProdNum == prodNum).FirstOrDefault();
            var result2 = pd.ProductImagePaths.Where(x => x.ImageProdNum == prodNum).FirstOrDefault() ?? new ProductImagePath();
            if (result1 != null)
            {
                ProductViewModel product = new ProductViewModel()
                {
                    ProdID = result1.ProdID,
                    ProdNum = result1.ProdNum,
                    ProdCode = result1.ProdCode,
                    ProdDesc = result1.ProdDesc,
                    ProdSize = result1.ProdSize,
                    ProdWeight = result1.ProdWeight,
                    ProdGrade = result1.ProdGrade,
                    ProdPack = result1.ProdPack,
                    Commodity = result1.Commodity,
                    ProductType = result1.ProductType,
                    ProdCompany = result1.ProdCompany,
                    CasesPerPallet = result1.CasesPerPallet,
                    Class = result1.Class,
                    MATCATEGORY = result1.MATCATEGORY,
                    Length = result1.Length,
                    Width = result1.Width,
                    Height = result1.Height,
                    ManufacturerCode = result1.ManufacturerCode,
                    SpecComments = result1.SpecComments,
                    UPCCODE = result1.UPCCODE,
                    UPCCODE2 = result1.UPCCODE2,
                    Image1Path = result2.Image1Path,
                    Image2Path = result2.Image2Path,
                    Image3Path = result2.Image3Path,
                    Image4Path = result2.Image4Path,
                    Image5Path = result2.Image5Path,
                    Image1Orig = result2.Image1Orig,
                    Image2Orig = result2.Image2Orig,
                    Image3Orig = result2.Image3Orig,
                    Image4Orig = result2.Image4Orig,
                    Image5Orig = result2.Image5Orig,
                    ImageProdNum = result2.ImageProdNum,
                    ImageCompany = result2.ImageCompany
                };
                return product;
            }
            return new ProductViewModel();
        }
    }
}