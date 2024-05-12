using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera
{
    public partial class FormEstadistica : Form
    {
        public FormEstadistica()
        {
            InitializeComponent();
        }

        private void FormEstadistica_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarEstadistica_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void btnMostrarDCierre_Click(object sender, EventArgs e)
        {
            dataGridViewCierreCajas.Rows.Clear();

            DateTime fechaSeleccionada = dateTimePickerCierreCajas.Value.Date;

            bool datosEncontrados = false;
            decimal totalCierre = 0;

            string[] archivos = { "Bomba1.txt", "Bomba2.txt", "Bomba3.txt", "Bomba4.txt" };
            foreach (string archivo in archivos)
            {
                string rutaArchivo = Path.Combine(@"C:\Users\Rony\Documents\Año 2024 Semestres\Programacion III\Proyectos o ejercicios\ProyectoFinalGasolinera\ProyectoFinalGasolinera\bin\Debug", archivo);

                if (File.Exists(rutaArchivo))
                {
                    string[] lineas = File.ReadAllLines(rutaArchivo);
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');

                        if (datos.Length >= 6)
                        {
                            if (DateTime.TryParseExact(datos[5], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaRegistro))
                            {
                                if (fechaRegistro.Date == fechaSeleccionada)
                                {
                                    if (decimal.TryParse(datos[4], out decimal precio))
                                    {
                                        dataGridViewCierreCajas.Rows.Add(datos[5], datos[4], datos[0], datos[3]);
                                        datosEncontrados = true;
                                        totalCierre += precio;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (!datosEncontrados)
            {
                MessageBox.Show("No hay cierres de día disponibles para la fecha seleccionada.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Cierre total del día: Q {totalCierre}", "Total del día", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonMAbasPre_Click(object sender, EventArgs e)
        {
            dataGridViewInformeAbaPrepa.Rows.Clear();

            DateTime fechaSeleccionada = dateTimePickerInfoAbasPrepa.Value.Date;

            bool datosEncontrados = false;

            string[] archivos = { "Bomba1.txt", "Bomba2.txt", "Bomba3.txt", "Bomba4.txt" };
            foreach (string archivo in archivos)
            {
                string rutaArchivo = Path.Combine(@"C:\Users\Rony\Documents\Año 2024 Semestres\Programacion III\Proyectos o ejercicios\ProyectoFinalGasolinera\ProyectoFinalGasolinera\bin\Debug", archivo);
                string nombreBomba = Path.GetFileNameWithoutExtension(archivo);

                if (File.Exists(rutaArchivo))
                {
                    string[] lineas = File.ReadAllLines(rutaArchivo);
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');

                        if (datos.Length >= 6)
                        {
                            if (DateTime.TryParseExact(datos[5], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaRegistro))
                            {
                                if (fechaRegistro.Date == fechaSeleccionada)
                                {
                                    if (datos[2].Trim() == "Seleccionar Cantidad de abastecimiento")
                                    {
                                        string fecha = datos[5];
                                        string nombreCliente = datos[0];
                                        string abastecimientoPrepago = datos[3];

                                        dataGridViewInformeAbaPrepa.Rows.Add(fecha, nombreCliente, abastecimientoPrepago, nombreBomba);
                                        datosEncontrados = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (!datosEncontrados)
            {
                MessageBox.Show("No se encontraron abastecimientos prepagos para la fecha seleccionada.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonMAbasTanq_Click(object sender, EventArgs e)
        {
            dataGridViewAbasLLeno.Rows.Clear();

            DateTime fechaSeleccionada = dateTimePickerAbasTanqueLleno.Value.Date;

            bool datosEncontrados = false;

            string[] archivos = { "Bomba1.txt", "Bomba2.txt", "Bomba3.txt", "Bomba4.txt" };
            foreach (string archivo in archivos)
            {
                string rutaArchivo = Path.Combine(@"C:\Users\Rony\Documents\Año 2024 Semestres\Programacion III\Proyectos o ejercicios\ProyectoFinalGasolinera\ProyectoFinalGasolinera\bin\Debug", archivo);
                string nombreBomba = Path.GetFileNameWithoutExtension(archivo);

                if (File.Exists(rutaArchivo))
                {
                    string[] lineas = File.ReadAllLines(rutaArchivo);
                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(',');

                        if (datos.Length >= 6)
                        {
                            if (DateTime.TryParseExact(datos[5], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaRegistro))
                            {
                                if (fechaRegistro.Date == fechaSeleccionada && datos[2].Trim() == "Tanque Lleno")
                                {
                                    string fecha = datos[5];
                                    string nombreCliente = datos[0];
                                    string abastecimientoTanqueLleno = "1000";
                                    dataGridViewAbasLLeno.Rows.Add(fecha, nombreCliente, abastecimientoTanqueLleno, nombreBomba);
                                    datosEncontrados = true;
                                }
                            }
                        }
                    }
                }
            }

            if (!datosEncontrados)
            {
                MessageBox.Show("No se encontraron abastecimientos de tanque lleno para la fecha seleccionada.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMostrarBombas_Click(object sender, EventArgs e)
        {

        }
    }
}
