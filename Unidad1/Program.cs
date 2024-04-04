using System;

namespace primer_programa5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //paso 1: declarar variables  y aclarar el tipo de dato que contiene.

            float numero1;
            float numero2;
            float resultado;
            
            //paso 2: pedir valores y leerlos.

          Console.WriteLine("Ingrese un número");
            numero1 = float.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese otro número");
            numero2 = float.Parse(Console.ReadLine());
                            
            //paso 3: realizar cálculo.

            resultado=numero1+numero2;
            
            //paso 4: emitir el resultado.
          
          Console.WriteLine("El resultado es: " + resultado);
        } 
    }
}         