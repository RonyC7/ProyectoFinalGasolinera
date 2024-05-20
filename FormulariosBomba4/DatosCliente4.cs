using ProyectoFinalGasolinera.Clases;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba4
{
    public partial class DatosCliente4 : Form
    {
        private double precioCombustible;

        public event EventHandler DatosClienteGuardado;

        public DatosCliente4()
        {
            InitializeComponent();

            comboBoxTcom4.Items.AddRange(new string[] { "Super", "Power", "Diesel" });
            comboBoxSaba4.Items.AddRange(new string[] { "Tanque Lleno", "Seleccionar Cantidad de abastecimiento" });
            textBoxCantidad4.KeyPress += TextBoxCantidad4_KeyPress;

            precioCombustible = PreciosGasolina.Super;
            comboBoxTcom4.SelectedIndexChanged += ComboBoxTcom4_SelectedIndexChanged;
            comboBoxSaba4.SelectedIndexChanged += ComboBoxSaba4_SelectedIndexChanged;
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

        private void ComboBoxSaba4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSaba4.SelectedItem?.ToString() == "Tanque Lleno")
            {
                textBoxCantidad4.Text = "1000";
                textBoxCantidad4.Enabled = false;
            }
            else
            {
                textBoxCantidad4.Text = "";
                textBoxCantidad4.Enabled = true;
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
                if (!double.TryParse(textBoxCantidad4.Text, out cantidadAbastecimiento) || cantidadAbastecimiento <= 0)
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
