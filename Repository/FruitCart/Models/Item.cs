﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FruitCart.Models
{
    public class Item
    {
        public Product Product
        { get; set; }
        public int Quantity
        { get; set; }
        public double WeightOfCart
        { get; set; }
       
    }
} 