﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo01.models;

namespace WebAppDemo01.viewmodels
{
    public class ListaCorreosViewModel
    {
        public IEnumerable<Correos> Correos { get; set; }
        public string CategoriasCorreos { get; set; }
    }
}
