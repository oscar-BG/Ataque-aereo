using System;

namespace AtaqueAereo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ataque aereo";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetWindowSize(61, 21);
            Console.ForegroundColor = ConsoleColor.Black;

            Marco marco = new Marco();
            marco.dibujar_Marco();
            skin_Avion avion = new skin_Avion();
            avion.avion();
            Console.ReadKey();
        }
    }
}
