using System;

namespace ConsoleApp1.Aufgabe_2
{
	public class ex0201
	{
		static void eins() {
			double U = 10;
            double R = 470;
			double I = U / R;

			Console.WriteLine("Geben Sie bitte den Wert für die Spannung U ein: " + U);
            Console.WriteLine("Geben Sie bitte den Wert für den Widerstand R ein:  " + R);
			Console.WriteLine("Der Strom I beträgt " + I + "A");
        }
	}
}