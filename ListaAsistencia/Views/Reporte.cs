using ListaAsistencia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListaAsistencia.Views
{
    public partial class Reporte : Form
    {

        //Definicion de Datos y el DataSet 
        Datos dt = new Datos();
        DataSet ds;
        int nControl;
            
        //Constructor del reporte usando el nControl del alumno
        public Reporte(int nControl)
        {
            InitializeComponent();
            this.nControl = nControl;
            
        }

        //Al generarse el reporte, se muestran los datos
        private void Reporte_Load(object sender, EventArgs e)
        {
            try
            {
                //Se muestra en una de las tablas el nControl, el nombre del alumno, y el numero de asistencias
                ds = dt.ejecutar($"select alu.nControl as nControl, concat(nombre,' ',apPaterno,' ',apMaterno) as Estudiante, sum(vino='SI') as Asistencias_totales from Asistencia asi join Alumnos alu on asi.nControl = alu.nControl where alu.nControl={nControl}");
                if(ds != null)
                {
                    dgvCuenta.DataSource = ds.Tables[0];

                }

                //Muestra las asistencias del alumno segun la fecha
                ds = dt.ejecutar($"select fecha, vino from Asistencia where nControl ={nControl}");
                if(ds != null)
                {
                    dgvResumen.DataSource = ds.Tables[0];

                }

                if (dgvResumen.Rows[0].Cells[0].Value == null)
                {
                    this.Close();
                }
            }catch(Exception ex)
            {
                this.Close();
                MessageBox.Show("Error");

            }
        }
    }
}
