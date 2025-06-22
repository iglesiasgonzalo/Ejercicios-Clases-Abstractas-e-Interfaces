using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases_abstractas_Empleado
{
    internal class Program
    {
        abstract class Empleado
        {
            private string nombre;
            private double sueldoBase;

            public void SetNombre(string nombre)
            {
                this.nombre = nombre;
            }

            public string GetNombre()
            {
                return nombre;
            }

            public void SetSueldoBase(double sueldo)
            {
                sueldoBase = sueldo;
            }

            public double GetSueldoBase()
            {
                return sueldoBase;
            }

            public abstract double CalcularSueldo();
        }

        class EmpleadoTiempoCompleto : Empleado
        {
            private double bonoPresentismo;

            public void SetBonoPresentismo(double bono)
            {
                bonoPresentismo = bono;
            }

            public double GetBonoPresentismo()
            {
                return bonoPresentismo;
            }

            public override double CalcularSueldo()
            {
                return GetSueldoBase() + bonoPresentismo;
            }
        }

        class EmpleadoMedioTiempo : Empleado
        {
            private int horasSemanales;
            private double bonoExtra;

            public void SetHorasSemanales(int horas)
            {
                horasSemanales = horas;
            }

            public int GetHorasSemanales()
            {
                return horasSemanales;
            }

            public void SetBonoExtra(double bono)
            {
                bonoExtra = bono;
            }

            public double GetBonoExtra()
            {
                return bonoExtra;
            }

            public override double CalcularSueldo()
            {
                double bono = horasSemanales > 20 ? bonoExtra : 0;
                return GetSueldoBase() + bono;
            }
        }
        static void Main(string[] args)
        {
            // Empleado de tiempo completo
            EmpleadoTiempoCompleto empleado1 = new EmpleadoTiempoCompleto();
            empleado1.SetNombre("María");
            empleado1.SetSueldoBase(50000);
            empleado1.SetBonoPresentismo(5000);

            Console.WriteLine($"Empleado: {empleado1.GetNombre()}");
            Console.WriteLine($"Sueldo total (tiempo completo): {empleado1.CalcularSueldo()}");

            Console.WriteLine();

            // Empleado de medio tiempo
            EmpleadoMedioTiempo empleado2 = new EmpleadoMedioTiempo();
            empleado2.SetNombre("Luis");
            empleado2.SetSueldoBase(20000);
            empleado2.SetHorasSemanales(25); // Cambiá este valor para probar
            empleado2.SetBonoExtra(3000);

            Console.WriteLine($"Empleado: {empleado2.GetNombre()}");
            Console.WriteLine($"Sueldo total (medio tiempo): {empleado2.CalcularSueldo()}");

            Console.ReadKey();

        }
    }
}
