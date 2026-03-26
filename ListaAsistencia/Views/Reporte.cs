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
        Datos dt = new Datos();
        DataSet ds;
        int nControl;
            
        public Reporte(int nControl)
        {
            InitializeComponent();
            this.nControl = nControl;
            
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            try
            {
                ds = dt.ejecutar($"select alu.nControl as nControl, concat(nombre,' ',apPaterno,' ',apMaterno) as Estudiante, sum(vino='SI') as Asistencias_totales from Asistencia asi join Alumnos alu on asi.nControl = alu.nControl where alu.nControl={nControl}");
                if(ds != null)
                {
                    dgvCuenta.DataSource = ds.Tables[0];

                }

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
