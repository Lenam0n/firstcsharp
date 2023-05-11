using System;


namespace ConsoleApp1.Aufgabe_1
{
    public class ex0104
    {
        public static void vier(string[] args)
        {
            int U = 230;
            double I = 4.5;
            double res = U / I;

            Console.WriteLine("Ohmsches Gesetz Berechnung Version 1.0 \n Der Widerstand R beträgt: {0:F2} Ohm", res);
        }
    }
}