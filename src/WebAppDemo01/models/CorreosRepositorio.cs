using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo01.models
{
    public class CorreosRepositorio : ICorreosRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public CorreosRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Correos> Correos
        {
            get
            {
                return _appDbContext.Correos.Include(c => c.CatCorreos);
            }
        }
       // public IEnumerable<Correos> CorreosActivos
        //{
          //  get
           // {
             //   return _appDbContext.Correos.Include(c => c.CatCorreos).Where(p => p.CorreosActivos);
            //}
       // }
        public Correos GetCorreosPorCodigo(int CodigoCorreo)
        {
            return _appDbContext.Correos.FirstOrDefault(p => p.CodigoCorreo == CodigoCorreo);
        }
    }
}
