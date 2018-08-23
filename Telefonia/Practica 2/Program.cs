using System;

namespace Practica_2
{
    class Program
    {
        static void Main()
        {
            Planes_telefonicos miPlan = new Planes_telefonicos();
            plan200 PLAN200 = new plan200();
            plan500 PLAN500 = new plan500();
            Console.WriteLine("Selecciona el plan que quieres consultar:\na.- PLAN 200\nb.- PLAN 500");
            string w = Console.ReadLine();
            if (w=="a")
            {
                Console.WriteLine("[PLAN 200]");
                PLAN200.Extras1();

                PLAN200.costo = 100;
                PLAN200.megas = 1000;
                PLAN200.llamadas = 50;
                PLAN200.mensajes = 100;

                miPlan.Precio();
                miPlan.Datos();
                miPlan.Telefono();
            }
            else if(w=="b")
            {
                Console.WriteLine("[PLAN 500]");
                PLAN500.Extras2();

                PLAN500.costo = 500;
                PLAN500.megas = 5000;
                PLAN500.llamadas = 150;
                PLAN500.mensajes = 200;

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
