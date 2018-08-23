using System;

namespace Practica_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Selecciona el plan que quieres consultar:\na.- PLAN 200\nb.- PLAN 500");
            string w = Console.ReadLine();
            if (w=="a")
            {
                Console.WriteLine("[PLAN 200]");
                plan200 miPlan200 = new plan200();
                miPlan200.Precio();
                miPlan200.Datos();
                miPlan200.Telefono();

                Console.ReadLine();
            }
            else if(w=="b")
            {
                Console.WriteLine("[PLAN 500]");
                plan500 miPlan500 = new plan500();
                miPlan500.Precio();
                miPlan500.Datos();
                miPlan500.Telefono();

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Has ingresado una opción no válida.");
            }


        }
    }
}
