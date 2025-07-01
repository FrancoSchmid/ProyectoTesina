namespace pryTesina
{
    partial class frmTurnosClases
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
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.rdbPartido = new System.Windows.Forms.RadioButton();
            this.rdbClase = new System.Windows.Forms.RadioButton();
            this.pnlPartido = new System.Windows.Forms.Panel();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.pnlClase = new System.Windows.Forms.Panel();
            this.dgvListaDeTurnos = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.pnlPartido.SuspendLayout();
            this.pnlClase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnBuscarCliente.Font = new System.Drawing.Font("MV Boli", 13.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(368, 19);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(199, 32);
            this.btnBuscarCliente.TabIndex = 48;
            this.btnBuscarCliente.Text = "BUSCAR CLIENTE";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1201, 496);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 49;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(153, 27);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(201, 20);
            this.txtDocumento.TabIndex = 61;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(153, 15);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(205, 21);
            this.cmbCategoria.TabIndex = 62;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(153, 58);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(205, 21);
            this.cmbProfesor.TabIndex = 63;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(153, 97);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(205, 20);
            this.txtAlumno.TabIndex = 67;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGuardar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(12, 468);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 64);
            this.btnGuardar.TabIndex = 69;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(138, 468);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 64);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVolver.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(489, 468);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 64);
            this.btnVolver.TabIndex = 71;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 20);
            this.txtNombre.TabIndex = 74;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(153, 99);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(203, 20);
            this.txtTelefono.TabIndex = 76;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnAgregarCliente.Font = new System.Drawing.Font("MV Boli", 12.6F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(368, 63);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(199, 32);
            this.btnAgregarCliente.TabIndex = 78;
            this.btnAgregarCliente.Text = "AGREGAR CLIENTE";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnBuscarAlumno.Font = new System.Drawing.Font("MV Boli", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAlumno.Location = new System.Drawing.Point(370, 15);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(198, 32);
            this.btnBuscarAlumno.TabIndex = 79;
            this.btnBuscarAlumno.Text = "BUSCAR ALUMNO";
            this.btnBuscarAlumno.UseVisualStyleBackColor = false;
            // 
            // rdbPartido
            // 
            this.rdbPartido.AutoSize = true;
            this.rdbPartido.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdbPartido.Location = new System.Drawing.Point(16, 23);
            this.rdbPartido.Name = "rdbPartido";
            this.rdbPartido.Size = new System.Drawing.Size(102, 29);
            this.rdbPartido.TabIndex = 81;
            this.rdbPartido.TabStop = true;
            this.rdbPartido.Text = "Partido";
            this.rdbPartido.UseVisualStyleBackColor = true;
            // 
            // rdbClase
            // 
            this.rdbClase.AutoSize = true;
            this.rdbClase.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdbClase.Location = new System.Drawing.Point(17, 215);
            this.rdbClase.Name = "rdbClase";
            this.rdbClase.Size = new System.Drawing.Size(77, 29);
            this.rdbClase.TabIndex = 82;
            this.rdbClase.TabStop = true;
            this.rdbClase.Text = "Clase";
            this.rdbClase.UseVisualStyleBackColor = true;
            this.rdbClase.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pnlPartido
            // 
            this.pnlPartido.Controls.Add(this.lblTelefono);
            this.pnlPartido.Controls.Add(this.lblNombre);
            this.pnlPartido.Controls.Add(this.lblDocumento);
            this.pnlPartido.Controls.Add(this.btnBuscarCliente);
            this.pnlPartido.Controls.Add(this.txtDocumento);
            this.pnlPartido.Controls.Add(this.txtNombre);
            this.pnlPartido.Controls.Add(this.btnAgregarCliente);
            this.pnlPartido.Controls.Add(this.txtTelefono);
            this.pnlPartido.Location = new System.Drawing.Point(13, 58);
            this.pnlPartido.Name = "pnlPartido";
            this.pnlPartido.Size = new System.Drawing.Size(586, 135);
            this.pnlPartido.TabIndex = 83;
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTelefono.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(24, 92);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(123, 27);
            this.lblTelefono.TabIndex = 81;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(24, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(123, 27);
            this.lblNombre.TabIndex = 80;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDocumento
            // 
            this.lblDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDocumento.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDocumento.Location = new System.Drawing.Point(24, 19);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(123, 28);
            this.lblDocumento.TabIndex = 79;
            this.lblDocumento.Text = "Documento";
            this.lblDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlClase
            // 
            this.pnlClase.Controls.Add(this.dgvListaDeTurnos);
            this.pnlClase.Controls.Add(this.lblAlumno);
            this.pnlClase.Controls.Add(this.lblProfesor);
            this.pnlClase.Controls.Add(this.lblCategoria);
            this.pnlClase.Controls.Add(this.btnAgregarAlumno);
            this.pnlClase.Controls.Add(this.cmbCategoria);
            this.pnlClase.Controls.Add(this.cmbProfesor);
            this.pnlClase.Controls.Add(this.btnBuscarAlumno);
            this.pnlClase.Controls.Add(this.txtAlumno);
            this.pnlClase.Location = new System.Drawing.Point(12, 249);
            this.pnlClase.Name = "pnlClase";
            this.pnlClase.Size = new System.Drawing.Size(587, 203);
            this.pnlClase.TabIndex = 84;
            // 
            // dgvListaDeTurnos
            // 
            this.dgvListaDeTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.Profesor,
            this.Alumno1,
            this.Alumno2,
            this.Alumno3,
            this.Alumno4});
            this.dgvListaDeTurnos.Location = new System.Drawing.Point(1, 132);
            this.dgvListaDeTurnos.Name = "dgvListaDeTurnos";
            this.dgvListaDeTurnos.Size = new System.Drawing.Size(586, 62);
            this.dgvListaDeTurnos.TabIndex = 85;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 70;
            // 
            // Profesor
            // 
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            // 
            // Alumno1
            // 
            this.Alumno1.HeaderText = "Alumno 1";
            this.Alumno1.Name = "Alumno1";
            // 
            // Alumno2
            // 
            this.Alumno2.HeaderText = "Alumno 2";
            this.Alumno2.Name = "Alumno2";
            // 
            // Alumno3
            // 
            this.Alumno3.HeaderText = "Alumno 3";
            this.Alumno3.Name = "Alumno3";
            // 
            // Alumno4
            // 
            this.Alumno4.HeaderText = "Alumno 4";
            this.Alumno4.Name = "Alumno4";
            // 
            // lblAlumno
            // 
            this.lblAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAlumno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlumno.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAlumno.Location = new System.Drawing.Point(24, 88);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(123, 27);
            this.lblAlumno.TabIndex = 84;
            this.lblAlumno.Text = "Alumno";
            this.lblAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfesor
            // 
            this.lblProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProfesor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProfesor.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblProfesor.Location = new System.Drawing.Point(24, 52);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(123, 27);
            this.lblProfesor.TabIndex = 83;
            this.lblProfesor.Text = "Profesor";
            this.lblProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoria.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(24, 15);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(123, 28);
            this.lblCategoria.TabIndex = 82;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnAgregarAlumno.Font = new System.Drawing.Font("MV Boli", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAlumno.Location = new System.Drawing.Point(370, 58);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(198, 32);
            this.btnAgregarAlumno.TabIndex = 81;
            this.btnAgregarAlumno.Text = "AGREGAR ALUMNO";
            this.btnAgregarAlumno.UseVisualStyleBackColor = false;
            // 
            // frmTurnosClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 544);
            this.Controls.Add(this.pnlClase);
            this.Controls.Add(this.pnlPartido);
            this.Controls.Add(this.rdbClase);
            this.Controls.Add(this.rdbPartido);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmTurnosClases";
            this.Text = "Turno";
            this.pnlPartido.ResumeLayout(false);
            this.pnlPartido.PerformLayout();
            this.pnlClase.ResumeLayout(false);
            this.pnlClase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.RadioButton rdbPartido;
        private System.Windows.Forms.RadioButton rdbClase;
        private System.Windows.Forms.Panel pnlPartido;
        private System.Windows.Forms.Panel pnlClase;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridView dgvListaDeTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno4;
    }
}