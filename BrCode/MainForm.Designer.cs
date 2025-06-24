namespace BrCode
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnParse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.panelTodo = new System.Windows.Forms.Panel();
            this.tbErrores = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvLexer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbSintaxResult = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbSemanticResult = new System.Windows.Forms.TextBox();
            this.consoleControl1 = new ConsoleControl.ConsoleControl();
            this.labelConsola = new System.Windows.Forms.Label();
            this.tbCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Herramientas = new System.Windows.Forms.TableLayoutPanel();
            this.btnAyuda = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Analisis = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTodo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexer)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCode)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Herramientas.SuspendLayout();
            this.Analisis.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 112);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnParse
            // 
            this.btnParse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnParse.BackgroundImage = global::BrCode.Properties.Resources.sdssd1;
            this.btnParse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnParse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnParse.FlatAppearance.BorderSize = 0;
            this.btnParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParse.Location = new System.Drawing.Point(317, 3);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 52);
            this.btnParse.TabIndex = 23;
            this.btnParse.Text = "Ejecutar";
            this.btnParse.UseVisualStyleBackColor = false;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMin.Image = global::BrCode.Properties.Resources.minus_solid;
            this.pictureBoxMin.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(43, 31);
            this.pictureBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMin.TabIndex = 8;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMax.Image = global::BrCode.Properties.Resources.window_maximize_regular;
            this.pictureBoxMax.Location = new System.Drawing.Point(52, 3);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(43, 31);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMax.TabIndex = 7;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCerrar.Image = global::BrCode.Properties.Resources.iconocerrarblanco;
            this.pictureBoxCerrar.Location = new System.Drawing.Point(101, 3);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(43, 31);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCerrar.TabIndex = 6;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::BrCode.Properties.Resources.BrCodeLogo;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewFile.BackgroundImage")));
            this.btnNewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewFile.FlatAppearance.BorderSize = 0;
            this.btnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFile.Location = new System.Drawing.Point(70, 3);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(79, 52);
            this.btnNewFile.TabIndex = 2;
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.BackgroundImage")));
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Location = new System.Drawing.Point(155, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(77, 52);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // panelTodo
            // 
            this.panelTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelTodo.Controls.Add(this.tbErrores);
            this.panelTodo.Controls.Add(this.labelConsola);
            this.panelTodo.Location = new System.Drawing.Point(-1, 95);
            this.panelTodo.Name = "panelTodo";
            this.panelTodo.Size = new System.Drawing.Size(1119, 563);
            this.panelTodo.TabIndex = 11;
            // 
            // tbErrores
            // 
            this.tbErrores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbErrores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tbErrores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbErrores.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbErrores.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbErrores.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbErrores.Location = new System.Drawing.Point(761, 218);
            this.tbErrores.Multiline = true;
            this.tbErrores.Name = "tbErrores";
            this.tbErrores.ReadOnly = true;
            this.tbErrores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbErrores.Size = new System.Drawing.Size(346, 120);
            this.tbErrores.TabIndex = 31;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 271);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.tabPage1.Controls.Add(this.dgvLexer);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(345, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Léxico";
            // 
            // dgvLexer
            // 
            this.dgvLexer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLexer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLexer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.dgvLexer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLexer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLexer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLexer.ColumnHeadersHeight = 25;
            this.dgvLexer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLexer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLexer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLexer.EnableHeadersVisualStyles = false;
            this.dgvLexer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.dgvLexer.Location = new System.Drawing.Point(2, 2);
            this.dgvLexer.MultiSelect = false;
            this.dgvLexer.Name = "dgvLexer";
            this.dgvLexer.ReadOnly = true;
            this.dgvLexer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLexer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLexer.RowHeadersVisible = false;
            this.dgvLexer.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvLexer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLexer.Size = new System.Drawing.Size(341, 237);
            this.dgvLexer.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Token";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Línea";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Columna";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 86;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbSintaxResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(345, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sintáctico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbSintaxResult
            // 
            this.tbSintaxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.tbSintaxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSintaxResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSintaxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSintaxResult.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSintaxResult.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSintaxResult.Location = new System.Drawing.Point(2, 2);
            this.tbSintaxResult.Multiline = true;
            this.tbSintaxResult.Name = "tbSintaxResult";
            this.tbSintaxResult.ReadOnly = true;
            this.tbSintaxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSintaxResult.Size = new System.Drawing.Size(341, 237);
            this.tbSintaxResult.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbSemanticResult);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(345, 241);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Semántico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbSemanticResult
            // 
            this.tbSemanticResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.tbSemanticResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSemanticResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSemanticResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSemanticResult.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSemanticResult.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSemanticResult.Location = new System.Drawing.Point(2, 2);
            this.tbSemanticResult.Multiline = true;
            this.tbSemanticResult.Name = "tbSemanticResult";
            this.tbSemanticResult.ReadOnly = true;
            this.tbSemanticResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSemanticResult.Size = new System.Drawing.Size(341, 237);
            this.tbSemanticResult.TabIndex = 3;
            // 
            // consoleControl1
            // 
            this.consoleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleControl1.IsInputEnabled = true;
            this.consoleControl1.Location = new System.Drawing.Point(4, 279);
            this.consoleControl1.Margin = new System.Windows.Forms.Padding(4);
            this.consoleControl1.Name = "consoleControl1";
            this.consoleControl1.SendKeyboardCommandsToProcess = false;
            this.consoleControl1.ShowDiagnostics = true;
            this.consoleControl1.Size = new System.Drawing.Size(349, 267);
            this.consoleControl1.TabIndex = 27;
            // 
            // labelConsola
            // 
            this.labelConsola.AutoSize = true;
            this.labelConsola.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsola.ForeColor = System.Drawing.Color.White;
            this.labelConsola.Location = new System.Drawing.Point(758, 388);
            this.labelConsola.Name = "labelConsola";
            this.labelConsola.Size = new System.Drawing.Size(92, 26);
            this.labelConsola.TabIndex = 22;
            this.labelConsola.Text = "Consola";
            // 
            // tbCode
            // 
            this.tbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.tbCode.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(" +
    "?<range>:)\\s*(?<range>[^;]+);";
            this.tbCode.AutoScrollMinSize = new System.Drawing.Size(575, 240);
            this.tbCode.BackBrush = null;
            this.tbCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.tbCode.CharHeight = 24;
            this.tbCode.CharWidth = 12;
            this.tbCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbCode.FoldingIndicatorColor = System.Drawing.Color.Orange;
            this.tbCode.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.tbCode.ForeColor = System.Drawing.Color.White;
            this.tbCode.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.tbCode.IsReplaceMode = false;
            this.tbCode.LineNumberColor = System.Drawing.Color.White;
            this.tbCode.Location = new System.Drawing.Point(3, 67);
            this.tbCode.Name = "tbCode";
            this.tbCode.Paddings = new System.Windows.Forms.Padding(0);
            this.tbCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.tbCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbCode.ServiceColors")));
            this.tbCode.Size = new System.Drawing.Size(718, 570);
            this.tbCode.TabIndex = 21;
            this.tbCode.Text = "import java.util.*;\r\n\r\npublic class Main {\r\n    public static void main(String[] " +
    "args) {\r\n        // Tu código aquí\r\n        \r\n        System.out.println(\"Hola m" +
    "undo\");\r\n    }\r\n}\r\n";
            this.tbCode.Zoom = 100;
            this.tbCode.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.tbCode_TextChanged);
            this.tbCode.Load += new System.EventHandler(this.tbCode_Load);
            this.tbCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCode_KeyDown);
            this.tbCode.Leave += new System.EventHandler(this.tbCode_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Herramientas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Analisis, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1035, 640);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // Herramientas
            // 
            this.Herramientas.ColumnCount = 6;
            this.Herramientas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Herramientas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Herramientas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Herramientas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Herramientas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Herramientas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Herramientas.Controls.Add(this.pictureBox1, 0, 0);
            this.Herramientas.Controls.Add(this.btnParse, 0, 0);
            this.Herramientas.Controls.Add(this.btnOpenFile, 0, 0);
            this.Herramientas.Controls.Add(this.pictureBox2, 0, 0);
            this.Herramientas.Controls.Add(this.btnNewFile, 0, 0);
            this.Herramientas.Controls.Add(this.btnAyuda, 5, 0);
            this.Herramientas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Herramientas.Location = new System.Drawing.Point(3, 3);
            this.Herramientas.Name = "Herramientas";
            this.Herramientas.RowCount = 1;
            this.Herramientas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Herramientas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Herramientas.Size = new System.Drawing.Size(718, 58);
            this.Herramientas.TabIndex = 0;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.BorderRadius = 0;
            this.btnAyuda.ButtonText = "Tutorial";
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.DisabledColor = System.Drawing.Color.Gray;
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAyuda.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAyuda.Iconimage = null;
            this.btnAyuda.Iconimage_right = null;
            this.btnAyuda.Iconimage_right_Selected = null;
            this.btnAyuda.Iconimage_Selected = null;
            this.btnAyuda.IconMarginLeft = 0;
            this.btnAyuda.IconMarginRight = 0;
            this.btnAyuda.IconRightVisible = true;
            this.btnAyuda.IconRightZoom = 0D;
            this.btnAyuda.IconVisible = true;
            this.btnAyuda.IconZoom = 90D;
            this.btnAyuda.IsTab = false;
            this.btnAyuda.Location = new System.Drawing.Point(399, 4);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.btnAyuda.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAyuda.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAyuda.selected = false;
            this.btnAyuda.Size = new System.Drawing.Size(315, 50);
            this.btnAyuda.TabIndex = 21;
            this.btnAyuda.Text = "Tutorial";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAyuda.Textcolor = System.Drawing.Color.White;
            this.btnAyuda.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // Analisis
            // 
            this.Analisis.ColumnCount = 1;
            this.Analisis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Analisis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Analisis.Controls.Add(this.tabControl1, 0, 0);
            this.Analisis.Controls.Add(this.consoleControl1, 0, 1);
            this.Analisis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Analisis.Location = new System.Drawing.Point(727, 67);
            this.Analisis.Name = "Analisis";
            this.Analisis.RowCount = 3;
            this.Analisis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Analisis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Analisis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Analisis.Size = new System.Drawing.Size(305, 570);
            this.Analisis.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxMin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxMax, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxCerrar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(155, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(147, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(727, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(305, 58);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1035, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTodo);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LearnKode;";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTodo.ResumeLayout(false);
            this.panelTodo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLexer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCode)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Herramientas.ResumeLayout(false);
            this.Analisis.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.Panel panelTodo;
        private ConsoleControl.ConsoleControl consoleControl1;
        private System.Windows.Forms.Label labelConsola;
        private FastColoredTextBoxNS.FastColoredTextBox tbCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbErrores;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLexer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbSintaxResult;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbSemanticResult;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel Herramientas;
        private Bunifu.Framework.UI.BunifuFlatButton btnAyuda;
        private System.Windows.Forms.TableLayoutPanel Analisis;
    }
}