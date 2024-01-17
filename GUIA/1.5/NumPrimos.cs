/*Un número primo es un número entero positivo X que tiene solamente dos divisores
distintos: 1 y X. Los primeros números enteros primos son 2, 3, 5, 7, 11 y 13.
Un numero primo D se llama divisor primo de un entero positivo P si existe un entero
positivo K tal que D * K = P. Por ejemplo, 2 y 5 son divisores primos de 20.
Suponiendo que se dan dos enteros positivos N y M, obtener una función de retorno
boolean que permita verificar N y M tienen el mismo conjunto de divisores primos. Por
ejemplo:
N = 15 y M = 75, los divisores primos son los mismos: {3, 5}.
N = 10 y M = 30, los divisores primos no son los mismos: {2, 5} no es igual a {2, 3, 5}.*/

using System.Collections.Generic;
using System.ComponentModel;

internal class NumPrimos
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un numero: ");
        int M = int.Parse(Console.ReadLine());
        Console.Write("Ingrese un numero: ");
        int N = int.Parse(Console.ReadLine());

        List<int> PrimeN = CalculatePrimeNum(N);
        List<int> PrimeM = CalculatePrimeNum(M);

        EqualPrimeDivisors(PrimeM, PrimeN).ForEach(p => Console.WriteLine(p.ToString()));

    }

    static bool IsPrime(int num)
    {
        int Count = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                Count++;
            }
        }
        if (Count > 2)
        {
            return false;
        }
        return true;
    }

    static List<int> CalculatePrimeNum(int num)
    {
        List<int> PrimeNum = new List<int>();

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                if (IsPrime(i))
                {
                    PrimeNum.Add(i);
                }
           
            }
        }
        return PrimeNum;
    } 

    static List<int> EqualPrimeDivisors(List<int> ListM, List<int> ListN)
    {
        bool isEqual = true;

        if (ListM.Count != ListN.Count || (ListN.Count == 0 && ListM.Count == 0))
        {
            isEqual = false;
        }

        for (int i = 0; i < ListM.Count; i++)
        {
            if (ListM.ElementAt(i) != ListN.ElementAt(i))
            {
                isEqual = false;
                break;
            }
        }

        if (!isEqual)
        {
            Console.WriteLine("...No poseen los mismos divisores primos...");
            return new List<int>();
        }
        else
        {
            Console.Write("Los dos numeros ingresados si poseen el mismo conjunto de divisores primos: ");
            return ListM;
        }
    }

}



