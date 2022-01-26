
using RPG.Models;
using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "knight");
            Wizard wizard = new Wizard("Jennica", 99, "White Wizard");
            Hero ninja = new Hero("Wedge", 42, "Ninja");
            Wizard black_wizard = new Wizard("Topapa", 80, "Black Wizard");

            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(black_wizard.Attack());


        }
    }
}
