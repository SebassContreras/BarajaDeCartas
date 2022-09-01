using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajaDeCartas
{
    class Carta
    {
        int numero;
        int palo;
        string[] palos = { "Diamantes", "Picas", "Corazones", "treboles" };
        string[] tipo = { "As", "Jota", "Reina", "Rey" };

        public Carta(int n, int p)
        {
            numero = n;
            palo = p;
        }

        public void escribeCarta()
        {
            switch (numero)
            {
                case 1:
                    Console.WriteLine(tipo[0] + " de " + palos[palo]);
                    break;
                case 10:
                    Console.WriteLine(tipo[1] + " de " + palos[palo]);
                    break;
                case 11:
                    Console.WriteLine(tipo[2] + " de " + palos[palo]);
                    break;
                case 12:
                    Console.WriteLine(tipo[3] + " de " + palos[palo]);
                    break;
                default:
                    Console.WriteLine(numero + " de " + palos[palo]);
                    break;
            }    
        }
    }
}
