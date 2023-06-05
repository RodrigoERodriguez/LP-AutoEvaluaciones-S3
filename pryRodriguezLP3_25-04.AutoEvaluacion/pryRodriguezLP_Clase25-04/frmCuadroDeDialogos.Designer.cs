namespace pryRodriguezLP_Clase25_04
{
    partial class frmCuadroDeDialogos
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEntradaT = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSalidaT = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 14;
            // 
            // lblEntradaT
            // 
            this.lblEntradaT.AutoSize = true;
            this.lblEntradaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaT.Location = new System.Drawing.Point(22, 30);
            this.lblEntradaT.Name = "lblEntradaT";
            this.lblEntradaT.Size = new System.Drawing.Size(65, 16);
            this.lblEntradaT.TabIndex = 13;
            this.lblEntradaT.Text = "Entrada:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 16;
            // 
            // lblSalidaT
            // 
            this.lblSalidaT.AutoSize = true;
            this.lblSalidaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalidaT.Location = new System.Drawing.Point(22, 73);
            this.lblSalidaT.Name = "lblSalidaT";
            this.lblSalidaT.Size = new System.Drawing.Size(56, 16);
            this.lblSalidaT.TabIndex = 15;
            this.lblSalidaT.Text = "Salida:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(125, 135);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 29);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCuadroDeDialogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 197);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSalidaT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEntradaT);
            this.Name = "frmCuadroDeDialogos";
            this.Text = "Romanos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEntradaT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSalidaT;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}