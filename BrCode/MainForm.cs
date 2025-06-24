using BrCode.Irony;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;

namespace BrCode
{
    public partial class MainForm : Form
    {
        string fileLocation = "";
        string fileName = "";
        bool syntaxError = false;

        Dictionary<string, string> Shorts = new Dictionary<string, string>();
        string ShortCode = "";

        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        CancellationTokenSource tokenSource;
        CancellationToken token;


        public MainForm() {
            synthesizer.SetOutputToDefaultAudioDevice();
            //Inicializamos los componentes y asignamos la visibilidad a los elementos dinamicos.
            InitializeComponent();
            tbCode.Language = FastColoredTextBoxNS.Language.CSharp;
            tbCode.Focus();
            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;

            //Se define el codigo de ejemplo que se mostrara en la ventana de codigo.
            tbCode.Text = "import java.util.*;\r\n\r\npublic class App {\r\n    public static void main(String[] " +
                "args) {\r\n        // Tu código aquí\r\n        \r\n        System.out.println(\"Hola m" +
                "undo\");\r\n    }\r\n}\r\n";


            //Se definen los atajos en un diccionario tal que la clave (string) es el codigo numerico que se tiene que ingresar a traves del numpad para que sea traducido al valor (string).

            //Categoria Tipos Primitivos:
            Shorts.Add("111", "int");
            Shorts.Add("112", "float");
            Shorts.Add("113", "double");
            Shorts.Add("114", "byte");
            Shorts.Add("115", "char");
            Shorts.Add("116", "boolean");
            Shorts.Add("117", "void");
            Shorts.Add("118", "short");
            Shorts.Add("119", "long");

            //Categoria POO:
            Shorts.Add("121", "new");
            Shorts.Add("122", "abstract");
            Shorts.Add("123", "import");
            Shorts.Add("124", "implements");
            Shorts.Add("125", "instanceOf");
            Shorts.Add("126", "super");
            Shorts.Add("127", "this");
            Shorts.Add("128", "transient");
            Shorts.Add("129", "extends");

            //Categoria Expcepciones:
            Shorts.Add("131", "try");
            Shorts.Add("132", "catch");
            Shorts.Add("133", "throws");
            Shorts.Add("134", "throw");

            //Categoria Modificadores de Acceso:
            Shorts.Add("141", "private");
            Shorts.Add("142", "protected");
            Shorts.Add("143", "public");

            //Cateogria Modificadores de No Acceso:
            Shorts.Add("151", "static");
            Shorts.Add("152", "final");
            Shorts.Add("153", "abstract");
            Shorts.Add("154", "synchronized");
            Shorts.Add("155", "transient");
            Shorts.Add("156", "volatile");
            Shorts.Add("157", "strictfp");

            //Cateogoria Ciclos:
            Shorts.Add("161", "while");
            Shorts.Add("162", "do");
            Shorts.Add("163", "for");

            //Navegación en Bloques:
            Shorts.Add("171", "continue");
            Shorts.Add("172", "break");
            Shorts.Add("173", "case");
            Shorts.Add("174", "return");
            Shorts.Add("175", "goto");

            //Categoria en Estructuras de Control:
            Shorts.Add("181", "if");
            Shorts.Add("182", "else");
            Shorts.Add("183", "else if");
            Shorts.Add("184", "switch");
            Shorts.Add("185", "=?:");

            //Categoria Palabras Reservadas:
            Shorts.Add("191", "class");
            Shorts.Add("192", "interface");
            Shorts.Add("193", "enum");
            Shorts.Add("194", "package");

            //Sin Categoria:
            Shorts.Add("101", "assert");
            Shorts.Add("102", "native");

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Analize_Text(object sender, EventArgs e)
        {


        }

        private void AnalizeCode()
        {
            dgvLexer.Rows.Clear();
            foreach (TokenCode token in TokenTable.LexicalAnalysis(tbCode.Text))
            {
                if (token.Name == "ERROR")
                {
                    dgvLexer.Rows.Add(token.Name, token.Lexeme, token.Line, token.Column);
                }
                else
                {
                    if (token.Name != "SPACE" && token.Name != "IGNORE")
                    {
                        dgvLexer.Rows.Add(token.Name, token.Lexeme, token.Line, token.Column);
                    }
                }
            }
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            NuevoArchivo();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            AbrirArchivo();
        }

        private void NuevoArchivo() {
            this.Hide();
            MainForm newForm = new MainForm();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }

        private void AbrirArchivo() {
            OpenFileDialog dialog = new OpenFileDialog() {
                FileName = "Selecciona un archivo",
                Filter = "Archivos Java (*.java)|*.java",
                Title = "Carga tu código"
            };
            if (dialog.ShowDialog() == DialogResult.OK) {
                StreamReader sr = new StreamReader(dialog.FileName);
                fileLocation = dialog.FileName.Replace(dialog.SafeFileName, "");
                fileName = dialog.SafeFileName;
                tbCode.Text = sr.ReadToEnd();
            }
        }

        private void Ejecutar() {
            if (tbCode.Text == "") {

                dgvLexer.Rows.Clear();

                dgvLexer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 202, 40);

            }
            else {
                //Creamos un Task para ejecutar asincronamente el TextToSpeech y lo iniciamos con el codigo completo como parametro
                AsyncTTS(tbCode.Text);

                //Ejecutamos el metodo para analizar el codigo
                AnalizeCode();
                tbSintaxResult.Text = "";
                PrototypeParser.errors = "";
                PrototypeParser.treeText = "";
                bool result = PrototypeParser.Parse(tbCode.Text);
                string resultText;
                //Comprobamos si existen errores, en caso de que no existan errores:
                if (result) {
                    tbSintaxResult.ForeColor = Color.FromArgb(46, 204, 113);




                    resultText = "No se encontraron errores\r\nAnálisis correcto\r\n";

                    dgvLexer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113);
                    resultText += "\r\n=====ÁRBOL=====\r\n";
                    resultText += PrototypeParser.treeText;
                    syntaxError = false;
                }
                //En caso de que existan errores:
                else {

                    dgvLexer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 51, 86);
                    tbSintaxResult.ForeColor = Color.FromArgb(255, 51, 86);
                    resultText = PrototypeParser.errors;


                    syntaxError = true;
                }
                checkSemanthic();
                tbSintaxResult.Text = resultText;
                PrototypeSemantic.errors.Clear();
            }
            string strCmdText;
            strCmdText = "/K cd " + @fileLocation + " && javac " + fileName + " && java " + fileName.Replace(".java", "");
            if (consoleControl1.IsProcessRunning) {
                consoleControl1.WriteInput(strCmdText.Replace("/K", ""), consoleControl1.ForeColor, false);
            }
            else {
                consoleControl1.StartProcess("CMD.exe", strCmdText);
            }
        }

        private void Guardar() {
            //aqui codigo para guardar el codigo actual
            if (fileLocation == "") {
                var saveDialog = new SaveFileDialog() {
                    InitialDirectory = @"C:\",
                    Filter = "Archivos Java (*.java)|*.java",
                    DefaultExt = "java",
                    Title = "Guarda tu código antes de ejecutarlo",
                    CheckPathExists = true
                };
                if (saveDialog.ShowDialog() == DialogResult.OK) {
                    if (saveDialog.FileName != "") {
                        string[] parts = saveDialog.FileName.Split('\\');
                        fileName = parts[parts.Length - 1];
                        fileLocation = saveDialog.FileName.Replace(fileName, "");
                        if (!fileName.Contains(PrototypeSemantic.codeClass)) {
                            MessageBox.Show("La clase y el archivo deben tener el mismo nombre", "Error al guardar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        File.WriteAllText(saveDialog.FileName, tbCode.Text);
                    }
                }
            }
            else {
                string fullName = fileLocation + fileName;
                File.WriteAllText(fullName, tbCode.Text);
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            Ejecutar();
            
        }

        private void checkSemanthic()
        {
            string resultText = "\r\n";
            if (PrototypeSemantic.errors.Count > 0)
            {
                foreach (string error in PrototypeSemantic.errors)
                {
                    resultText += error + "\r\n";
                }
                tbSemanticResult.ForeColor = Color.FromArgb(255, 51, 86);

                dgvLexer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 51, 86);
                if (tbErrores.ForeColor == Color.FromArgb(46, 204, 113))
                {
                    tbErrores.ForeColor = Color.FromArgb(255, 51, 86);
                }
            }
            else
            {

                tbSemanticResult.ForeColor = Color.FromArgb(46, 204, 113);
                resultText = "\r\nNo se encontraron errores semánticos\r\nAnálisis correcto\r\n";
            }
            tbSemanticResult.Text = resultText;
            tbErrores.Text += resultText;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio abrirPantallaCarga = new Inicio();
            abrirPantallaCarga.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void tbCode_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            

        }

        private void dgvLexer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tbCode.Text = "";
            dgvLexer.Rows.Clear();
          
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Tutorial AbrirTuto = new Tutorial();
            AbrirTuto.Show();
         }
        int contadorC = 0;
        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (contadorC % 2 == 0)
            {
                pictureBoxCerrar.Image = pictureBoxCerrar.Image = BrCode.Properties.Resources.iconocerrar;
                pictureBoxMax.Image = pictureBoxMax.Image = BrCode.Properties.Resources.iconomaximizar;
                pictureBoxMin.Image = pictureBoxMin.Image = BrCode.Properties.Resources.iconominimizar;

                labelConsola.ForeColor = Color.FromArgb(17, 30, 41);
                tbCode.ForeColor = Color.FromArgb(0, 0, 0);
                tbCode.IndentBackColor = Color.FromArgb(220, 220, 220);
                tbCode.LineNumberColor = Color.FromArgb(0, 0, 0);
                tbCode.BackColor = Color.FromArgb(241, 241, 241);
                panelTodo.BackColor = Color.FromArgb(241,241,241);
                panel1.BackColor = Color.FromArgb(255, 255, 255);
                //datagrid view
                dgvLexer.GridColor = Color.FromArgb(255,255,255);
                dgvLexer.BackgroundColor = Color.FromArgb(255,255,255);
                dgvLexer.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                dgvLexer.DefaultCellStyle.ForeColor = Color.FromArgb(17, 30, 41);
                dgvLexer.RowsDefaultCellStyle.BackColor = Color.FromArgb(255,255,255);
                dgvLexer.RowsDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

                tbSemanticResult.BackColor = Color.FromArgb(255,255,255);
                tbErrores.BackColor = Color.FromArgb(255, 255, 255);
                tbSintaxResult.BackColor = Color.FromArgb(255, 255, 255);
                btnAyuda.BackColor = Color.FromArgb(241, 241, 241);
                btnAyuda.Activecolor = Color.FromArgb(46, 204, 113);
                btnAyuda.Normalcolor = Color.FromArgb(220, 220, 220);
                btnAyuda.ForeColor = Color.FromArgb(0, 0, 0);
                btnAyuda.Textcolor = Color.FromArgb(0, 0, 0);

            }
            else {
                pictureBoxCerrar.Image = pictureBoxCerrar.Image = BrCode.Properties.Resources.iconocerrarblanco;
                pictureBoxMax.Image = pictureBoxMax.Image = BrCode.Properties.Resources.iconomaximizarblanco;
                pictureBoxMin.Image = pictureBoxMin.Image = BrCode.Properties.Resources.iconominimizarblanco;

                labelConsola.ForeColor = Color.FromArgb(255, 255, 255);
                tbCode.ForeColor = Color.FromArgb(255, 255, 255);
                tbCode.IndentBackColor = Color.FromArgb(12, 21, 29);
                tbCode.LineNumberColor = Color.FromArgb(255, 255, 255);
                tbCode.BackColor = Color.FromArgb(17, 30, 41);
                panelTodo.BackColor = Color.FromArgb(17, 30, 41);
                panel1.BackColor = Color.FromArgb(12, 21, 29);

                dgvLexer.GridColor = Color.FromArgb(17, 30, 41);
                dgvLexer.BackgroundColor = Color.FromArgb(17, 30, 41);
                dgvLexer.DefaultCellStyle.BackColor = Color.FromArgb(17, 30, 41);
                dgvLexer.DefaultCellStyle.ForeColor = Color.FromArgb(255,255,255);
                dgvLexer.RowsDefaultCellStyle.BackColor = Color.FromArgb(12, 21, 29);
                dgvLexer.RowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);

                tbSemanticResult.BackColor = Color.FromArgb(12, 21, 29);
                tbSintaxResult.BackColor = Color.FromArgb(12, 21, 29);
                btnAyuda.BackColor = Color.FromArgb(17, 30, 41);
                btnAyuda.Normalcolor = Color.FromArgb(17, 30, 41);
                btnAyuda.Textcolor = Color.FromArgb(255, 255, 255);
                btnAyuda.ForeColor = Color.FromArgb(255, 255, 255);
            }
            contadorC ++;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Tutorial AbrirTuto = new Tutorial();
            AbrirTuto.Show();
        }

        private void imgError_Click(object sender, EventArgs e)
        {
            DetallesErrorSintactico abrirDetallesSintactico = new DetallesErrorSintactico();
            abrirDetallesSintactico.Show();
            //click imagen error
        }

        private void imgErrorSemantico_Click(object sender, EventArgs e)
        {
            DetallesErrorSemantico abrirDetallesSemantico = new DetallesErrorSemantico();
            abrirDetallesSemantico.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Guardar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbModo_Click(object sender, EventArgs e)
        {

        }

        private void tbCode_Load(object sender, EventArgs e)
        {

        }

        //Metodo de registro de los atajos de teclado.
        private void tbCode_KeyDown(object sender, KeyEventArgs e) {
            //if (e.KeyCode > Keys.NumPad0 || e.KeyCode < Keys.NumPad9) {
                switch (e.KeyCode) {
                    case Keys.NumPad1:
                        ShortCode += "1";
                        e.Handled = true;
                        break;
                    case Keys.NumPad2:
                        ShortCode += "2";
                        e.Handled = true;
                        break;
                    case Keys.NumPad3:
                        ShortCode += "3";
                        e.Handled = true;
                        break;
                    case Keys.NumPad4:
                        ShortCode += "4";
                        e.Handled = true;
                        break;
                    case Keys.NumPad5:
                        ShortCode += "5";
                        e.Handled = true;
                        break;
                    case Keys.NumPad6:
                        ShortCode += "6";
                        e.Handled = true;
                        break;
                    case Keys.NumPad7:
                        ShortCode += "7";
                        e.Handled = true;
                        break;
                    case Keys.NumPad8:
                        ShortCode += "8";
                        e.Handled = true;
                        break;
                    case Keys.NumPad9:
                        ShortCode += "9";
                        e.Handled = true;
                        break;
                    case Keys.NumPad0:
                        Shorts.TryGetValue(ShortCode, out ShortCode);
                        tbCode.InsertText(ShortCode+" ");
                        AsyncTTS(ShortCode);
                        ShortCode = "";
                        e.Handled = true;
                        break;
                    case Keys.Escape:
                        synthesizer.SpeakAsyncCancelAll();
                        break;
                    case Keys.F1:
                        AsyncTTS(consoleControl1.Text);
                        e.Handled = true;
                        break;
                    case Keys.F2:
                        AsyncTTS(tbCode.Selection.Text);
                        e.Handled = true;
                        break;
                    case Keys.F3:
                        AsyncTTS(tbCode.Selection.Start.ToString());
                        e.Handled = true;
                        break;
                    case Keys.F4:
                        AsyncTTS(tbCode.Text);
                        e.Handled = true;
                        break;
                    case Keys.F5:
                        AsyncTTS("Escribiendo");
                        tbCode.Focus();
                        e.Handled = true;
                        break;
                    case Keys.F6:
                        AsyncTTS("Guardando Archivo");
                        Guardar();
                        e.Handled = true;
                    break;
                    case Keys.F7:
                        AsyncTTS("Cargando Archivo");
                        AbrirArchivo();
                        e.Handled = true;
                    break;
                    case Keys.F8:
                        AsyncTTS("Nuevo Archivo");
                        NuevoArchivo();
                        e.Handled = true;
                    break;
                    case Keys.F9:
                        AsyncTTS("Compilando");
                        Ejecutar();
                        e.Handled = true;
                    break;
                    case Keys.F10:
                        AsyncTTS("Analisis Sintactico. " + tbSintaxResult + ".Analisis Semantico. " + tbSemanticResult);
                        e.Handled = true;
                        break;
                    case Keys.F11:
                        if(synthesizer.Rate<10) synthesizer.Rate++;
                    break;
                    case Keys.F12:
                        if(synthesizer.Rate > 0)synthesizer.Rate--;
                    break;

            }
            //}
        }

        //Meotodo de reproduccion de Texto a Voz.
        //public void AsyncTTS(string text) {
        //    SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        //    synthesizer.SetOutputToDefaultAudioDevice();
        //    synthesizer.Speak(text);
        //    //Thread.Sleep(0);
        //}

        public void AsyncTTS(string text) {
            if (text != null) {
                synthesizer.SpeakAsync(text);
            }
            else {
                synthesizer.SpeakAsync("Caracter no valido");
            }
        }

        private void Ejecutar_Click(object sender, EventArgs e) {

        }

        private void tbCode_Leave(object sender, EventArgs e) {
            tbCode.Focus();
        }
    }
}
