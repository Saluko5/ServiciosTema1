using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp2
{
    internal class Program
    {
        public static readonly object l = new object();
        static double contador = 0;
        public static bool pausa = false;
        static bool ganador = false;
        static Random random;
        static int vueltas = 0;
        static string[] estados = new string[4];
        //todo el pulse y la booleana y en vez de switch un array hecho
        public static void fplayer1()
        {
            int n;
            random = new Random();
            while (!ganador)
            {
                lock (l)
                {
                    n = random.Next(1, 11);
                    if (!ganador)
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Jugador 1:{0,2}", n);
                        if ((n == 5 || n == 7) && !pausa)
                        {
                            pausa = true;
                            contador++;
                        }
                        else if ((n == 5 || n == 7) && pausa)
                        {
                            pausa = true;
                            contador += 5;
                        }
                        n = random.Next(100, 100 * n);
                        Console.SetCursorPosition(10, 10);
                        string cadena = String.Format("Total:{0,2}", contador);
                        Console.WriteLine(cadena);
                        Console.SetCursorPosition(0, 0);
                        if (contador >= 20)
                        {
                            ganador = true;
                        }
                    }
                    Thread.Sleep(n);
                }
            }
        }
        public static void fplayer2()
        {
            int n;
            random = new Random();
            while (!ganador)
            {
                if (!ganador)
                {
                    lock (l)
                    {
                        n = random.Next(1, 11);
                        if ((n == 5 || n == 7) && !pausa)
                        {
                            //aqui
                            contador--;
                        }
                        if ((n == 5 || n == 7) && pausa)
                        {
                            Monitor.Pulse(l);
                            contador -= 5;
                            pausa = false;
                        }
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("Jugador 2:{0,2}", n);
                        n = random.Next(100, 100 * n);
                        Console.SetCursorPosition(10, 10);
                        string cadena = String.Format("Total:{0,2}", contador);
                        Console.WriteLine(cadena);
                        Console.SetCursorPosition(0, 1);
                        if (contador <= -20)
                        {
                            ganador = true;
                        }
                    }
                    Thread.Sleep(n);
                }
            }

        }
        public static void fdisplay()
        {
            while (!ganador)
            {
                Thread.Sleep(200);
                lock (l)
                {

                    if (pausa)
                    {
                        Monitor.Wait(l);
                    }
                    Console.SetCursorPosition(0, 3);//aqui      
                    Console.WriteLine(estados[vueltas]);
                }
                vueltas++;
                if (vueltas == 4)
                {
                    vueltas = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            estados[0] = "|";
            estados[1] = "/";
            estados[2] = "-";
            estados[3] = @"\";
            Thread player1 = new Thread(fplayer1);
            Thread player2 = new Thread(fplayer2);
            Thread hilo = new Thread(fdisplay);

            hilo.Start();
            player1.Start();
            player2.Start();
            player2.Join();
            Console.Clear();
            if (contador > 0)
            {
                Console.WriteLine("Gano el jugador 1");
            }
            else
            {
                Console.WriteLine("Gano el jugador 2");
            }
        }
    }
}
