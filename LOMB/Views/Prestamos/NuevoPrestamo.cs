﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOMB.Views
{
    public partial class NuevoPrestamo : Form
    {
        public NuevoPrestamo()
        {
            InitializeComponent();
        }

        private void cmbBoxEjemplar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxLector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxLibro.Text = string.Empty;
            cmbBoxEjemplar.Items.Clear();
            cmbBoxLector.Items.Clear();
        }
    }
}
