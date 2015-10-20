using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAlumnosClases.Datos
{
    public class Trabajador : Persona
    {
        //METODO HEREDADO
        public override void Funciones()
        {

        }

        public Trabajador(string nombre, int edad) : base(nombre, edad)
        {
        }
    }
}
