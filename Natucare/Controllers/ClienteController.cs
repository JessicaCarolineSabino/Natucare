using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Natucare.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natucare.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Contexto db;

        public ClienteController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: ClienteController
        public ActionResult Index()
        {
            return View(db.CLIENTES.ToList());
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente collection)
        {
            try
            {
                db.CLIENTES.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View( db.CLIENTES.Where(a=> a.Id == id ).FirstOrDefault() );
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Cliente collection)
        {
            try
            {
                db.CLIENTES.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            db.CLIENTES.Remove(db.CLIENTES.Where(a=>a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
