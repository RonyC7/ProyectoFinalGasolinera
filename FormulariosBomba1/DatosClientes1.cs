using ProyectoFinalGasolinera.Clases;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba1
{
    public partial class DatosClientes1 : Form
    {
        private double precioGasolina; 

        public DatosClientes1()
        {
            InitializeComponent();

            comboBoxTcom1.Items.AddRange(new string[] { "Super", "Regular", "Diesel" });
            comboBoxSaba1.Items.AddRange(new string[] { "Tanque Lleno", "Seleccionar Cantidad de abastecimiento" });
            textBoxCantidad1.KeyPress += TextBoxCantidad1_KeyPress;

            precioGasolina = PreciosGasolina.Super; 
            comboBoxTcom1.SelectedIndexChanged += ComboBoxTcom1_SelectedIndexChanged;
        }

        private void ComboBoxTcom1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTcom1.SelectedItem?.ToString())
            {
                case "Super":
                    precioGasolina = PreciosGasolina.Super;
                    break;
                case "Regular":
                    precioGasolina = PreciosGasolina.Regular;
                    break;
                case "Diesel":
                    precioGasolina = PreciosGasolina.Diesel;
                    break;
                default:
                    precioGasolina = PreciosGasolina.Super;
                    break;
            }
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

            if (string.IsNullOrEmpty(nombreCliente))
            {
                MessageBox.Show("Por favor, ingrese un nombre de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(tipoCombustible) || string.IsNullOrEmpty(tipoAbastecimiento))
            {
                MessageBox.Show("Por favor, seleccione un tipo de combustible y un tipo de abastecimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tipoAbastecimiento == "Seleccionar Cantidad de abastecimiento")
            {
                if (!double.TryParse(textBoxCantidad1.Text, out cantidadAbastecimiento) || cantidadAbastecimiento <= 0)
                {
                    MessageBox.Show("Por favor, ingrese una cantidad de abastecimiento válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            double totalPagar = tipoAbastecimiento == "Tanque Lleno" ? precioGasolina * 1000 : precioGasolina * cantidadAbastecimiento;

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
