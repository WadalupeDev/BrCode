using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
 

namespace BrCode
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MainForm abrirPantallaCarga = new MainForm();
            abrirPantallaCarga.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void Empezar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Empezar_Click(object sender, EventArgs e)
        {
            MainForm abrirPantallaCarga = new MainForm();
            abrirPantallaCarga.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            MainForm abrirPantallaCarga = new MainForm();
            abrirPantallaCarga.Show();
            this.Hide();
        }

        private void xx_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Tutorial AbrirTuto = new Tutorial();
            AbrirTuto.Show();
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
