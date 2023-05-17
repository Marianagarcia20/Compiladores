namespace ProyectoFinalSistemasP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PictureBoxCompilar = new System.Windows.Forms.PictureBox();
            this.PictureBoxCargar = new System.Windows.Forms.PictureBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label3 = new System.Windows.Forms.Label();
            this.ListBoxStrings = new System.Windows.Forms.ListBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ListBoxReales = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ListBoxEnteras = new System.Windows.Forms.ListBox();
            this.listBoxPR = new System.Windows.Forms.ListBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtidentificadores = new System.Windows.Forms.Label();
            this.txtpalabrasr = new System.Windows.Forms.Label();
            this.txtarchivos = new System.Windows.Forms.Label();
            this.listBoxIds = new System.Windows.Forms.ListBox();
            this.txtarchivoe = new System.Windows.Forms.Label();
            this.listBoxEntrada = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelCompilador = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.comboBoxLenguaje = new System.Windows.Forms.ComboBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxLog = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCompilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panelCompilador.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLog)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxCompilar
            // 
            this.PictureBoxCompilar.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxCompilar.Image")));
            this.PictureBoxCompilar.Location = new System.Drawing.Point(989, 15);
            this.PictureBoxCompilar.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxCompilar.Name = "PictureBoxCompilar";
            this.PictureBoxCompilar.Size = new System.Drawing.Size(64, 64);
            this.PictureBoxCompilar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxCompilar.TabIndex = 61;
            this.PictureBoxCompilar.TabStop = false;
            this.PictureBoxCompilar.Click += new System.EventHandler(this.PictureBoxCompilar_Click);
            // 
            // PictureBoxCargar
            // 
            this.PictureBoxCargar.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxCargar.Image")));
            this.PictureBoxCargar.Location = new System.Drawing.Point(900, 15);
            this.PictureBoxCargar.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxCargar.Name = "PictureBoxCargar";
            this.PictureBoxCargar.Size = new System.Drawing.Size(64, 64);
            this.PictureBoxCargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxCargar.TabIndex = 60;
            this.PictureBoxCargar.TabStop = false;
            this.PictureBoxCargar.Click += new System.EventHandler(this.PictureBoxCargar_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.Location = new System.Drawing.Point(293, 144);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(461, 469);
            this.DataGridView1.TabIndex = 59;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Token";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(1174, 358);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 22);
            this.Label3.TabIndex = 58;
            this.Label3.Text = "Ctes Strings";
            // 
            // ListBoxStrings
            // 
            this.ListBoxStrings.FormattingEnabled = true;
            this.ListBoxStrings.ItemHeight = 16;
            this.ListBoxStrings.Location = new System.Drawing.Point(1112, 390);
            this.ListBoxStrings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxStrings.Name = "ListBoxStrings";
            this.ListBoxStrings.Size = new System.Drawing.Size(207, 196);
            this.ListBoxStrings.TabIndex = 57;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(956, 359);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 22);
            this.Label2.TabIndex = 56;
            this.Label2.Text = "Ctes Reales";
            // 
            // ListBoxReales
            // 
            this.ListBoxReales.FormattingEnabled = true;
            this.ListBoxReales.ItemHeight = 16;
            this.ListBoxReales.Location = new System.Drawing.Point(911, 389);
            this.ListBoxReales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxReales.Name = "ListBoxReales";
            this.ListBoxReales.Size = new System.Drawing.Size(168, 196);
            this.ListBoxReales.TabIndex = 55;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(1257, 110);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(94, 22);
            this.Label1.TabIndex = 54;
            this.Label1.Text = "Ctes Enteras";
            // 
            // ListBoxEnteras
            // 
            this.ListBoxEnteras.FormattingEnabled = true;
            this.ListBoxEnteras.ItemHeight = 16;
            this.ListBoxEnteras.Location = new System.Drawing.Point(1223, 145);
            this.ListBoxEnteras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxEnteras.Name = "ListBoxEnteras";
            this.ListBoxEnteras.Size = new System.Drawing.Size(168, 196);
            this.ListBoxEnteras.TabIndex = 53;
            // 
            // listBoxPR
            // 
            this.listBoxPR.FormattingEnabled = true;
            this.listBoxPR.ItemHeight = 16;
            this.listBoxPR.Location = new System.Drawing.Point(827, 145);
            this.listBoxPR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPR.Name = "listBoxPR";
            this.listBoxPR.Size = new System.Drawing.Size(175, 196);
            this.listBoxPR.TabIndex = 52;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(557, 32);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(270, 36);
            this.Label5.TabIndex = 51;
            this.Label5.Text = "C O M P I L A D O R E S";
            // 
            // txtidentificadores
            // 
            this.txtidentificadores.AutoSize = true;
            this.txtidentificadores.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentificadores.Location = new System.Drawing.Point(1054, 110);
            this.txtidentificadores.Name = "txtidentificadores";
            this.txtidentificadores.Size = new System.Drawing.Size(110, 22);
            this.txtidentificadores.TabIndex = 50;
            this.txtidentificadores.Text = "Identificadores";
            // 
            // txtpalabrasr
            // 
            this.txtpalabrasr.AutoSize = true;
            this.txtpalabrasr.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpalabrasr.Location = new System.Drawing.Point(843, 110);
            this.txtpalabrasr.Name = "txtpalabrasr";
            this.txtpalabrasr.Size = new System.Drawing.Size(146, 22);
            this.txtpalabrasr.TabIndex = 49;
            this.txtpalabrasr.Text = "Palabras reservadas";
            // 
            // txtarchivos
            // 
            this.txtarchivos.AutoSize = true;
            this.txtarchivos.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarchivos.Location = new System.Drawing.Point(489, 110);
            this.txtarchivos.Name = "txtarchivos";
            this.txtarchivos.Size = new System.Drawing.Size(123, 22);
            this.txtarchivos.TabIndex = 48;
            this.txtarchivos.Text = "Archivo de salida";
            // 
            // listBoxIds
            // 
            this.listBoxIds.FormattingEnabled = true;
            this.listBoxIds.ItemHeight = 16;
            this.listBoxIds.Location = new System.Drawing.Point(1027, 145);
            this.listBoxIds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxIds.Name = "listBoxIds";
            this.listBoxIds.Size = new System.Drawing.Size(168, 196);
            this.listBoxIds.TabIndex = 47;
            // 
            // txtarchivoe
            // 
            this.txtarchivoe.AutoSize = true;
            this.txtarchivoe.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarchivoe.Location = new System.Drawing.Point(89, 110);
            this.txtarchivoe.Name = "txtarchivoe";
            this.txtarchivoe.Size = new System.Drawing.Size(136, 22);
            this.txtarchivoe.TabIndex = 64;
            this.txtarchivoe.Text = "Archivo de entrada";
            // 
            // listBoxEntrada
            // 
            this.listBoxEntrada.FormattingEnabled = true;
            this.listBoxEntrada.ItemHeight = 16;
            this.listBoxEntrada.Location = new System.Drawing.Point(25, 145);
            this.listBoxEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEntrada.Name = "listBoxEntrada";
            this.listBoxEntrada.Size = new System.Drawing.Size(263, 468);
            this.listBoxEntrada.TabIndex = 63;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelCompilador
            // 
            this.panelCompilador.BackColor = System.Drawing.Color.White;
            this.panelCompilador.Controls.Add(this.pictureBoxLog);
            this.panelCompilador.Controls.Add(this.label10);
            this.panelCompilador.Controls.Add(this.buttonLogout);
            this.panelCompilador.Controls.Add(this.DataGridView1);
            this.panelCompilador.Controls.Add(this.txtarchivoe);
            this.panelCompilador.Controls.Add(this.listBoxIds);
            this.panelCompilador.Controls.Add(this.listBoxEntrada);
            this.panelCompilador.Controls.Add(this.txtarchivos);
            this.panelCompilador.Controls.Add(this.txtpalabrasr);
            this.panelCompilador.Controls.Add(this.PictureBoxCompilar);
            this.panelCompilador.Controls.Add(this.txtidentificadores);
            this.panelCompilador.Controls.Add(this.PictureBoxCargar);
            this.panelCompilador.Controls.Add(this.Label5);
            this.panelCompilador.Controls.Add(this.listBoxPR);
            this.panelCompilador.Controls.Add(this.Label3);
            this.panelCompilador.Controls.Add(this.ListBoxEnteras);
            this.panelCompilador.Controls.Add(this.ListBoxStrings);
            this.panelCompilador.Controls.Add(this.Label1);
            this.panelCompilador.Controls.Add(this.Label2);
            this.panelCompilador.Controls.Add(this.ListBoxReales);
            this.panelCompilador.Location = new System.Drawing.Point(-3, 13);
            this.panelCompilador.Margin = new System.Windows.Forms.Padding(4);
            this.panelCompilador.Name = "panelCompilador";
            this.panelCompilador.Size = new System.Drawing.Size(1412, 620);
            this.panelCompilador.TabIndex = 65;
            this.panelCompilador.Visible = false;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.Window;
            this.panelLogin.Controls.Add(this.panel1);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.buttonRegistrarse);
            this.panelLogin.Controls.Add(this.comboBoxLenguaje);
            this.panelLogin.Controls.Add(this.textContraseña);
            this.panelLogin.Controls.Add(this.textUsuario);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.label8);
            this.panelLogin.Controls.Add(this.label7);
            this.panelLogin.Controls.Add(this.label6);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Location = new System.Drawing.Point(383, 1);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(544, 502);
            this.panelLogin.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 43);
            this.panel1.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 67);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.Color.Black;
            this.buttonRegistrarse.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.White;
            this.buttonRegistrarse.Location = new System.Drawing.Point(287, 390);
            this.buttonRegistrarse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(164, 50);
            this.buttonRegistrarse.TabIndex = 61;
            this.buttonRegistrarse.Text = "Crear cuenta nueva";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // comboBoxLenguaje
            // 
            this.comboBoxLenguaje.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLenguaje.FormattingEnabled = true;
            this.comboBoxLenguaje.Location = new System.Drawing.Point(185, 314);
            this.comboBoxLenguaje.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLenguaje.Name = "comboBoxLenguaje";
            this.comboBoxLenguaje.Size = new System.Drawing.Size(195, 24);
            this.comboBoxLenguaje.TabIndex = 59;
            // 
            // textContraseña
            // 
            this.textContraseña.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseña.Location = new System.Drawing.Point(185, 241);
            this.textContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(195, 26);
            this.textContraseña.TabIndex = 58;
            this.textContraseña.UseSystemPasswordChar = true;
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.Location = new System.Drawing.Point(185, 164);
            this.textUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(195, 26);
            this.textUsuario.TabIndex = 57;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Black;
            this.buttonLogin.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(137, 390);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(142, 50);
            this.buttonLogin.TabIndex = 56;
            this.buttonLogin.Text = "Iniciar sesion";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 55;
            this.label8.Text = "Lenguaje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 54;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 53;
            this.label6.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "I n i c i a r  S e s i o n";
            // 
            // pictureBoxLog
            // 
            this.pictureBoxLog.BackColor = System.Drawing.Color.White;
            this.pictureBoxLog.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLog.Image")));
            this.pictureBoxLog.Location = new System.Drawing.Point(1078, 15);
            this.pictureBoxLog.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLog.Name = "pictureBoxLog";
            this.pictureBoxLog.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLog.TabIndex = 67;
            this.pictureBoxLog.TabStop = false;
            this.pictureBoxLog.Click += new System.EventHandler(this.pictureBoxLog_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 23);
            this.label10.TabIndex = 66;
            this.label10.Text = "Usuario";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Black;
            this.buttonLogout.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(1213, 15);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(142, 50);
            this.buttonLogout.TabIndex = 65;
            this.buttonLogout.Text = "Cerrar Sesion";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1404, 632);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelCompilador);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCompilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panelCompilador.ResumeLayout(false);
            this.panelCompilador.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.PictureBox PictureBoxCompilar;
        internal System.Windows.Forms.PictureBox PictureBoxCargar;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ListBox ListBoxStrings;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ListBox ListBoxReales;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ListBox ListBoxEnteras;
        internal System.Windows.Forms.ListBox listBoxPR;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label txtidentificadores;
        private System.Windows.Forms.Label txtpalabrasr;
        private System.Windows.Forms.Label txtarchivos;
        private System.Windows.Forms.ListBox listBoxIds;
        private System.Windows.Forms.Label txtarchivoe;
        private System.Windows.Forms.ListBox listBoxEntrada;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelCompilador;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.ComboBox comboBoxLenguaje;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Button buttonLogin;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLogout;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.PictureBox pictureBoxLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

