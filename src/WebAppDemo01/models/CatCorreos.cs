using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo01.models
{
    public class CatCorreos
    {
        [Key]
        public int CodigoCatCorreo { get; set; }
        public string NombreCatCorreo { get; set; }
        public string DescripcionCatCorreo { get; set; }
        public List<Correos> Correos { get; set; }
    }
}
