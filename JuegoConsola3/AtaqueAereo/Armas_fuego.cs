using System;
using System.Collections.Generic;
using System.Text;

namespace AtaqueAereo
{
    class Armas_fuego
    {
        skin_Avion avion = new skin_Avion();
        private void campoBlancoFuego()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("+");
        }

        public void set_ataqueDelantero()
        {
            int x = avion.get_AtacarX();
            int y = avion.get_AtacarY();

            int posicionActual = x + 2;
            int posicionRecorrer = 60 - posicionActual;

            for (int i = 1; i < posicionRecorrer; i++)
            {

                Console.SetCursorPosition(posicionActual + i, y);
                Console.Write(">");

                for (int t = 0; t < 1000000; t++)
                {

                }

            }
            for (int i = 0; i < posicionRecorrer; i++)
            {
                Console.SetCursorPosition(posicionActual + i, y);
                campoBlancoFuego();
                for (int a = 0; a < 10000; a++)
                {

                }
            }
        }
    }
}
