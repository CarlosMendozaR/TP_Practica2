using System;

namespace Practica_2
{
    class Program
    {
        static void Main()
        {
            
            Planes_telefonicos miPlan = new Planes_telefonicos();
            
            Console.WriteLine("Selecciona el plan que quieres consultar:\na.- PLAN 200\nb.- PLAN 500");
            string w = Console.ReadLine();
            if (w=="a")
            {
                Console.WriteLine("[PLAN 200]");
                miPlan.Precio();
                miPlan.Datos();
                miPlan.Telefono();
            }
            else if(w=="b")
            {
                Console.WriteLine("[PLAN 500]");
                miPlan.Precio();
                miPlan.Datos();
                miPlan.Telefono();
            }
            else
            {
                Console.WriteLine("Has ingresado una opción no válida.");
            }


        }
    }
}
