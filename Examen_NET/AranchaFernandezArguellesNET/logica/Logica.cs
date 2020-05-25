using AranchaFernandezArguellesNET.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AranchaFernandezArguellesNET.logica
{
    public class Logica
    {

        // ATRIBUTOS
        // Colección que implementa avisadores para los cambios en la tabla. (PUBLIC)
        public ObservableCollection<Persona> listaPersonas { get; set; }

        // MÉTODOS
        // Constructor
        public Logica()
        {
            listaPersonas = new ObservableCollection<Persona>();
        }

        // Añadir/Eliminar de la lista
        public void aniadirPersona(Persona persona)
        {
            listaPersonas.Add(persona);
        }
        // Sustituimos la persona que ocupa la posición especificada por la nueva persona pasada por parámetro
        // En C# sí podemos acceder a una posición de una lista (en Java no existían índices en las listas)
        public void modificarPersona(Persona persona, int posicion)
        {
            listaPersonas[posicion] = persona;
        }


    }
}
