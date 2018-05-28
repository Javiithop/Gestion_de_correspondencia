using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WebAppDemo01.models
{
    public class Correos
    {
        [Key]
        public int CodigoCorreo { get; set; }
        public string NombreCorreo { get; set; }
        public string DescripCorreo { get; set; }
        public string DescripCortaCorreo { get; set; }
        public string DescripLargaCorreo { get; set; }
        public string FechaIngreso { get; set; }
        public string ImagenURL { get; set; }
        public string ImagenPreviaURL { get; set; }
        public bool EstadoCorreo { get; set; }
        public int CodigoCategoria { get; set;  }
        public virtual CatCorreos CatCorreos { get; set; }
    }
}
