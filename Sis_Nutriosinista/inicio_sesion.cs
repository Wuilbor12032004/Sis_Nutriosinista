namespace Sis_Nutriosinista

{
    public partial class Form_Iniciodeseccion : Form
    {
        public Form_Iniciodeseccion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form_Registro_Usuario registroUsuarioForm = new Form_Registro_Usuario();


            registroUsuarioForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoninicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxContrase�a.Text))
            {
                MessageBox.Show("Por favor, ingrese la contrase�a.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }

        private void textBoxContrase�a_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
