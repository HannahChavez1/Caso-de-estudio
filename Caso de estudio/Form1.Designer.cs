namespace Caso_de_estudio
{
    partial class Form1
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
            label1 = new Label();
            txtNombre = new TextBox();
            panel1 = new Panel();
            chkLectura = new CheckBox();
            chkProgramacion = new CheckBox();
            chkArte = new CheckBox();
            chkMusica = new CheckBox();
            chkDeportes = new CheckBox();
            panel2 = new Panel();
            rbLinea = new RadioButton();
            rbHibrida = new RadioButton();
            rbPresencial = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            btbLimpiar = new Button();
            label4 = new Label();
            txtResumen = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del usuario";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 23);
            txtNombre.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(chkLectura);
            panel1.Controls.Add(chkProgramacion);
            panel1.Controls.Add(chkArte);
            panel1.Controls.Add(chkMusica);
            panel1.Controls.Add(chkDeportes);
            panel1.Location = new Point(12, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 139);
            panel1.TabIndex = 2;
            // 
            // chkLectura
            // 
            chkLectura.AutoSize = true;
            chkLectura.Location = new Point(11, 81);
            chkLectura.Name = "chkLectura";
            chkLectura.Size = new Size(65, 19);
            chkLectura.TabIndex = 4;
            chkLectura.Text = "Lectura";
            chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkProgramacion
            // 
            chkProgramacion.AutoSize = true;
            chkProgramacion.Location = new Point(11, 107);
            chkProgramacion.Name = "chkProgramacion";
            chkProgramacion.Size = new Size(101, 19);
            chkProgramacion.TabIndex = 3;
            chkProgramacion.Text = "Programacion";
            chkProgramacion.UseVisualStyleBackColor = true;
            // 
            // chkArte
            // 
            chkArte.AutoSize = true;
            chkArte.Location = new Point(11, 56);
            chkArte.Name = "chkArte";
            chkArte.Size = new Size(48, 19);
            chkArte.TabIndex = 2;
            chkArte.Text = "Arte";
            chkArte.UseVisualStyleBackColor = true;
            // 
            // chkMusica
            // 
            chkMusica.AutoSize = true;
            chkMusica.Location = new Point(11, 31);
            chkMusica.Name = "chkMusica";
            chkMusica.Size = new Size(64, 19);
            chkMusica.TabIndex = 1;
            chkMusica.Text = "Musica";
            chkMusica.UseVisualStyleBackColor = true;
            chkMusica.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkDeportes
            // 
            chkDeportes.AutoSize = true;
            chkDeportes.Location = new Point(11, 6);
            chkDeportes.Name = "chkDeportes";
            chkDeportes.Size = new Size(73, 19);
            chkDeportes.TabIndex = 0;
            chkDeportes.Text = "Deportes";
            chkDeportes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbLinea);
            panel2.Controls.Add(rbHibrida);
            panel2.Controls.Add(rbPresencial);
            panel2.Location = new Point(330, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 139);
            panel2.TabIndex = 3;
            // 
            // rbLinea
            // 
            rbLinea.AutoSize = true;
            rbLinea.Location = new Point(20, 81);
            rbLinea.Name = "rbLinea";
            rbLinea.Size = new Size(66, 19);
            rbLinea.TabIndex = 2;
            rbLinea.TabStop = true;
            rbLinea.Text = "En linea";
            rbLinea.UseVisualStyleBackColor = true;
            // 
            // rbHibrida
            // 
            rbHibrida.AutoSize = true;
            rbHibrida.Location = new Point(20, 31);
            rbHibrida.Name = "rbHibrida";
            rbHibrida.Size = new Size(64, 19);
            rbHibrida.TabIndex = 1;
            rbHibrida.TabStop = true;
            rbHibrida.Text = "Hibrida";
            rbHibrida.UseVisualStyleBackColor = true;
            // 
            // rbPresencial
            // 
            rbPresencial.AutoSize = true;
            rbPresencial.Location = new Point(20, 56);
            rbPresencial.Name = "rbPresencial";
            rbPresencial.Size = new Size(78, 19);
            rbPresencial.TabIndex = 0;
            rbPresencial.TabStop = true;
            rbPresencial.Text = "Presencial";
            rbPresencial.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 102);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 4;
            label3.Text = "Modalidad Preferida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(217, 15);
            label2.TabIndex = 5;
            label2.Text = "Actividades favoritas (ocpvion multiple)";
            // 
            // button1
            // 
            button1.Location = new Point(315, 311);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 6;
            button1.Text = "Mostrar resumen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btbLimpiar
            // 
            btbLimpiar.Location = new Point(464, 311);
            btbLimpiar.Name = "btbLimpiar";
            btbLimpiar.Size = new Size(75, 23);
            btbLimpiar.TabIndex = 7;
            btbLimpiar.Text = "Limpiar";
            btbLimpiar.UseVisualStyleBackColor = true;
            btbLimpiar.Click += btbLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 355);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Resumen :";
            // 
            // txtResumen
            // 
            txtResumen.Location = new Point(12, 373);
            txtResumen.Multiline = true;
            txtResumen.Name = "txtResumen";
            txtResumen.Size = new Size(569, 183);
            txtResumen.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 568);
            Controls.Add(txtResumen);
            Controls.Add(label4);
            Controls.Add(btbLimpiar);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private CheckBox chkLectura;
        private CheckBox chkProgramacion;
        private CheckBox chkArte;
        private CheckBox chkMusica;
        private CheckBox chkDeportes;
        private RadioButton rbLinea;
        private RadioButton rbHibrida;
        private RadioButton rbPresencial;
        private Label label2;
        private Button button1;
        private Button btbLimpiar;
        private Label label4;
        private TextBox txtResumen;
    }
}
