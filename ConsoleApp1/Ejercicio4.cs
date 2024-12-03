using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicio4
    {
        static readonly private object l = new object();
        static bool ganador = false;
        static void Main(string[] args)
        {
            double n = 0;
            Thread hilo1 = new Thread(() =>
            {
                while (!ganador)
                {

                    lock (l)
                    {
                        if (!ganador)
                        {
                            Console.WriteLine("{0,4}", n);
                            Console.ForegroundColor = ConsoleColor.Green;
                            if (n == 500)
                            {
                                ganador = true;
                            }
                            else
                            {
                                n++;
                            }
                        }
                        if (ganador)
                        {
                            Monitor.Pulse(l);
                        }
                    }
                }

            });
            Thread hilo2 = new Thread(() =>
            {

                while (!ganador)
                {
                    lock (l)
                    {
                        if (!ganador)
                        {
                            Console.WriteLine("{0,4}", n);
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (n == -500)
                            {
                                ganador = true;
                                Monitor.Pulse(l);
                            }
                            else
                            {
                                n--;
                            }
                        }

                    }
                }

            });
            hilo1.Start();
            hilo2.Start();
            lock (l)
            {

                Monitor.Wait(l);
            }

            if (n < 0)
            {
                Console.WriteLine("Ganaron los negativos");
            }
            else
            {
                Console.WriteLine("Ganaron los positivos");
            }
        }
    }
}
