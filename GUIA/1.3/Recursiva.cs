//Obtener una función recursiva que calcule el Máximo Común Divisor de dos números M y N.


using System.Security.Cryptography;

internal class Recursiva
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un primer valor: ");   
        double M = double.Parse(Console.ReadLine());

        Console.Write("Ingrese un segundo valor: ");
        double N = double.Parse(Console.ReadLine());

        double resultado = CalcularMCD(N, M);

        Console.WriteLine("El maximo comun divisor o MCD de " + N + " y " + M + " es: " + resultado);
    }

    static double CalcularMCD(double n, double m)
    {
        if (m == 0)
        {
            return n;
        }
        else
        {
            return CalcularMCD(m, n % m);
        }
    }
}