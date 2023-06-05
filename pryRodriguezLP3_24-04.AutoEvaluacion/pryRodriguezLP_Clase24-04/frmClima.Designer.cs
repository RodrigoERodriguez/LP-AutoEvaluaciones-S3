namespace pryRodriguezLP_Clase24_04
{
    partial class frmClima
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
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.lblMinima = new System.Windows.Forms.Label();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(18, 41);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(94, 16);
            this.lblLocalidad.TabIndex = 0;
            this.lblLocalidad.Text = "LOCALIDAD:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(18, 80);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 16);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "FECHA:";
            // 
            // lblMaxima
            // 
            this.lblMaxima.AutoSize = true;
            this.lblMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxima.Location = new System.Drawing.Point(18, 155);
            this.lblMaxima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(68, 16);
            this.lblMaxima.TabIndex = 3;
            this.lblMaxima.Text = "MAXIMA:";
            // 
            // lblMinima
            // 
            this.lblMinima.AutoSize = true;
            this.lblMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinima.Location = new System.Drawing.Point(18, 116);
            this.lblMinima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinima.Name = "lblMinima";
            this.lblMinima.Size = new System.Drawing.Size(64, 16);
            this.lblMinima.TabIndex = 2;
            this.lblMinima.Text = "MINIMA:";
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(132, 31);
            this.cbLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(180, 24);
            this.cbLocalidad.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(116, 80);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(298, 22);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.UseWaitCursor = true;
            this.dtpFecha.Value = new System.DateTime(2023, 4, 24, 0, 0, 0, 0);
            // 
            // lblMin
            // 
            this.lblMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMin.Location = new System.Drawing.Point(116, 116);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(117, 19);
            this.lblMin.TabIndex = 6;
            // 
            // lblMax
            // 
            this.lblMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMax.Location = new System.Drawing.Point(116, 155);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(117, 19);
            this.lblMax.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(180, 206);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmClima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 253);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbLocalidad);
            this.Controls.Add(this.lblMaxima);
            this.Controls.Add(this.lblMinima);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblLocalidad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClima";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmClima_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMaxima;
        private System.Windows.Forms.Label lblMinima;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnBuscar;
    }
}

