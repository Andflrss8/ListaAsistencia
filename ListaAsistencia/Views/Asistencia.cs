using ListaAsistencia.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListaAsistencia.Views
{
    public partial class Asistencia : Form
    {

        //Definicion de instancia de Datos, DataSet y DataGridView
        Datos dt = new Datos();
        DataSet ds;
        DataGridView lista;

        //Constuctor del frm Asistencia.
        //Se envia el dgv de la lista de alumnos para que tome los datos
        public Asistencia(DataGridView lista)
        {
            try
            {

                this.lista = lista;
                InitializeComponent();
                actualizar();

                //Por cada alumno en la lista de alumnos
                //se inserta un registro de asistencia y se actualiza el dgv
                for (int i = 0; i < lista.Rows.Count; i++)
                {
                    dt.ejecutarComando($"Insert into Asistencia(fecha,nControl,vino) values(" +
                        $"'{dtpFecha.Value.ToShortDateString()}', {lista.Rows[i].Cells[0].Value}, 'NO')");
                }

                actualizar();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe haber registros de alumnos para generar lista de asistencia" + ex.ToString());
            }
        }

        //Actualizar el dgv al ejecutar un comando SQL
        public void actualizar()
        {
            try
            {
                //Consulta por medio de un join entre la tabla Alumnos y Asistencia
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


        //Crea un registro o muestra el registro creado de asistencia en dicha fecha
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            actualizar();

            //Se insertan los alumnos en asistencia en caso de que haya nuevos
            for (int i = 0; i < lista.RowCount; i++)
            {

                dt.ejecutarComando($"Insert into Asistencia(fecha,nControl,vino) values(" +
                   $"'{dtpFecha.Value.ToShortDateString()}', {lista.Rows[i].Cells[0].Value}, 'NO')");
            }
            dgvAsistencia.Columns.Clear();
            actualizar();
            rbTodos.Checked = true;

        }


        //Filtrar por alumnos que asistieron
        private void rbAsistio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Consulta con los alumnos que si vinieron
                ds = dt.ejecutar($"Select fecha, alu.nControl, concat(nombre,' ',apPaterno,' ',apMaterno) as nombreCompleto " +
                    $", vino as Asistio from Asistencia asi left join Alumnos alu on asi.nControl = alu.nControl " +
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

        //Filtrar por alumnos que faltaron
        private void rbNoAsistio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Consulta con los alumnos que no vinieron
                ds = dt.ejecutar($"Select fecha, alu.nControl, concat(nombre,' ',apPaterno,' ',apMaterno) as nombreCompleto " +
                    $", vino as Asistio from Asistencia asi left join Alumnos alu on asi.nControl = alu.nControl " +
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

       

        //Mostrar todos los alumnos, hayan venido o no
        private void rbTodos_CheckedChanged(object sender, EventArgs e)
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
                MessageBox.Show("Error");
            }
        }

        //Colocar o quitar la asistencia a un alummno al presionar Enter en el campo de texto
        //La idea es que el lector de codigo de barras introduzca el nControl en el campo
        private void txtRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                ds = dt.ejecutar($"UPDATE Asistencia set vino= IF(vino='SI', 'NO','SI') where nControl ={int.Parse(txtRegistro.Text)} and fecha='{dtpFecha.Value.ToShortDateString()}'");
                txtRegistro.Text = "";
                actualizar();
                txtRegistro.Focus();
                rbTodos.Checked = true;
            }

            

        }

        //Hace la misma funcion que al presionar enter. Pero de una forma manual sin tener que escribir el nControl
        //Por si por ejemplo, alguien olvida su credencial
        private void dgvAsistencia_CellClick(object sender, DataGridViewCellEventArgs e)
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
            txtRegistro.Focus();
            rbTodos.Checked = true;
        }

        //Genera un resumen del alumno usando el mismo campo de texto que para registrar asistencia
        private void btnResumen_Click(object sender, EventArgs e)
        {

            try
            {

                Reporte reporte = new Reporte(int.Parse(txtRegistro.Text));
                reporte.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Solo valores numericos");
            }

        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            txtRegistro.Focus();
            rbTodos.Checked = true;
        }
    }
}
