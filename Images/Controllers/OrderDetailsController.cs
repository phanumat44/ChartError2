using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Images.Models;
using System.Data.Entity;
using Newtonsoft.Json;
using System.Data;
using System.Text;

namespace Images.Controllers
{
    public class OrderDetailsController : Controller
    {
        private Entities1 db = new Entities1();
        // GET: OrderDetails
        public ActionResult Index()
        {
            var orderDetails = db.order_details.Include(o => o.Picture);
            return View(orderDetails.ToList());
        }
        public ViewResult ViewOrderDetails()
        {
            IEnumerable<OrderDetailsViewModel> model = null;
            model = (from prod in db.Pictures
                     join o in db.order_details on prod.Pic_ID equals o.Pic_ID
                     select new OrderDetailsViewModel
                     {
                         Creator = prod.user_email,
                         Name = prod.Name,
                         Price = (decimal)prod.Price,
                         Amount = (int)o.amount,
                         Total = (decimal)o.sub_total
                     });
            return View(model);
        }
    }
}