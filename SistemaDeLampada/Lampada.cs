using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLampada
{
    class Lampada
    {
        bool Ligada = false;

        public void Ligar()
        {
            if (Ligada == false)
            {
                Ligada = true;
            }
        }

        public void Desligar()
        {
            if (Ligada == true)
            {
                Ligada = false;
            }
        }

        public void MostrarEstado()
        {
            if (Ligada == true)
            {
                Console.WriteLine("A lâmpada está ligada!");
            }
            else
            {
                Console.WriteLine("A lâmpada está desligada!");
            }
        }
    }
}