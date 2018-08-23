using System;

namespace Practica_2
{
    class plan500:Planes_telefonicos
    {
        #region Constructor
        public plan500()
        {
            Extras2();
        }
        #endregion

        #region Atributos
        public string redesSociales="Tienes redes sociales ilimitadas.";
        public byte llamadasExtranjero=50;
        #endregion

        #region Mero
        public void Extras2()
        {
            costo = 500;
            megas = 5000;
            llamadas = 150;
            mensajes = 200;
            Console.WriteLine("\n*Con este plan:\n{0}\nTienes {1} llamadas al extranjero", redesSociales,llamadasExtranjero);
        }
        #endregion

    }
}
