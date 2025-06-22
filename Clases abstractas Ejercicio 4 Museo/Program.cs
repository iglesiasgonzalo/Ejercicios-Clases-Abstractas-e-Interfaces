using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_abstractas_Ejercicio_4_Museo
{
    internal class Program
    {
        abstract class Animal
        {
            private string nombre;

            public void SetNombre(string nombre)
            {
                this.nombre = nombre;
            }

            public string GetNombre()
            {
                return nombre;
            }

            public abstract void HacerSonido();

            public void MostrarNombre()
            {
                Console.WriteLine($"Animal: {GetNombre()}");
            }
        }

        class Leon : Animal
        {
            public Leon()
            {
                SetNombre("León");
            }

            public override void HacerSonido()
            {
                Console.WriteLine("El león ruge: ¡GRAAAARRR!");
            }
        }

        class Loro : Animal
        {
            public Loro()
            {
                SetNombre("Loro");
            }

            public override void HacerSonido()
            {
                Console.WriteLine("El loro dice: ¡Hola! ¿Querés una semilla?");
            }
        }

        class Delfin : Animal
        {
            public Delfin()
            {
                SetNombre("Delfín");
            }

            public override void HacerSonido()
            {
                Console.WriteLine("El delfín emite un clic: *clic clic clic*");
            }
        }

        static void Main(string[] args)
        {
            Animal[] animales = new Animal[3];
            animales[0] = new Leon();
            animales[1] = new Loro();
            animales[2] = new Delfin();

            foreach (Animal animal in animales)
            {
                animal.MostrarNombre();
                animal.HacerSonido();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
 