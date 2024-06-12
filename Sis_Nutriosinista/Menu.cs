using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Sis_Nutriosinista
{




    public partial class Menu : Form
    {
        private bool isUserRegistered = false;
        private bool isUserLoggedIn = false;




        public Menu()
        {
            


        }





        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconoMaximisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void IconoRestaurar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;

        }

        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Iniciodeseccion inicio = new Form_Iniciodeseccion();


            inicio.TopLevel = false;
            inicio.FormBorderStyle = FormBorderStyle.None;
            inicio.Dock = DockStyle.Fill;


            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(inicio);

            inicio.Show();



        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Registro_Usuario Registro = new Form_Registro_Usuario();


            Registro.TopLevel = false;
            Registro.FormBorderStyle = FormBorderStyle.None;
            Registro.Dock = DockStyle.Fill;


            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(Registro);

            Registro.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Expediente Expediente = new Form_Expediente();


            Expediente.TopLevel = false;
            Expediente.FormBorderStyle = FormBorderStyle.None;
            Expediente.Dock = DockStyle.Fill;


            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(Expediente);

            Expediente.Show();
        }

        private void panelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Citas citas = new Form_Citas();


            citas.TopLevel = false;
            citas.FormBorderStyle = FormBorderStyle.None;
            citas.Dock = DockStyle.Fill;


            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(citas);

            citas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Menuvertical_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
