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
        //Find all products 
        public List<Product> findAll()
        { return this.Products; }
        //Find a specific Product
        public Product find(int Id)
        { return this.Products.Single(p => p.Id.Equals(Id)); }

       
    }
}
