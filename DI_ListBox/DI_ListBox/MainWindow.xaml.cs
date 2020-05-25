using DI_ListBox.dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DI_ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Persona> personas = new ObservableCollection<Persona>();
        ObservableCollection<Direccion> direcciones = new ObservableCollection<Direccion>();

        public MainWindow()
        {
            InitializeComponent();
            // Creamos una lista de personas y otra de direcciones
            personas.Add(new Persona("Arancha","Fernández Argüelles"));
            direcciones.Add(new Direccion("Arancha","C/Un sitio Nº1 12345 SuPueblo"));
            direcciones.Add(new Direccion("Arancha","C/Otro sitio Nº9 54321 SuPuebloTambién"));
            
            personas.Add(new Persona("Andreíta", "Cómete el Pollo!"));
            direcciones.Add(new Direccion("Andreíta", "C/Su casa Nº7 77777 Turulandia"));
            direcciones.Add(new Direccion("Andreíta", "C/La casa suya Nº5 55555 OtroLugar"));
            
            personas.Add(new Persona("Perico", "Piña Pandereta"));
            direcciones.Add(new Direccion("Perico", "C/CasaCasita Nº3 03030 ElPaísDeLaPiña:)"));

            foreach (Persona persona in personas)
            {
                ComboBoxItem cbi = new ComboBoxItem();
                cbi.Content = persona;
                cb_personas.Items.Add(cbi);
            }

        }


        private void cb_personas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)cb_personas.SelectedItem;
            Persona personaSeleccionada = (Persona)cbi.Content;
            listb_direcciones.Items.Clear();
            // Persona persona=(Persona)cb_personas.SelectedItem.Content; // Esto casca, hay que hacerlo en dos pasos :(
            foreach (Direccion direccionLeida in direcciones)
            {
                if (direccionLeida.NombrePersona== personaSeleccionada.Nombre)
                {
                    ListBoxItem lbi = new ListBoxItem();
                    lbi.Content = direccionLeida;
                    listb_direcciones.Items.Add(lbi);
                }
            }
            
        }

        private void bt_1_Click(object sender, RoutedEventArgs e)
        {
            Button boton=(Button)sender;
            boton.Background = Brushes.DarkCyan;
        }
    }

    
}
