using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba2
{
    public partial class EstadoAbastecimiento2 : Form
    {
        public EstadoAbastecimiento2()
        {
            InitializeComponent();
        }

        private void btncerrar2_Click(object sender, EventArgs e)
        {
            this.Close();

            FormPrincipal formPrincipal = new FormPrincipal();

            formPrincipal.Show();
        }
    }
}
