using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public delegate void Function();
    internal class MyTimer
    {

        public static readonly object l = new object();
        public int Interval { get; set; }
        private bool pausado;
        private Function a;
        public MyTimer(Function funcionpasada)
        {
            a = funcionpasada;
            Thread hilo = new Thread(funcion);
            hilo.IsBackground = true;
            pausado = true;
            hilo.Start();
        }
        public void run()
        {
            lock (l)
            {
                if (pausado)
                {
                    Monitor.Pulse(l);
                    pausado = false;
                }
            }
        }

        public void pause()
        {
            lock (l)
            {
                pausado = true;
            }
        }

        public void funcion()
        {
            while (true)
            {
                Thread.Sleep(Interval);
                lock (l)
                {
                    if (pausado)
                    {
                        Monitor.Wait(l);
                    }
                        a();
                }
            }
        }
    }

}
