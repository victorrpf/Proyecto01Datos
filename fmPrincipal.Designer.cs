namespace Proyecto01Datos
{
    partial class fmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.etMantenimiento = new System.Windows.Forms.Label();
            this.btPorComandos = new System.Windows.Forms.Button();
            this.btAutomatico = new System.Windows.Forms.Button();
            this.btDefinitivo = new System.Windows.Forms.Button();
            this.btConsultas = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAcercade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etMantenimiento
            // 
            this.etMantenimiento.AutoSize = true;
            this.etMantenimiento.Location = new System.Drawing.Point(108, 9);
            this.etMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etMantenimiento.Name = "etMantenimiento";
            this.etMantenimiento.Size = new System.Drawing.Size(232, 25);
            this.etMantenimiento.TabIndex = 0;
            this.etMantenimiento.Text = "Mantenimiento de Tablas";
            // 
            // btPorComandos
            // 
            this.btPorComandos.AutoSize = true;
            this.btPorComandos.Location = new System.Drawing.Point(134, 55);
            this.btPorComandos.Name = "btPorComandos";
            this.btPorComandos.Size = new System.Drawing.Size(182, 35);
            this.btPorComandos.TabIndex = 1;
            this.btPorComandos.Text = "Por Comandos";
            this.btPorComandos.UseVisualStyleBackColor = true;
            this.btPorComandos.Click += new System.EventHandler(this.btPorComandos_Click);
            // 
            // btAutomatico
            // 
            this.btAutomatico.AutoSize = true;
            this.btAutomatico.Location = new System.Drawing.Point(134, 113);
            this.btAutomatico.Name = "btAutomatico";
            this.btAutomatico.Size = new System.Drawing.Size(182, 35);
            this.btAutomatico.TabIndex = 2;
            this.btAutomatico.Text = "Automático";
            this.btAutomatico.UseVisualStyleBackColor = true;
            this.btAutomatico.Click += new System.EventHandler(this.btAutomatico_Click);
            // 
            // btDefinitivo
            // 
            this.btDefinitivo.AutoSize = true;
            this.btDefinitivo.Location = new System.Drawing.Point(134, 172);
            this.btDefinitivo.Name = "btDefinitivo";
            this.btDefinitivo.Size = new System.Drawing.Size(182, 35);
            this.btDefinitivo.TabIndex = 3;
            this.btDefinitivo.Text = "Definitivo";
            this.btDefinitivo.UseVisualStyleBackColor = true;
            this.btDefinitivo.Click += new System.EventHandler(this.btDefinitivo_Click);
            // 
            // btConsultas
            // 
            this.btConsultas.AutoSize = true;
            this.btConsultas.Location = new System.Drawing.Point(134, 233);
            this.btConsultas.Name = "btConsultas";
            this.btConsultas.Size = new System.Drawing.Size(182, 35);
            this.btConsultas.TabIndex = 4;
            this.btConsultas.Text = "Consultas y Filtros";
            this.btConsultas.UseVisualStyleBackColor = true;
            this.btConsultas.Click += new System.EventHandler(this.btConsultas_Click);
            // 
            // btSalir
            // 
            this.btSalir.AutoSize = true;
            this.btSalir.Location = new System.Drawing.Point(134, 293);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(182, 35);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAcercade
            // 
            this.btAcercade.AutoSize = true;
            this.btAcercade.Location = new System.Drawing.Point(134, 355);
            this.btAcercade.Name = "btAcercade";
            this.btAcercade.Size = new System.Drawing.Size(182, 35);
            this.btAcercade.TabIndex = 6;
            this.btAcercade.Text = "Acerca de";
            this.btAcercade.UseVisualStyleBackColor = true;
            // 
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 414);
            this.Controls.Add(this.btAcercade);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btConsultas);
            this.Controls.Add(this.btDefinitivo);
            this.Controls.Add(this.btAutomatico);
            this.Controls.Add(this.btPorComandos);
            this.Controls.Add(this.etMantenimiento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmPrincipal";
            this.Text = "Formulario Principal del Proyecto 01Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etMantenimiento;
        private System.Windows.Forms.Button btPorComandos;
        private System.Windows.Forms.Button btAutomatico;
        private System.Windows.Forms.Button btDefinitivo;
        private System.Windows.Forms.Button btConsultas;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAcercade;
    }
}

