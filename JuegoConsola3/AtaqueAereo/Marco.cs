using System;
using System.Collections.Generic;
using System.Text;

namespace AtaqueAereo
{
    class Marco
    {
        public Marco()
        {
            Console.Title = "Ataque aereo";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetWindowSize(61, 21);
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(0, 0);
            Console.Write("╔");
            
            for (int x = 0; x < 60; x++)
            {
                Console.Write("═");
            }
            Console.SetCursorPosition(60, 0);
            Console.Write("╗");
            for (int y = 0; y < 20; y++)
            {
                Console.WriteLine("║");
            }
            for (int x1 = 0; x1 < 60; x1++)
            {
                Console.SetCursorPosition(x1, 20);
                Console.Write("═");
            }
            Console.SetCursorPosition(0, 20);
            Console.Write("╚");
            for (int y1 = 0; y1 < 20; y1++)
            {
                Console.SetCursorPosition(60,y1);
                Console.WriteLine("║");
            }
            Console.SetCursorPosition(60, 20);
            Console.Write("╝");
            Console.SetCursorPosition(60,0);
            Console.Write("╗");
        }
    }
}
