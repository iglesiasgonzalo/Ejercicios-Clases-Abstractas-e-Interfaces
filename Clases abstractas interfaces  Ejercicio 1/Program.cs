using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_abstractas_interfaces__Ejercicio_1
{
    internal class Program
    {
        public interface IExportable
        {
            void Exportar(string contenido);
        }

       
        public abstract class ExportadorBase : IExportable
        {
            private string formato;

            public void SetFormato(string formato)
            {
                this.formato = formato;
            }

            public string GetFormato()
            {
                return formato;
            }

            public abstract void Exportar(string contenido);
        }

       

        public class ExportadorPDF : ExportadorBase
        {
            public override void Exportar(string contenido)
            {
                SetFormato("PDF");
                Console.WriteLine($"Exportando contenido en formato {GetFormato()}: {contenido}");
            }
        }

        public class ExportadorExcel : ExportadorBase
        {
            public override void Exportar(string contenido)
            {
                SetFormato("Excel");
                Console.WriteLine($"Exportando contenido en formato {GetFormato()}: {contenido}");
            }
        }

        public class ExportadorCSV : ExportadorBase
        {
            public override void Exportar(string contenido)
            {
                SetFormato("CSV");
                Console.WriteLine($"Exportando contenido en formato {GetFormato()}: {contenido}");
            }
        }

        static void Main(string[] args)
        {
            string contenido = "Este es el informe de las personas encuestadas.";

            IExportable[] exportadores = new IExportable[3];
            exportadores[0] = new ExportadorPDF();
            exportadores[1] = new ExportadorExcel();
            exportadores[2] = new ExportadorCSV();

            foreach (IExportable exportador in exportadores)
            {
                exportador.Exportar(contenido);
            }
            Console.ReadKey();
        }
    }
}
