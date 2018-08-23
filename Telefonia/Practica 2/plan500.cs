using System;

namespace Practica_2
{
    class plan500:Planes_telefonicos
    {
        #region Atributos
        public string redesSociales="Tienes redes sociales ilimitadas.";
        public byte llamadasExtranjero=50;
        #endregion
        public void Extras2()
        {
            Console.WriteLine("\n*Con este plan:\n{0}\nTienes {1} llamadas al extranjero", redesSociales,llamadasExtranjero);
        }


    }
}
