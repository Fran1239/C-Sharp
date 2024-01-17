/*Representar un polinomio completo de grado n mediante un arreglo. Ingresar el grado del
polinomio y sus coeficientes. A continuación, ingresar un valor x y calcular el polinomio
evaluado en ese valor. Utilizar funciones en la resolución.*/

internal class Polynoms
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el grado del polinomio: ");
        int degree = int.Parse(Console.ReadLine());

        int[] coefficients = new int[degree + 1];

        for (int i = 0; i <= degree; i++)
        {
            Console.Write("Ingrese el coeficiente " + (i + 1) + " del polinomio: ");
            coefficients[i] = int.Parse(Console.ReadLine());
        }

        CalculatePolynomial(coefficients, degree);

    }

    static void CalculatePolynomial(int[] coefficients, int degree)
    {
        int cont = degree;
        int polynomial = 0;
        bool isDegreeNull = false;

        Console.Write("Ingrese un numero para valuar el polinomio en ese valor: ");
        int X = int.Parse(Console.ReadLine());

        for (int i = 0; i <= degree; i++)
        {
            int valor = (int)(coefficients[i] * Math.Pow(X, cont));
            polynomial += valor;
            cont--;
        }
        Console.WriteLine(polynomial);

    }
}