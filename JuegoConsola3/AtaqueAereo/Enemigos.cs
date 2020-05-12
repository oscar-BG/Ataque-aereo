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
        
        public int enemigos
        {
            set
            {
                int suma = value;
                c = suma;
                longitud = 60 - c;
                int longBlanco = longitud + 1;
                if (longitud > 0)
                {
                    Console.SetCursorPosition(longitud, 5);
                    sking_enemigo();
                    for (int a = 0; a < 100000; a++)
                    {

                    }
                    Console.SetCursorPosition(longBlanco, 5);
                    campoBlanco();
                    if (longitud == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(1, 5);
                        Console.WriteLine("+");
                    }
                }
            }
            
            get
            {
                return longitud;
            }
        }
    }
}
