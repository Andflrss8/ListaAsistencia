namespace ListaAsistencia.Views
{
    partial class Reporte
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
            dgvCuenta = new DataGridView();
            label1 = new Label();
            dgvResumen = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            SuspendLayout();
            // 
            // dgvCuenta
            // 
            dgvCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuenta.Location = new Point(105, 25);
            dgvCuenta.Name = "dgvCuenta";
            dgvCuenta.RowHeadersWidth = 51;
            dgvCuenta.Size = new Size(404, 73);
            dgvCuenta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 126);
            label1.Name = "label1";
            label1.Size = new Size(259, 31);
            label1.TabIndex = 1;
            label1.Text = "Resumen de asistencia:";
            // 
            // dgvResumen
            // 
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(135, 182);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.RowHeadersWidth = 51;
            dgvResumen.Size = new Size(351, 188);
            dgvResumen.TabIndex = 2;
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 420);
            Controls.Add(dgvResumen);
            Controls.Add(label1);
            Controls.Add(dgvCuenta);
            Name = "Reporte";
            Text = "Reporte";
            Load += Reporte_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCuenta;
        private Label label1;
        private DataGridView dgvResumen;
    }
}