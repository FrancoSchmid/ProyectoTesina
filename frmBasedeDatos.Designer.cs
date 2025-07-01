namespace pryTesina
{
    partial class frmBasedeDatos
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
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvBuscarBaseDeDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarBaseDeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Clientes",
            "Alumnos",
            "Profesores"});
            this.cmbBuscar.Location = new System.Drawing.Point(162, 24);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(192, 21);
            this.cmbBuscar.TabIndex = 64;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnBuscar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(12, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 37);
            this.btnBuscar.TabIndex = 63;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvBuscarBaseDeDatos
            // 
            this.dgvBuscarBaseDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarBaseDeDatos.Location = new System.Drawing.Point(12, 55);
            this.dgvBuscarBaseDeDatos.Name = "dgvBuscarBaseDeDatos";
            this.dgvBuscarBaseDeDatos.Size = new System.Drawing.Size(853, 450);
            this.dgvBuscarBaseDeDatos.TabIndex = 65;
            // 
            // frmBasedeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 517);
            this.Controls.Add(this.dgvBuscarBaseDeDatos);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmBasedeDatos";
            this.Text = "frmBasedeDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarBaseDeDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvBuscarBaseDeDatos;
    }
}