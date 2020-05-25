using IngresosYGastos.dtos;
using IngresosYGastos.logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IngresosYGastos.gui
{
    /// <summary>
    /// Lógica de interacción para WindowLibro.xaml
    /// </summary>
    public partial class WindowLibro : Window
    {

        private LogicaNegocio logicaNegocio;
        private Operacion operacionSeleccionada;
        private int indiceSeleccionado;
        private int erroresValidacion;


        public WindowLibro(LogicaNegocio logicaNegocio,int indiceSeleccionado)
        {
            InitializeComponent();

            this.logicaNegocio = logicaNegocio;
            this.indiceSeleccionado = indiceSeleccionado;
            if (indiceSeleccionado != -1)
            {
                operacionSeleccionada = (Operacion)logicaNegocio.listaOperaciones[indiceSeleccionado].Clone();
                bindingOperacion();
                button_aceptar.Content = "Modificar";
            }
            else
            {
                reiniciarCampos();
            }

            this.ResizeMode = System.Windows.ResizeMode.NoResize;
        }

        /* VALIDACIÓN 
        // Se ejecuta al modificar aquellos campos que incorporan en el XML:
        // <TextBox .... Validation.Error="Validation_Error" Text="{Binding Path=Titulo,NotifyOnValidationError=True,ValidatesOnDataErrors=True}" ...>
        // Validation.Error="Validation_Error" -> Método a ejecutar cuando la validación del campo sea errónea
        // {Binding ...NotifyOnValidationError=True...} -> El campo del binding notificará el resultado de la validación (valida la clase Operacion)
        // {Binding ...ValidatesOnDataErrors=True...} -> Se lanza error de validación al fallar la validación del punto anterior

        // Los campos a rellenar tienen un Binding con los atributos correspondientes del objeto operación, y como la clase Operacion
        // implementa el interface IDataErrorInfo, cada vez que hacemos una modificación en sus atributos ejecuta el método que evalúa
        // la validez de los valores de dichos atributos en ese momento (p.ej: que el importe no sea 0) y LO NOTIFICA.
        // Con el binding estamos cambiando en tiempo real el valor de los atributos, la clase Operacion notifica del resultado de evaluar la expresión
        // y nos está ejecutando a la par este método al incluir en el Binding del XML ValidatesOnDataErrors=True
        // que recibe el evento que sucedió y el elemento de la UI que lo ha desencadenado
         */
        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added) // Acción del evento=Error 'añadido', sumamos 1 error de validación
                erroresValidacion++;
            else // Acción del evento=Error 'no añadido', restamos 1 error 
                erroresValidacion--;

            if (erroresValidacion == 0) // No hay errores de validación en toda la ventana
                button_aceptar.IsEnabled = true;
            else
                button_aceptar.IsEnabled = false;
        }

        /* MÉTODOS CLICK
         */
        private void Button_Click_Aceptar(object sender, RoutedEventArgs e)
        {
            if (button_aceptar.Content.Equals("Modificar"))
            {
                logicaNegocio.modificarOperacion(operacionSeleccionada, indiceSeleccionado);
                this.Close();
            }
            else
            {
                logicaNegocio.aniadirOperacion(operacionSeleccionada);
                this.Close();
            }
            reiniciarCampos();
        }

        private void buttonCancelar_Click(object sender, RoutedEventArgs e)
        {
            reiniciarCampos();
            this.Close();
        }

        /* MÉTODOS AUXILIARES
         */
        private void reiniciarCampos()
        {
            textBox_importe.Text = "";
            textBox_concepto.Text = "";
            datePicker.SelectedDate = null;
            button_aceptar.Content = "Añadir";
            operacionSeleccionada = new Operacion();
            bindingOperacion();
            indiceSeleccionado = -1;
        }

        private void bindingOperacion()
        {
            textBox_concepto.DataContext = operacionSeleccionada;
            textBox_importe.DataContext = operacionSeleccionada;
            datePicker.DataContext = operacionSeleccionada;
        }

    }
}
