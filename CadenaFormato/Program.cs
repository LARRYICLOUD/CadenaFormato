using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaFormato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");

            //Cadenas de formato
            //Insetando un marcador de posicion
            //insertando expresiones interpoladas
            //Formato compuesto

            int num1 = 5; 
             int   num2 = 10;
            int num3 = 5722;
            Console.WriteLine("El primer valor es: {0}, y el segundo valor es: {1}, el tercer valor es: {2}", num1, num2, num3);

            string cadena3;

            cadena3 = String.Format("El valor es {0}", num3);
            Console.WriteLine(cadena3);

            //Caracter de cadena interpolada $ signo pesos

            int numero1 = 2, numero2 = 3, numero3 = 4;
            // Una "literal de cadena entrecomillas", es la tipica cadena encerrada entre comillas dobles
            Console.WriteLine($"El primer valor es: {numero1}, y el segundo valor es: {numero2}, el tercer valor es: {numero3}");

            //el caracter $ va antes de las comillas dobles de la primera cadena

        }
    }
}
