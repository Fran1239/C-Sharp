/*Un grillo se encuentra de un lado de la calle y necesita llegar hasta el otro lado.
Suponiendo que se encuentra actualmente en la posición X y que quiere llegar a la
posición Y tal que, Y es mayor o igual que X, determine la cantidad mínima de saltos que
el grillo debe realizar para alcanzar su objetivo. Considere que el grillo siempre salta una
distancia fija, D.
El programa debe solicitar el ingreso de tres enteros X, Y y D y mediante una función
calcular y posteriormente mostrar el mínimo número de saltos necesarios.*/

using System;

namespace Grillo
{
    class Grillo
    {
        static void Main(string[] args)
        {
            double D = 0, Y = 0; 

            Console.WriteLine("Ingrese la posicion de salida del grillo: ");
            string partida = Console.ReadLine();
            double X = Convert.ToInt32(partida);

            do
            {
                Console.WriteLine("Ingrese la posicion de llegada del grillo: ");
                string llegada = Console.ReadLine();
                Y = Convert.ToInt32(llegada);
            } while (Y <= X);

            do
            {
                Console.WriteLine("Ingrese la longitud del salto del grillo: ");
                string salto = Console.ReadLine();
                D = Convert.ToInt32(salto);
            } while (D > (Y - X) || D == 0);

            double S = (Y - X) / D;

            int CantS = (int)Math.Round(S);
            Console.WriteLine("La cantidad minima de saltos que debe realizar el grillo para llegar a la meta es de " + CantS);
        }
    }
}


