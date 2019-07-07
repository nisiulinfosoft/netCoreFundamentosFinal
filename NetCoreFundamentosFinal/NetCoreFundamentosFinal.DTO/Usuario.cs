using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreFundamentosFinal.DTO
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Login { get; set; }
        public string Clave { get; set; }
        public string Origen { get; set; }
    }
}
