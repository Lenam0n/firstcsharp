using System;


namespace ConsoleApp1.Aufgabe_2
{
	public class ex0202
    {
		public static void zwei(string[] args)
		{
            Console.WriteLine("Geben Sie bitte den Wert für die Spannung U ein: ");
			string U = Console.ReadLine();
			Console.WriteLine("Geben Sie bitte den Wert für den Strom I ein: ");
            string I = Console.ReadLine();

			double R = double.Parse(U) / double.Parse(I);

			Console.WriteLine("Der Widerstand R beträgt " + R + " Ohm");
		}
	}
}