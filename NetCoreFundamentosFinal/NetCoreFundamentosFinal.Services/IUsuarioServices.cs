using NetCoreFundamentosFinal.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreFundamentosFinal.Services
{
    public interface IUsuarioServices
    {
        Usuario Autenticar(string login, string clave);
        Usuario Insertar(Usuario usuario);
    }
}
