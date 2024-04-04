using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y 
            //la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado 
            //que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

            //a. declaro las varibles (nombre y tipo).
            float distancia;
            float velocidad;
            float tiempo;

            //b. pido, leo y guardo los datos.
            Console.WriteLine("Ingrese la distancia. (Kilométros)");
            distancia = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad del vehículo. (Kilométros/Hora)");
            velocidad = float.Parse(Console.ReadLine());

            //c. calculo.
            tiempo = distancia/velocidad;

            //d. muestro el resultado.
            Console.WriteLine("El tiempo aproximado que el vehículo tardara en recorrer " + distancia + "km a una velocidad promedio de " + velocidad + "km/h es de: " + tiempo.ToString("0.00") + " horas.");
        }
    }
}
