using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_ListBox.dtos
{
    public class Persona
    {
        public String Nombre {get; set; }
        public String Apellidos {get; set; }

        public Persona(String nombre, String apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellidos;
        }
    }
}
