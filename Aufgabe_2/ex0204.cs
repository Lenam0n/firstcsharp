using System;
namespace ConsoleApp1.Aufgabe_2
{
    public class ex0204
    {
        public static void vier()
        {
            Console.WriteLine("Multilineinput Version 1.0");
            Console.WriteLine("Geben Sie bitte 2 Werte ein: ");
            string[] words = Console.ReadLine().Split(' ');

            Console.WriteLine("Wert 1: " + words[0]);
            Console.WriteLine("Wert 2: " + words[1]);


        }
    }
}