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
            label2 = new Label();
            btnRegistro = new Button();
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
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(btnRegistro);
            splitContainer1.Panel1.Controls.Add(txtRegistro);
            splitContainer1.Panel1.Controls.Add(gbBotones);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(dtpFecha);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAsistencia);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 172;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 141);
            label2.Name = "label2";
            label2.Size = new Size(146, 17);
            label2.TabIndex = 5;
            label2.Text = "(Solo numero de control)";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(348, 111);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(155, 29);
            btnRegistro.TabIndex = 4;
            btnRegistro.Text = "Obtener reporte";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(51, 111);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(274, 27);
            txtRegistro.TabIndex = 3;
            // 
            // gbBotones
            // 
            gbBotones.Controls.Add(rbTodos);
            gbBotones.Controls.Add(rbNoAsistio);
            gbBotones.Controls.Add(rbAsistio);
            gbBotones.Location = new Point(380, 24);
            gbBotones.Name = "gbBotones";
            gbBotones.Size = new Size(377, 80);
            gbBotones.TabIndex = 2;
            gbBotones.TabStop = false;
            gbBotones.Text = "Filtrar:";
            // 
            // rbTodos
            // 
            rbTodos.AutoSize = true;
            rbTodos.Location = new Point(239, 26);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(70, 24);
            rbTodos.TabIndex = 2;
            rbTodos.TabStop = true;
            rbTodos.Text = "Todos";
            rbTodos.UseVisualStyleBackColor = true;
            rbTodos.CheckedChanged += rbTodos_CheckedChanged;
            // 
            // rbNoAsistio
            // 
            rbNoAsistio.AutoSize = true;
            rbNoAsistio.Location = new Point(125, 25);
            rbNoAsistio.Name = "rbNoAsistio";
            rbNoAsistio.Size = new Size(98, 24);
            rbNoAsistio.TabIndex = 1;
            rbNoAsistio.TabStop = true;
            rbNoAsistio.Text = "No Asistio";
            rbNoAsistio.UseVisualStyleBackColor = true;
            rbNoAsistio.CheckedChanged += rbNoAsistio_CheckedChanged;
            // 
            // rbAsistio
            // 
            rbAsistio.AutoSize = true;
            rbAsistio.Location = new Point(28, 26);
            rbAsistio.Name = "rbAsistio";
            rbAsistio.Size = new Size(74, 24);
            rbAsistio.TabIndex = 0;
            rbAsistio.TabStop = true;
            rbAsistio.Text = "Asistio";
            rbAsistio.UseVisualStyleBackColor = true;
            rbAsistio.CheckedChanged += rbAsistio_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Asistencia al:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(40, 46);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(285, 27);
            dtpFecha.TabIndex = 0;
            dtpFecha.Value = new DateTime(2026, 3, 23, 0, 0, 0, 0);
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Dock = DockStyle.Fill;
            dgvAsistencia.Location = new Point(0, 0);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.RowHeadersWidth = 51;
            dgvAsistencia.Size = new Size(800, 274);
            dgvAsistencia.TabIndex = 0;
            dgvAsistencia.CellContentDoubleClick += dgvAsistencia_CellContentDoubleClick;
            // 
            // Asistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Asistencia";
            Text = "Asistencia";
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
        private Button btnRegistro;
        private TextBox txtRegistro;
    }
}