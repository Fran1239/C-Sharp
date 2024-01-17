//Obtener una función recursiva que calcule el factorial de un numero N.

internal class Factorial
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el valor a ser factorizado: ");
        double N = double.Parse(Console.ReadLine());

        double rta = CalculoFactorial(N);

        Console.WriteLine("El factorial de " + N + " es: " + rta);
    }

    static double CalculoFactorial(double n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * CalculoFactorial(n - 1);
        }
    }
}
