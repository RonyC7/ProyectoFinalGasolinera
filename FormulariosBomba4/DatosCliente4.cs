using ProyectoFinalGasolinera.Clases;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba4
{
    public partial class DatosCliente4 : Form
    {
        private double precioCombustible;

        public DatosCliente4()
        {
            InitializeComponent();

            comboBoxTcom4.Items.AddRange(new string[] { "Super", "Power", "Diesel" });
            comboBoxSaba4.Items.AddRange(new string[] { "Tanque Lleno", "Seleccionar Cantidad de abastecimiento" });
            textBoxCantidad4.KeyPress += TextBoxCantidad4_KeyPress;

            precioCombustible = PreciosGasolina.Super;
            comboBoxTcom4.SelectedIndexChanged += ComboBoxTcom4_SelectedIndexChanged;
        }

        private void ComboBoxTcom4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTcom4.SelectedItem?.ToString())
            {
                case "Super":
                    precioCombustible = PreciosGasolina.Super;
                    break;
                case "Power":
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

        private void btnCerrar4_Click(object sender, EventArgs e)
        {
            this.Close();

            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void btnagregarC4_Click(object sender, EventArgs e)
        {
            string nombreCliente = textBoxnombreC4.Text;
            string tipoCombustible = comboBoxTcom4.SelectedItem?.ToString();
            string tipoAbastecimiento = comboBoxSaba4.SelectedItem?.ToString();
            double cantidadAbastecimiento = 0;

            if (tipoAbastecimiento == "Tanque Lleno")
            {
                cantidadAbastecimiento = 1000; // Máximo 1000 litros
                textBoxCantidad4.Enabled = false;
            }
            else if (tipoAbastecimiento == "Seleccionar Cantidad de abastecimiento")
            {
                textBoxCantidad4.Enabled = true;

                if (!double.TryParse(textBoxCantidad4.Text, out cantidadAbastecimiento))
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

        private void DatosCliente4_Load(object sender, EventArgs e)
        {

        }

        private void GuardarDatos(string datosCliente)
        {
            try
            {
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Bomba4.txt");

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

        private void TextBoxCantidad4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
