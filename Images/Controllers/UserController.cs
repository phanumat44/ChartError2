using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Images.Controllers
{
    public class UserController : Controller
    {
        private Entities1 db = new Entities1();
        // GET: User
        public ActionResult Index()
        {
            return View(db.UserCollections.ToList().Where(user => user.user_email == User.Identity.Name));
        }
        public ActionResult AddToMyLib(int idx ,decimal? price,string url,string type,string name,string size,string desc)
        {
            if (idx == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Picture picture = db.Pictures.Find(idx);
            if (picture == null)
            {
                return HttpNotFound();
            }

            UserCollection user = new UserCollection();
            
            user.user_email = User.Identity.Name;
            user.Id_userimage = idx;
            user.Price = price;
            user.url = url;
            user.Type = type;
            user.Name = name;
            user.Size = size;
            user.Desc = desc;

            db.UserCollections.Add(user);
            db.SaveChanges();


            return RedirectToAction("Index");
            //return View(picture);
        }
    }
}