using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla 
            //el máximo de los números pares y el mínimo de los números impares.

            int n, maxPar=0, minImpar=0;

            for (int x = 0; x < 19; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n=int.Parse(Console.ReadLine());

                if(x==0){
                    maxPar=n;
                    minImpar=n;
                }

                if(n%2==0 && n>maxPar){
                    maxPar=n;
                }
                if(n%2!=0 && n<minImpar){
                    minImpar=n;
                }
            }

            Console.WriteLine("El mayor de los números pares es: "+maxPar+Environment.NewLine+"El menor de los números impares es: "+minImpar);
        }
    }
}
