using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Vehiculo
{
    internal class Program
    {
        abstract class Vehiculo
        {
            private string tipo;

            public void SetTipo(string tipo)
            {
                this.tipo = tipo;
            }

            public string GetTipo()
            {
                return tipo;
            }

            public abstract void Arrancar();

            public void Acelerar()
            {
                Console.WriteLine($"{tipo} está acelerando...");
            }

            public void MostrarTipo()
            {
                Console.WriteLine($"Tipo de vehículo: {GetTipo()}");
            }
        }

        class Auto : Vehiculo
        {
            public Auto()
            {
                SetTipo("Auto");
            }

            public override void Arrancar()
            {
                Console.WriteLine("El auto arranca con llave y hace 'vroom'");
                Acelerar();
            }
        }

        class Moto : Vehiculo
        {
            public Moto()
            {
                SetTipo("Moto");
            }

            public override void Arrancar()
            {
                Console.WriteLine("La moto arranca con botón y hace 'brrrm'");
                Acelerar();
            }
        }

        class Camion : Vehiculo
        {
            public Camion()
            {
                SetTipo("Camión");
            }

            public override void Arrancar()
            {
                Console.WriteLine("El camión arranca con motor pesado y hace 'grrrooom'");
                Acelerar();
            }
        }


        static void Main(string[] args)
        {
            Vehiculo[] vehiculos = new Vehiculo[3];
            vehiculos[0] = new Auto();
            vehiculos[1] = new Moto();
            vehiculos[2] = new Camion();

            foreach (Vehiculo v in vehiculos)
            {
                v.MostrarTipo();
                v.Arrancar();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
