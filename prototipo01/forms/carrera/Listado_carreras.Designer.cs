﻿namespace prototipo01.forms.carrera
{
    partial class Listado_carreras
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
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(112)))));
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.6F, System.Drawing.FontStyle.Bold);
            this.Btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.Location = new System.Drawing.Point(727, 260);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(82, 41);
            this.Btn_Actualizar.TabIndex = 26;
            this.Btn_Actualizar.Text = "ACTUALIZAR";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Location = new System.Drawing.Point(812, 260);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(82, 41);
            this.Btn_Eliminar.TabIndex = 25;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(46, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Buscar";
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox1.Location = new System.Drawing.Point(118, 201);
            this.txtBox1.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(524, 39);
            this.txtBox1.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.ubicacion});
            this.dataGridView1.Location = new System.Drawing.Point(49, 260);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 323);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 330;
            // 
            // ubicacion
            // 
            this.ubicacion.HeaderText = "Ubicación";
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.ReadOnly = true;
            this.ubicacion.Width = 430;
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_Crear.FlatAppearance.BorderSize = 0;
            this.Btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Crear.ForeColor = System.Drawing.Color.White;
            this.Btn_Crear.Location = new System.Drawing.Point(766, 132);
            this.Btn_Crear.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(82, 41);
            this.Btn_Crear.TabIndex = 22;
            this.Btn_Crear.Text = "CREAR";
            this.Btn_Crear.UseVisualStyleBackColor = false;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 48);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Carreras";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_Buscar.BackgroundImage = global::prototipo01.Properties.Resources.iconmonstr_magnifier_1_32;
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(646, 201);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(39, 39);
            this.Btn_Buscar.TabIndex = 27;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Listado_carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 612);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Crear);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_carreras";
            this.Text = "Listado_carreras";
            this.Load += new System.EventHandler(this.Listado_carreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}