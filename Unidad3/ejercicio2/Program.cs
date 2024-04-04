using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla 
            //“Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o 
            //“Cero” si el número es igual a cero.

            float numero;

            Console.WriteLine("Ingrese un número");
            numero = float.Parse(Console.ReadLine());

            if (numero == 0){
            Console.WriteLine("El número es igual a 0");
            }else if (numero > 0){
            Console.WriteLine("El número es positivo");
            }else if (numero < 0){                         
                Console.WriteLine("El número es negativo");
            }
            //en este bloque podria haber usado solo ELSE, ya que, 
            //la unica posibilidad es que el número sea negativo.
        }
    }
}
