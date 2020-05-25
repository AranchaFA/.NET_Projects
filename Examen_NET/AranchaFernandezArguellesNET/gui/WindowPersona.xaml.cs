using AranchaFernandezArguellesNET.dto;
using AranchaFernandezArguellesNET.logica;
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

namespace AranchaFernandezArguellesNET.gui
{
    /// <summary>
    /// Lógica de interacción para WindowPersona.xaml
    /// </summary>
    public partial class WindowPersona : Window
    {
        Logica logica;
        private Persona personaAGrabar;
        private int erroresValidacion;

        public WindowPersona(Logica logica)
        {
            InitializeComponent();
            this.logica = logica;
            personaAGrabar = new Persona();
            // Hacemos binding de los textbox con los atributos de la persona
            textbox_apellidos.DataContext = personaAGrabar;
            textbox_Nombre.DataContext = personaAGrabar;
        }

        private void clickInsertar(object sender, RoutedEventArgs e)
        {
            logica.aniadirPersona(personaAGrabar);
            this.Close(); // Cerramos tras añadir
        }

        private void clickCancelar(object sender, RoutedEventArgs e)
        {
            this.Close(); // Cerramos sin añadir nada
        }

        // Validamos que los campos no estén vacíos y activamos/desactivamos el botón añadir en función del resultado
        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added) // Acción del evento=Error 'añadido', sumamos 1 error de validación
                erroresValidacion++;
            else // Acción del evento=Error 'no añadido', restamos 1 error 
                erroresValidacion--;

            if (erroresValidacion == 0) // No hay errores de validación en toda la ventana
                bt_insertar.IsEnabled = true;
            else
                bt_insertar.IsEnabled = false;

            sender.GetType();
        }
    }
}
