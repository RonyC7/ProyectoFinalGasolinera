﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalGasolinera.FormulariosBomba3
{
    public partial class EstadoAbastecimiento3 : Form
    {
        public EstadoAbastecimiento3()
        {
            InitializeComponent();
        }

        private void btncerrar3_Click(object sender, EventArgs e)
        {
            this.Close();

            FormPrincipal formPrincipal = new FormPrincipal();

            formPrincipal.Show();
        }
    }
}
