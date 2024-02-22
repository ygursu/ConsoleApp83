using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedikdortgenlerprizmasiyuzeyalani
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("a kenarını girin");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("b kenarını girin");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("c kenarını girin");
            int c = Int32.Parse(Console.ReadLine());

            int yuzeyalani = 2 * (a * b + a * c + b * c);
            Console.WriteLine("Dikdörtgenler prizmasının yüzey alanı=" + yuzeyalani);


            Console.ReadLine();

        }
    }
}