using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FruitCart.Models;

namespace FruitCart.Controllers
{
    public class SummaryController : Controller
    {
        // GET: Summary
        public ActionResult Index()
        {
          DataModel dbModel = new DataModel();
            Summary summary = new Summary();
            List<Product> products = new List<Product>();
            if (Session["CartId"] != null)
            {
                int CartId = (int)Session["CartId"];
                summary.CartDetail = dbModel.CartDetails.Single(CartDetail => CartDetail.CardId.Equals(CartId));
                summary.UserDetail = dbModel.UserDetails.Single(UserDetail => UserDetail.UserId.Equals(CartId));
                summary.CartItems = dbModel.CartItems.ToList().FindAll(cartitem => cartitem.CartId.Equals(CartId));  
                foreach(var item in summary.CartItems)
                { products.Add(item.Product);
                }
                summary.Products = products;   
              
                
               // ViewBag.summary = summary;
            }
            return View(summary);
        }
    }
}