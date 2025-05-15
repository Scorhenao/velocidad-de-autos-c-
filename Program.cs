using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velocidad_de_autos
{
    internal class Program
    {
        // clase array de restricciones de velocidad segun area
        public class Restricciones
        // area y velocidad
        {
            public string Area { get; set; }
            public int Velocidad { get; set; }

            //constantes de restricciones de velocidad
            public const int ZonaEscolar = 30;
            public const int ZonaUrbana = 60;
            public const int ZonaRural = 80;
            public const int RutaNacional = 100;
        }
                
              
        static void Main(string[] args)
        {

            //generar area y velocidad random con datos random 
            Random random = new Random();
            List<Restricciones> restricciones = new List<Restricciones>
            {
                new Restricciones { Area = "Zona Escolar", Velocidad = random.Next(0,200)},
                new Restricciones { Area = "Zona Urbanas", Velocidad = random.Next(0,200)},
                new Restricciones { Area = "Zona Rural", Velocidad = random.Next(0,200)},
                new Restricciones { Area = "Rutas Nacionales", Velocidad = random.Next(0,200)}
            };

            // probar cada uno e imprimir si cumple o no con las restricciones
            foreach (var restriccion in restricciones)
            {
                Console.WriteLine($"Area: {restriccion.Area}, Velocidad: {restriccion.Velocidad}");
                // fecha actual en esta iteracion 
                DateTime fechaActual = DateTime.Now;
                switch (restriccion.Area)
                {
                    case "Zona Escolar":
                        if (restriccion.Velocidad > Restricciones.ZonaEscolar)
                            Console.WriteLine($"Exceso de velocidad en la hora {fechaActual}");
                        else
                            Console.WriteLine($"Velocidad dentro de lo permitido en la hora {fechaActual}");
                        break;
                    case "Zona Urbanas":
                        if (restriccion.Velocidad > Restricciones.ZonaUrbana)
                            Console.WriteLine($"Exceso de velocidad en la hora {fechaActual}");
                        else
                            Console.WriteLine($"Velocidad dentro de lo permitido en la hora {fechaActual}");
                        break;
                    case "Zona Rural":
                        if (restriccion.Velocidad > Restricciones.ZonaRural)
                            Console.WriteLine($"Exceso de velocidad en la hora {fechaActual}");
                        else
                            Console.WriteLine($"Velocidad dentro de lo permitido en la hora {fechaActual}");
                        break;
                    case "Rutas Nacionales":
                        if (restriccion.Velocidad > Restricciones.RutaNacional)
                            Console.WriteLine($"Exceso de velocidad en la hora {fechaActual}");
                        else
                            Console.WriteLine($"Velocidad dentro de lo permitido en la hora {fechaActual}");
                        break;
                }
            }


        }
    }
}
