﻿using System;

namespace Övning4
{
    class Program
    {
        /*
        Skapa en metod som lägger till momsen på en viss summa. Antag att
        momsen är 25%. 
         */
        static void Main(string[] args)
        {
            System.Console.Write("Hur mycket kostnar produkten(i SEK): ");
            double productVal = Convert.ToDouble(Console.ReadLine());
            double productValueWithOutTax = Tax(productVal);
            System.Console.WriteLine("Kostnaden för produkt ink. 25% moms är: {0}", productValueWithOutTax);
            productValueWithOutTax = Math.Round(productValueWithOutTax,2);
            System.Console.WriteLine("Avrundad decimal = {0}",productValueWithOutTax);
        }
        static double Tax (double tax)
        {
            return tax * 1.25;
        }
    }
}
