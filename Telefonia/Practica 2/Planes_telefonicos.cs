using System;

namespace Practica_2
{
    class Planes_telefonicos
    {
        #region Atributos
        public ushort costo;
        public ushort megas;
        public byte llamadas;
        public byte mensajes;
        #endregion

        #region Métodos
        public void Precio()
        {
            Console.WriteLine("El precio del plan es de $"+this.costo);
        }

        public void Datos()
        {
            Console.WriteLine("Este plan te ofrece {0} MB.", this.megas);
        }

        public void Telefono()
        {
            Console.WriteLine("Tienes {0} llamadas y {1} mensajes de texto para utilizar.", this.llamadas, this.mensajes);
        }
        #endregion

    }
}
