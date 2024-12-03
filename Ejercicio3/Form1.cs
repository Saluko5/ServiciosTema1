using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnProcesos, "Muestra todos los procesos actuales del ordenador");
            toolTip1.SetToolTip(btnInfo, "Busca el proceso a traves del la id que le ponga en el textbox y te muestra su informacion");
            toolTip1.SetToolTip(btnMatar, "Busca el proceso a traves del la id que le ponga en el textbox y lo mata");
            toolTip1.SetToolTip(btnCierre, "Busca el proceso a traves del la id que le ponga en el textbox y lo cierra");
            toolTip1.SetToolTip(btnBusqueda, "Muestra el nombre de todos los procesos que empieces por la cadena pasada por el textbox");
            toolTip1.SetToolTip(btnIniciar, "Inicia el proceso al que le hayas pasado el nombre en el textbox");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void procesos(object sender, EventArgs e)
        {
            Process[] procesos = Process.GetProcesses();
            string cadena = "";
            foreach (Process process in procesos)
            {
                if (process.ProcessName.Length > 15 && process.MainWindowTitle.Length <= 15)
                {
                    cadena += String.Format("{0,-10} | {1,15} | {2,15} |{3}", process.Id,
                        process.ProcessName.Substring(0, 10) + "...", process.MainWindowTitle, Environment.NewLine);
                }
                if (process.ProcessName.Length <= 15 && process.MainWindowTitle.Length > 15)
                {
                    cadena += String.Format("{0,-10} | {1,15} | {2,15} |{3}", process.Id, process.ProcessName,
                        process.MainWindowTitle.Substring(0, 10) + "...", Environment.NewLine);
                }
                if (process.ProcessName.Length > 15 && process.MainWindowTitle.Length > 15)
                {
                    cadena += String.Format("{0,-10} | {1,15} | {2,15} |{3}", process.Id, process.ProcessName.Substring(0, 12) + "...",
                        process.MainWindowTitle.Substring(0, 10) + "...", Environment.NewLine);
                }
                else if (process.ProcessName.Length <= 15 && process.MainWindowTitle.Length <= 15)
                {
                    cadena += String.Format("{0,-10} | {1,15} | {2,15} |{3}", process.Id, process.ProcessName, process.MainWindowTitle, Environment.NewLine);
                }
            }
            txtGrande.Text = cadena;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void info(object sender, EventArgs e)
        {
            try
            {

                Process[] procesos = Process.GetProcesses();
                Process proceso;
                string cadena = "";
                for (int i = 0; i < procesos.Length; i++)
                {
                    if (procesos[i].Id == Convert.ToInt32(txtPequeño.Text))
                    {
                        proceso = procesos[i];
                        cadena += String.Format("Nombre:{0}{1}PID:{2}{3}Numero de modulos:{4}{5}Numero de subprocesos:{6}{7}", proceso.ProcessName, Environment.NewLine, proceso.Id, Environment.NewLine, proceso.Modules.Count, Environment.NewLine, proceso.Threads.Count, Environment.NewLine);
                        ProcessThreadCollection coleccionhilos = proceso.Threads;
                        ProcessModuleCollection coleccionmodulos = proceso.Modules;
                        foreach (ProcessThread hilo in coleccionhilos)
                        {
                            cadena += String.Format("{0}{1}{2}{3}", hilo.Id, Environment.NewLine, hilo.StartTime, Environment.NewLine);
                        }
                        foreach (ProcessModule modulo in coleccionmodulos)
                        {
                            cadena += String.Format("{0}{1}{2}{3}", modulo.ModuleName, Environment.NewLine, modulo.FileName, Environment.NewLine);
                        }
                        txtGrande.Text = cadena;
                    }
                }
            }
            catch (Exception ex)
            {
                lblerrores.Text = "Error";
            }
        }

        private void cerrar(object sender, EventArgs e)
        {
            try
            {

                Process[] procesos = Process.GetProcesses();
                Process proceso;
                for (int i = 0; i < procesos.Length; i++)
                {
                    if (procesos[i].Id == Convert.ToInt32(txtPequeño.Text))
                    {
                        proceso = procesos[i];
                        proceso.CloseMainWindow();
                    }
                }
            }
            catch (Exception ex)
            {
                lblerrores.Text = "Error";
            }
        }

        private void matar(object sender, EventArgs e)
        {
            try
            {

                Process[] procesos = Process.GetProcesses();
                Process proceso;
                for (int i = 0; i < procesos.Length; i++)
                {
                    if (procesos[i].Id == Convert.ToInt32(txtPequeño.Text))
                    {
                        proceso = procesos[i];
                        proceso.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                lblerrores.Text = "Error";
            }
        }

        private void iniciar(object sender, EventArgs e)
        {
            try
            {
                Process p;
                p = Process.Start(txtPequeño.Text);
            }
            catch (Exception ex)
            {
                lblerrores.Text = "Error";
            }
        }

        private void busqueda(object sender, EventArgs e)
        {
            try
            {
                string cadena = "";
                Process[] procesos = Process.GetProcesses();
                Array.ForEach(procesos, (proceso) =>
                {

                    if (proceso.ProcessName.ToUpper().StartsWith(txtPequeño.Text.ToUpper()))
                    {
                        cadena += String.Format("{0}{1}", proceso.ProcessName, Environment.NewLine);
                    }
                });
                if (cadena == "")
                {
                    lblerrores.Text = "No se encontro ningun archivo que empiece por la cadena indicada";
                }
                else
                {
                    txtGrande.Text = cadena;
                }
            }
            catch (Exception ex)
            {
                lblerrores.Text = "Error";
            }
        }
    }
}
