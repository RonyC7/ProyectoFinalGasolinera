using ProyectoFinalGasolinera.Clases;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera
{
    public partial class FormConfiguracion : Form
    {
        private const string RutaArchivo = "precios_gasolina.txt";

        public FormConfiguracion()
        {
            InitializeComponent();
            CargarPrecios();
        }

        private void btnCerrarConfi_Click(object sender, EventArgs e)
        {
            GuardarPrecios();
            this.Close();

            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void btnGuardarPrecios_Click(object sender, EventArgs e)
        {
            try
            {
                PreciosGasolina.Super = double.Parse(txtSuper.Text);
                PreciosGasolina.Diesel = double.Parse(txtDiesel.Text);
                PreciosGasolina.Regular = double.Parse(txtRegular.Text);

                GuardarPrecios();
                CargarPrecios(); 
                MessageBox.Show("Precios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los precios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormConfiguracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuardarPrecios();
        }

        private void CargarPrecios()
        {
            try
            {
                if (File.Exists(RutaArchivo))
                {
                    using (StreamReader sr = new StreamReader(RutaArchivo))
                    {
                        string[] precios = sr.ReadLine().Split(',');
                        if (precios.Length == 3)
                        {
                            lblPrecioSuper.Text = $"Q {precios[0]}";
                            lblPrecioDiesel.Text = $"Q {precios[1]}";
                            lblPrecioRegular.Text = $"Q {precios[2]}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los precios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarPrecios()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(RutaArchivo))
                {
                    sw.WriteLine($"{txtSuper.Text},{txtDiesel.Text},{txtRegular.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los precios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
