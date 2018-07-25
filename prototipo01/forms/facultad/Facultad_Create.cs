﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.facultad
{
    public partial class Facultad_Create : Form
    {
        public Facultad_Create()
        {
            InitializeComponent();
        }


        private void openForm(object formHijo)
        {
            this.Controls.Clear();
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Controls.Add(fh);
            this.Tag = fh;
            fh.Show();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openForm(new Listado_facultades());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
