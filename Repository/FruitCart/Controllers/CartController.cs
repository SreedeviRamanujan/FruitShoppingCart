using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FruitCart.Models;

namespace FruitCart.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View(); 
        }
        public ActionResult Buy( int Id)
        {
            ProductModel productModel = new ProductModel();
            if(Session["cart"]==null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = productModel.find(Id), Quantity = 1 });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExist(Id);
                if(index!=-1)
                {
                    cart[index].Quantity++;
                    cart[index].WeightOfCart = Convert.ToDouble(cart.Sum(item => (item.Product.Weight) * (item.Quantity)));
                }
                else
                {
                    cart.Add(new Item { Product = productModel.find(Id), Quantity = 1 });
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int Id)
        {
            List<Item> cart = new List<Item>();
            int index = isExist(Id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }

        private int isExist(int Id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(Id))
                {
                    return i;
                }
            }
            return -1;
            }
        }
    }
