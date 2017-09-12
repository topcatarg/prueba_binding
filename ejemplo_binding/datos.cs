using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_binding
{
    class datos : Notificador
    {

        private ObservableCollection<DatosPuros> _CollectionDatos;

        public datos()
        {
            _CollectionDatos = new ObservableCollection<DatosPuros>();
        }

        public ObservableCollection<DatosPuros> ColeccionDatos
        {
            get
            {
                return this._CollectionDatos;
            }
            set
            {
                if ((this._CollectionDatos != null))
                {
                    if ((_CollectionDatos.Equals(value) != true))
                    {
                        this._CollectionDatos = value;
                        this.OnPropertyChanged("ColeccionDatos");
                    }
                }
                else
                {
                    this._CollectionDatos = value;
                    this.OnPropertyChanged("ColeccionDatos");
                }
            }
        }
    }

    public class DatosPuros : Notificador
    {

        private string _nombre;

        public string nombre
        {
            get
            { return this._nombre; }
            set
            {
                if ((this._nombre != null))
                {
                    if ((_nombre.Equals(value) != true))
                    {
                        this._nombre = value;
                        this.OnPropertyChanged("nombre");
                    }
                }
                else
                {
                    this._nombre = value;
                    this.OnPropertyChanged("nombre");
                }


               
            }
        }

        private int _edad;
        public int edad
        {
            get
            { return this._edad; }
            set
            {
                if ((this._edad.Equals(value) != true))
                {
                    this._edad = value;
                    this.OnPropertyChanged("edad");
                }

            }
        }

        public int _altura;

        public int altura
        {
            get
            { return this._altura; }
            set
            {
                if ((this._altura.Equals(value) != true))
                {
                    this._altura = value;
                    this.OnPropertyChanged("altura");
                }
            }
        }



    }

public class Notificador: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
