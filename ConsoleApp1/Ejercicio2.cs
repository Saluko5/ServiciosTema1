using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicio2
    {

        public static bool MenuGenerator(string[] opciones, MyDelegate[] del)  //Indexación en 1 para usuario. Comp rangos. Sale si excepción
        {
            if(opciones == null || opciones.Contains(null) || del == null || del.Contains(null))
            {
                return false;
            }

            if(opciones.Length != del.Length)
            {
                return false;
            }
            int opcion;
            bool bien;

            do
            {
                Console.WriteLine("Que quieres hacer?");
                for (int i = 0; i < opciones.Length; i++)
                {
                    Console.WriteLine($"{i+1}.{opciones[i]}");
                }
                Console.WriteLine($"{opciones.Length+1}.Salir");
                bien = int.TryParse(Console.ReadLine(), out opcion);
                if (!bien)
                {
                    Console.WriteLine("Introduce un numero entero");
                    bien = false;
                }
                opcion--;
                if ( opcion >= 0 && opcion < opciones.Length)
                {
                    del[opcion]();
                }
            } while (opcion != opciones.Length);
            return bien;
        }
        public delegate void MyDelegate();
        static void f1()
        {
            Console.WriteLine("A");
        }
        static void f2()
        {
            Console.WriteLine("B");
        }
        static void f3()
        {
            Console.WriteLine("C");
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(MenuGenerator(new string[] { "Op1", "Op2", "Op3"},
        //    new MyDelegate[] { () => Console.WriteLine("A"), () => Console.WriteLine("B"), () => Console.WriteLine("C")}));
        //    Console.ReadKey();
        //}
    }
}

