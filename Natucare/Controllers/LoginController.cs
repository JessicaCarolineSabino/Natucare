using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Natucare.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Natucare.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto db;

        public LoginController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: LoginController
        public ActionResult Entrar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Entrar(string login, string senha)
        {
            /* Usuarios usuarioLogado = db.USUARIOS.Where(a => a.Login == login && a.Senha == senha).FirstOrDefault();

            if (usuarioLogado == null)
            {
                TempData["erro"] = "Usuário e senha inválidos";
                return View();
            }
            */
            if (login == "admin" && senha == "123")
            {


                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, "Admin"));
                claims.Add(new Claim(ClaimTypes.Sid, "1"));

                var userIdentity = new ClaimsIdentity(claims, "Acesso");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync("CookieAuthentication", principal, new AuthenticationProperties());


                return Redirect("/CadastroProdutos");
            }
            else
            {
                TempData["erro"] = "Usuário e senha inválidos";
                return View();
            }
        }
        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync("CookieAuthentication");
            return Redirect("Login/Entrar/");
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
