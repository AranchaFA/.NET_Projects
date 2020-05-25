using IngresosYGastos.dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresosYGastos.logica
{
    public class LogicaNegocio
    {
        // ATRIBUTOS
        // Colección que implementa avisadores para los cambios en la tabla. (PUBLIC)
        // OJO: Actualiza los cambios al agregar/eliminar elementos a la tabla, 
        // pero NO los cambios en los datos internos (atributos) de los elementos.
        // Para eso, se debe implementar en la clase de los objetos INotifyPropertyChanged
        // e implementar el método de la interfaz en los setter de los atributos a controlar
        public ObservableCollection<Operacion> listaOperaciones { get; set; }

        // MÉTODOS
        // Constructor
        public LogicaNegocio()
        {
            listaOperaciones = new ObservableCollection<Operacion>();
        }

        // Añadir/Eliminar de la lista
        public void aniadirOperacion(Operacion operacion)
        {
            listaOperaciones.Add(operacion);
        }
        // Necesitamos especificar la posición que ocupa el elemento a actualizar, para sustituir el contenido de la lista
        // en esa posición por el nuevo objeto con los datos actualizados
        // En C# sí podemos acceder a una posición de una lista (en Java no existían índices en las listas)
        public void modificarOperacion(Operacion operacion, int posicion)
        {
            listaOperaciones[posicion] = operacion;
        }
    }
}
