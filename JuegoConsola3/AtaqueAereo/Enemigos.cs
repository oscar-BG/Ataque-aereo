using System;
using System.Collections.Generic;
using System.Text;

namespace AtaqueAereo
{
    class Enemigos
    {
        private int c;
        private int longitud;
        private int suma;
        
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
                suma = value;
                if (suma > 0)
                {
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
            }
            get
            {
                return longitud;
            }
        }

        public int enemigos2
        {
            set
            {
                suma = value;
                if (suma > 0)
                {
                    c = suma;
                    longitud = 60 - c;
                    int longBlanco = longitud + 1;
                    if (longitud > 0)
                    {
                        Console.SetCursorPosition(longitud, 10);
                        sking_enemigo();
                        for (int a = 0; a < 100000; a++)
                        {

                        }
                        Console.SetCursorPosition(longBlanco, 10);
                        campoBlanco();
                        if (longitud == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(1, 10);
                            Console.WriteLine("+");
                        }
                    }
                }
            }
            get
            {
                return longitud;
            }
        }

        public int enemigos3
        {
            set
            {
                suma = value;
                if (suma > 0)
                {
                    c = suma;
                    longitud = 60 - c;
                    int longBlanco = longitud + 1;
                    if (longitud > 0)
                    {
                        Console.SetCursorPosition(longitud, 8);
                        sking_enemigo();
                        for (int a = 0; a < 100000; a++)
                        {

                        }
                        Console.SetCursorPosition(longBlanco, 8);
                        campoBlanco();
                        if (longitud == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(1, 8);
                            Console.WriteLine("+");
                        }
                    }
                }
            }
            get
            {
                return longitud;
            }
        }

        public int enemigos4(int value, int y)
        {
            suma = value;
            if (suma > 0)
            {
                c = suma;
                longitud = 60 - c;
                int longBlanco = longitud + 1;
                if (longitud > 0)
                {
                    Console.SetCursorPosition(longitud,y);
                    sking_enemigo();
                    for (int a = 0; a < 100000; a++)
                    {

                    }
                    Console.SetCursorPosition(longBlanco, y);
                    campoBlanco();
                    if (longitud == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(1, y);
                        Console.WriteLine("+");
                    }
                }
            }
            return longitud;
        }


    }
}
