using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FruitCart.Models
{
    public class ProductModel
    {
        public List<Product> Products;
       
        public ProductModel()
            {
        
            DataModel dataModel = new DataModel();
            this.Products = dataModel.Products.ToList();
            }

       
    }
}