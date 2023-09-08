namespace Punto3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string afirm = " ";
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;

            do
            {
                Console.WriteLine("Desea ingresar hacer una potenciacion?");
                Console.WriteLine("Si para continuar - No para finalizar");
                afirm = Console.ReadLine();
                if ((afirm == "Si" || afirm == "si"))
                {
                    Console.WriteLine("ingrese un numero base");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese un numero exponente");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    num3 = Math.Pow(num1, num2);
                }

                Console.WriteLine(num1 + "^" + num2 + "=" + num3);


            } while ((afirm == "Si" || afirm == "si"));


        }
    }
}