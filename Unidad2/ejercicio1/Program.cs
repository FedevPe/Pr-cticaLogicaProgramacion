using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

            //a. declaro varibles (nombre y tipo).
            int numero1;
            int numero2;
            int resultado;

            //b. pido, leo y guardo los datos ingresados.
            Console.WriteLine("Introduce un número");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número");
            numero2 = int.Parse(Console.ReadLine());

            //c. calculo.
            resultado = numero1 + numero2;

            //d. muestro el resultado.
            Console.WriteLine("El resultado es:" + resultado);

        }
    }
}
