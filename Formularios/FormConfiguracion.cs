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
            this.Close();

            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void btnGuardarPrecios_Click(object sender, EventArgs e)
        {
            try
            {
                lblPrecioSuper.Text = txtSuper.Text;
                lblPrecioDiesel.Text = txtDiesel.Text;
                lblPrecioRegular.Text = txtRegular.Text;

                GuardarPrecios();
                MessageBox.Show("Precios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los precios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            lblPrecioSuper.Text = precios[0];
                            lblPrecioDiesel.Text = precios[1];
                            lblPrecioRegular.Text = precios[2];
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
                    sw.WriteLine($"{lblPrecioSuper.Text},{lblPrecioDiesel.Text},{lblPrecioRegular.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los precios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
