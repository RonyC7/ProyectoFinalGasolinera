using ProyectoFinalGasolinera.Clases;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba2
{
    public partial class DatosClientes2 : Form
    {
        private double precioCombustible;

        public event EventHandler DatosClienteGuardado;

        public DatosClientes2()
        {
            InitializeComponent();

            comboBoxTcom2.Items.AddRange(new string[] { "Super", "Regular", "Diesel" });
            comboBoxSaba2.Items.AddRange(new string[] { "Tanque Lleno", "Seleccionar Cantidad de abastecimiento" });
            textBoxCantidad2.KeyPress += TextBoxCantidad2_KeyPress;

            precioCombustible = PreciosGasolina.Super;
            comboBoxTcom2.SelectedIndexChanged += ComboBoxTcom2_SelectedIndexChanged;
            comboBoxSaba2.SelectedIndexChanged += ComboBoxSaba2_SelectedIndexChanged;
        }

        private void ComboBoxTcom2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTcom2.SelectedItem?.ToString())
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

        private void ComboBoxSaba2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSaba2.SelectedItem?.ToString() == "Tanque Lleno")
            {
                textBoxCantidad2.Text = "1000";
                textBoxCantidad2.Enabled = false;
            }
            else
            {
                textBoxCantidad2.Text = "";
                textBoxCantidad2.Enabled = true;
            }
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
                if (!double.TryParse(textBoxCantidad2.Text, out cantidadAbastecimiento) || cantidadAbastecimiento <= 0)
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
