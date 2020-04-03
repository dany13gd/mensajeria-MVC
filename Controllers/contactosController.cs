using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MensajeriaMVC.Models;

namespace MensajeriaMVC.Controllers
{
    public class contactosController : Controller
    {
        private Entities db = new Entities();

        // GET: contactos
        public ActionResult Index()
        {
            return View(db.contactos.ToList());
        }

        // GET: contactos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contactos contactos = db.contactos.Find(id);
            if (contactos == null)
            {
                return HttpNotFound();
            }
            return View(contactos);
        }

        // GET: contactos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: contactos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,organizacion,puesto,archivar_como_a,email,mostrar_como,pagina_web,direccion_im,tel_trabajo,tel_particular,fax_trabajo,tel_movil,direccion_trabajo,direccion_correspondencia,notas,imagen")] contactos contactos)
        {
            if (ModelState.IsValid)
            {
                db.contactos.Add(contactos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactos);
        }

        // GET: contactos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contactos contactos = db.contactos.Find(id);
            if (contactos == null)
            {
                return HttpNotFound();
            }
            return View(contactos);
        }

        // POST: contactos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,organizacion,puesto,archivar_como_a,email,mostrar_como,pagina_web,direccion_im,tel_trabajo,tel_particular,fax_trabajo,tel_movil,direccion_trabajo,direccion_correspondencia,notas,imagen")] contactos contactos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactos);
        }

        // GET: contactos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contactos contactos = db.contactos.Find(id);
            if (contactos == null)
            {
                return HttpNotFound();
            }
            return View(contactos);
        }

        // POST: contactos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            contactos contactos = db.contactos.Find(id);
            db.contactos.Remove(contactos);
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
        public ActionResult MainView()
        {
            return View();
        }


        public ActionResult CreateEditFormView()
        {
            return View();
        }


        public ActionResult ContactDetailView()
        {
            return View();
        }


        public ActionResult ListView()
        {

            return View();
        }
    }
}
