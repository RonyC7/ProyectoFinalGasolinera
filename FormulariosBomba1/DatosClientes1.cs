using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba1
{
    public partial class DatosClientes1 : Form
    {
        public DatosClientes1()
        {
            InitializeComponent();

            comboBoxTcom1.Items.AddRange(new string[] { "Super", "Power", "Diesel" });

            comboBoxSaba1.Items.AddRange(new string[] { "Tanque Lleno", "Seleccionar Cantidad de abastecimiento" });

            textBoxCantidad1.KeyPress += TextBoxCantidad1_KeyPress;
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();

            FormPrincipal formPrincipal = new FormPrincipal();

            formPrincipal.Show();
        }

        private void btnagregarC1_Click(object sender, EventArgs e)
        {
            string nombreCliente = textBoxnombreC1.Text;
            string tipoCombustible = comboBoxTcom1.SelectedItem?.ToString();
            string tipoAbastecimiento = comboBoxSaba1.SelectedItem?.ToString();
            double cantidadAbastecimiento = 0;

            if (tipoAbastecimiento == "Tanque Lleno")
            {
                cantidadAbastecimiento = 1000; // Máximo 1000 litros
                textBoxCantidad1.Enabled = false; 
            }
            else if (tipoAbastecimiento == "Seleccionar Cantidad de abastecimiento")
            {
                textBoxCantidad1.Enabled = true; 

                if (!double.TryParse(textBoxCantidad1.Text, out cantidadAbastecimiento))
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(nombreCliente))
            {
                string datosCliente = $"{nombreCliente},{tipoCombustible},{tipoAbastecimiento},{cantidadAbastecimiento}";
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
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bomba1.txt");

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

        private void TextBoxCantidad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
