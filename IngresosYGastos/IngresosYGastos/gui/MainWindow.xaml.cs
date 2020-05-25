using IngresosYGastos.dtos;
using IngresosYGastos.logica;
using IngresosYGastos.gui;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IngresosYGastos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ///////////////
        // ATRIBUTOS //
        ///////////////
        private LogicaNegocio logicaNegocio;
        private Operacion operacionSeleccionada;
        private int indiceSeleccionado;
        private int erroresValidacion;


        /////////////
        // MÉTODOS //
        /////////////
        /* Constructor
         */
        public MainWindow()
        {
            InitializeComponent();
            logicaNegocio = new LogicaNegocio();
            dataGrid.DataContext = logicaNegocio; // El DataContext (elemento del que extraer los datos) del Binding del grid será el atributo logigaNegocio
            operacionSeleccionada = new Operacion();
            bindingOperacion();
            reiniciarCampos();
            //button_aceptar.IsEnabled = false;
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

            sender.GetType();
        }

        /* MÉTODOS CLICK
         */
        private void Button_Click_Aceptar(object sender, RoutedEventArgs e)
        {
            if (button_aceptar.Content.Equals("Modificar"))
            {
                logicaNegocio.modificarOperacion(operacionSeleccionada, indiceSeleccionado);
            }
            else
            {
                logicaNegocio.aniadirOperacion(operacionSeleccionada);
            }
            reiniciarCampos();
        }
        
        private void buttonCancelar_Click(object sender, RoutedEventArgs e)
        {
            reiniciarCampos();
        }

        private void button_nuevaVentana_Click(object sender, RoutedEventArgs e)
        {
            WindowLibro windowLibro = new WindowLibro(logicaNegocio, indiceSeleccionado);
            windowLibro.Show();
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                indiceSeleccionado = dataGrid.SelectedIndex;
                Operacion operacionGrid = (Operacion)dataGrid.SelectedItem;
                operacionSeleccionada = (Operacion)operacionGrid.Clone();
                bindingOperacion();
                /**
                if (operacionSeleccionada.Ingreso != 0)
                    textBox_importe.Text = Convert.ToString(operacionSeleccionada.Ingreso);
                else
                    textBox_importe.Text = Convert.ToString(operacionSeleccionada.Gasto);
                */
                button_aceptar.Content = "Modificar";
            }
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

        
        /**
        // Métodos Click de los botones:
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        { // Abrir para añadir nuevo libro
            DialogoLibro dialogoLibro = new DialogoLibro(logicaNegocio);
            dialogoLibro.Show();
        }

        private void ButtonModificar_Click(object sender, RoutedEventArgs e)
        { // Abrir para modificar libro seleccionado
            if (DataGridLibros.SelectedIndex != -1)
            {
                Libro libro = (Libro)DataGridLibros.SelectedItem; // Sacar el elemento seleccionado del grid
                // Abrimos la ventana para mostrar el libro pasando UN CLON del libro seleccionado, si pasamos el original las modificaciones se verán y 'grabrán'
                // en tiempo real al ir escribiendo, aunque al final demos a cancelar! Y queremos que sólo se modifique el objeto guardado en la lista de la lógica
                // cuando se de a aceptar los cambios. Para eso, trabajaremos sobre un clon del objeto, y si finalmente se aceptan los cambios sustituimos el objeto
                // antiguo por el clon modificado en la lista. Para eso hará falta también especificar la posición que ocupa en la lista (C# tiene listas con índices)
                DialogoLibro dialogoLibro = new DialogoLibro(logicaNegocio, (Libro)libro.Clone(), DataGridLibros.SelectedIndex);
                dialogoLibro.Show();
            }
        }
 * */
    }
}
