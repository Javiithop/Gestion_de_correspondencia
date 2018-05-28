using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo01.models
{
    public interface ICorreosRepositorio
    {
        IEnumerable<Correos> Correos { get; }

        Correos GetCorreosPorCodigo(int CodigoCorreo);
    }
}
