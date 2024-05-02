using ProyectoFinalGasolinera.Clases;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba3
{
    public partial class DatosClientes3 : Form
    {
        private double precioCombustible;

        public DatosClientes3()
        {
            InitializeComponent();

            comboBoxTcom3.Items.AddRange(new string[] { "Super", "Regular", "Diesel" });
            comboBoxSaba3.Items.AddRange(new string[] { "Tanque Lleno", "Seleccionar Cantidad de abastecimiento" });
            textBoxCantidad3.KeyPress += TextBoxCantidad3_KeyPress;

            precioCombustible = PreciosGasolina.Super; 
            comboBoxTcom3.SelectedIndexChanged += ComboBoxTcom3_SelectedIndexChanged;
        }

        private void ComboBoxTcom3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTcom3.SelectedItem?.ToString())
            {
                case "Super":
                    precioCombustible = PreciosGasolina.Super;
                    break;
                case "Regular":
                    precioCombustible = PreciosGasolina.Regular;
                    break;
                case "Diesel":
                    precioCombustible = PreciosGasolina.Diesel;
                    break;
                default:
                    precioCombustible = PreciosGasolina.Super;
                    break;
            }
        }

        private void btnCerrar3_Click(object sender, EventArgs e)
        {
            this.Close();

            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void buttonagregarC3_Click(object sender, EventArgs e)
        {
            string nombreCliente = textBoxnombreC3.Text;
            string tipoCombustible = comboBoxTcom3.SelectedItem?.ToString();
            string tipoAbastecimiento = comboBoxSaba3.SelectedItem?.ToString();
            double cantidadAbastecimiento = 0;

            if (tipoAbastecimiento == "Tanque Lleno")
            {
                cantidadAbastecimiento = 1000; // Máximo 1000 litros
                textBoxCantidad3.Enabled = false;
            }
            else if (tipoAbastecimiento == "Seleccionar Cantidad de abastecimiento")
            {
                textBoxCantidad3.Enabled = true;

                if (!double.TryParse(textBoxCantidad3.Text, out cantidadAbastecimiento))
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            double totalPagar = tipoAbastecimiento == "Tanque Lleno" ? precioCombustible * 1000 : precioCombustible * cantidadAbastecimiento;

            string mensaje = $"Nombre del cliente: {nombreCliente}\n" +
                             $"Tipo de gasolina: {tipoCombustible}\n" +
                             $"Tipo de abastecimiento: {tipoAbastecimiento}\n" +
                             $"Cantidad de abastecimiento: {(tipoAbastecimiento == "Tanque Lleno" ? "Tanque Lleno (1000 litros)" : cantidadAbastecimiento.ToString())}\n" +
                             $"Total a pagar: Q {totalPagar}";

            MessageBox.Show(mensaje, "Resumen de la transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GuardarDatos($"{nombreCliente},{tipoCombustible},{tipoAbastecimiento},{cantidadAbastecimiento},{totalPagar},{DateTime.Now}");
        }

        private void GuardarDatos(string datosCliente)
        {
            try
            {
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bomba3.txt");

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

        private void TextBoxCantidad3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
