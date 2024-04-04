using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule 
            //el promedio de edad de aquellas personas mayores a 18 años.

            int edad, acumulador=0, promedio, contador=0;

            for (int x = 0; x < 19; x++)
            {
                Console.WriteLine("Ingrese el valor: ");
                edad=int.Parse(Console.ReadLine());

                if(edad>18){
                    acumulador+=edad;
                    contador++;
                }
            }
            
            promedio=acumulador/contador;

            Console.WriteLine("El promedio de edad de las personas mayores a 18 ("+contador+") es de: "+promedio);
        }
    }
}
