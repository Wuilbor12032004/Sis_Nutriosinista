using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_Nutriosinista
{
    public partial class Form_Registro_Usuario : Form
    {
        public Form_Registro_Usuario()
        {
            InitializeComponent();
        }

        private void buttonregistrodeusuario_Click(object sender, EventArgs e)
        {

            // Crear una instancia de Registro_de_usuario y llenar con los datos del formulario
            Form_Registro_Usuario registro = new Form_Registro_Usuario();


            // Mostrar un mensaje indicando que se guardó correctamente
            MessageBox.Show("Datos guardados correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario actual
            this.Close();

      


        }

        private void textBoxnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxcorreo_TextChanged(object sender, EventArgs e)
        {
        }
    }
    
}