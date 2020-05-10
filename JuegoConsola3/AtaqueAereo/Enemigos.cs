using System;
using System.Collections.Generic;
using System.Text;

namespace AtaqueAereo
{
    class Enemigos
    {
        private int c;
        private int longitud;
        
        private void sking_enemigo()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("╣");
        }
        private void campoBlanco()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("X");
        }
        private void colocarEnemigo()
        {

        }
        public void enemigos(int suma)
        {
            Random random = new Random();
            c = suma;
            longitud = 60 - c;
            int longBlanco = longitud + 1;
            
            int y = random.Next(1,20);
            if (longitud > 0) 
            {
                Console.SetCursorPosition(longitud, y);
                sking_enemigo();
                for (int a = 0; a < 100000; a++)
                {

                }
                Console.SetCursorPosition(longBlanco, y);
                campoBlanco();

                Console.SetCursorPosition(longitud, 10);
                sking_enemigo();
                for (int a = 0; a < 100000; a++)
                {

                }
                Console.SetCursorPosition(longBlanco, 10);
                campoBlanco();

                Console.SetCursorPosition(longitud, 17);
                sking_enemigo();
                for (int a = 0; a < 100000; a++)
                {

                }
                Console.SetCursorPosition(longBlanco, 17);
                campoBlanco();
            }
        }
    }
}
