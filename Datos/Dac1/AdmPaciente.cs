﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> Listar()
        {
            List<Paciente> listaPaciente = new List<Paciente>();
            listaPaciente.Add(new Paciente()  { Id = 1, Nombre = "Rocio", Apellido = "Ianniello", Domicilio = "Av.Siempreviva 123", Telefono = "42433354", Email = "nickorn96@gmail.com", NroHistorialClinica = 1234 });
            listaPaciente.Add(new Paciente() { Id = 2, Nombre = "Nicolas", Apellido = "Ramos", Domicilio = "Calle falsa 123", Telefono = "42123354", Email = "pepa@gmail.com", NroHistorialClinica = 1200 });
            listaPaciente.Add(new Paciente() { Id = 3, Nombre = "Agustina", Apellido = "Canale", Domicilio = "Corrientes 2000", Telefono = "42343354", Email = "pepito@gmail.com", NroHistorialClinica = 3434 });
            listaPaciente.Add(new Paciente() { Id = 4, Nombre = "Martin", Apellido = "Quiroga", Domicilio = "Cordoba 2323", Telefono = "4246354", Email = "pipon@gmail.com", NroHistorialClinica = 15434 });
            listaPaciente.Add(new Paciente() { Id = 5, Nombre = "Samuel", Apellido = "Rivera", Domicilio = "Melo 935", Telefono = "42433454", Email = "pepon@gmail.com", NroHistorialClinica = 16534 });


            //TODO...
            return listaPaciente;
        }

        public static int Insertar(Paciente paciente)
        {
            //TODO...
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO...
            return 0;
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            //TODO...
            return null;
        }
    }
}
