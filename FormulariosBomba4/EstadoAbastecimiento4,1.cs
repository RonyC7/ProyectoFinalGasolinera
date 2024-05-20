using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba4
{
    public partial class EstadoAbastecimiento4_1 : Form
    {
        public EstadoAbastecimiento4_1()
        {
            InitializeComponent();
        }

        private void btncerrar4_Click(object sender, EventArgs e)
        {
            this.Close();

            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void btnMostrar4_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bomba4.txt");
            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                string[] ultimaLinea = lineas.Last().Split(',');

                string estadoAbastecimiento = "En uso";
                string cantidadSolicitada = ultimaLinea[3];
                string cantidadAbastecida = "0";

                labelEstado4.Text = estadoAbastecimiento;
                labelCantidadS4.Text = cantidadSolicitada;
                labelCantidadA4.Text = cantidadAbastecida;

                Timer timer = new Timer();
                timer.Interval = 1000;
                double cantidad = double.Parse(cantidadSolicitada);
                double cantidadIncrementada = 0;
                timer.Tick += (s, args) =>
                {
                    cantidadIncrementada += 10;
                    labelCantidadA4.Text = cantidadIncrementada.ToString();
                    if (cantidadIncrementada >= cantidad)
                    {
                        timer.Stop();
                        labelEstado4.Text = "Disponible";
                        MessageBox.Show("Tanque 4 libre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };
                timer.Start();
            }
            else
            {
                MessageBox.Show("No hay datos disponibles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
