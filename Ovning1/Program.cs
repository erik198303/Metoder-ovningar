using System;

namespace Ovning1
{
    class Program
    {
        /*
        Skapa en metod Hello() som tar en string variabel som indata och skriver
        ut texten med ett annat meddelande 
         */
        static void Main(string[] args)
        {
            Hello("Hej");
        }
        static void Hello(string input)
        {
            System.Console.WriteLine("Halloj! " + input);
        }
    }
}
