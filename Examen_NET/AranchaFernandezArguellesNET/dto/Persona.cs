using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AranchaFernandezArguellesNET.dto
{
    public class Persona : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {

        // ATRIBUTOS
        private String _nombre;
        private String _apellidos;
        private String _estado;
        // Manejador de eventos para avisar de los cambios en los atributos
        public event PropertyChangedEventHandler PropertyChanged;

        // MÉTODOS

        // CONSTRUCTORES
        public Persona()
        {
            this._estado = "FUERA";
        }

        // GETTERS+SETTERS (Con implementación de INotifyPropertyChanged para el DataGrid)
        public String Nombre
        {
            get { return _nombre; }
            set
            {
                this._nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }

        public String Apellidos
        {
            get { return _apellidos; }
            set
            {
                this._apellidos = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Apellidos"));
            }
        }

        public String Estado
        {
            get { return _estado; }
            set
            {
                this._estado = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Estado"));
            }
        }

        // ICloneable
        public object Clone()
        {
            return this.MemberwiseClone(); // Clona el objeto y todos sus atributos
        }

        // IDataErrorInfo : Para la validación de campos (que no sean nulos o vacíos el nombre y los apellidos)
        public string Error 
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(_nombre))
                        result = "Introduce un nombre";
                }
                if (columnName == "Apellidos")
                {
                    if (string.IsNullOrEmpty(_apellidos))
                        result = "Introduce unos apellidos";
                }
                // El estado no se valida, pues no se introduce al registrar una nueva persona
                return result;
            }
        }

        public override string ToString()
        {
            return Nombre + " " + Apellidos;
        }
    }
}
