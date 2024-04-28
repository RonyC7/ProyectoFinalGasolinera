using ProyectoFinalGasolinera.FormulariosBomba1;
using ProyectoFinalGasolinera.FormulariosBomba2;
using ProyectoFinalGasolinera.FormulariosBomba3;
using ProyectoFinalGasolinera.FormulariosBomba4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera
{
    public partial class FormPrincipal : Form
    {
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

            DatosClientes1 formDatosClientes1 = new DatosClientes1();

            formDatosClientes1.Show();
        }

        private void btnEAbas1_Click(object sender, EventArgs e)
        {
            this.Hide();

            EstadoAbastecimiento1 formEstadoAbastecimiento1 = new EstadoAbastecimiento1();

            formEstadoAbastecimiento1.Show();
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
