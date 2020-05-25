using AranchaFernandezArguellesNET.dto;
using AranchaFernandezArguellesNET.gui;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AranchaFernandezArguellesNET
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ///////////////
        // ATRIBUTOS //
        ///////////////
        private Logica logica;
        public List<Persona> ListaPersona;

        ///////////////
        //  MÉTODOS  //
        ///////////////

        public MainWindow()
        {
            InitializeComponent();
            logica=new Logica();
            
            // Tanto el DataGrid como el ComboBox presentan los datos de la lógica de negocio
            dataGrid.DataContext = logica;
            comboBox.DataContext = logica;
            // Los botones deberán estar inicialmente deshabilitados porque aún no habrá personas en la lista
            bt_Entra.IsEnabled = false;
            bt_Sale.IsEnabled = false;
        }

        private void clickAnhadir(object sender, RoutedEventArgs e)
        {
            WindowPersona windowPersona = new WindowPersona(logica);
            windowPersona.Show();
        }

        private void clickSale(object sender, RoutedEventArgs e)
        {
            modificarEstadoPersona();

            //ComboBoxItem cbi = (ComboBoxItem)comboBox.SelectedItem;
            //Persona persona = (Persona)cbi.Content;
            //persona.Estado = "FUERA";
            //if (persona.Estado == "FUERA") persona.Estado = "DENTRO";
            //else persona.Estado = "FUERA";
        }

        private void clickEntra(object sender, RoutedEventArgs e)
        {
            modificarEstadoPersona();
            //ComboBoxItem cbi = (ComboBoxItem)comboBox.SelectedItem;
            //Persona persona = (Persona)cbi.Content;
            //persona.Estado = "DENTRO";
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // No obtenemos del combo un objeto persona, porque lo carga con los Strings del toString
            int indiceSeleccionado = comboBox.SelectedIndex;
            Persona persona = logica.listaPersonas[indiceSeleccionado];

                if (persona.Estado == "FUERA")
                {
                    bt_Entra.IsEnabled = true;
                    bt_Sale.IsEnabled = false;
                }
                else
                {
                    bt_Entra.IsEnabled = false;
                    bt_Sale.IsEnabled = true;
                }

        }

        private void modificarEstadoPersona()
        {
            // No obtenemos del combo un objeto persona, porque lo carga con los Strings del toString
            int indiceSeleccionado = comboBox.SelectedIndex;
            Persona persona = logica.listaPersonas[indiceSeleccionado];
            if (persona.Estado == "FUERA")
            {
                persona.Estado = "DENTRO";
                bt_Entra.IsEnabled = false;
                bt_Sale.IsEnabled = true;
            }
            else
            {
                persona.Estado = "FUERA";
                bt_Entra.IsEnabled = true;
                bt_Sale.IsEnabled = false;
            }
        }
    }
}
