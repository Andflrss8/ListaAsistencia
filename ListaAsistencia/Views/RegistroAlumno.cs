using ListaAsistencia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ListaAsistencia.Views
{
    public partial class RegistroAlumno : Form
    {
        int nC = 0;
        bool update = false;
        Datos dt = new Datos();
        ListaAlumnos lista;
        public RegistroAlumno(ListaAlumnos lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        public RegistroAlumno(int nC, string nombre, string apPat, string apMat, ListaAlumnos lista)
        {
            InitializeComponent();
            this.nC = nC;
            txtNC.Text = nC + "";
            txtNombre.Text = nombre;
            txtPat.Text = apPat;
            txtMat.Text = apMat;
            update = true;
            txtNC.Enabled = false;
            this.lista = lista;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (update == false)
                {
                    bool resultado = dt.ejecutarComando(
                        $"Insert into Alumnos(nControl,nombre,apPaterno,apMaterno) " +
                        $"values('{int.Parse(txtNC.Text)}', '{txtNombre.Text}', '{txtPat.Text}', '{txtMat.Text}')");

                    if (resultado)
                    {
                        MessageBox.Show("Alumno agregado correctamente");
                        lista.actualizar();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar alumno");
                    }
                }
                else
                {
                    bool resultado = dt.ejecutarComando(
                        $"Update Alumnos set nombre='{txtNombre.Text}', apPaterno='{txtPat.Text}', apMaterno='{txtMat.Text}'" +
                        $" where nControl= {int.Parse(txtNC.Text)}");

                    if (resultado)
                    {
                        MessageBox.Show("Alumno actualizado correctamente");
                        lista.actualizar();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar alumno");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El numero de control debe ser de valor numerico entero");
            }
        }
    }
}
