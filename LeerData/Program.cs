using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var db = new AppVentaCursosContext())
            {
                var cursos = db.Curso.Include( p => p.PrecioPromocion).AsNoTracking();
                foreach(var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo + "---" + curso.PrecioPromocion.PrecioActual);
                }


               /* var cursos = db.Curso.AsNoTracking();
                foreach(var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo + "---" + curso.Descripcion);
                }*/
            }
        }
    }
}