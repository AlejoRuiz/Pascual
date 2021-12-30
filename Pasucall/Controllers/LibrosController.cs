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
    public class LibrosController : Controller
    {
        private dbLibreriaEntities2 db = new dbLibreriaEntities2();

        // GET: Libros
        public ActionResult Index()
        {
            return View(db.tbl_Libro.ToList());
        }

        // GET: Libros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Libro tbl_Libro = db.tbl_Libro.Find(id);
            if (tbl_Libro == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Libro);
        }

        // GET: Libros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codigo,nombre_autor,nombre_libro,fecha_nacimiento,fecha_publicacion")] tbl_Libro tbl_Libro)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Libro.Add(tbl_Libro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Libro);
        }

        // GET: Libros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Libro tbl_Libro = db.tbl_Libro.Find(id);
            if (tbl_Libro == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Libro);
        }

        // POST: Libros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codigo,nombre_autor,nombre_libro,fecha_nacimiento,fecha_publicacion")] tbl_Libro tbl_Libro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Libro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Libro);
        }

        // GET: Libros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Libro tbl_Libro = db.tbl_Libro.Find(id);
            if (tbl_Libro == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Libro);
        }

        // POST: Libros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Libro tbl_Libro = db.tbl_Libro.Find(id);
            db.tbl_Libro.Remove(tbl_Libro);
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
