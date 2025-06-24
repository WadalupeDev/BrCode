using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrCode
{
    public partial class Tutorial : Form
    {

        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        Label[] parrafos = new Label[29];
        int currectParr = 0;
        
        public Tutorial()
        {
            InitializeComponent();
            parrafos[0] = label30;
            parrafos[1] =label2;
            parrafos[2] =lbJavaText;
            parrafos[3] =label24;
            parrafos[4] =label29;
            parrafos[5] =label28;
            parrafos[6] =label31;
            parrafos[7] =label26;
            parrafos[8] =lbVariable1;
            parrafos[9] =label3;
            parrafos[10] =label4;
            parrafos[11] =label5;
            parrafos[12] =label6;
            parrafos[13] =label8;
            parrafos[14] =label7;
            parrafos[15] =label10;
            parrafos[16] =label9;
            parrafos[17] =label12;
            parrafos[18] =label11;
            parrafos[19] =label14;
            parrafos[20] =label13;
            parrafos[21] =label16;
            parrafos[22] =label15;
            parrafos[23] =label18;
            parrafos[24] =label17;
            parrafos[25] =label20;
            parrafos[26] =label19;
            parrafos[27] =label22;
            parrafos[28] = label21;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            MainForm abrirPantallaCarga = new MainForm();
            abrirPantallaCarga.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void lbJavaText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbJava_Click(object sender, EventArgs e)
        {

        }

        private void lbJavaCode5_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        public void AsyncTTS(string text) {
            synthesizer.SetOutputToDefaultAudioDevice();
            if (text != null) {
                synthesizer.SpeakAsync(text);
            }
            else {
                synthesizer.SpeakAsync("Caracter no valido");
            }
        }

        private void TutorialLearnKode_KeyDown(object sender, KeyEventArgs e) {
            
        }

        private void TutorialLearnKode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Space:
                    synthesizer.SpeakAsyncCancelAll();
                    break;
                case Keys.Right:
                    synthesizer.Rate++;
                    break;
                case Keys.Left:
                    synthesizer.Rate--;
                    break;
            }
        }

        private void tabPage6_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            switch (keyData) {
                case Keys.Space:
                    AsyncTTS(parrafos[currectParr].Text);
                    return true;
                case Keys.Right:
                    synthesizer.Rate++;
                    return true;
                case Keys.Left:
                    synthesizer.Rate--;
                    return true;
                case Keys.Escape:
                    currectParr++;
                    synthesizer.SpeakAsyncCancelAll();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void lbVariable1_Click(object sender, EventArgs e) {

        }
    }
}
