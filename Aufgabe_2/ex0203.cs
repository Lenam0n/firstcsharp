using System;
namespace ConsoleApp1.Aufgabe_2
{
    public class ex0203
    {
        public static void drei(string[] args)
        {
            Console.WriteLine("Geben Sie bitte den Wert für den Widerstand R ein: ");
            string R = Console.ReadLine();
            Console.WriteLine("Geben Sie bitte den Wert für den Strom I ein:  ");
            string I = Console.ReadLine();
            double U = double.Parse(I) * double.Parse(R);
            Console.WriteLine("Die Spannung U beträgt {0:0.0#} V", U);
        }
    }
}