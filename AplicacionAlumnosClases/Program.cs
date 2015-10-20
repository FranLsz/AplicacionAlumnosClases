using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionAlumnosClases.Datos;

namespace AplicacionAlumnosClases
{
    class Program
    {
        static void Main(string[] args)
        {


            Alumno al = new Alumno();
            //sin necesidad de constructor, una vez creado el objeto se mete el valor a sus propiedades
            Alumno al2 = new Alumno()
            {
                Nombre = "Pepe",
                Edad = 25,
                Nota = 8,
                Curso = "C#"
            };
            al.Nombre = "Fran";
            al.Edad = 20;
            Console.WriteLine(al.Nombre);
            Console.WriteLine(al2.GetNotaTexto());
            al.Detalles();
            Console.Read();
        }
    }
}
