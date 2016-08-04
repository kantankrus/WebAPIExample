using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductMaterials.Models
{
    public class ProductViewModel
    {
        public int ProdID { get; set; }
        public string ProdNum { get; set; }
        public string ProdCode { get; set; }
        public string ProdDesc { get; set; }
        public Nullable<short> ProdSize { get; set; }
        public Nullable<int> ProdWeight { get; set; }
        public string ProdGrade { get; set; }
        public string ProdPack { get; set; }
        public string Commodity { get; set; }
        public string ProductType { get; set; }
        public byte ProdCompany { get; set; }
        public Nullable<short> CasesPerPallet { get; set; }
        public string Class { get; set; }
        public string MATCATEGORY { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Height { get; set; }
        public string ManufacturerCode { get; set; }
        public string SpecComments { get; set; }
        public string UPCCODE { get; set; }
        public string UPCCODE2 { get; set; }
        public string Image1Path { get; set; }
        public string Image2Path { get; set; }
        public string Image3Path { get; set; }
        public string Image4Path { get; set; }
        public string Image5Path { get; set; }
        public string Image1Orig { get; set; }
        public string Image2Orig { get; set; }
        public string Image3Orig { get; set; }
        public string Image4Orig { get; set; }
        public string Image5Orig { get; set; }
        public string ImageProdNum { get; set; }
        public string ImageCompany { get; set; }
    }
}