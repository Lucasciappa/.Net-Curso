using System;
using VehiculoPOO.Models;

namespace VehiculoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Hyundai", 12000, 4);
            auto1.Acelerar();
            auto1.Arrancar();
            auto1.Acelerar();
            auto1.DatosActuales();
        }
    }
}
