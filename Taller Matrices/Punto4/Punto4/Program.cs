namespace Punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int columnas = 0;
            int[,] matriz = new int[3, 4];
            int[] sumfi = new int[3];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Por favor, ingrese un número para la casilla con posición: " + i + "," + j);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumfi[i] = matriz[i, j] + sumfi[i];
                }
            }
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumfi[i] = matriz[i, j] + sumfi[i];
                }
            }
            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumfi[i] = matriz[i, j] + sumfi[i];
                }
            }


            Console.WriteLine("\nEl contenido de la matriz es:\t");

            for (filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for (columnas = 0; columnas < matriz.GetLength(1); columnas++)
                    Console.Write($"{matriz[filas, columnas]} \t");

                Console.WriteLine();
            }


            Console.WriteLine("La suma de la primera fila es de " + sumfi[0]);
            Console.WriteLine("La suma de la segunda fila es de " + sumfi[1]);
            Console.WriteLine("La suma de la tercera fila es de " + sumfi[2]);

        }
    }
}