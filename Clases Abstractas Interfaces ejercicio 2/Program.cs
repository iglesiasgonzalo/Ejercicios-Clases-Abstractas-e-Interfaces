using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Interfaces_ejercicio_2
{
    internal class Program
    {
        public interface IVehiculo
        {
            void Conducir();
        }

        public abstract class VehiculoBase : IVehiculo
        {
            private string marca;

            public void SetMarca(string marca)
            {
                this.marca = marca;
            }

            public string GetMarca()
            {
                return marca;
            }

            public abstract void Conducir();
        }

        
        public class Auto : VehiculoBase
        {
            public override void Conducir()
            {
                Console.WriteLine($"Conduciendo un auto de marca {GetMarca()} por la autopista.");
            }
        }

        public class Moto : VehiculoBase
        {
            public override void Conducir()
            {
                Console.WriteLine($"Conduciendo una moto de marca {GetMarca()} entre el tráfico.");
            }
        }

       
        public class Bicicleta : VehiculoBase
        {
            public override void Conducir()
            {
                Console.WriteLine($"Pedaleando una bicicleta de marca {GetMarca()} en el parque.");
            }
        }
        static void Main(string[] args)
        {
            IVehiculo[] vehiculos = new IVehiculo[3];

            Auto auto = new Auto();
            auto.SetMarca("Toyota");

            Moto moto = new Moto();
            moto.SetMarca("Yamaha");

            Bicicleta bicicleta = new Bicicleta();
            bicicleta.SetMarca("Trek");

            vehiculos[0] = auto;
            vehiculos[1] = moto;
            vehiculos[2] = bicicleta;

            foreach (IVehiculo v in vehiculos)
            {
                v.Conducir();
            }

            Console.ReadKey();
        }
    }
}
