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
using prototipo01.models;

namespace prototipo01
{
    public partial class Laboratorio_Create : Form
    {

        ControladorLaboratorio controladorLaboratorio = new ControladorLaboratorio();

        public Laboratorio_Create()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //listaLaboratorios listlab = new listaLaboratorios();
            //listlab.Show();

            this.Dispose();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_nombre.Text)  || string.IsNullOrEmpty(Cbo_catedratico.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void dataSalones()
        {
            cbo_salon.DataSource = controladorLaboratorio.getSalones();
            cbo_salon.DisplayMember = "Name";
            cbo_salon.ValueMember = "id_salon";


        }


        private void dataCatedraicos()
        {

            Cbo_catedratico.DataSource = controladorLaboratorio.getCatedraticos();
            Cbo_catedratico.DisplayMember = "Name";
            Cbo_catedratico.ValueMember = "dpi_catedratico";

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Clases.Validacion.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void Cbo_edificio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {

            string nombre_laboratorio = Txt_nombre.Text.ToString();
            int id_catedratico = Convert.ToInt32(Cbo_catedratico.Text.ToString());
            int id_salon = Convert.ToInt32(cbo_salon.Text.ToString());


            controladorLaboratorio.guardarlaboratorio(nombre_laboratorio,id_catedratico,1,id_salon);


        }

        private void Laboratorio_Create_Load(object sender, EventArgs e)
        {
            dataSalones();
            dataCatedraicos();
        }

        private void Txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
