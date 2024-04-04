using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar.
            //Para ello existe la siguiente escala de precios:

                                //i5 (1)	i7 (2)	  i9 (3)
                //8 RAM (1)	    USD 800	   USD900	  USD1200
                //16 RAM (2)	USD 900	   USD1000	  USD1400
                //32 RAM (3)	USD 1000   USD1400    USD 2000

            //Además, el equipo viene con un disco que permite almacenar 500 GB de información 
            //y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
            //Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, 
            //y si extiende el disco o no y calcule y emita por pantalla el monto de la máquina seleccionada.

            int procesador = 0, ram = 0, disco = 0; 
            float importe = 0 ;
            bool x=true, y=true, z=true;

            //Console.WriteLine("¿Qué procesador desea?"+Environment.NewLine+"1. i5 "+Environment.NewLine+"2. i7"+Environment.NewLine+"3. i9");
            //procesador=int.Parse(Console.ReadLine());

            Console.WriteLine("¿Qué procesador desea?"+Environment.NewLine+"1. i5 "+Environment.NewLine+"2. i7"+Environment.NewLine+"3. i9");
            
            while(x){
                procesador=int.Parse(Console.ReadLine());

                if (procesador>=1 && procesador<=3){
                    x=false;
                }else{
                    Console.WriteLine("Eliga una opción de la lista de procesadores.");
                }
            }
            
            Console.WriteLine("Eliga la capacidad de la memoria RAM:"+Environment.NewLine+"1. 8Gb"+Environment.NewLine+"2. 16Gb"+Environment.NewLine+"3. 32Gb");
            
            while(y){
                ram=int.Parse(Console.ReadLine());

                if(ram>=1 && ram<=3){
                    y=false;
                }else{
                    Console.WriteLine("Eliga una opción de la lista.");
                }

            }

            Console.WriteLine("¿Desea extender la capacidad de su disco de almacenamiento?"+Environment.NewLine+"1. Si"+Environment.NewLine+"2.No");
            
            while(z){
                disco=int.Parse(Console.ReadLine());

                if(disco==1 || disco==2){
                    z=false;
                }else{
                    Console.WriteLine("Eliga una opción de la lista.");
                }
            }


            if(procesador==1 && ram==1){
                importe=800;
            }else if (procesador==1 && ram==2){
                importe=900;
            }else if (procesador==1 && ram==3){
                importe=1000;
            }

            if(procesador==2 && ram==1){
                importe=900;
            }else if (procesador==2 && ram==2){
                importe=1000;
            }else if (procesador==2 && ram==3){
                importe=1400;
            }
            
            if(procesador==3 && ram==1){
                importe=1200;
            }else if (procesador==3 && ram==2){
                importe=1400;
            }else if (procesador==3 && ram==3){
                importe=2000;
            }

            if (disco==1){
                importe+=300;
            }
            
            Console.WriteLine("El total de su compra es de: U$D "+ importe);
        }
    }
}
