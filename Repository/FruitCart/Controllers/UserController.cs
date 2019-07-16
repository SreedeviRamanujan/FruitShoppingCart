using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FruitCart.Models;

namespace FruitCart.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()

        {
            return View();
        }
        // GET: Submit
        [HttpPost]
        public ActionResult Index(UserDetail obj)
        {
            if (ModelState.IsValid)
            {
                List<Item> cart = new List<Item>();
                CartItem cartItem = new CartItem();
                List<CartItem> cartItemList = new List<CartItem>();
                cart = (List<Item>)Session["cart"];
              

                DataModel userDataDB = new DataModel(); 
                       
                userDataDB.UserDetails.Add(obj);
                userDataDB.SaveChanges();
                CartDetail cartDetail = new CartDetail();
                cartDetail.UserId = obj.UserId;
                userDataDB.CartDetails.Add(cartDetail);
                userDataDB.SaveChanges();
                cartItem.CartId = userDataDB.CartDetails.ToList().Find(UserDetail => UserDetail.UserId.Equals(obj.UserId)).CardId;
                Session["CartId"] = cartItem.CartId;
                foreach (var item in cart)
                {
                    cartItem.ProductId = item.Product.Id;
                    cartItem.Quantity = item.Quantity;
                    
                    userDataDB.CartItems.Add(cartItem);
                    userDataDB.SaveChanges();
                }                       


               

            }
            return View(obj);
        }
    }
}