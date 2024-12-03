using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        public static readonly object l = new object();
        public static bool ganador = false;
        static void Main(string[] args)
        {
            int prediccion;
            int n = 0;
            bool bien;
            int caballoganador;
            Thread[] hilos;
            Caballo[] caballos;
            do
            {
                // lock (l)
                {

                    ganador = false;
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("Que numero caballo crees que ganara?\n1,2,3,4,5"); //es por q necesita el lock del main
                        bien = int.TryParse(Console.ReadLine(), out prediccion);
                        if (!bien)
                        {
                            Console.WriteLine("Escriba una de las opciones");
                        }
                    } while (prediccion <= 0 || prediccion >= 6 || !bien);
                    prediccion--;
                    Console.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.SetCursorPosition(20, i);
                        Console.Write("|");
                    }
                    hilos = new Thread[5];
                    caballos = new Caballo[5];
                    Console.SetCursorPosition(0, 0);
                    for (int i = 0; i < caballos.Length; i++)
                    {
                        caballos[i] = new Caballo(i);
                    }
                    for (int i = 0; i < hilos.Length; i++)
                    {
                        hilos[i] = new Thread(caballos[i].correr);
                        hilos[i].Start();
                    }
                }
                lock (l)
                {
                    Monitor.Wait(l);
                }
                ganador = true;
                caballoganador = 7;
                for (int i = 0; i < 5; i++)
                {
                    if (caballos[i].Ganadorcaballo)
                    {
                        Console.SetCursorPosition(0, 6);
                        Console.Write($"Ha ganado el caballo numero:{i + 1}\n");
                        caballoganador = i;
                    }
                }
                if (prediccion == caballoganador)
                {
                    Console.WriteLine("Su caballo ha ganado!!!");
                }
                do
                {
                    Console.WriteLine("Quieres repetir y hacer otra carrera?\n1 Para repetir, otra tecla para no");
                    bien = int.TryParse(Console.ReadLine(), out n);
                    if (!bien)
                    {
                        Console.WriteLine("Escriba un numero int");
                    }
                } while (!bien);

            } while (n == 1);
        }
    }
}
