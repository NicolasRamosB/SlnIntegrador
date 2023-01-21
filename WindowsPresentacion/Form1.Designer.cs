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
            this.btnInsertarMedico = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNombreMedico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textApeMedico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textDomiMedico = new System.Windows.Forms.TextBox();
            this.textEspMedico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textMatMedico = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textTelMedico = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textEmailMedico = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaMedico
            // 
            this.dataListaMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaMedico.Location = new System.Drawing.Point(121, 141);
            this.dataListaMedico.Name = "dataListaMedico";
            this.dataListaMedico.Size = new System.Drawing.Size(822, 151);
            this.dataListaMedico.TabIndex = 0;
            // 
            // medicoClinico
            // 
            this.medicoClinico.FormattingEnabled = true;
            this.medicoClinico.Location = new System.Drawing.Point(1008, 106);
            this.medicoClinico.Name = "medicoClinico";
            this.medicoClinico.Size = new System.Drawing.Size(235, 186);
            this.medicoClinico.TabIndex = 1;
            // 
            // listNumeroHabitacion
            // 
            this.listNumeroHabitacion.FormattingEnabled = true;
            this.listNumeroHabitacion.Location = new System.Drawing.Point(1008, 441);
            this.listNumeroHabitacion.Name = "listNumeroHabitacion";
            this.listNumeroHabitacion.Size = new System.Drawing.Size(235, 186);
            this.listNumeroHabitacion.TabIndex = 2;
            // 
            // dataListaPacientes
            // 
            this.dataListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaPacientes.Location = new System.Drawing.Point(121, 476);
            this.dataListaPacientes.Name = "dataListaPacientes";
            this.dataListaPacientes.Size = new System.Drawing.Size(822, 151);
            this.dataListaPacientes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de Medicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de pacientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1006, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de medicos clinicos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1005, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista de habitaciones";
            // 
            // btnInsertarMedico
            // 
            this.btnInsertarMedico.Location = new System.Drawing.Point(23, 141);
            this.btnInsertarMedico.Name = "btnInsertarMedico";
            this.btnInsertarMedico.Size = new System.Drawing.Size(92, 29);
            this.btnInsertarMedico.TabIndex = 9;
            this.btnInsertarMedico.Text = "Insertar";
            this.btnInsertarMedico.UseVisualStyleBackColor = true;
            this.btnInsertarMedico.Click += new System.EventHandler(this.btnInsertarMedico_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(24, 176);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 29);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Buscar por ID";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 29);
            this.button4.TabIndex = 13;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 581);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 29);
            this.button5.TabIndex = 17;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 546);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 29);
            this.button6.TabIndex = 16;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 511);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 29);
            this.button7.TabIndex = 15;
            this.button7.Text = "Editar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(23, 476);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 29);
            this.button8.TabIndex = 14;
            this.button8.Text = "Insertar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(196, 66);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(152, 20);
            this.textId.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre";
            // 
            // textNombreMedico
            // 
            this.textNombreMedico.Location = new System.Drawing.Point(372, 27);
            this.textNombreMedico.Name = "textNombreMedico";
            this.textNombreMedico.Size = new System.Drawing.Size(152, 20);
            this.textNombreMedico.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Apellido";
            // 
            // textApeMedico
            // 
            this.textApeMedico.Location = new System.Drawing.Point(372, 66);
            this.textApeMedico.Name = "textApeMedico";
            this.textApeMedico.Size = new System.Drawing.Size(152, 20);
            this.textApeMedico.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Domicilio";
            // 
            // textDomiMedico
            // 
            this.textDomiMedico.Location = new System.Drawing.Point(563, 27);
            this.textDomiMedico.Name = "textDomiMedico";
            this.textDomiMedico.Size = new System.Drawing.Size(152, 20);
            this.textDomiMedico.TabIndex = 23;
            // 
            // textEspMedico
            // 
            this.textEspMedico.Location = new System.Drawing.Point(756, 27);
            this.textEspMedico.Name = "textEspMedico";
            this.textEspMedico.Size = new System.Drawing.Size(152, 20);
            this.textEspMedico.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(799, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Especialidad";
            // 
            // textMatMedico
            // 
            this.textMatMedico.Location = new System.Drawing.Point(756, 106);
            this.textMatMedico.Name = "textMatMedico";
            this.textMatMedico.Size = new System.Drawing.Size(152, 20);
            this.textMatMedico.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(810, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Matricula";
            // 
            // textTelMedico
            // 
            this.textTelMedico.Location = new System.Drawing.Point(563, 67);
            this.textTelMedico.Name = "textTelMedico";
            this.textTelMedico.Size = new System.Drawing.Size(152, 20);
            this.textTelMedico.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(617, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Telefono";
            // 
            // textEmailMedico
            // 
            this.textEmailMedico.Location = new System.Drawing.Point(563, 106);
            this.textEmailMedico.Name = "textEmailMedico";
            this.textEmailMedico.Size = new System.Drawing.Size(152, 20);
            this.textEmailMedico.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(617, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Email";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(664, 426);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(152, 20);
            this.textBox10.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(681, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Numero Historial Clinico";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(664, 380);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(152, 20);
            this.textBox11.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(718, 364);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Email";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(479, 426);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(152, 20);
            this.textBox12.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(533, 410);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Telefono";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(479, 384);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(152, 20);
            this.textBox13.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(533, 368);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Domicilio";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(289, 429);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(152, 20);
            this.textBox14.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(343, 413);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Apellido";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(289, 384);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(152, 20);
            this.textBox15.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(343, 368);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Nombre";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(132, 426);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(135, 20);
            this.textBox16.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(194, 406);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "ID";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(236, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Crear Medico";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(151, 384);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "Agregar Paciente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(842, 410);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Asiganar Medico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 650);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textEspMedico);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textMatMedico);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textTelMedico);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textEmailMedico);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textDomiMedico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textApeMedico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textNombreMedico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.btnInsertarMedico);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Button btnInsertarMedico;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNombreMedico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textApeMedico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textDomiMedico;
        private System.Windows.Forms.TextBox textEspMedico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textMatMedico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textTelMedico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textEmailMedico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
    }
}

