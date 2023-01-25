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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //MEDICO
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Medico medico in AdmMedico.ListarTodo())
            {
                comboMedico.Items.Add($"Nom: {medico.Nombre} {medico.Apellido} Id: {medico.Id}");
            }

            foreach (Habitacion habitacion in AdmHabitacion.Listar())
            {
                comboHabitacion.Items.Add($"Num: {habitacion.Numero} Id: {habitacion.Id}");
            }

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
       
                listNumeroHabitacion.Items.Add($"Habitacion: {habitacion.Numero},  {habitacion.Estado}");
            }

            MostrarMedicos();
            MostrarPaciente();

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico() { Id= Convert.ToInt32(textId.Text), Nombre = textNombreMedico.Text, Apellido = textApeMedico.Text, Domicilio = textDomiMedico.Text, Telefono = textTelMedico.Text, Email = textEmailMedico.Text, Especialidad = textEspMedico.Text, Matricula = textMatMedico.Text };
            int filasAfectadas = AdmMedico.Editar(medico);
            if (filasAfectadas != 0)
            {
                MessageBox.Show("Editado Ok");
                MostrarMedicos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Medico medico = new Medico() { Id = Convert.ToInt32(textId.Text)};
            int filasAfectadas = AdmMedico.Eliminar(Convert.ToInt32(textId.Text));
            if (filasAfectadas != 0)
            {
                MessageBox.Show("Eliminado Ok");
                MostrarMedicos();
            }
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);


            Medico medico = AdmMedico.TraerUno(id);
            MessageBox.Show($"Medico: {medico.Nombre} {medico.Apellido}\n" +
                $"Especialidad: {medico.Especialidad}\n" +
                $"Matricula: {medico.Matricula} ");
        }

        private int ObtenerIdMedico()
        {
            string[] idMedico = new string[5];
            idMedico = comboMedico.Text.Split(' ');
            int obtener = Convert.ToInt32(idMedico[4]);
            return obtener;
        }

        private int ObtenerIdHabitacion()
        {
            string[] idHabitacion = new string[4];
            idHabitacion = comboHabitacion.Text.Split(' ');
            int obtener = Convert.ToInt32(idHabitacion[3]);
            return obtener;
        }

        //----------------------------------------------------------------------------------

        //PACIENTE
        private void MostrarPaciente()
        {
            dataListaPacientes.DataSource = AdmPaciente.Listar();
        }

        private void btnAddPac_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente() { Nombre = textNomPac.Text, Apellido = textApPac.Text, Domicilio = textDomPac.Text, Telefono = textTelPac.Text, Email = textEmailPac.Text, NroHistorialClinica= Convert.ToInt32(textNumPac.Text), MedicoId= ObtenerIdMedico(), HabitacionId= ObtenerIdHabitacion() };

            int filasAfectadas = AdmPaciente.Insertar(paciente);
            if (filasAfectadas > 0)
            {
                MessageBox.Show($"Se ha agregado nuevo medico: {textNombreMedico.Text} {textApeMedico.Text}");
                MostrarPaciente();
            }
            
        }

        private void btnGetPac_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textIdPac.Text);


            Paciente paciente = AdmPaciente.TraerUno(id);
            MessageBox.Show($"Paciente: {paciente.Nombre} {paciente.Apellido}\n" +
                $"Email: {paciente.Email}\n" +
                $"Nro.Historial Clinico: {paciente.NroHistorialClinica} ");
        }

        private void btnDeletePac_Click(object sender, EventArgs e)
        {
            int filasAfectadas = AdmPaciente.Eliminar(Convert.ToInt32(textIdPac.Text));
            if (filasAfectadas != 0)
            {
                MessageBox.Show("Eliminado Ok");
                MostrarMedicos();
            }
        }
    }
}
