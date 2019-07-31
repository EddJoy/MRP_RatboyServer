using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MRP_RatboyServer.Models;

namespace MRP_RatboyServer.Controllers
{
    public class AccesoriosController : Controller
    {
        private BD_ArmadoPcEntities4 db = new BD_ArmadoPcEntities4();

        // GET: Accesorios
        public ActionResult Index()
        {
            return View(db.Accesorio.ToList());
        }

        // GET: Accesorios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accesorio accesorio = db.Accesorio.Find(id);
            if (accesorio == null)
            {
                return HttpNotFound();
            }
            return View(accesorio);
        }

        // GET: Accesorios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accesorios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAccesorio,categoria,nombre,marca,modelo,precioProveedor,precioVenta,estatus,descripcion")] Accesorio accesorio)
        {
            if (ModelState.IsValid)
            {
                db.Accesorio.Add(accesorio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accesorio);
        }

        // GET: Accesorios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accesorio accesorio = db.Accesorio.Find(id);
            if (accesorio == null)
            {
                return HttpNotFound();
            }
            return View(accesorio);
        }

        // POST: Accesorios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAccesorio,categoria,nombre,marca,modelo,precioProveedor,precioVenta,estatus,descripcion")] Accesorio accesorio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accesorio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accesorio);
        }

        // GET: Accesorios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accesorio accesorio = db.Accesorio.Find(id);
            if (accesorio == null)
            {
                return HttpNotFound();
            }
            return View(accesorio);
        }

        // POST: Accesorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accesorio accesorio = db.Accesorio.Find(id);
            db.Accesorio.Remove(accesorio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
