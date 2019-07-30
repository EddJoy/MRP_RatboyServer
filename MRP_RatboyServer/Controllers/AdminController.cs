using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MRP_RatboyServer.Models;

namespace MRP_RatboyServer.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if(!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                BD_ArmadoPcEntities1 db = new BD_ArmadoPcEntities1();
                var user = db.Usuarios.FirstOrDefault(e => e.correo == email && e.password == password);
                // si usuario es diferente de null
                if(user != null)
                {
                    // encontramos un usuario con los datos
                    FormsAuthentication.SetAuthCookie(user.correo, true);
                    return RedirectToAction("Index", "Profile");
                } else
                {
                    return RedirectToAction("Index", new { message = "No enontramos tus datos"  });
                }
            } else
            {
                return RedirectToAction("Index", new { message = "Llena los campos para poder iniciar sesión" });
            }
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}