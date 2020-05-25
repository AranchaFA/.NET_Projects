using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI_ListBox
{
    class Direccion
    {
        public String NombrePersona {get; set; }
        public String Direccion {get; set; }

        public Direccion(String nombrePersona, String direccion)
        {
            NombrePersona = nombrePersona;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return NombrePersona + " " + Direccion;
        }
    }
}
