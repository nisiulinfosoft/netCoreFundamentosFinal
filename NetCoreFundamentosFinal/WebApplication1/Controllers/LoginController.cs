using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreFundamentosFinal.DTO;
using NetCoreFundamentosFinal.Services;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioServices _Services;

        public LoginController(
            IUsuarioServices _services
            )
        {
            _Services = _services;
        }
        [HttpGet]
        public IActionResult Index()
        {
            Usuario u = new Usuario();
            return View(u);
        }

        [HttpPost]
        public IActionResult Index(Usuario user)
        {
            Usuario u = _Services.Autenticar(user.Login, user.Clave);
            if (u == null)
            {
                ModelState.AddModelError("*", "Credenciales invalidas");
                return View(u);
            }
            else
            {
                //grabarlo en sesion 
                HttpContext.Session.SetString("login", u.Login);
                u.Clave = "";
                string usuariotexto = JsonConvert.SerializeObject(u);
                HttpContext.Session.SetString("user", usuariotexto);
                return RedirectToAction("Index", "Home");
            }

        }

        public IActionResult CerrarSesion()
        {

            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
        }
    }
}