/*Dados tres valores enteros A, B y K, determine, mediante una función la cantidad de
números divisibles por K que se encuentran en el entorno A, B.*/

internal class Divisibles
{
    private static void Main(string[] args)
    {
        int B = 0, contj = 1;

        Console.Write("Ingrese el valor de A: ");
        string Ast = Console.ReadLine();
        int A = int.Parse(Ast);

        do
        {
            Console.Write("Ingrese el valor de B: ");
            string Bst = Console.ReadLine();
            B = int.Parse(Bst);
        } while (B < A);

        Console.Write("Ingrese el valor de K: ");
        string Kst = Console.ReadLine();
        int K = int.Parse(Kst);

        for (int i = A; i <= B; i++)
        {
            int rta = K % i;
           
            if (rta == 0)
            {
                Console.Write(contj + ") " + i + "\n");
                contj++;
            }
        }
    }
}