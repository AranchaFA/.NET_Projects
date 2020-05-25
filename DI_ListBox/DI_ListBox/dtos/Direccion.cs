using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI_ListBox
{
    class Direccion
    {
        public String NombrePersona {get; set; }
        public String stringDireccion {get; set; }

        public Direccion(String nombrePersona, String stringDireccion)
        {
            NombrePersona = nombrePersona;
            this.stringDireccion = stringDireccion;
        }

        public override string ToString()
        {
            return NombrePersona + " " + stringDireccion;
        }
    }
}
