using ListaAsistencia.Clases;
using ListaAsistencia.Views;
using System.Data;

namespace ListaAsistencia
{
    public partial class ListaAlumnos : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public ListaAlumnos()
        {
            InitializeComponent();
            actualizarToolStripMenuItem_Click(this, new EventArgs());
        }

        private void btnAgregarAlumnos_Click(object sender, EventArgs e)
        {
            RegistroAlumno registro = new RegistroAlumno();
            registro.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");

            }
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistroAlumno actualizacion = new RegistroAlumno(Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value), dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[2].Value.ToString(), dgvAlumnos.CurrentRow.Cells[3].Value.ToString());

            actualizacion.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta seguro de que quiere eliminar el alumno seleccionado?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool resultado = datos.ejecutarComando(
                        $"Delete from Alumnos where nControl= {Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value)}");
                    MessageBox.Show("Alumno eliminado correctamente", "Alumno eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar alumno");
            }
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = new Asistencia(this.dgvAlumnos);
            asistencia.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ds = datos.ejecutar($"select * from Alumnos where nombre like('{txtBuscar.Text}%') or apPaterno like('{txtBuscar.Text}%') or apMaterno like('{txtBuscar.Text}%')");
            if(ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];
            }
        }
    }
}
