using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreFundamentosFinal.DTO;
using NetCoreFundamentosFinal.Services;
using WebApplication1.Filters;

namespace WebApplication1.Controllers
{
    [AutenticaFilter]
    public class TrabajadorController : Controller
    {
        private ITrabajadorServices _services;
        public TrabajadorController(ITrabajadorServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            return View(_services.Listar());
        }

        [HttpGet]
        public IActionResult Editar(int id = 0)
        {
            Trabajador a;

            if (id == 0) //nuevo
            {
                a = new Trabajador();
            }
            else //editar
            {
                a = _services.Recuperar(id);
            }
            return View(a);

        }

        [HttpPost]
        public IActionResult Grabar(Trabajador a)
        {
            if (a.IdTrabajador == 0)
            {
                _services.Insertar(a);
            }
            else
            {
                _services.Actualizar(a);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Eliminar(int id = 0)
        {
            _services.Eliminar(id);

            return RedirectToAction("Index");
        }
    }
}