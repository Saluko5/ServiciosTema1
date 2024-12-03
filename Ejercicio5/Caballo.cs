using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Caballo
    {
        public bool Ganadorcaballo { get; set; }
        public int Posicion { get; set; }
        public Caballo(int posicion)
        {
            this.Posicion = posicion;
        }
        public void correr()
        {
            int x = 0;
            int probab;
            while (!Program.ganador) //aqui estaba el error
            {
                Random random = new Random();
                probab = random.Next(1, 6);

                //if (probab == 3)
                //{
                //    Thread.Sleep(500);
                //}
                Thread.Sleep(100);
                lock (Program.l)
                {
                    if (!Program.ganador)
                    {
                        //x += random.Next(1, 4);
                        x += 1;
                        Console.SetCursorPosition(x, this.Posicion);
                        Console.Write("*");
                        if (x >= 20)
                        {
                            Ganadorcaballo = true;
                            Program.ganador = true;
                            Monitor.Pulse(Program.l);
                        }
                    }
                }
            }
        }
    }
}
