using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoPOO.Models
{
    class Auto : Vehiculo
    {
        private int _ruedas;
        public int Ruedas { get => _ruedas; set => _ruedas = value; }
        
        
        public Auto(string marca, float precio, int ruedas)
        {
            this._ruedas = ruedas;
            this._marca = marca;
            this._precio = precio;
        }

        public new void DatosActuales()
        {
            Console.WriteLine("La marca del auto es " + this.Marca + " el precio es de " + this.Precio + " actualmente esta yendo a una velocidad de " + _velocidad + " km/h.");
        }
    }


}
