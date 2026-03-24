using ListaAsistencia.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListaAsistencia.Views
{
    public partial class Asistencia : Form
    {
        Datos dt = new Datos();
        DataSet ds;
        DataGridView lista;
        public Asistencia(DataGridView lista)
        {
            this.lista = lista;
            InitializeComponent();
            if (dgvAsistencia.RowCount == 0)
            {
                dgvAsistencia.RowCount = lista.RowCount;
                for (int i = 0; i < dgvAsistencia.RowCount - 1; i++)
                {
                    dt.ejecutarComando($"Insert into Asistencia(fecha,nControl,vino) values(" +
                        $"'{dtpFecha.Value.ToShortDateString()}', {lista.Rows[i].Cells[0].Value}, 'NO')");
                }

            }
            actualizar();
        }

        public void actualizar()
        {
            try
            {


                ds = dt.ejecutar($"Select fecha, alu.nControl, concat(nombre,' ',apPaterno,' ',apMaterno) as nombreCompleto " +
                    $", vino as Asistio from Asistencia asi left join Alumnos alu on asi.nControl = alu.nControl " +
                    $"where fecha='{dtpFecha.Value.ToShortDateString()}'");

                if (ds != null)
                {
                    dgvAsistencia.Columns.Clear();
                    dgvAsistencia.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Sistema");
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            actualizar();
            if (dgvAsistencia.RowCount == 0 || dgvAsistencia.Rows[0].Cells[0].Value == null)
            {

                for (int i = 0; i < lista.RowCount - 1; i++)
                {

                    dt.ejecutarComando($"Insert into Asistencia(fecha,nControl,vino) values(" +
                        $"'{dtpFecha.Value.ToShortDateString()}', {lista.Rows[i].Cells[0].Value}, 'NO')");
                }
                actualizar();
            }

        }

        private void dgvAsistencia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAsistencia.CurrentRow.Cells[3].Value.ToString() == "SI")
            {
                ds = dt.ejecutar($"update Asistencia set vino='NO' where fecha='{dgvAsistencia.CurrentRow.Cells[0].Value.ToString()}' and nControl= " +
                    $"{Convert.ToInt32(dgvAsistencia.CurrentRow.Cells[1].Value)}");

            }
            else
            {
                ds = dt.ejecutar($"update Asistencia set vino='SI' where fecha='{dgvAsistencia.CurrentRow.Cells[0].Value.ToString()}' and nControl= " +
                   $"{Convert.ToInt32(dgvAsistencia.CurrentRow.Cells[1].Value)}");
            }
            actualizar();
        }

        private void rbAsistio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ds = dt.ejecutar($"Select fecha, alu.nControl, concat(nombre,' ',apPaterno,' ',apMaterno) as nombreCompleto " +
                    $", vino from Asistencia asi left join Alumnos alu on asi.nControl = alu.nControl " +
                    $"where fecha='{dtpFecha.Value.ToShortDateString()}' and vino='SI'");

                if (ds != null)
                {
                    dgvAsistencia.Columns.Clear();
                    dgvAsistencia.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void rbNoAsistio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ds = dt.ejecutar($"Select fecha, alu.nControl, concat(nombre,' ',apPaterno,' ',apMaterno) as nombreCompleto " +
                    $", vino from Asistencia asi left join Alumnos alu on asi.nControl = alu.nControl " +
                    $"where fecha='{dtpFecha.Value.ToShortDateString()}' and vino='NO'");

                if (ds != null)
                {
                    dgvAsistencia.Columns.Clear();
                    dgvAsistencia.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ds = dt.ejecutar($"Select fecha, alu.nControl, concat(nombre,' ',apPaterno,' ',apMaterno) as nombreCompleto " +
                    $", vino from Asistencia asi left join Alumnos alu on asi.nControl = alu.nControl " +
                    $"where fecha='{dtpFecha.Value.ToShortDateString()}'");

                if (ds != null)
                {
                    dgvAsistencia.Columns.Clear();
                    dgvAsistencia.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte reporte = new Reporte(int.Parse(txtRegistro.Text));
                reporte.Show();
            }catch(Exception ex)
            { 
                MessageBox.Show("Solo valores numericos");
            }
        }
    }
}
