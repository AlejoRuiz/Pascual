using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pasucall.Models;

namespace Pasucall.Controllers
{
    public class EstudianteController : Controller
    {
        private dbLibreriaEntities2 db = new dbLibreriaEntities2();

        // GET: Estudiante
        public ActionResult Index()
        {
            return View(db.tbl_Estudiante.ToList());
        }

        // GET: Estudiante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Estudiante tbl_Estudiante = db.tbl_Estudiante.Find(id);
            if (tbl_Estudiante == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Estudiante);
        }

        // GET: Estudiante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudiante/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "documento,nombre_completo,programa")] tbl_Estudiante tbl_Estudiante)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Estudiante.Add(tbl_Estudiante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Estudiante);
        }

        // GET: Estudiante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Estudiante tbl_Estudiante = db.tbl_Estudiante.Find(id);
            if (tbl_Estudiante == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Estudiante);
        }

        // POST: Estudiante/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "documento,nombre_completo,programa")] tbl_Estudiante tbl_Estudiante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Estudiante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Estudiante);
        }

        // GET: Estudiante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Estudiante tbl_Estudiante = db.tbl_Estudiante.Find(id);
            if (tbl_Estudiante == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Estudiante);
        }

        // POST: Estudiante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Estudiante tbl_Estudiante = db.tbl_Estudiante.Find(id);
            db.tbl_Estudiante.Remove(tbl_Estudiante);
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
