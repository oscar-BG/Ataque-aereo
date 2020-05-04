using System;
using System.Collections.Generic;
using System.Text;

namespace AtaqueAereo
{
    class skin_Avion
    {
        private void dibuja_Avion()
        {
            Console.WriteLine("═╞");
        }
        public void avion()
        {
            int x = 5;
            int y = 10;
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.SetCursorPosition(x, y);
                dibuja_Avion();
                keyInfo = Console.ReadKey();

                while (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    y -= 1;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(x, y);
                    dibuja_Avion();
                    break;
                }
                
            } while (true);
            
        }

    }
}
