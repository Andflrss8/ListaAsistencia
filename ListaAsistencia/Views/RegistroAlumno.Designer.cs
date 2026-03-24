namespace ListaAsistencia.Views
{
    partial class RegistroAlumno
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtPat = new TextBox();
            txtMat = new TextBox();
            label4 = new Label();
            txtNC = new TextBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 44);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre(s):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 96);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 148);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(192, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPat
            // 
            txtPat.Location = new Point(155, 93);
            txtPat.Name = "txtPat";
            txtPat.Size = new Size(192, 23);
            txtPat.TabIndex = 4;
            // 
            // txtMat
            // 
            txtMat.Location = new Point(155, 145);
            txtMat.Name = "txtMat";
            txtMat.Size = new Size(192, 23);
            txtMat.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 44);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 6;
            label4.Text = "Número de control:";
            // 
            // txtNC
            // 
            txtNC.Location = new Point(504, 41);
            txtNC.Name = "txtNC";
            txtNC.Size = new Size(183, 23);
            txtNC.TabIndex = 7;
            txtNC.TextChanged += textBox4_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(479, 106);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // RegistroAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 206);
            Controls.Add(btnConfirmar);
            Controls.Add(txtNC);
            Controls.Add(label4);
            Controls.Add(txtMat);
            Controls.Add(txtPat);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroAlumno";
            Text = "RegistroAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtPat;
        private TextBox txtMat;
        private Label label4;
        private TextBox txtNC;
        private Button btnConfirmar;
    }
}