using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Ejercicio_1_Figuras
{
    internal class Program
    {
        public abstract class Figura
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

            public abstract double CalcularArea();

            public void MostrarArea()
            {
                Console.WriteLine($"El área de la figura '{GetNombre()}' es: {CalcularArea():F2} unidades cuadradas.");
            }
        }

        public class Cuadrado : Figura
        {
            private double lado;

            public void SetLado(double lado)
            {
                this.lado = lado;
            }

            public double GetLado()
            {
                return lado;
            }

            public override double CalcularArea()
            {
                return lado * lado;
            }
        }

        public class Circulo : Figura
        {
            private double radio;

            public void SetRadio(double radio)
            {
                this.radio = radio;
            }

            public double GetRadio()
            {
                return radio;
            }

            public override double CalcularArea()
            {
                return 3.1416 * radio * radio;
            }
        }
        public class Triangulo : Figura
        {
            private double baseT;
            private double altura;

            public void SetBase(double baseT)
            {
                this.baseT = baseT;
            }

            public double GetBase()
            {
                return baseT;
            }

            public void SetAltura(double altura)
            {
                this.altura = altura;
            }

            public double GetAltura()
            {
                return altura;
            }

            public override double CalcularArea()
            {
                return (baseT * altura) / 2;
            }
        }

        public static void Main()
        {
            Figura[] figuras = new Figura[3];

            Cuadrado cuadrado = new Cuadrado();
            cuadrado.SetNombre("Cuadrado");
            cuadrado.SetLado(4);

            Circulo circulo = new Circulo();
            circulo.SetNombre("Círculo");
            circulo.SetRadio(2.5);

            Triangulo triangulo = new Triangulo();
            triangulo.SetNombre("Triángulo");
            triangulo.SetBase(6);
            triangulo.SetAltura(3);

            figuras[0] = cuadrado;
            figuras[1] = circulo;
            figuras[2] = triangulo;

            foreach (Figura figura in figuras)
            {
                figura.MostrarArea();
            }

            Console.ReadKey();
        }

    }
}
