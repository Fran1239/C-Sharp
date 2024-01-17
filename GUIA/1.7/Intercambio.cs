/*Escribir una función que intercambie el valor de dos variables, es decir si X=5 e Y=7 tras
aplicar la función, por ejemplo haciendo "intercambiar(X,Y)" se tiene que X=7 e Y=5.*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el valor de X: ");
        decimal X = decimal.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de Y: ");
        decimal Y = decimal.Parse(Console.ReadLine());

        decimal Z = X;
        X = Y;
        Y = Z;

        Console.Write("X = {0} \nY = {1}", X, Y);
    }
}