﻿using prototipo01.controladores;
using prototipo01.forms;
using prototipo01.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)textBox1;
            string email = objTextBox.Text;

            TextBox objTextBox2 = (TextBox)textBox2;
            string pass = objTextBox2.Text;


            if (login(email,pass))
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }

            //this.Hide();
            //Dashboard dashboard = new Dashboard();
            //dashboard.Show();

        }



        public Boolean login(String correo, String password)
        {
            ControladorUsuario controladorUsuario = new ControladorUsuario();
            usuario user = controladorUsuario.buscarUsuarioCorreo(correo);
            return controladorUsuario.login(user, password);
        }

    }


    

}
//eddy lopez