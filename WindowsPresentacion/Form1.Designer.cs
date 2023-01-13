namespace WindowsPresentacion
{
    partial class Form1
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
            this.dataListaMedico = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.medicoClinico = new System.Windows.Forms.ListBox();
            this.listNumeroHabitacion = new System.Windows.Forms.ListBox();
            this.dataListaPacientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaMedico
            // 
            this.dataListaMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaMedico.Location = new System.Drawing.Point(12, 62);
            this.dataListaMedico.Name = "dataListaMedico";
            this.dataListaMedico.Size = new System.Drawing.Size(757, 151);
            this.dataListaMedico.TabIndex = 0;
            // 
            // medicoClinico
            // 
            this.medicoClinico.FormattingEnabled = true;
            this.medicoClinico.Location = new System.Drawing.Point(816, 27);
            this.medicoClinico.Name = "medicoClinico";
            this.medicoClinico.Size = new System.Drawing.Size(235, 186);
            this.medicoClinico.TabIndex = 1;
            // 
            // listNumeroHabitacion
            // 
            this.listNumeroHabitacion.FormattingEnabled = true;
            this.listNumeroHabitacion.Location = new System.Drawing.Point(816, 241);
            this.listNumeroHabitacion.Name = "listNumeroHabitacion";
            this.listNumeroHabitacion.Size = new System.Drawing.Size(235, 186);
            this.listNumeroHabitacion.TabIndex = 2;
            // 
            // dataListaPacientes
            // 
            this.dataListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaPacientes.Location = new System.Drawing.Point(12, 276);
            this.dataListaPacientes.Name = "dataListaPacientes";
            this.dataListaPacientes.Size = new System.Drawing.Size(757, 151);
            this.dataListaPacientes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de Medicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de pacientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(813, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de medicos clinicos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(813, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista de habitaciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 463);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataListaPacientes);
            this.Controls.Add(this.listNumeroHabitacion);
            this.Controls.Add(this.medicoClinico);
            this.Controls.Add(this.dataListaMedico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaMedico;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox medicoClinico;
        private System.Windows.Forms.ListBox listNumeroHabitacion;
        private System.Windows.Forms.DataGridView dataListaPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

