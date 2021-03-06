﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAlumnosClases.Datos
{
    public abstract class Persona
    {
        //PROPIEDADES
        private string _nombre;
        public string Nombre
        {
            set
            { _nombre = value.ToUpper(); }
            get { return _nombre; }
        }
        public int Edad { get; set; }

        //CONTRCUTORES
        //se pone el constructor vacio para no cargarse el por defecto y poder instanciar objetos sin parametros
        protected Persona()
        {
        }
        protected Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }


        //METODOS
        public void Detalles()
        {
            Console.WriteLine("{0} {1}", Nombre, Edad);

        }


        //METODO ABSTRACTO
        public abstract void Funciones();

    }
}
