using ProyectoFinalGasolinera.FormulariosBomba1;
using ProyectoFinalGasolinera.FormulariosBomba2;
using ProyectoFinalGasolinera.FormulariosBomba3;
using ProyectoFinalGasolinera.FormulariosBomba4;
using System;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera
{
    public partial class FormPrincipal : Form
    {
        private DatosClientes1 datosClientesForm1;
        private EstadoAbastecimiento1 estadoAbastecimientoForm1;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnDclientes2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosClientes2 formDatosClientes2 = new DatosClientes2();
            formDatosClientes2.Show();
        }

        private void btnDClientes1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (datosClientesForm1 == null || datosClientesForm1.IsDisposed)
            {
                datosClientesForm1 = new DatosClientes1();
            }
            datosClientesForm1.Show();
        }

        private void btnEAbas1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (estadoAbastecimientoForm1 == null || estadoAbastecimientoForm1.IsDisposed)
            {
                estadoAbastecimientoForm1 = new EstadoAbastecimiento1();
            }
            estadoAbastecimientoForm1.Show();
        }

        private void btnEAbas2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstadoAbastecimiento2 formEstadoAbastecimiento2 = new EstadoAbastecimiento2();
            formEstadoAbastecimiento2.Show();
        }

        private void Clientes3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosClientes3 formDatosClientes3 = new DatosClientes3();
            formDatosClientes3.Show();
        }

        private void btnEAbas3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstadoAbastecimiento3 formEstadoAbastecimiento3 = new EstadoAbastecimiento3();
            formEstadoAbastecimiento3.Show();
        }

        private void btnClientes4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosCliente4 formDatosClientes4 = new DatosCliente4();
            formDatosClientes4.Show();
        }

        private void btnEAbas4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstadoAbastecimiento4_1 formEstadoAbastecimiento4 = new EstadoAbastecimiento4_1();
            formEstadoAbastecimiento4.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConfiguracion formConfiguracion = new FormConfiguracion();
            formConfiguracion.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEstadistica formEstadistica = new FormEstadistica();
            formEstadistica.Show();
        }
    }
}
