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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnBaseDatos = new System.Windows.Forms.Button();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnBaseDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBaseDatos.BackgroundImage")));
            this.btnBaseDatos.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold);
            this.btnBaseDatos.ForeColor = System.Drawing.Color.White;
            this.btnBaseDatos.Location = new System.Drawing.Point(449, 12);
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(380, 387);
            this.btnBaseDatos.TabIndex = 44;
            this.btnBaseDatos.Text = "BASE DE DATOS";
            this.btnBaseDatos.UseVisualStyleBackColor = false;
            // 
            // btnTurnos
            // 
            this.btnTurnos.BackColor = System.Drawing.Color.Transparent;
            this.btnTurnos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTurnos.BackgroundImage")));
            this.btnTurnos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTurnos.FlatAppearance.BorderSize = 5;
            this.btnTurnos.Font = new System.Drawing.Font("MV Boli", 31F, System.Drawing.FontStyle.Bold);
            this.btnTurnos.ForeColor = System.Drawing.Color.White;
            this.btnTurnos.Location = new System.Drawing.Point(53, 12);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(380, 387);
            this.btnTurnos.TabIndex = 42;
            this.btnTurnos.Text = "TURNOS";
            this.btnTurnos.UseVisualStyleBackColor = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.btnBaseDatos);
            this.Controls.Add(this.btnTurnos);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaseDatos;
        private System.Windows.Forms.Button btnTurnos;
    }
}