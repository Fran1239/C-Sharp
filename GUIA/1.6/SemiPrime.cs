/*Un semi-primo es un número natural que es el producto de dos números primos no
necesariamente distintos. Por ejemplo, los números 4, 6, 9, 10, 14, 15, 21, 22, 25, 26, son
semi-primos. Dado un numero entero X determinar mediante una función de retorno
boolean si se trata de un número semi-primo.*/

internal class SemiPrime
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un valor: ");
        int num = int.Parse(Console.ReadLine());

        FindPrimePairs(num);

    }

    static bool IsPrime(int primNum)
    {
        int Count = 0;

        for (int i = 1; i <= primNum; i++)
        {
            if (primNum % i == 0)
            {
                Count++;
            }
        }

        while (Count == 2)
        {
            return true;
            break;

        } 

        return false;
    }

    static bool FindPrimePairs(int num)
    {
        int possiblePrime1 = 0;
        int possiblePrime2 = 0;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                possiblePrime1 = i;
                possiblePrime2 = num / i;

                while (IsPrime(possiblePrime1) == true && IsPrime(possiblePrime2) == true && possiblePrime1 * possiblePrime2 == num)
                {
                    Console.WriteLine("Si es numero semi-primo");
                    return true;
                    break;
                }
            }
        }
        Console.WriteLine("No es un numero semi-primo");
        return false;
    }

}