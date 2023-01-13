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
            ((System.ComponentModel.ISupportInitialize)(this.dataListaMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaMedico
            // 
            this.dataListaMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaMedico.Location = new System.Drawing.Point(12, 12);
            this.dataListaMedico.Name = "dataListaMedico";
            this.dataListaMedico.Size = new System.Drawing.Size(398, 375);
            this.dataListaMedico.TabIndex = 0;
            // 
            // medicoClinico
            // 
            this.medicoClinico.FormattingEnabled = true;
            this.medicoClinico.Location = new System.Drawing.Point(416, 12);
            this.medicoClinico.Name = "medicoClinico";
            this.medicoClinico.Size = new System.Drawing.Size(186, 121);
            this.medicoClinico.TabIndex = 1;
            // 
            // listNumeroHabitacion
            // 
            this.listNumeroHabitacion.FormattingEnabled = true;
            this.listNumeroHabitacion.Location = new System.Drawing.Point(416, 139);
            this.listNumeroHabitacion.Name = "listNumeroHabitacion";
            this.listNumeroHabitacion.Size = new System.Drawing.Size(186, 121);
            this.listNumeroHabitacion.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.listNumeroHabitacion);
            this.Controls.Add(this.medicoClinico);
            this.Controls.Add(this.dataListaMedico);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataListaMedico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaMedico;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox medicoClinico;
        private System.Windows.Forms.ListBox listNumeroHabitacion;
    }
}

