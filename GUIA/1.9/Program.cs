/*Una permutación es una secuencia que contiene cada elemento de 1 a N una vez, y solo
una vez. Suponiendo que se ingresa un arreglo unidimensional de tamaño N, determinar
mediante una función si dicho arreglo representa o no una permutación.
El programa debe solicitar el tamaño del arreglo, a continuación, sus elementos e
invocar una función de retorno boolean que devuelva true en caso de tratarse de una
permutación o false en caso contrario.*/

internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        int[] secuence = new int[i];

        Console.Write("Ingrese el tamanio del arreglo: ");
        i = int.Parse(Console.ReadLine());

        for (int j = 0; j <= i; j++)
        {
            Console.Write("Elemento {0}: ", j + 1);

            if (int.TryParse(Console.ReadLine(), out int val))
            {
                secuence[j] = val;
            }
            else
            {
                Console.WriteLine("Ingrese un valor numérico válido.");
                j--;
            }
        }

        IsPermutation(secuence, i);
    }

    static bool IsPermutation(int[] permutation, int length)
    {
        for (int i = 0; i <= length; i++)
        {
            int value = i - 1;
            if (permutation[i] <= permutation[value])
            {
                return false;
            }
        }
        return true;
    }
}