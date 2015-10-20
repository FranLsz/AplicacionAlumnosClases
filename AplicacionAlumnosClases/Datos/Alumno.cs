using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAlumnosClases.Datos
{
    public class Alumno : Persona
    {

        //PROPIEDADES
        public int Nota { set; get; }

        public string Curso { get; set; }


        //CONTRUCTORES
        //public Alumno()
        //{
        //    Nombre = "";
        //    Nota = 0;
        //    Edad = 0;
        //    Curso = "";
        //}

        //public Alumno(string nombre, int nota, int edad)
        //{
        //    Nombre = nombre;
        //    Nota = nota;
        //    Edad = edad;
        //}

        #region Metodos

        //METODOS
        public void ModificarNota(int cantidad)
        {
            Nota += cantidad;
        }

        public string GetNotaTexto()
        {
            if (Nota < 5)
                return "Suspenso";
            else if (Nota < 7)
                return "Aprobado";
            else if (Nota < 9)
                return "Notable";
            else
                return "Sobresaliente";
        }

        #endregion

        //METODOS HEREDADOS
        public override void Funciones()
        {

        }
        public Alumno() : base()
        {


        }
        public Alumno(string nombre, int nota, int edad) : base(nombre, edad)
        {


        }

    }
}
