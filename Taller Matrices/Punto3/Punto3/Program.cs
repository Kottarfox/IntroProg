namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de filas:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de columnas:");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            Console.WriteLine("Ingrese los múltiplos de 5 o 3:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int numero;
                    bool Multiplo;

                    do
                    {
                        Console.Write($"[{i}, {j}]: ");
                        numero = int.Parse(Console.ReadLine());
                        Multiplo = (numero % 3 == 0) || (numero % 5 == 0);

                        if (!Multiplo)
                        {
                            Console.WriteLine("Ingrese un múltiplo de 3 o 5.");
                        }

                    } while (!Multiplo);

                    matriz[i, j] = numero;
                }
            }

            Console.WriteLine("Matriz:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}