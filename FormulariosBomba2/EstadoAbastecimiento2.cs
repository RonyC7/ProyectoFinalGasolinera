using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba2
{
    public partial class EstadoAbastecimiento2 : Form
    {
        public EstadoAbastecimiento2()
        {
            InitializeComponent();
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bomba2.txt");
            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                if (lineas.Length > 0)
                {
                    string[] ultimaLinea = lineas.Last().Split(',');

                    string estadoAbastecimiento = "En uso";
                    string cantidadSolicitada = ultimaLinea[3];
                    string cantidadAbastecida = "0";

                    labelEstado2.Text = estadoAbastecimiento;
                    labelCantidadS2.Text = cantidadSolicitada;
                    labelCantidadA2.Text = cantidadAbastecida;

                    Timer timer = new Timer();
                    timer.Interval = 1000; 
                    double cantidad = double.Parse(cantidadSolicitada);
                    double cantidadIncrementada = 0;
                    timer.Tick += (s, args) =>
                    {
                        cantidadIncrementada += 10; 
                        labelCantidadA2.Text = cantidadIncrementada.ToString();
                        if (cantidadIncrementada >= cantidad)
                        {
                            timer.Stop();
                            labelEstado2.Text = "Disponible";
                            MessageBox.Show("Tanque 2 libre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btncerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }
    }
}
