using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Persona
    {
        public Persona()
        {
            Nombre = "";
            Edad = 0;
            Sexo = "";
            Peso = 0;
            Altura = 0;
        }
        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public string fede() { return "Esta es tu edad: " + Edad; }

    }
}
