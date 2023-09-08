namespace Punto4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int tiempo = 0;
            bool bajo15 = false;
            int prom = 0;
            int acumulador = 0;


            do
            {
                Console.WriteLine("ingrese el tiempo");
                tiempo = Convert.ToInt32(Console.ReadLine());
                if (tiempo > 20)
                {
                    Console.WriteLine("no es apto");
                    Console.ReadLine();

                    return;
                }
                else
                {
                    if (tiempo < 15)
                    {
                        bajo15 = true;
                        contador++;

                    }
                    else
                    {
                        contador++;
                    }
                }

                acumulador = acumulador + tiempo;

            } while (contador < 10);

            prom = acumulador / 10;

            if (bajo15 || prom <= 18)
            {
                Console.WriteLine("es apto" + prom);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("no es apto" + prom);
                Console.ReadLine();

            }

        }
    }
}