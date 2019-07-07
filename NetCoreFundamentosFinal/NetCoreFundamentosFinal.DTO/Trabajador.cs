using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreFundamentosFinal.DTO
{
    public class Trabajador
    {
        [Key]
        public int IdTrabajador { get; set; }
        public string NroDocumento { get; set; }
        public string NombreCompleto { get; set; }
        public decimal Sueldo { get; set; }
    }
}
