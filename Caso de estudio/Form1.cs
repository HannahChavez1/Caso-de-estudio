namespace Caso_de_estudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //====================================
            // 1.- VALIDAR EL NOMBRE
            //====================================
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                  "Por favor escribe tu nombre.",
                   "Validación",
                      MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );
                txtNombre.Focus();
            }
            //=========================================
            // 2.- OBTENER LAS ACTIIDADES SELECCIONADAS
            //=========================================

            List<string> Actividades = new List<string>();
            if (chkDeportes.Checked)
            {
                Actividades.Add("Deportes");
            }
            if (chkMusica.Checked)
            {
                Actividades.Add("Musica");
            }
            if (chkArte.Checked)
            {
                Actividades.Add("Arte");
            }
            if (chkProgramacion.Checked)
            {
                Actividades.Add("Programacion");
            }
            if (chkLectura.Checked)
            {
                Actividades.Add("Lectura");
            }

            //======================================
            // 3.- COMPROBAR SELECCIÓN
            //======================================
            if (Actividades.Count == 0)
            {
                MessageBox.Show(
                    "por favor seleciona una atividad minimo.",
                    "validacion.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            //======================================
            // 4.- OBTENER LA MODALIDAD
            //======================================
            string modaliad = "";
            if (rbPresencial.Checked)
            {
                modaliad = "Precencial";
            }
            else if (rbHibrida.Checked)
            {
                modaliad = "Hibrida";
            }
            else if (rbLinea.Checked)
            {
                modaliad = "En linea";
            }
            else
            {
                MessageBox.Show("Porfavor seleccione una modalidad",
                    "validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //======================================
            // 4.- CREAR EL RESUMEN
            //======================================
            string resumen =
                "Resumen de preferencia\r\n" +
                "-------------------------\r\n" +
                "Nombre: " + txtNombre.Text + "\r\n" +
                "Actividades: " + string.Join(",", Actividades) + "\r\n" +
                "Modalidad: " + modaliad;
            txtResumen.Text = resumen;


        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar nombre
            txtNombre.Clear(); //txtNombre="";
            //desmarcamos el checkBox
            chkDeportes.Checked = false;
            chkLectura.Checked = false;
            chkArte.Checked = false;
            chkMusica.Checked = false;
            chkProgramacion.Checked = false;
            //desmarcar RadioButton
            rbLinea.Checked = false;
            rbHibrida.Checked = false;
            rbPresencial.Checked = false;
            //Limpiar Resumen
            txtResumen.Clear();
            //Regesamos el cursor al nombre
            txtNombre.Focus();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btbLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar nombre
            txtNombre.Clear(); //txtNombre="";
            //desmarcamos el checkBox
            chkDeportes.Checked = false;
            chkLectura.Checked = false;
            chkArte.Checked = false;
            chkMusica.Checked = false;
            chkProgramacion.Checked = false;
            //desmarcar RadioButton
            rbLinea.Checked = false;
            rbHibrida.Checked = false;
            rbPresencial.Checked = false;
            //Limpiar Resumen
            txtResumen.Clear();
            //Regesamos el cursor al nombre
            txtNombre.Focus();
        }
    }
}


