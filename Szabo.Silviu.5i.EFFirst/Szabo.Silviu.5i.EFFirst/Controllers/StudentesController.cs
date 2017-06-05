using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Szabo.Silviu._5i.EFFirst.Models;

namespace Szabo.Silviu._5i.EFFirst.Controllers
{
    public class StudentesController : Controller
    {
        private EF db = new EF();

        // GET: Studentes
        public ActionResult Index()
        {
            return View(db.Studenti.ToList());
        }

        // GET: Studentes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studente studente = db.Studenti.Find(id);
            if (studente == null)
            {
                return HttpNotFound();
            }
            return View(studente);
        }

        // GET: Studentes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Studentes/Create
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Cognome")] Studente studente)
        {
            if (ModelState.IsValid)
            {
                db.Studenti.Add(studente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studente);
        }

        // GET: Studentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studente studente = db.Studenti.Find(id);
            if (studente == null)
            {
                return HttpNotFound();
            }
            return View(studente);
        }

        // POST: Studentes/Edit/5
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Cognome")] Studente studente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studente);
        }

        // GET: Studentes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studente studente = db.Studenti.Find(id);
            if (studente == null)
            {
                return HttpNotFound();
            }
            return View(studente);
        }

        // POST: Studentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Studente studente = db.Studenti.Find(id);
            db.Studenti.Remove(studente);
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
