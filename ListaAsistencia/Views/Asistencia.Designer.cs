namespace ListaAsistencia.Views
{
    partial class Asistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btnResumen = new Button();
            label2 = new Label();
            txtRegistro = new TextBox();
            gbBotones = new GroupBox();
            rbTodos = new RadioButton();
            rbNoAsistio = new RadioButton();
            rbAsistio = new RadioButton();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            dgvAsistencia = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gbBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnResumen);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtRegistro);
            splitContainer1.Panel1.Controls.Add(gbBotones);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(dtpFecha);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAsistencia);
            splitContainer1.Size = new Size(700, 338);
            splitContainer1.SplitterDistance = 129;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(318, 83);
            btnResumen.Margin = new Padding(3, 2, 3, 2);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(153, 22);
            btnResumen.TabIndex = 6;
            btnResumen.Text = "Resumen de alumno";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 106);
            label2.Name = "label2";
            label2.Size = new Size(123, 13);
            label2.TabIndex = 5;
            label2.Text = "(Solo numero de control)";
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(45, 83);
            txtRegistro.Margin = new Padding(3, 2, 3, 2);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(240, 23);
            txtRegistro.TabIndex = 3;
            txtRegistro.KeyPress += txtRegistro_KeyPress;
            // 
            // gbBotones
            // 
            gbBotones.Controls.Add(rbTodos);
            gbBotones.Controls.Add(rbNoAsistio);
            gbBotones.Controls.Add(rbAsistio);
            gbBotones.Location = new Point(351, 18);
            gbBotones.Margin = new Padding(3, 2, 3, 2);
            gbBotones.Name = "gbBotones";
            gbBotones.Padding = new Padding(3, 2, 3, 2);
            gbBotones.Size = new Size(330, 60);
            gbBotones.TabIndex = 2;
            gbBotones.TabStop = false;
            gbBotones.Text = "Filtrar:";
            // 
            // rbTodos
            // 
            rbTodos.AutoSize = true;
            rbTodos.Location = new Point(213, 20);
            rbTodos.Margin = new Padding(3, 2, 3, 2);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(57, 19);
            rbTodos.TabIndex = 2;
            rbTodos.TabStop = true;
            rbTodos.Text = "Todos";
            rbTodos.UseVisualStyleBackColor = true;
            rbTodos.CheckedChanged += rbTodos_CheckedChanged;
            // 
            // rbNoAsistio
            // 
            rbNoAsistio.AutoSize = true;
            rbNoAsistio.Location = new Point(109, 19);
            rbNoAsistio.Margin = new Padding(3, 2, 3, 2);
            rbNoAsistio.Name = "rbNoAsistio";
            rbNoAsistio.Size = new Size(79, 19);
            rbNoAsistio.TabIndex = 1;
            rbNoAsistio.TabStop = true;
            rbNoAsistio.Text = "No Asistio";
            rbNoAsistio.UseVisualStyleBackColor = true;
            rbNoAsistio.CheckedChanged += rbNoAsistio_CheckedChanged;
            // 
            // rbAsistio
            // 
            rbAsistio.AutoSize = true;
            rbAsistio.Location = new Point(24, 20);
            rbAsistio.Margin = new Padding(3, 2, 3, 2);
            rbAsistio.Name = "rbAsistio";
            rbAsistio.Size = new Size(60, 19);
            rbAsistio.TabIndex = 0;
            rbAsistio.TabStop = true;
            rbAsistio.Text = "Asistio";
            rbAsistio.UseVisualStyleBackColor = true;
            rbAsistio.CheckedChanged += rbAsistio_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 18);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Asistencia al:";
            // 
            // dtpFecha
            // 
            dtpFecha.Checked = false;
            dtpFecha.Location = new Point(35, 34);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 23);
            dtpFecha.TabIndex = 0;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.AllowUserToAddRows = false;
            dgvAsistencia.AllowUserToDeleteRows = false;
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(105, 0);
            dgvAsistencia.Margin = new Padding(3, 2, 3, 2);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.ReadOnly = true;
            dgvAsistencia.RowHeadersWidth = 51;
            dgvAsistencia.Size = new Size(492, 206);
            dgvAsistencia.TabIndex = 0;
            dgvAsistencia.CellClick += dgvAsistencia_CellClick;
            // 
            // Asistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Asistencia";
            Text = "Asistencia";
            Load += Asistencia_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            gbBotones.ResumeLayout(false);
            gbBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private DateTimePicker dtpFecha;
        private DataGridView dgvAsistencia;
        private GroupBox gbBotones;
        private RadioButton rbTodos;
        private RadioButton rbNoAsistio;
        private RadioButton rbAsistio;
        private Label label2;
        private TextBox txtRegistro;
        private Button btnResumen;
    }
}