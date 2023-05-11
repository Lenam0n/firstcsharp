using System;

namespace ConsoleApp1.Aufgabe_3
{
    public class ex0301
    {
        public static void eins(string[] args)
        {
            Console.WriteLine("Lineare Gleichung Version 1.0");
            Console.WriteLine("Bitte den Wert für a angeben: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Bitte den Wert für b angeben:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Die Lösung lautet x=" + (b /-a));


        }
    }
}
