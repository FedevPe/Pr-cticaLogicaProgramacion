using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada 
            //según los siguientes valores:
                //Si el importe es menor a ARS 1000, no hay descuento.
                //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
                //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla 
            //el importe final con el descuento que corresponda.

            float importe;
            float total;
            
            Console.WriteLine("Ingrese el importe de la compra realizada:");
            importe = float.Parse(Console.ReadLine());
            
            if (importe >= 5000){
                total = importe * 0.82f;
            }else if (importe>=1000){
               total = importe * 0.9f;
            }else{
                total = importe;
            }

            Console.WriteLine("El total de la compra es de: $" + total + " aplicando el descuento correspondiente.");
        }
    }
}
