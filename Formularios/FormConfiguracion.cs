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
                            PreciosGasolina.Super = double.Parse(precios[0]);
                            PreciosGasolina.Diesel = double.Parse(precios[1]);
                            PreciosGasolina.Regular = double.Parse(precios[2]);

                            lblPrecioSuper.Text = $"Q {PreciosGasolina.Super}";
                            lblPrecioDiesel.Text = $"Q {PreciosGasolina.Diesel}";
                            lblPrecioRegular.Text = $"Q {PreciosGasolina.Regular}";
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
                    sw.WriteLine($"{PreciosGasolina.Super},{PreciosGasolina.Diesel},{PreciosGasolina.Regular}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los precios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
