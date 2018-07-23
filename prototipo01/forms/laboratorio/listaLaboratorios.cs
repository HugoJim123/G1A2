﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo01.controladores;
using prototipo01.Dto;

namespace prototipo01
{
    public partial class listaLaboratorios : Form
    {

        BindingList<laboratorioDto> laboratorioDataSource = new BindingList<laboratorioDto>();
        ControladorLaboratorio controladorLaboratorio = new ControladorLaboratorio();

        public listaLaboratorios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Laboratorio_Create lcre = new Laboratorio_Create();
            lcre.Show();

            //this.Hide();
        }


        private void refreshDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            laboratorioDataSource = controladorLaboratorio.listLaboratorios();
            dataGridView1.DataSource = laboratorioDataSource;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Laboratorio_Update lup = new Laboratorio_Update();
            lup.Show();

            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void listaLaboratorios_Load(object sender, EventArgs e)
        {
            refreshDataSource();
        }
    }
}
