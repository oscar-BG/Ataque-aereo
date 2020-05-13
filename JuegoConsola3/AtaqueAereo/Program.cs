using System;

namespace AtaqueAereo
{
    class Program
    {
        static void Main(string[] args)
        {
            Marco marco_formato = new Marco(); //Constructor

            skin_Avion avion = new skin_Avion();
            avion.avion();
            Console.ReadKey();
        }
    }
}
