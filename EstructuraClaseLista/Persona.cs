using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EstructuraClaseLista
{
    class Persona
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}