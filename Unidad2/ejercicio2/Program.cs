using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

            //a. declaro varibles.
            int numero1;
            int resultado;

            //b. pido, leo y guardo los datos ingresados.
            Console.WriteLine("Introduce un número");
            numero1= int.Parse(Console.ReadLine());

            //c. calculo.
            resultado= numero1*numero1*numero1;

            //d. muestro el resultado.
            Console.WriteLine("El resultado de elevar " + numero1 + " al cubo es: " + resultado);
        }
    }
}
