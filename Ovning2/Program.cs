using System;

namespace Ovning2
{
    class Program
    {
        /*
        Skapa en metod som tar in två string variabler, lägger samman dessa och
        returnerar som en sträng. (Tex. Strängarna ”Hej på dig!” och ” Hur mår
        du?” blir ”Hej på dig! Hur mår du?”.
         */

        static void Main(string[] args)
        {
            
            TwoStrings("Tjena", " hur mår du?");
           
        }
        static void TwoStrings (string input1, string input2)
        {
            System.Console.WriteLine("{0} {1}", input1, input2);
        }
    }
}
