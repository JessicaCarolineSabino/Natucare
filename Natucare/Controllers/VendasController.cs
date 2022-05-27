using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Natucare.Entidades;
using Natucare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natucare.Controllers
{
    public class VendasController : Controller
    {
        private readonly Contexto db;

        public VendasController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: VendasController
        public ActionResult Index()
        {
            return View(db.VENDAS.Include(a => a.cadastroCliente).Include(a => a.Produto).ToList());
        }

        // GET: VendasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VendasController/Create
        public ActionResult Create()
        {
            VendasModel model = new VendasModel();
            model.ListaTodosClientes = db.CADASTROCLIENTE.ToList();
            model.ListaTodosProdutos = db.CADASTROPRODUTOS.ToList();
            return View(model);
        }

        // POST: VendasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VendasModel dados)
        {
            try
            {
                dados.Produto = db.CADASTROPRODUTOS.Find(dados.ProdutoId);

                Vendas venda = new Vendas();
                venda.Ciclo = dados.Ciclo;
                venda.CadastroClienteId = dados.CadastroClienteId;
                venda.ProdutoId = dados.ProdutoId;
                venda.Quantidade = dados.Quantidade;
                venda.ValorTotal = dados.Quantidade * dados.Produto.PrecoVenda;
                venda.precoProduto = dados.Produto.PrecoVenda;
                db.VENDAS.Add(venda);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VendasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VendasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Vendas collection)
        {
            try
            {
                db.VENDAS.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VendasController/Delete/5
        public ActionResult Delete(int id)
        {
            db.CADASTROPRODUTOS.Remove(db.CADASTROPRODUTOS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
