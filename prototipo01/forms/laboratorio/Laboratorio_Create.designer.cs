﻿namespace prototipo01
{
    partial class Laboratorio_Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CRUD = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbo_horario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.cbo_salon = new System.Windows.Forms.ComboBox();
            this.Cbo_catedratico = new System.Windows.Forms.ComboBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CRUD.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.tabPage1);
            this.CRUD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD.Location = new System.Drawing.Point(40, 143);
            this.CRUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CRUD.Name = "CRUD";
            this.CRUD.SelectedIndex = 0;
            this.CRUD.Size = new System.Drawing.Size(870, 426);
            this.CRUD.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbo_horario);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Btn_crear);
            this.tabPage1.Controls.Add(this.cbo_salon);
            this.tabPage1.Controls.Add(this.Cbo_catedratico);
            this.tabPage1.Controls.Add(this.Txt_nombre);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(862, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbo_horario
            // 
            this.cbo_horario.FormattingEnabled = true;
            this.cbo_horario.Location = new System.Drawing.Point(296, 269);
            this.cbo_horario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_horario.Name = "cbo_horario";
            this.cbo_horario.Size = new System.Drawing.Size(370, 27);
            this.cbo_horario.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(189, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Horario";
            // 
            // Btn_crear
            // 
            this.Btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_crear.FlatAppearance.BorderSize = 0;
            this.Btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear.ForeColor = System.Drawing.Color.White;
            this.Btn_crear.Image = global::prototipo01.Properties.Resources.iconmonstr_edit_11_24;
            this.Btn_crear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_crear.Location = new System.Drawing.Point(296, 335);
            this.Btn_crear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(145, 41);
            this.Btn_crear.TabIndex = 5;
            this.Btn_crear.Text = "Crear";
            this.Btn_crear.UseVisualStyleBackColor = false;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // cbo_salon
            // 
            this.cbo_salon.FormattingEnabled = true;
            this.cbo_salon.Location = new System.Drawing.Point(296, 192);
            this.cbo_salon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_salon.Name = "cbo_salon";
            this.cbo_salon.Size = new System.Drawing.Size(370, 27);
            this.cbo_salon.TabIndex = 3;
            // 
            // Cbo_catedratico
            // 
            this.Cbo_catedratico.FormattingEnabled = true;
            this.Cbo_catedratico.Location = new System.Drawing.Point(296, 115);
            this.Cbo_catedratico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_catedratico.Name = "Cbo_catedratico";
            this.Cbo_catedratico.Size = new System.Drawing.Size(370, 27);
            this.Cbo_catedratico.TabIndex = 2;
            this.Cbo_catedratico.SelectedIndexChanged += new System.EventHandler(this.Cbo_edificio_SelectedIndexChanged);
            this.Cbo_catedratico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_nombre.Location = new System.Drawing.Point(296, 40);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_nombre.MaxLength = 45;
            this.Txt_nombre.Multiline = true;
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(370, 28);
            this.Txt_nombre.TabIndex = 1;
            this.Txt_nombre.TextChanged += new System.EventHandler(this.Txt_nombre_TextChanged);
            this.Txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(128, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dpi catedratico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(202, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "salon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(184, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 50);
            this.panel1.TabIndex = 2;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackgroundImage = global::prototipo01.Properties.Resources.iconmonstr_angel_left_circle_thin_24;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(822, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(50, 50);
            this.btn_cerrar.TabIndex = 10;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Laboratorio";
            // 
            // Laboratorio_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 578);
            this.Controls.Add(this.CRUD);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Laboratorio_Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio";
            this.Load += new System.EventHandler(this.Laboratorio_Create_Load);
            this.CRUD.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CRUD;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_catedratico;
        private System.Windows.Forms.ComboBox cbo_salon;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.ComboBox cbo_horario;
        private System.Windows.Forms.Label label5;
    }
}