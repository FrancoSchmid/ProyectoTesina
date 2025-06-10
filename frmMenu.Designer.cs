namespace pryTesina
{
    partial class frmMenu
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
            this.btnBaseDatos = new System.Windows.Forms.Button();
            this.btnTorneos = new System.Windows.Forms.Button();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.btnClases = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnBaseDatos.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseDatos.ForeColor = System.Drawing.Color.White;
            this.btnBaseDatos.Location = new System.Drawing.Point(34, 25);
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(184, 70);
            this.btnBaseDatos.TabIndex = 44;
            this.btnBaseDatos.Text = "BASE DE DATOS";
            this.btnBaseDatos.UseVisualStyleBackColor = false;
            // 
            // btnTorneos
            // 
            this.btnTorneos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnTorneos.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTorneos.ForeColor = System.Drawing.Color.White;
            this.btnTorneos.Location = new System.Drawing.Point(224, 25);
            this.btnTorneos.Name = "btnTorneos";
            this.btnTorneos.Size = new System.Drawing.Size(184, 70);
            this.btnTorneos.TabIndex = 43;
            this.btnTorneos.Text = "TORNEOS";
            this.btnTorneos.UseVisualStyleBackColor = false;
            // 
            // btnTurnos
            // 
            this.btnTurnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnTurnos.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.ForeColor = System.Drawing.Color.White;
            this.btnTurnos.Location = new System.Drawing.Point(414, 25);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(184, 70);
            this.btnTurnos.TabIndex = 42;
            this.btnTurnos.Text = "TURNOS";
            this.btnTurnos.UseVisualStyleBackColor = false;
            // 
            // btnClases
            // 
            this.btnClases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnClases.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClases.ForeColor = System.Drawing.Color.White;
            this.btnClases.Location = new System.Drawing.Point(604, 25);
            this.btnClases.Name = "btnClases";
            this.btnClases.Size = new System.Drawing.Size(184, 70);
            this.btnClases.TabIndex = 41;
            this.btnClases.Text = "CLASES";
            this.btnClases.UseVisualStyleBackColor = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.btnBaseDatos);
            this.Controls.Add(this.btnTorneos);
            this.Controls.Add(this.btnTurnos);
            this.Controls.Add(this.btnClases);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaseDatos;
        private System.Windows.Forms.Button btnTorneos;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Button btnClases;
    }
}