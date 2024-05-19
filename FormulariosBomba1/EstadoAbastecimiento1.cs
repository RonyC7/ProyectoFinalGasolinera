using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba1
{
    public partial class EstadoAbastecimiento1 : Form
    {
        public EstadoAbastecimiento1()
        {
            InitializeComponent();
        }

        private void btnMostrar1_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bomba1.txt");
            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                if (lineas.Length > 0)
                {
                    string[] ultimaLinea = lineas.Last().Split(',');

                    string estadoAbastecimiento = "En uso";
                    string cantidadSolicitada = ultimaLinea[3];
                    string cantidadAbastecida = "0";

                    labelEstado1.Text = estadoAbastecimiento;
                    labelCantidadS1.Text = cantidadSolicitada;
                    labelCantidadA1.Text = cantidadAbastecida;

                    
                    Timer timer = new Timer();
                    timer.Interval = 1000; 
                    double cantidad = double.Parse(cantidadSolicitada);
                    double cantidadIncrementada = 0;
                    timer.Tick += (s, args) =>
                    {
                        cantidadIncrementada += 10; 
                        labelCantidadA1.Text = cantidadIncrementada.ToString();
                        if (cantidadIncrementada >= cantidad)
                        {
                            timer.Stop();
                            labelEstado1.Text = "Disponible";
                            MessageBox.Show("Tanque 1 libre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    };
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("No hay datos disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo de datos no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelCantidadS_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }
    }
}
