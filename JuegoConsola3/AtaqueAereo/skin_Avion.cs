using System;
using System.Collections.Generic;
using System.Text;

namespace AtaqueAereo
{
    class skin_Avion
    {
        Enemigos enemigos = new Enemigos();
        public int x = 5;
        public int y = 10;
        private int incremento = 0;
        private int incremento2 = 0;
        private int uno = 1;
        private int uno2 = 1;
        
        private void dibuja_Avion()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("═╞");
        }
        private void campoBlanco()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("■■");
        }
        private void campoBlancoFuego()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("+");
        }

        public void  avion()
        {
            ConsoleKeyInfo keyInfo;

            do
            {
                incremento = incremento + uno;
                incremento2 = incremento2 + uno2;
                Console.SetCursorPosition(x, y);
                dibuja_Avion();
                keyInfo = Console.ReadKey();
                
                while (keyInfo.Key == ConsoleKey.UpArrow) //Tecla arriba
                {
                    y -= 1;
                    Console.SetCursorPosition(x, y);
                    dibuja_Avion();
                    Console.SetCursorPosition(x, y + 1);
                    campoBlanco();
                    
                    if (y==0)
                    {
                        y += 1;
                    }
                    
                    break;
                }

                while (keyInfo.Key == ConsoleKey.DownArrow) //Tecla abajo
                {
                    y += 1;
                    Console.SetCursorPosition(x, y);
                    dibuja_Avion();
                    Console.SetCursorPosition(x, y - 1);
                    campoBlanco();
                    if (y==20)
                    {
                        y -= 1;
                    }
                    break;
                }

                while (keyInfo.Key == ConsoleKey.LeftArrow)// Tecla Izquierda
                {
                    x -= 1;
                    Console.SetCursorPosition(x, y);
                    dibuja_Avion();
                    Console.SetCursorPosition(x+1, y);
                    campoBlanco();
                    if (x==0)
                    {
                        x += 1;
                    }
                    break;
                }

                while (keyInfo.Key == ConsoleKey.RightArrow) //Tecla Derecha
                {
                    x += 1;
                    Console.SetCursorPosition(x, y);
                    dibuja_Avion();
                    Console.SetCursorPosition(x - 1, y);
                    campoBlanco();
                    if (x==60)
                    {
                        x -= 1;
                    }
                    break;
                }
                

                if (keyInfo.Key == ConsoleKey.D)
                {
                    teclaD();
                }
               
                enemigos.enemigos=incremento; //Uso de Set de la clase Enemigos
                enemigos.enemigos2 = incremento2;
            } while (true);
            
        }

        private void teclaD()
        {
            int posicionActual = x + 2;
            int posicionRecorrer = 60 - posicionActual;
            int recibirlog;
            int recibirlog2;
            recibirlog = enemigos.enemigos; //Hacemos uso de get de la clase Enemigos
            recibirlog2 = enemigos.enemigos2;
            for (int i = 1; i < posicionRecorrer; i++)
            {

                Console.SetCursorPosition(posicionActual + i, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(">");
                if (posicionActual + i == recibirlog && y == 5)
                {
                    incremento = 0;
                    uno = 0;
                }
                else if (posicionActual + i == recibirlog2 && y == 10)
                {
                    incremento2 = 0;
                    uno2 = 0;
                }
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
