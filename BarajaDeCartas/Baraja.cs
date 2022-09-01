using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajaDeCartas
{
    class Baraja
    {
        List<Carta> baraja = new List<Carta>();
        Carta card;

        public Baraja()
        {
            int i, j;

            for (j = 0; j < 4; j++)
            {
                for (i = 0; i < 12; i++)
                {
                    card = new Carta(i + 1, j);
                    baraja.Add(card);
                }
            }
        }
        public void numCartas()
        {
            Console.WriteLine("En la baraja hay " + baraja.Count + " cartas.");
        }
        public void robaCarta()
        {
            Console.WriteLine("Has robado una carta: ");

            baraja[0].escribeCarta();
            baraja.Remove(baraja[0]);
        }
        public void cogeCarta(int n)
        {
            Console.WriteLine("Has cogido la carta de la posición: " + n);
            baraja[n].escribeCarta();
            baraja.Remove(baraja[n]);
        }
        public void cogeCartaAlAzar()
        {
            Random r = new Random();
            int n = r.Next(0, baraja.Count);

            Console.WriteLine("Has cogido una carta al azar: ");
            baraja[n].escribeCarta();
            baraja.Remove(baraja[n]);
        }
        public void escribeBaraja()
        {
            int i;
            Console.WriteLine("La Baraja es");

            for (i = 0; i < baraja.Count; i++)
            {
                Console.Write((i + 1) + ". ");

                baraja[i].escribeCarta();
            }
        }
        public void Barajar()
        {
            Random r = new Random();
            int posicion;
            int i;

            for (i = 0; i < 48; i++)
            {
                posicion = r.Next(0, 48);
                baraja.Insert(posicion, baraja[0]);
                baraja.Remove(baraja[0]);
            }
        }
    }
}

