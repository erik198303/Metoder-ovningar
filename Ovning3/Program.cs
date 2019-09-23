using System;

namespace Ovning3
{
    class Program
    {
        /*
        Skapa metoden Addera() som tar in två heltal och returnerar summan.
         */
        static void Main(string[] args)
        {
           System.Console.WriteLine("Summan från metod: " + Add(5,5));
           
        }
        static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
