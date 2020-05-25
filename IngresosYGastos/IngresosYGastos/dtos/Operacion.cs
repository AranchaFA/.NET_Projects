using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresosYGastos.dtos
{
    public class Operacion : INotifyPropertyChanged, ICloneable, IDataErrorInfo 
    {
        // ATRIBUTOS
        private int _ingreso;
        private int _gasto;
        private int _importe;
        private String _concepto;
        private DateTime _fecha;
        // Manejador de eventos para avisar de los cambios en los atributos
        public event PropertyChangedEventHandler PropertyChanged;
        

        // MÉTODOS

        // CONSTRUCTORES
        public Operacion()
        {
            this._fecha = DateTime.Now;
        }

        // GETTERS+SETTERS
        public int Ingreso// No se puede llamar a los set/get _importe(=que el atributo), por eso va con I mayúscula
        {
            get { return _ingreso; }
            set
            {  
                // AQUÍ NO ASIGNAMOS NINGÚN VALOR, PORQUE EL VALOR DE INGRESO O GASTO SE ASIGNA EN EL SETTER DE IMPORTE
                // QUE ES EL CAMPO QUE RECOGEMOS CON EL BINDING DEL TEXTBOX

                // Sí necesitamos implementar el método de la interfaz para que se actualice al modificar
                this.PropertyChanged(this, new PropertyChangedEventArgs("Ingreso"));
            }
        }

        public int Gasto
        {
            get { return _gasto; }
            set
            {
                // AQUÍ NO ASIGNAMOS NINGÚN VALOR, PORQUE EL VALOR DE INGRESO O GASTO SE ASIGNA EN EL SETTER DE IMPORTE
                // QUE ES EL CAMPO QUE RECOGEMOS CON EL BINDING DEL TEXTBOX

                // Sí necesitamos implementar el método de la interfaz para que se actualice al modificar
                this.PropertyChanged(this, new PropertyChangedEventArgs("Gasto"));
            }
        }

        public int Importe
        {
            get { return _importe; }
            set
            {
                this._importe = value;

                // HAY QUE ASIGNAR AQUÍ LOS VALORES DE INGRESO O GASTO PORQUE LO QUE RECOGEMOS EN EL BINDING DEL TEXTBOX
                // ES EL IMPORTE, ASÍ QUE ES SETTER QUE SE EJECUTA ES ESTE
                _ingreso = _importe >= 0 ? _importe : 0;
                _gasto = _importe < 0 ? _importe : 0;
                  
                this.PropertyChanged(this, new PropertyChangedEventArgs("Importe"));
                // INotifyPropertyChanged: implementamos el método del interface en el setter del atributo
                // cuyos cambios queremos notificar (generando un Event asociado al CAMPOS DEL GRID del que se trata en cada caso)
            }
        }

        public String Concepto
        {
            get { return _concepto; }
            set
            {
                this._concepto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Concepto"));
                // INotifyPropertyChanged: implementamos el método del interface en el setter del atributo
                // cuyos cambios queremos notificar (generando un Event asociado al CAMPOS DEL GRID del que se trata en cada caso)
            }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set
            {
                this._fecha = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Fecha"));
                // INotifyPropertyChanged: implementamos el método del interface en el setter del atributo
                // cuyos cambios queremos notificar (generando un Event asociado al CAMPOS DEL GRID del que se trata en cada caso)
            }
        }

        // ICloneable: Para que no se alteren los atributos hasta que no se confirmen las modificaciones realizadas,
        // en vez de trabajar directamente sobre el objeto Operacion sobre el que tengamos hecho un binding trabajamos
        // sobre un clon. Si se confirman los cambios sustituimos el original por el modificado: opOriginal=opClonado
        public object Clone()
        {
            return this.MemberwiseClone(); // Indica que se clona el objeto y todos sus atributos
        }

        // IDataErrorInfo : Para la validación de campos
        public string Error // No definimos en nuestro caso ningún mensaje de retorno para el Error de validación
        { 
            get { return ""; }
        }

        // Devuelve cadena vacía si la validación de todos los atributos es correcta, si la validación de algún atributo
        // falla devolvemos la cadena que corresponda en cada caso. Luego gestionaremos qué acciones queremos hacer en función
        // del resultado de la validación (p.ej: desactivar el botón de aceptar o enviar formulario,...).
        // Se ejecuta cada vez que se detecta un cambio en el valor de ese atributo.
        // Como estos campos tendrán hecho un binding a los textBox de la UI, actualizarán su valor en tiempo real según el 
        // usuario vaya escribiendo, y se evaluará si la expresión introducida por el usuario es válida también en tiempo real.
        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Concepto")
                {
                    if (string.IsNullOrEmpty(_concepto))
                        result = "Introduce un concepto";
                }
                if (columnName == "Importe")
                {
                    if (_importe==0)
                        result = "Introduce un importe";
                }
                if (columnName == "Fecha")
                {
                    if (_fecha==null)
                        result = "Introduce una fecha";
                }
                return result;
            }
        }

    }
}
