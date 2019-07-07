using NetCoreFundamentosFinal.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreFundamentosFinal.Services
{
    public interface ITrabajadorServices
    {
        List<Trabajador> Listar();
        Trabajador Recuperar(int id);
        Trabajador Insertar(Trabajador trabajador);
        Trabajador Actualizar(Trabajador trabajador);
        bool Eliminar(int id);
    }
}
