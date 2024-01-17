/*Leer la cantidad de elementos de un vector y los datos en él. A continuación, reorganizar
el arreglo en modo que los valores impares queden en el primer tramo del arreglo y los
pares detrás.*/

using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> values = new List<int>();

        Console.WriteLine("Ingrese elementos a la lista (ingrese un valor no numérico para finalizar):");

        for (int i = 0; ; i++)
        {
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int elemento))
            {
                values.Add(elemento);
            }
            else
            {
                break;
            }

            OrderEvenOdd(values);

    }

    static void OrderEvenOdd(List<int> orderedevenodd)
    {
        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        int j = 0;

        for (int i = 0; i <= orderedevenodd.Count; i++)
        {
            if (orderedevenodd[i] % 2 == 0)
            {
                even.Add(i);
            }
            else
            {
                odd.Add(i);
            }
        }

        OrderValuesList(even);
        OrderValuesList(odd); 

        Console.Write("Lista ordenada de menor a mayor y de impar a par: ");

        for (int i = 0; i < orderedevenodd.Count; i++)
        {
            Console.WriteLine(odd[i]);
        }

        for (int i = 0; i < orderedevenodd.Count; i++)
        {
            Console.WriteLine(even[i]);
        }

    }

    static List<int> OrderValuesList(List<int> values)
    {
        int countj = 0;
       
        while (countj != values.Count)
        {
            for (int i = 0; i <= values.Count; i++)
            {
                if (values[i] > values[i++])
                {
                    values[i] = values[i++];
                    countj++;
                }
            }
        }

        return values;
    }

}