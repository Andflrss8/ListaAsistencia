namespace ListaAsistencia
{
    partial class ListaAlumnos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msOpciones = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            asistenciaToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            dgvAlumnos = new DataGridView();
            btnEliminar = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            btnAgregarAlumnos = new Button();
            msOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // msOpciones
            // 
            msOpciones.ImageScalingSize = new Size(20, 20);
            msOpciones.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, alumnosToolStripMenuItem, asistenciaToolStripMenuItem, actualizarToolStripMenuItem });
            msOpciones.Location = new Point(0, 0);
            msOpciones.Name = "msOpciones";
            msOpciones.Padding = new Padding(7, 3, 0, 3);
            msOpciones.Size = new Size(800, 30);
            msOpciones.TabIndex = 0;
            msOpciones.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(81, 24);
            alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // asistenciaToolStripMenuItem
            // 
            asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            asistenciaToolStripMenuItem.Size = new Size(89, 24);
            asistenciaToolStripMenuItem.Text = "Asistencia";
            asistenciaToolStripMenuItem.Click += asistenciaToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(128, 24);
            actualizarToolStripMenuItem.Text = "Actualizar Tabla";
            actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 30);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvAlumnos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnEliminar);
            splitContainer1.Panel2.Controls.Add(txtBuscar);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(btnAgregarAlumnos);
            splitContainer1.Size = new Size(800, 421);
            splitContainer1.SplitterDistance = 316;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.Location = new Point(0, 0);
            dgvAlumnos.Margin = new Padding(3, 4, 3, 4);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.Size = new Size(800, 316);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellContentDoubleClick += dgvAlumnos_CellContentDoubleClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(582, 31);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(97, 37);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(267, 27);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.AutoSize = true;
            label1.Location = new Point(27, 41);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // btnAgregarAlumnos
            // 
            btnAgregarAlumnos.Location = new Point(437, 32);
            btnAgregarAlumnos.Margin = new Padding(3, 4, 3, 4);
            btnAgregarAlumnos.Name = "btnAgregarAlumnos";
            btnAgregarAlumnos.Size = new Size(87, 39);
            btnAgregarAlumnos.TabIndex = 0;
            btnAgregarAlumnos.Text = "Agregar";
            btnAgregarAlumnos.UseVisualStyleBackColor = true;
            btnAgregarAlumnos.Click += btnAgregarAlumnos_Click;
            // 
            // ListaAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(splitContainer1);
            Controls.Add(msOpciones);
            MainMenuStrip = msOpciones;
            Name = "ListaAlumnos";
            Text = "ListaAsistencia";
            msOpciones.ResumeLayout(false);
            msOpciones.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msOpciones;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem asistenciaToolStripMenuItem;
        private SplitContainer splitContainer1;
        private DataGridView dgvAlumnos;
        private Button btnAgregarAlumnos;
        private TextBox txtBuscar;
        private Label label1;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button btnEliminar;
    }
}
