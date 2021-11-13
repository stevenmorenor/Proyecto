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
                var cursos = db.Curso.Include(c => c.InstructorLink).ThenInclude(ci => ci.Instructor);
                foreach(var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                    foreach(var insLink in curso.InstructorLink)
                    {
                        Console.WriteLine("*******" + insLink.Instructor.Nombre + "--" + insLink.Instructor.Apellidos);
                    }
                }



                /*var cursos = db.Curso.Include (c=> c.ComentarioLista).AsNoTracking();
                foreach(var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                    foreach(var comentario in curso.ComentarioLista)
                    {
                        Console.WriteLine("*******" + comentario.ComentarioTexto);
                    }
                }
                                       
                var cursos = db.Curso.Include( p => p.PrecioPromocion).AsNoTracking();
                foreach(var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo + "---" + curso.PrecioPromocion.PrecioActual);
                }


                 var cursos = db.Curso.AsNoTracking();
                foreach(var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo + "---" + curso.Descripcion);
                }*/
            }
        }
    }
}