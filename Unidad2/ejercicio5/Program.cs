using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno 
            //y luego calcule y emita por pantalla el promedio final.

            //a. declaro variables.
            float nota1;
            float nota2;
            float nota3;
            float resultado;

            //b. pido, leo y guardo los datos ingresados.
            Console.WriteLine("Introduce la primera nota. (1-10)");
            nota1=float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la segunda nota. (1-10)");
            nota2=float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la tercera nota. (1-10)");
            nota3=float.Parse(Console.ReadLine());

            //c. calculo.
            resultado=(nota1+nota2+nota3)/3;

            //d. muestro el resultado.
            Console.WriteLine("El promedio es de: " + resultado.ToString("0.00"));
                            
        }
    }
}
