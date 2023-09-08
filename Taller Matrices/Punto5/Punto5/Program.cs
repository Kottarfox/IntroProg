namespace Punto5
{

    struct Alumno
    {
        public string nombre;
        public int edad;
        public double promedio;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno[,] alumnos = new Alumno[5, 1];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese información del alumno {0}:", i + 1);
                Console.Write("Nombre: ");
                alumnos[i, 0].nombre = Console.ReadLine();
                Console.Write("Edad: ");
                alumnos[i, 0].edad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Promedio: ");
                alumnos[i, 0].promedio = Convert.ToDouble(Console.ReadLine());
            }

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("\nSeleccione un estudiante para ver su información (1-5):");
                Console.WriteLine("Presione 0 para salir.");

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion > 0 && opcion < 6)
                {
                    Alumno alumnoSeleccionado = alumnos[opcion - 1, 0];
                    Console.WriteLine("\nInformación del alumno {0}:", opcion);
                    Console.WriteLine("Nombre: {0}", alumnoSeleccionado.nombre);
                    Console.WriteLine("Edad: {0}", alumnoSeleccionado.edad);
                    Console.WriteLine("Promedio: {0}", alumnoSeleccionado.promedio);
                }
                else if (opcion != 0)
                {
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                }
            }
        }
    }
 }