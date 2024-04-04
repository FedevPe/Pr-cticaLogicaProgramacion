using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar un número y luego se emita por pantalla
            //un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

            //declaro la variable (nombre y tipo)

            int numero;

            //pido, leo y guardo el dato

            Console.WriteLine("Ingrese un número");
            numero = int.Parse(Console.ReadLine());

            //condicional para saber si el numero es mayor o menor a 10 

            if(numero>10){
                Console.WriteLine("El número " + numero + " es mayor a 10.");  
                //instrucción del bloque verdadero,imprime en pantalla un mensaje.                                                            //imprime en pantalla un mensaje
            }else{
                Console.WriteLine("El número " + numero + " no es mayor a 10"); 
                //instrucción del bloque falso, imprime en pantalla un mensaje.
            } 
        }
    }
}
