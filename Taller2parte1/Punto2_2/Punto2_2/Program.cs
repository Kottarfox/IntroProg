namespace Punto2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nume = 0;
            int resultado;

            do
            {
                Console.Write("Ingrese el un numero entero: ");
                nume = Convert.ToInt32(Console.ReadLine());
                if (nume < 0)
                {
                    Console.WriteLine("ingrese un numero superior a 0");
                    return;
                }
                else
                {
                    Console.WriteLine("Los divisores de " + nume + " son: ");
                }

                for (int i = 1; i <= nume; i++)
                {
                    if (i <= nume)
                    {
                        resultado = nume % i;

                        if (resultado == 0) { Console.Write(" " + i + " "); }
                    }
                }
            } while (nume > 0);

        }
    }
 }