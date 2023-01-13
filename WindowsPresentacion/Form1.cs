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
            foreach (Medico medico in AdmMedico.Listar())
            {
                if (medico.Especialidad.Equals("Medico Clinico"))
                {
                    medicoClinico.Items.Add(medico.Nombre);
                    countMedicoClinico++;
                }
                
            }
            medicoClinico.Items.Add($"Cantidad medicos clinicos: {countMedicoClinico}");

            foreach (Habitacion habitacion in AdmHabitacion.Listar())
            {
                string ocupado = "";

                if (habitacion.Estado)
                {
                    ocupado = "Ocupado";
                }else
                {
                    ocupado = "Libre";
                }

                listNumeroHabitacion.Items.Add($"Habitacion: {habitacion.Numero},  {ocupado}");
                  
                

            }

            dataListaMedico.DataSource = AdmMedico.Listar();
            dataListaPacientes.DataSource = AdmPaciente.Listar();

        }

       
    }
}
