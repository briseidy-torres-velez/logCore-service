using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Log
    {
        public int Id { get; set; }
        public string Aplicacion { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }
    }
}
