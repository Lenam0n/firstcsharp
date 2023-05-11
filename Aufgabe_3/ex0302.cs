using System;

namespace ConsoleApp1.Aufgabe_3
{
    public class ex0302
    {
        public static void Main()
        {
            Console.WriteLine("Gewinnberechnung Version 1.0");
            Console.WriteLine("Bitte geben Sie die fixen Kosten x ein: ");
            int FixKosten = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Kosten für ein Produkt y ein: ");
            int Kosten = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den Erlös z für ein Produkt ein: ");
            int profit = int.Parse(Console.ReadLine());
            Console.WriteLine("Wie viele Produkte n sollen hergestellt werden: ");
            int Anzahl = int.Parse(Console.ReadLine());

            Console.WriteLine((FixKosten - (profit - Kosten)*Anzahl)*-1);

        }
    }
}