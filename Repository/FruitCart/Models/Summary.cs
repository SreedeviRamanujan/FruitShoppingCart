using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FruitCart.Models
{
    public class Summary
    {
        public List<Product> Products;  

        public CartDetail CartDetail
        {
            get;set;
        }
        public UserDetail UserDetail
        { get; set; }
        public List<CartItem> CartItems;
    }
}