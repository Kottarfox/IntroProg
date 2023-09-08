namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Ingrese el número de filas: ");
                int filas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el número de columnas: ");
                int columnas = int.Parse(Console.ReadLine());

                int[,] matriz = new int[filas, columnas];
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write("Ingrese el elemento [{0}, {1}]: ", i, j);
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Matriz ingresada:");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write("{0}\t", matriz[i, j]);
                    }
                    Console.WriteLine();
                }

                int[] sumasColumnas = new int[columnas];
                for (int j = 0; j < columnas; j++)
                {
                    for (int i = 0; i < filas; i++)
                    {
                        sumasColumnas[j] += matriz[i, j];
                    }
                }

                Console.WriteLine("Sumas de cada columna:");
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Columna {0}: {1}", j, sumasColumnas[j]);
                }

                int[] restasFilas = new int[filas];
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        restasFilas[i] -= matriz[i, j];
                    }
                }

                Console.WriteLine("Restas de cada fila:");
                for (int i = 0; i < filas; i++)
                {
                    Console.WriteLine("Fila {0}: {1}", i, restasFilas[i]);

                    Console.ReadKey();
                }
            }
        }
    }
}