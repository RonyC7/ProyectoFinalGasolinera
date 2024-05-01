using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba2
{
    public partial class DatosClientes2 : Form
    {
        public DatosClientes2()
        {
            InitializeComponent();

            comboBoxTcom2.Items.AddRange(new string[] { "Super", "Power", "Diesel" });
            comboBoxSaba2.Items.AddRange(new string[] { "Tanque Lleno", "Seleccionar Cantidad de abastecimiento" });
            textBoxCantidad2.KeyPress += TextBoxCantidad2_KeyPress;
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            this.Close();

            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void btnagregarC2_Click(object sender, EventArgs e)
        {
            string nombreCliente = textBoxnombreC2.Text;
            string tipoCombustible = comboBoxTcom2.SelectedItem?.ToString();
            string tipoAbastecimiento = comboBoxSaba2.SelectedItem?.ToString();
            double cantidadAbastecimiento = 0;

            if (tipoAbastecimiento == "Tanque Lleno")
            {
                cantidadAbastecimiento = 1000; // Máximo 1000 litros
                textBoxCantidad2.Enabled = false;
            }
            else if (tipoAbastecimiento == "Seleccionar Cantidad de abastecimiento")
            {
                textBoxCantidad2.Enabled = true;

                if (!double.TryParse(textBoxCantidad2.Text, out cantidadAbastecimiento))
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(nombreCliente))
            {
                string datosCliente = $"{nombreCliente},{tipoCombustible},{tipoAbastecimiento},{cantidadAbastecimiento},{DateTime.Now}";
                GuardarDatos(datosCliente);

                MessageBox.Show("Datos del cliente agregados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarDatos(string datosCliente)
        {
            try
            {
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bomba2.txt");

                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    sw.WriteLine(datosCliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos del cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxCantidad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
