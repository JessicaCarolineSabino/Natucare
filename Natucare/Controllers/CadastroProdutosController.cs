using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Natucare.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natucare.Controllers
{
    public class CadastroProdutosController : Controller
    {
        private readonly Contexto db;

        public CadastroProdutosController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: CadastroProdutoController
        public ActionResult Index()
        {
            return View(db.CADASTROPRODUTOS.ToList());
        }

        // GET: CadastroProdutoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadastroProdutoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastroProdutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CadastroProdutos collection)
        {
            try
            {
                db.CADASTROPRODUTOS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastroProdutoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.CADASTROPRODUTOS.Where(a=>a.Id == id).FirstOrDefault());
        }

        // POST: CadastroProdutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CadastroProdutos collection)
        {
            try
            {
                db.CADASTROPRODUTOS.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastroProdutoController/Delete/5
        public ActionResult Delete(int id)
        {
            db.CADASTROPRODUTOS.Remove(db.CADASTROPRODUTOS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
