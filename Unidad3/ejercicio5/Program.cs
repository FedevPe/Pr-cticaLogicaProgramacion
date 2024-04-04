using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

            float n1, n2, n3, n4;
                        
            Console.WriteLine("Ingresa el primer número:");
            n1= float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número:");
            n2= float.Parse(Console.ReadLine());           
            Console.WriteLine("Ingresa el tercer número:");
            n3= float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el cuarto número:");
            n4= float.Parse(Console.ReadLine());

            if(n1>100){
                Console.WriteLine("El número: " + n1 + " es mayor a 100");
            }
            if (n2>100){
                Console.WriteLine("El número: " + n2 + " es mayor a 100");
            }
            if (n3>100){
                Console.WriteLine("El número: " + n3 + " es mayor a 100");
            }
            if (n4>100){
                Console.WriteLine("El número: " + n4 + " es mayor a 100");
            }
        }
    }
}


            


