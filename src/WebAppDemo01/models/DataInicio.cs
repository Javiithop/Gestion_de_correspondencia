using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
namespace WebAppDemo01.models
{
    public static class DataInicio
    {
        
        public static void AgregarData(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!contexto.CategoriasCorreos.Any())
            {
                contexto.CategoriasCorreos.AddRange(CategoriasCorreosIniciales.Select(c => c.Value));
            }
            if (!contexto.Correos.Any())
            {
                contexto.AddRange
                (
                    new Correos {
                       NombreCorreo = "Informe",
                        DescripCorreo="Todos los empleados",
                        DescripCortaCorreo = "Informe General",
                        DescripLargaCorreo = "Informe sobre la reunion sostenida con miembros de administracion",
                        FechaIngreso = "Sabado 12 de mayo, 2018",
                        ImagenURL = "/Imagenes/iu.jpg",
                        ImagenPreviaURL = "/Imagenes/iu.jpg",
                        EstadoCorreo = true,
                 CatCorreos = CategoriasCorreosIniciales["Informativo"]
                    },
                    new Correos
                    {
                        NombreCorreo = "Solicitud",
                        DescripCorreo = "Exclusivo de Administradores",
                        DescripCortaCorreo = "Solicitud de Informe",
                        DescripLargaCorreo = "Solicitud dirigida a los administradores, para que entregen sus informes de trabajo mensual antes del mes de junio",
                        FechaIngreso = "Domingo 13 de mayo, 2018",
                        ImagenURL = "/Imagenes/iu.jpg",
                        ImagenPreviaURL = "/Imagenes/iu.jpg",
                        EstadoCorreo = true,
                        CatCorreos = CategoriasCorreosIniciales["Confidencial"]
                    },
                    new Correos
                    {
                        NombreCorreo = "Invitación",
                        DescripCorreo = "Todos los empleados",
                        DescripCortaCorreo = "Invitación a celebración",
                        DescripLargaCorreo = "Invitación a celebración de 10 años de fundación de la empresa, esperando respuesta",
                        FechaIngreso = "Domingo 13 de mayo, 2018",
                        ImagenURL = "/Imagenes/iu.jpg",
                        ImagenPreviaURL = "/Imagenes/iu.jpg",
                        EstadoCorreo = true,
                        CatCorreos = CategoriasCorreosIniciales["Publico"]
                    }
                );
            }

            contexto.SaveChanges();
        }
        public static Dictionary<string, CatCorreos> catcorreosiniciales;
        public static Dictionary<string, CatCorreos> CategoriasCorreosIniciales
        {
            get
            {
                if(catcorreosiniciales == null)
                {
                    var listadoCategorias = new CatCorreos[]
                    {
                        new CatCorreos { NombreCatCorreo = "Confidencial" },
                        new CatCorreos { NombreCatCorreo = "Informativo" },
                        new CatCorreos { NombreCatCorreo = "Publico" },
                    };
                    catcorreosiniciales = new Dictionary<string, CatCorreos>();

                    foreach(CatCorreos catcorreoini in listadoCategorias)
                    {
                        catcorreosiniciales.Add(catcorreoini.NombreCatCorreo, catcorreoini);
                    }
                }
                return catcorreosiniciales;
            }
        }
    }
}
