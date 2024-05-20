using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba3
{
    public partial class EstadoAbastecimiento3 : Form
    {
        public EstadoAbastecimiento3()
        {
            InitializeComponent();
        }

        private void btncerrar3_Click(object sender, EventArgs e)
        {
            this.Close();

            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void btnMostrar3_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bomba3.txt");
            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                string[] ultimaLinea = lineas.Last().Split(',');

                string estadoAbastecimiento = "En uso";
                string cantidadSolicitada = ultimaLinea[3];
                string cantidadAbastecida = "0";

                labelEstado3.Text = estadoAbastecimiento;
                labelCantidadS3.Text = cantidadSolicitada;
                labelCantidadA3.Text = cantidadAbastecida;

                Timer timer = new Timer();
                timer.Interval = 1000; 
                double cantidad = double.Parse(cantidadSolicitada);
                double cantidadIncrementada = 0;
                timer.Tick += (s, args) =>
                {
                    cantidadIncrementada += 10; 
                    labelCantidadA3.Text = cantidadIncrementada.ToString();
                    if (cantidadIncrementada >= cantidad)
                    {
                        timer.Stop();
                        labelEstado3.Text = "Disponible";
                        MessageBox.Show("Tanque 3 libre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
