using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Natucare.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natucare.Controllers
{
    public class CadastroClienteController : Controller
    {
        private readonly Contexto db;

        public CadastroClienteController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: CadastroClienteController
        public ActionResult Index()
        {
            return View(db.CADASTROCLIENTE.ToList());
        }

        // GET: CadastroClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadastroClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastroClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CadastroCliente collection)
        {
            try
            {
                db.CADASTROCLIENTE.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastroClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.CADASTROPRODUTOS.Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: CadastroClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CadastroCliente collection)
        {
            try
            {
                db.CADASTROCLIENTE.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastroClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            db.CADASTROCLIENTE.Remove(db.CADASTROCLIENTE.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
