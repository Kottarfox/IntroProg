namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese el elemento [{0}, {1}]: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (matriz[i, j] > maximo)
                    {
                        maximo = matriz[i, j];
                    }
                    if (matriz[i, j] < minimo)
                    {
                        minimo = matriz[i, j];
                    }
                }
            }

            // Mostrar la matriz ingresada
            Console.WriteLine("Matriz ingresada:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Número mayor: {0}", maximo);
            Console.WriteLine("Número menor: {0}", minimo);

            Console.ReadKey();

        }
    }
}