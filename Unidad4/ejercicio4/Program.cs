using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
            //si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            float n1, n2, n3;

            Console.WriteLine("Ingrese el primer número:");
            n1=float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            n2=float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            n3=float.Parse(Console.ReadLine());

            if ((n1+n2)>(n2*n3)){
                Console.WriteLine("La suma del primer número ("+n1+" + "+n2+")"+Environment.NewLine+"es mayor al producto del segundo con el tercer número ("+n3+" x "+n2+").");
            }

        }
    }
}