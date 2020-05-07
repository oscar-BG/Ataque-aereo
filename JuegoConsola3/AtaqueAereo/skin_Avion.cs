using System;
using System.Collections.Generic;
using System.Text;

namespace AtaqueAereo
{
    class skin_Avion
    {
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
        public void avion()
        {
            int x = 5;
            int y = 10;
            int xAtac;
            int yAtac;
            
            ConsoleKeyInfo keyInfo;
            do
            {
                
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
                    int posicionActual = x + 2;
                    int posicionRecorrer = 60 - posicionActual;
              
                    for (int i = 1; i < posicionRecorrer; i++)
                    {

                        Console.SetCursorPosition(posicionActual+i, y);
                        Console.Write(">");
                        for (int t = 0; t < 1000000; t++)
                        {

                        }
                        
                    }
                    
                }

            } while (true);
            
        } 

    }
}
