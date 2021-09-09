using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoPOO.Models
{
    public abstract class Vehiculo
    {
        public string _marca;
        public float _precio;
        public static int _velocidad = 0;


        public string Marca { get => _marca; set => _marca = value; }

        public float Precio
        {
            get => _precio;
            protected set
            {
                if (value < 0)
                    throw new Exception("El precio no puede ser menor que 0.");
                _precio = value;
            }
        }

        public virtual void DatosActuales()
        {
            Console.WriteLine("La marca del vehiculo es " + this.Marca + " el precio es de " + this.Precio + " actualmente esta yendo a una velocidad de " + _velocidad + " km/h.");
        }

        public void Arrancar()
        {
            if(_velocidad != 0)
            {
                throw new Exception("Imposible arrancar si estás conduciendo!");
            }
            _velocidad++;
        }

        public void Acelerar()
        {
            if(_velocidad <= 0)
            {
                throw new Exception("Imposible acelerar si todavía no arrancó!");
            }
            _velocidad++;
        }

        public void Desacelerar()
        {
            if(_velocidad <= 0)
            {
                throw new Exception("Imposible desacelerar si no se esta conduciendo!");
            }
            _velocidad--;
        }

        public void Frenar()
        {
            if (_velocidad <= 0)
            {
                throw new Exception("Imposible desacelerar si no estas conduciendo!");
            }
            _velocidad = 0;
        }

    }
}
