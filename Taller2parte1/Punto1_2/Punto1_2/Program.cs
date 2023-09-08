namespace Punto1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calif = " ";
            double calif1 = 0;
            int contador = 0;
            double acumulador = 0;
            double acumulador2 = 0;

            do
            {
                Console.WriteLine("Desea ingresar una nota?");
                Console.WriteLine("Si para continuar - No para finalizar");
                calif = Console.ReadLine();
                if ((calif == "Si" || calif == "si"))
                {
                    contador++;
                    Console.WriteLine("ingrese una calificacion (recuerde que para decimales se usa , coma ");
                    calif1 = Convert.ToDouble(Console.ReadLine());
                    acumulador = (calif1 + acumulador);
                }

                acumulador2 = acumulador / contador;

            } while ((calif == "Si" || calif == "si"));

            Console.WriteLine("el promedio de las notas es " + acumulador2);
        }
    }
}