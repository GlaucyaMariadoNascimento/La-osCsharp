using System;



namespace La_osCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resultado;

            Console.WriteLine("Digite um número para obter sua tabuada: " + "\n");
            num = Convert.ToInt16(Console.ReadLine());

            for (int cont = 1; cont <= 10; cont ++) {
                resultado = num * cont;
                Console.WriteLine(+ cont + " x " + num + " = " + resultado);

            }
        }
    }
}
