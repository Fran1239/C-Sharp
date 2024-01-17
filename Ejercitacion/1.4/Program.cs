using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona p2 = new Persona();
            var numero = Console.ReadLine();
            int parsedNumber;

            

            //while (!int.TryParse(numero, out parsedNumber)) 
            //{
            //    Console.WriteLine("ESCRIBI BIEN EL NUMERO");
            //    numero = Console.ReadLine();
            //}

            //p2.Edad = parsedNumber;


            //try
            //{
            //    Persona p2 = new Persona();
            //    p2.Edad = int.Parse(Console.ReadLine());





            //}catch (Exception ex)
            //{
            //    Console.WriteLine("Escribi bien el tipo de dato salame");
            //    Console.Write(ex.ToString());

            //}
            //Persona p1 = new Persona("Franco",20, "H", 85, 1.86);
            Console.WriteLine(p2.fede());

            Console.Read();
            //Console.WriteLine("Nombre: ");


        }
    }
}
