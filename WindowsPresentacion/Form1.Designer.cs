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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDeletePac = new System.Windows.Forms.Button();
            this.btnGetPac = new System.Windows.Forms.Button();
            this.btnAddPac = new System.Windows.Forms.Button();
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
            this.textNumPac = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textEmailPac = new System.Windows.Forms.TextBox();
            this.textTelPac = new System.Windows.Forms.TextBox();
            this.textDomPac = new System.Windows.Forms.TextBox();
            this.textApPac = new System.Windows.Forms.TextBox();
            this.textNomPac = new System.Windows.Forms.TextBox();
            this.textIdPac = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.comboMedico = new System.Windows.Forms.ComboBox();
            this.comboHabitacion = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaMedico
            // 
            this.dataListaMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaMedico.Location = new System.Drawing.Point(392, 87);
            this.dataListaMedico.Name = "dataListaMedico";
            this.dataListaMedico.Size = new System.Drawing.Size(477, 201);
            this.dataListaMedico.TabIndex = 0;
            // 
            // medicoClinico
            // 
            this.medicoClinico.FormattingEnabled = true;
            this.medicoClinico.Location = new System.Drawing.Point(890, 105);
            this.medicoClinico.Name = "medicoClinico";
            this.medicoClinico.Size = new System.Drawing.Size(234, 186);
            this.medicoClinico.TabIndex = 1;
            // 
            // listNumeroHabitacion
            // 
            this.listNumeroHabitacion.FormattingEnabled = true;
            this.listNumeroHabitacion.Location = new System.Drawing.Point(890, 402);
            this.listNumeroHabitacion.Name = "listNumeroHabitacion";
            this.listNumeroHabitacion.Size = new System.Drawing.Size(235, 186);
            this.listNumeroHabitacion.TabIndex = 2;
            // 
            // dataListaPacientes
            // 
            this.dataListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaPacientes.Location = new System.Drawing.Point(392, 356);
            this.dataListaPacientes.Name = "dataListaPacientes";
            this.dataListaPacientes.Size = new System.Drawing.Size(477, 232);
            this.dataListaPacientes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de Medicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de pacientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(888, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de medicos clinicos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(888, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista de habitaciones";
            // 
            // btnInsertarMedico
            // 
            this.btnInsertarMedico.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInsertarMedico.Location = new System.Drawing.Point(295, 87);
            this.btnInsertarMedico.Name = "btnInsertarMedico";
            this.btnInsertarMedico.Size = new System.Drawing.Size(92, 29);
            this.btnInsertarMedico.TabIndex = 9;
            this.btnInsertarMedico.Text = "Insertar";
            this.btnInsertarMedico.UseVisualStyleBackColor = false;
            this.btnInsertarMedico.Click += new System.EventHandler(this.btnInsertarMedico_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(295, 122);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 29);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Location = new System.Drawing.Point(295, 259);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 29);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDeletePac
            // 
            this.btnDeletePac.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeletePac.Location = new System.Drawing.Point(295, 559);
            this.btnDeletePac.Name = "btnDeletePac";
            this.btnDeletePac.Size = new System.Drawing.Size(92, 29);
            this.btnDeletePac.TabIndex = 17;
            this.btnDeletePac.Text = "Eliminar";
            this.btnDeletePac.UseVisualStyleBackColor = false;
            this.btnDeletePac.Click += new System.EventHandler(this.btnDeletePac_Click);
            // 
            // btnGetPac
            // 
            this.btnGetPac.Location = new System.Drawing.Point(295, 398);
            this.btnGetPac.Name = "btnGetPac";
            this.btnGetPac.Size = new System.Drawing.Size(92, 29);
            this.btnGetPac.TabIndex = 16;
            this.btnGetPac.Text = "Traer Paciente";
            this.btnGetPac.UseVisualStyleBackColor = true;
            this.btnGetPac.Click += new System.EventHandler(this.btnGetPac_Click);
            // 
            // btnAddPac
            // 
            this.btnAddPac.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddPac.Location = new System.Drawing.Point(295, 363);
            this.btnAddPac.Name = "btnAddPac";
            this.btnAddPac.Size = new System.Drawing.Size(92, 29);
            this.btnAddPac.TabIndex = 14;
            this.btnAddPac.Text = "Insertar";
            this.btnAddPac.UseVisualStyleBackColor = false;
            this.btnAddPac.Click += new System.EventHandler(this.btnAddPac_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID :";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(120, 87);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(152, 20);
            this.textId.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre :";
            // 
            // textNombreMedico
            // 
            this.textNombreMedico.Location = new System.Drawing.Point(120, 115);
            this.textNombreMedico.Name = "textNombreMedico";
            this.textNombreMedico.Size = new System.Drawing.Size(152, 20);
            this.textNombreMedico.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Apellido :";
            // 
            // textApeMedico
            // 
            this.textApeMedico.Location = new System.Drawing.Point(120, 141);
            this.textApeMedico.Name = "textApeMedico";
            this.textApeMedico.Size = new System.Drawing.Size(152, 20);
            this.textApeMedico.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Domicilio :";
            // 
            // textDomiMedico
            // 
            this.textDomiMedico.Location = new System.Drawing.Point(120, 167);
            this.textDomiMedico.Name = "textDomiMedico";
            this.textDomiMedico.Size = new System.Drawing.Size(152, 20);
            this.textDomiMedico.TabIndex = 23;
            // 
            // textEspMedico
            // 
            this.textEspMedico.Location = new System.Drawing.Point(120, 245);
            this.textEspMedico.Name = "textEspMedico";
            this.textEspMedico.Size = new System.Drawing.Size(152, 20);
            this.textEspMedico.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Especialidad :";
            // 
            // textMatMedico
            // 
            this.textMatMedico.Location = new System.Drawing.Point(120, 271);
            this.textMatMedico.Name = "textMatMedico";
            this.textMatMedico.Size = new System.Drawing.Size(152, 20);
            this.textMatMedico.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Matricula :";
            // 
            // textTelMedico
            // 
            this.textTelMedico.Location = new System.Drawing.Point(120, 193);
            this.textTelMedico.Name = "textTelMedico";
            this.textTelMedico.Size = new System.Drawing.Size(152, 20);
            this.textTelMedico.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Telefono :";
            // 
            // textEmailMedico
            // 
            this.textEmailMedico.Location = new System.Drawing.Point(120, 219);
            this.textEmailMedico.Name = "textEmailMedico";
            this.textEmailMedico.Size = new System.Drawing.Size(152, 20);
            this.textEmailMedico.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Email :";
            // 
            // textNumPac
            // 
            this.textNumPac.Location = new System.Drawing.Point(120, 514);
            this.textNumPac.Name = "textNumPac";
            this.textNumPac.Size = new System.Drawing.Size(152, 20);
            this.textNumPac.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 516);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Nro.Hist. Clinico:";
            // 
            // textEmailPac
            // 
            this.textEmailPac.Location = new System.Drawing.Point(120, 488);
            this.textEmailPac.Name = "textEmailPac";
            this.textEmailPac.Size = new System.Drawing.Size(152, 20);
            this.textEmailPac.TabIndex = 43;
            // 
            // textTelPac
            // 
            this.textTelPac.Location = new System.Drawing.Point(120, 462);
            this.textTelPac.Name = "textTelPac";
            this.textTelPac.Size = new System.Drawing.Size(152, 20);
            this.textTelPac.TabIndex = 41;
            // 
            // textDomPac
            // 
            this.textDomPac.Location = new System.Drawing.Point(120, 436);
            this.textDomPac.Name = "textDomPac";
            this.textDomPac.Size = new System.Drawing.Size(152, 20);
            this.textDomPac.TabIndex = 39;
            // 
            // textApPac
            // 
            this.textApPac.Location = new System.Drawing.Point(120, 410);
            this.textApPac.Name = "textApPac";
            this.textApPac.Size = new System.Drawing.Size(152, 20);
            this.textApPac.TabIndex = 37;
            // 
            // textNomPac
            // 
            this.textNomPac.Location = new System.Drawing.Point(120, 384);
            this.textNomPac.Name = "textNomPac";
            this.textNomPac.Size = new System.Drawing.Size(152, 20);
            this.textNomPac.TabIndex = 35;
            // 
            // textIdPac
            // 
            this.textIdPac.Location = new System.Drawing.Point(120, 356);
            this.textIdPac.Name = "textIdPac";
            this.textIdPac.Size = new System.Drawing.Size(152, 20);
            this.textIdPac.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(116, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 21);
            this.label21.TabIndex = 48;
            this.label21.Text = "Crear Medico";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(116, 329);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(170, 24);
            this.label22.TabIndex = 49;
            this.label22.Text = "Agregar Paciente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 543);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Asiganar Medico :";
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Location = new System.Drawing.Point(295, 157);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(92, 29);
            this.btnBuscarId.TabIndex = 51;
            this.btnBuscarId.Text = "Traer Medico";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // comboMedico
            // 
            this.comboMedico.FormattingEnabled = true;
            this.comboMedico.Location = new System.Drawing.Point(120, 540);
            this.comboMedico.Name = "comboMedico";
            this.comboMedico.Size = new System.Drawing.Size(151, 21);
            this.comboMedico.TabIndex = 52;
            // 
            // comboHabitacion
            // 
            this.comboHabitacion.FormattingEnabled = true;
            this.comboHabitacion.Location = new System.Drawing.Point(120, 567);
            this.comboHabitacion.Name = "comboHabitacion";
            this.comboHabitacion.Size = new System.Drawing.Size(151, 21);
            this.comboHabitacion.TabIndex = 53;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 570);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 13);
            this.label23.TabIndex = 54;
            this.label23.Text = "Asiganar Habitacion :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(65, 465);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "Telefono :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(82, 491);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 60;
            this.label24.Text = "Email :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(65, 439);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 59;
            this.label25.Text = "Domicilio :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(70, 413);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 58;
            this.label26.Text = "Apellido :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(70, 387);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(50, 13);
            this.label27.TabIndex = 57;
            this.label27.Text = "Nombre :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(96, 359);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(24, 13);
            this.label28.TabIndex = 56;
            this.label28.Text = "ID :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(414, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(246, 29);
            this.label15.TabIndex = 62;
            this.label15.Text = "CLINICA JUNCAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 671);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.comboHabitacion);
            this.Controls.Add(this.comboMedico);
            this.Controls.Add(this.btnBuscarId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textNumPac);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textEmailPac);
            this.Controls.Add(this.textTelPac);
            this.Controls.Add(this.textDomPac);
            this.Controls.Add(this.textApPac);
            this.Controls.Add(this.textNomPac);
            this.Controls.Add(this.textIdPac);
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
            this.Controls.Add(this.btnDeletePac);
            this.Controls.Add(this.btnGetPac);
            this.Controls.Add(this.btnAddPac);
            this.Controls.Add(this.btnEliminar);
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
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDeletePac;
        private System.Windows.Forms.Button btnGetPac;
        private System.Windows.Forms.Button btnAddPac;
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
        private System.Windows.Forms.TextBox textNumPac;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textEmailPac;
        private System.Windows.Forms.TextBox textTelPac;
        private System.Windows.Forms.TextBox textDomPac;
        private System.Windows.Forms.TextBox textApPac;
        private System.Windows.Forms.TextBox textNomPac;
        private System.Windows.Forms.TextBox textIdPac;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.ComboBox comboMedico;
        private System.Windows.Forms.ComboBox comboHabitacion;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label15;
    }
}

