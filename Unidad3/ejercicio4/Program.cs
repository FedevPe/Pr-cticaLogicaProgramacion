using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

            float n1, n2, n3, n4;
            float menor;
            
            Console.WriteLine("Ingrese el primer número:");
            n1=float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            n2=float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            n3=float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número:");
            n4=float.Parse(Console.ReadLine());

            if(n1<n2){
                menor=n1;
            }else{
                menor=n2;
            }
            if (n3<menor){
                menor=n3;
            }
            if (menor>n4){
                menor=n4;
            }
            
            Console.WriteLine("El menor de los números es: " + menor);
            
        }
    }
}
