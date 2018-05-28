using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppDemo01.models;
using WebAppDemo01.viewmodels;

namespace WebAppDemo01.controllers
{
    public class CorreosController : Controller
    {
        private readonly ICatCorreosRepositorio _catcorreosRepositorio;
        private readonly ICorreosRepositorio _correosRepositorio;

        public CorreosController(ICatCorreosRepositorio catcorreosRepositorio, ICorreosRepositorio correosRepositorio)
        {
            _catcorreosRepositorio = catcorreosRepositorio;
            _correosRepositorio = correosRepositorio;
        }

        public ViewResult ListaCorreos()
        {
            ListaCorreosViewModel listacorreosViewModel = new ListaCorreosViewModel();
            listacorreosViewModel.Correos = _correosRepositorio.Correos;
            return View(listacorreosViewModel);
        }

    }
}
