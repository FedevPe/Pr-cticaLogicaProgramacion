using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% 
            //sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por 
            //un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

            //Datos:
            //Sueldo fijo=$15000
            //5% comisión sobre el total facturado por empleado

            //a. declaro las variables (nombre y tipo).
            const float sueldo=15000;
            float totalFacturado;
            float total;
            const float porcentajeComision=0.05f;
            
            //b. pido, leo y guardo los datos ingresados.
            Console.WriteLine("Ingrese el total facturado.");
            totalFacturado = float.Parse(Console.ReadLine());
            
            //c. calculo.
            total = sueldo + (totalFacturado*porcentajeComision);

            //d. muestro el resultado.
            Console.WriteLine("El sueldo total corresponde a: " + total);
        }
    }
}
