﻿using System;

namespace Practica_2
{
    class plan200:Planes_telefonicos
    {
        #region Atributos
        public string whatsapp="Tienes Whatsapp";
        public string facebook="Tienes Facebook";
        public string instagram="Tienes Instagram";
        #endregion

        public void Extras1()
        {
            this.costo = 100;
            this.megas = 1000;
            this.llamadas = 50;
            this.mensajes = 100;
            Console.WriteLine("*Con este plan:\n{0}\n{1}\n{2}",whatsapp,facebook,instagram);
        }
    }
}
