using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppDemo01.models
{
    public class CatCorreosRepositorio: ICatCorreosRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public CatCorreosRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public IEnumerable<CatCorreos> CategoriasCorreos => _appDbContext.CategoriasCorreos;
    }
}
