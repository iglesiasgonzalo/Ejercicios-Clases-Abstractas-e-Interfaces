using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_abstractas_Interfaces_Ejercicio_3
{
    internal class Program
    {

        public interface IControladorApi
        {
            string Get(int id);
            void Post(string nuevo);
            void Put(int id, string cambio);
            void Delete(int id);
        }

        public abstract class EntidadBase
        {
            private int id;
            private string datos;

            public void SetId(int id)
            {
                this.id = id;
            }

            public int GetId()
            {
                return id;
            }

            public void SetDatos(string datos)
            {
                this.datos = datos;
            }

            public string GetDatos()
            {
                return datos;
            }
        }

        public class Usuario : EntidadBase, IControladorApi
        {
            private static Dictionary<int, string> baseDatosSimulada = new Dictionary<int, string>();

            public string Get(int id)
            {
                if (baseDatosSimulada.ContainsKey(id))
                {
                    SetId(id);
                    SetDatos(baseDatosSimulada[id]);
                    return $"GET: Usuario {GetId()} → {GetDatos()}";
                }
                return $"GET: Usuario con id {id} no encontrado.";
            }

            public void Post(string nuevo)
            {
                int nuevoId = baseDatosSimulada.Count + 1;
                baseDatosSimulada[nuevoId] = nuevo;
                Console.WriteLine($"POST: Usuario creado con id {nuevoId} → {nuevo}");
            }

            public void Put(int id, string cambio)
            {
                if (baseDatosSimulada.ContainsKey(id))
                {
                    baseDatosSimulada[id] = cambio;
                    Console.WriteLine($"PUT: Usuario {id} actualizado → {cambio}");
                }
                else
                {
                    baseDatosSimulada[id] = cambio;
                    Console.WriteLine($"PUT: Usuario nuevo creado con id {id} → {cambio}");
                }
            }

            public void Delete(int id)
            {
                if (baseDatosSimulada.Remove(id))
                    Console.WriteLine($"DELETE: Usuario con id {id} eliminado.");
                else
                    Console.WriteLine($"DELETE: Usuario con id {id} no encontrado.");
            }
        }



        static void Main(string[] args)
        {
            public static void Main()
        {
            Usuario usuarioApi = new Usuario();

            usuarioApi.Post("Juan Pérez");
            usuarioApi.Post("Ana Gómez");

            Console.WriteLine(usuarioApi.Get(1));
            Console.WriteLine(usuarioApi.Get(2));

            usuarioApi.Put(2, "Ana González");
            Console.WriteLine(usuarioApi.Get(2));

            usuarioApi.Delete(1);
            Console.WriteLine(usuarioApi.Get(1));
        }
    }
    }
}
