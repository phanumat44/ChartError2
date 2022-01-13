using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Images.Controllers
{
    public class APIController : Controller
    {
        // GET: API
        public JsonResult OrderbyModel()
        {
            var orderModel = new OrderDetailsDataModel();
            var data = orderModel.GetOrderbyModel();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult OrderbyModelPic()
        {
            var orderModel = new OrderDetailsDataModel();
            var data = orderModel.GetOrderbyModelPic();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}