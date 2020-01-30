using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectAplication.Models;

namespace ProyectAplication.Controllers
{
    public class ConstellationsController : Controller
    {
        private AstronomyContext db = new AstronomyContext();

        // GET: Constellations
        public ActionResult Index()
        {
            return View(db.Constellations.ToList());
        }

        // GET: Constellations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constellation constellation = db.Constellations.Find(id);
            if (constellation == null)
            {
                return HttpNotFound();
            }
            return View(constellation);
        }

        // GET: Constellations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Constellations/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdConstellation,Name_C,Hemisphere,Period,Name_S")] Constellation constellation)
        {
            if (ModelState.IsValid)
            {
                db.Constellations.Add(constellation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(constellation);
        }

        // GET: Constellations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constellation constellation = db.Constellations.Find(id);
            if (constellation == null)
            {
                return HttpNotFound();
            }
            return View(constellation);
        }

        // POST: Constellations/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdConstellation,Name_C,Hemisphere,Period,Name_S")] Constellation constellation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(constellation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(constellation);
        }

        // GET: Constellations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constellation constellation = db.Constellations.Find(id);
            if (constellation == null)
            {
                return HttpNotFound();
            }
            return View(constellation);
        }

        // POST: Constellations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Constellation constellation = db.Constellations.Find(id);
            db.Constellations.Remove(constellation);
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
