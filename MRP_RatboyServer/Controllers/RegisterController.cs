using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MRP_RatboyServer.Models;
using System.Web.Hosting;
using System.Text;
using System.Net.Mail;
using System.Web.Security;

namespace MRP_RatboyServer.Controllers
{
    public class RegisterController : Controller
    {
        BD_ArmadoPcEntities db = new BD_ArmadoPcEntities();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        //Login para usuarios cliente
        //TODO relacionar metodo con view
        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            if (!string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password))
            {
                BD_ArmadoPcEntities db = new BD_ArmadoPcEntities();
                var user = db.UsuariosCliente.FirstOrDefault(e => e.correo == Email && e.password == Password && e.isValid == true);
                // si usuario es diferente de null
                if (user != null)
                {
                    // encontramos un usuario con los datos
                    FormsAuthentication.SetAuthCookie(user.correo, true);
                    return RedirectToAction("Index", "Cliente");
                }
                else
                {
                    return RedirectToAction("Index", new { message = "No enontramos tus datos" });
                }
            }
            else
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

        public JsonResult SaveData(UsuariosCliente model)
        {
            model.isValid = false;
            db.UsuariosCliente.Add(model);
            db.SaveChanges();
            BuildEmailTemplate(model.idUserCliente);
            return Json("Registro exitoso", JsonRequestBehavior.AllowGet);
        }
        public ActionResult Confirm(int regId)
        {
            ViewBag.regId = regId;
            return View();
        }
        public JsonResult RegisterConfirm(int regId)
        {
            UsuariosCliente Data = db.UsuariosCliente.Where(x => x.idUserCliente == regId).FirstOrDefault();
            Data.isValid = true;
            db.SaveChanges();
            var msg = "Tu correo esta verificado!";
            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        public void BuildEmailTemplate(int regID)
        {
            string body = System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/EmailTemplate/") + "Test" + ".cshtml");
            var regInfo = db.UsuariosCliente.Where(x => x.idUserCliente == regID).FirstOrDefault();
            var url = "https://localhost:44348/" + "Register/Confirm?regId=" + regID;
            body = body.Replace("@ViewBag.ConfirmationLink", url);
            body = body.ToString();
            BuildEmailTemplate("Tu cuenta fue creada exitosamente", body, regInfo.correo);
        }

        public static void BuildEmailTemplate(string subjectText, string bodyText, string sendTo)
        {
            string from, to, bcc, cc, subject, body;
            from = "desarrollo9company@gmail.com";
            to = sendTo.Trim();
            bcc = "";
            cc = "";
            subject = subjectText;
            StringBuilder sb = new StringBuilder();
            sb.Append(bodyText);
            body = sb.ToString();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(to));
            if (!string.IsNullOrEmpty(bcc))
            {
                mail.Bcc.Add(new MailAddress(bcc));
            }
            if (!string.IsNullOrEmpty(cc))
            {
                mail.CC.Add(new MailAddress(cc));
            }
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            SendEmail(mail);
        }

        private static void SendEmail(MailMessage mail)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential("desarrollo9company@gmail.com", "Desarrollo9");
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}