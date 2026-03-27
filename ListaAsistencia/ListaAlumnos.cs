using ListaAsistencia.Clases;
using ListaAsistencia.Views;
using OfficeOpenXml;
using System.Data;

namespace ListaAsistencia
{
    public partial class ListaAlumnos : Form
    {
        //Definicion de Datos y DataSet
        Datos datos = new Datos();
        DataSet ds;

        //Constructor del frame
        public ListaAlumnos()
        {
            InitializeComponent();
            actualizar();
        }

        //Mostrar el frame para agregar alumnos
        private void btnAgregarAlumnos_Click(object sender, EventArgs e)
        {
            RegistroAlumno registro = new RegistroAlumno(this);
            registro.Show();
        }

     
        //Actualizar el dgv
        public void actualizar()
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

        //Muestra el frame para actualizar
        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistroAlumno actualizacion = new RegistroAlumno(Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value), dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[2].Value.ToString(), dgvAlumnos.CurrentRow.Cells[3].Value.ToString(), this);

            actualizacion.Show();
        }

        //Cerrar el programa
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Eliminar un registro
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta seguro de que quiere eliminar el alumno seleccionado?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool resultado = datos.ejecutarComando(
                        $"Delete from Alumnos where nControl= {Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value)}");
                    MessageBox.Show("Alumno eliminado correctamente", "Alumno eliminado");

                    actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar alumno");
            }
        }

        //Mostrar el frame de asistencia
        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = new Asistencia(this.dgvAlumnos);
            asistencia.Show();
        }

        //Consulta en forma de una barra de busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ds = datos.ejecutar($"select * from Alumnos where cast(nControl as char) like('{txtBuscar.Text}%') or nombre like('{txtBuscar.Text}%') or apPaterno like('{txtBuscar.Text}%') or apMaterno like('{txtBuscar.Text}%')");
            if (ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];
            }
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Importar desde un excel
        private void btnImportar_Click(object sender, EventArgs e)
        {
            string path;
            DialogResult dr = ofdExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {

                datos.ejecutarComando("delete from Alumnos");
                actualizar();
                path = ofdExcel.FileName;
                ExcelPackage.License.SetNonCommercialPersonal("Andres Flores");
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;
                    DataTable dt = new DataTable();
                    for (int col = 1; col <= colCount; col++)
                    {
                        dt.Columns.Add(worksheet.Cells[1, col].Value.ToString());
                    }
                    for (int row = 2; row <= rowCount - 1; row++)
                    {
                        DataRow drNew = dt.NewRow();
                        for (int col = 1; col <= colCount; col++)
                        {
                            drNew[col - 1] = worksheet.Cells[row, col].Value.ToString();
                        }
                        dt.Rows.Add(drNew);
                        string comando = $"Insert into Alumnos(nControl,nombre,apPaterno,apMaterno) " +
                            $"Values({drNew.ItemArray[0]},'{drNew.ItemArray[1]}','{drNew.ItemArray[2]}','{drNew.ItemArray[3]}')";

                        datos.ejecutarComando(comando);
                    }
                }
                actualizar();

            }

        }

        
    }
}
