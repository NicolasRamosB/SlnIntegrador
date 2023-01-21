using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Models;
using Negocio;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

            int countMedicoClinico = 0;

            foreach (Medico medico in AdmMedico.ListarTodo())
            {
                if (medico.Especialidad.Equals("Medico Clinico"))
                {
                    medicoClinico.Items.Add(medico.Nombre);
                    countMedicoClinico++;
                    MostrarMedicos();
                }

            }
            medicoClinico.Items.Add($"Cantidad medicos clinicos: {countMedicoClinico}");

            foreach (Habitacion habitacion in AdmHabitacion.Listar())
            {
                string ocupado = "";

                if (habitacion.Estado)
                {
                    ocupado = "Ocupado";
                }
                else
                {
                    ocupado = "Libre";
                }

                listNumeroHabitacion.Items.Add($"Habitacion: {habitacion.Numero},  {ocupado}");



            }

            MostrarMedicos();
            dataListaPacientes.DataSource = AdmPaciente.Listar();

        }

        private void MostrarMedicos()
        {
            dataListaMedico.DataSource = AdmMedico.ListarTodo();
        }

        private void btnInsertarMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico() { Nombre = textNombreMedico.Text, Apellido = textApeMedico.Text, Domicilio = textDomiMedico.Text, Telefono = textTelMedico.Text, Email = textEmailMedico.Text, Especialidad = textEspMedico.Text, Matricula = textMatMedico.Text };

            int filasAfectadas = AdmMedico.Insertar(medico);
            if (filasAfectadas > 0)
            {
                MessageBox.Show($"Se ha agregado nuevo medico: {textNombreMedico.Text} {textApeMedico.Text}");
                MostrarMedicos();
            }
        }

        //private void btnEditar_Click(object sender, EventArgs e)
        //{
        //    Medico medico = new Medico()
        //    {
        //        IdMedico = Convert.ToInt32(textId.Text),
        //        Nombre = textNombreMedico.Text,
        //        Apellido = textApeMedico.Text,
        //        Domicilio = textDomiMedico.Text,
        //        Telefono = textTelMedico.Text,
        //        Email = textEmailMedico.Text,
        //        Especialidad = textEspMedico.Text,
        //        Matricula = textMatMedico.Text
        //    };

        //    int filasAfectadas = AdmMedico.Editar()

        //}
    }
}
