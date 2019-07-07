using NetCoreFundamentosFinal.Contexto;
using NetCoreFundamentosFinal.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NetCoreFundamentosFinal.Services
{
    public class TrabajadorServices : ITrabajadorServices
    {
        private FundamentosContext _context;
        public TrabajadorServices(FundamentosContext context)
        {
            _context = context;
        }

        public Trabajador Actualizar(Trabajador trabajador)
        {
            _context.Trabajador.Update(trabajador);
            _context.SaveChanges();
            return trabajador;
        }

        public bool Eliminar(int id)
        {
            Trabajador a = (from x in _context.Trabajador
                            where x.IdTrabajador == id
                            select x).FirstOrDefault();

            if (a != null)
            {
                _context.Remove(a);
                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }

        }

        public Trabajador Insertar(Trabajador trabajador)
        {
            _context.Trabajador.Add(trabajador);
            _context.SaveChanges();
            return trabajador;
        }

        public List<Trabajador> Listar()
        {

            List<Trabajador> lista = (from x in _context.Trabajador
                                      select x).ToList();
            return lista;
        }

        public Trabajador Recuperar(int id)
        {
            Trabajador a = (from x in _context.Trabajador
                            where x.IdTrabajador == id
                          select x).FirstOrDefault();
            return a;
        }
    }
}
