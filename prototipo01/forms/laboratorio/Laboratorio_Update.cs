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
    public partial class Laboratorio_Update : Form
    {

        ControladorLaboratorio controladorLaboratorio = new ControladorLaboratorio();
        private int reference;

        public Laboratorio_Update()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //listaLaboratorios listlab = new listaLaboratorios();
            //listlab.Show();

            this.Dispose();
        }

        private void dataSalones()
        {
            Cbo_salon.DataSource = controladorLaboratorio.getSalones();
            Cbo_salon.DisplayMember = "Name";
            Cbo_salon.ValueMember = "id_salon";


        }


        private void dataCatedraticos()
        {

            Cbo_catedratico.DataSource = controladorLaboratorio.getCatedraticos();
            Cbo_catedratico.DisplayMember = "Name";
            Cbo_catedratico.ValueMember = "dpi_catedratico";

        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Clases.Validacion.SoloLetras(e);
        }

        private void Cbo_edificio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);

        }

        private void Txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_nombre.Text)  || string.IsNullOrEmpty(Cbo_catedratico.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Laboratorio_Update_Load(object sender, EventArgs e)
        {
            dataSalones();
            dataCatedraticos();

            laboratorio  Model = controladorLaboratorio.buscarLaboratorio(reference);
            Txt_nombre.Text = Model.descripcion_laboratorio.ToString();

        }

        private void Btn_actualizar_Click_1(object sender, EventArgs e)
        {
            string nombre = Txt_nombre.Text.ToString();
            int dpi_catedratico = Convert.ToInt32(Cbo_catedratico.Text.ToString());
            int id_salon = Convert.ToInt32(Cbo_salon.Text.ToString());


            controladorLaboratorio.actualizarLaboratorio(reference,nombre,dpi_catedratico,1,id_salon);
            
        }
    }
}
