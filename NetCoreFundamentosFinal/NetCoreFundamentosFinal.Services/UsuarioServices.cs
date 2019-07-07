using NetCoreFundamentosFinal.Contexto;
using NetCoreFundamentosFinal.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreFundamentosFinal.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly FundamentosContext context;

        public UsuarioServices(FundamentosContext context)
        {
            this.context = context;
        }

        public Usuario Autenticar(string login, string clave)
        {
            return context.Usuario
                .FirstOrDefault(t => t.Login == login && t.Clave == clave);
        }

        public Usuario Insertar(Usuario usuario)
        {
            context.Usuario.Add(usuario);
            context.SaveChanges();
            return usuario;
        }
    }
}
