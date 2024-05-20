using ProyectoFinalGasolinera.Clases;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba3
{
    public partial class DatosClientes3 : Form
    {
        private double precioCombustible;

        public event EventHandler DatosClienteGuardado;

        public DatosClientes3()
        {
            InitializeComponent();

            comboBoxTcom3.Items.AddRange(new string[] { "Super", "Regular", "Diesel" });
            comboBoxSaba3.Items.AddRange(new string[] { "Tanque Lleno", "Seleccionar Cantidad de abastecimiento" });
            textBoxCantidad3.KeyPress += TextBoxCantidad3_KeyPress;

            precioCombustible = PreciosGasolina.Super;
            comboBoxTcom3.SelectedIndexChanged += ComboBoxTcom3_SelectedIndexChanged;
            comboBoxSaba3.SelectedIndexChanged += ComboBoxSaba3_SelectedIndexChanged;
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

        private void ComboBoxSaba3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSaba3.SelectedItem?.ToString() == "Tanque Lleno")
            {
                textBoxCantidad3.Text = "1000";
                textBoxCantidad3.Enabled = false;
            }
            else
            {
                textBoxCantidad3.Text = "";
                textBoxCantidad3.Enabled = true;
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
                if (!double.TryParse(textBoxCantidad3.Text, out cantidadAbastecimiento) || cantidadAbastecimiento <= 0)
                {
                    MessageBox.Show("Por favor, ingrese una cantidad de abastecimiento válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                cantidadAbastecimiento = 1000; 
            }

            double totalPagar = precioCombustible * cantidadAbastecimiento;

            string mensaje = $"Nombre del cliente: {nombreCliente}\n" +
                             $"Tipo de gasolina: {tipoCombustible}\n" +
                             $"Tipo de abastecimiento: {tipoAbastecimiento}\n" +
                             $"Cantidad de abastecimiento: {cantidadAbastecimiento}\n" +
                             $"Total a pagar: Q {totalPagar}";

            MessageBox.Show(mensaje, "Resumen de la transacción", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GuardarDatos($"{nombreCliente},{tipoCombustible},{tipoAbastecimiento},{cantidadAbastecimiento},{totalPagar},{DateTime.Now}");
            DatosClienteGuardado?.Invoke(this, EventArgs.Empty); 
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
