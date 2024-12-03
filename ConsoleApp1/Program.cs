using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void view(int grade)
        {
            Console.ForegroundColor = grade >= 5 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"student grade: {grade,3}.");
            Console.ResetColor();
        }
        public static bool pass(int num)
        {
            return num >= 5;
        }
        //static void Main(string[] args)
        //{
        //    int[] v = { 2, 2, 6, 7, 1, 10, 3 };
        //    Array.ForEach (v, (a) =>
        //    {
        //        Console.ForegroundColor = a >= 5 ? ConsoleColor.Green : ConsoleColor.Red;
        //        Console.WriteLine($"student grade: {a,3}.");
        //        Console.ResetColor();
        //    });
        //    Console.WriteLine($"han aprobado {Array.Find(v, (a) => a >= 5)} estudiantes");

        //    Console.WriteLine($"Existe al menos un aprobado?{Array.Exists(v,(a => a >=5))}");//exists

        //    Console.WriteLine($"el ultimo aprobado fue el que tiene la posicion {Array.FindLast(v, (a) => a >= 5) + 1}");
        //    Array.ForEach (v, (a) => Console.WriteLine(1.0 / a));
        //}
    }
}
