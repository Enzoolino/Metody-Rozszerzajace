
using System.Linq;
using System;
using ExtensionMethods;
using System.Globalization;

namespace ExtensionApp
{
    class Program
    {
        static void Main(string[] arg)
        {

            //TEST1
            /*
            string napis = "KamIlek";
            Console.WriteLine(napis.BezSamoglosek());
            */


            //TEST2
            /*
            string napis = "127.70";
            Console.WriteLine(napis.IsNumeric());
            */

            //TEST3
            /*
            var lista = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(lista.Dump());
            */

            //TEST4
            /*
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.PrintLn();
            */

            //TEST5
            /*
            List<int> numbers = new() { 3, 4, 7, 6, 2, 1, 5 };
            Console.WriteLine(numbers.Median());
            */

            //TEST6
            /*
            int liczba = 8;
            if (liczba.Between(1, 7))
            {
                Console.WriteLine("Is included");
            }
            else
            {
                Console.WriteLine("Is not included");
            }
            */




        }
    }
}