namespace ProyectoFinalSistemasP
{
    partial class Log
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
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            this.checkBoxLenguaje = new System.Windows.Forms.CheckBox();
            this.checkBoxUsuario = new System.Windows.Forms.CheckBox();
            this.buttonXlsx = new System.Windows.Forms.Button();
            this.buttonCsv = new System.Windows.Forms.Button();
            this.buttonTxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.comboBoxLenguaje = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.Black;
            this.buttonFiltrar.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.ForeColor = System.Drawing.Color.White;
            this.buttonFiltrar.Location = new System.Drawing.Point(857, 478);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(100, 44);
            this.buttonFiltrar.TabIndex = 29;
            this.buttonFiltrar.Text = "F i l t r a r";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(854, 390);
            this.dateTimePickerFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(160, 26);
            this.dateTimePickerFinal.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(912, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "hasta";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(854, 335);
            this.dateTimePickerInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(160, 26);
            this.dateTimePickerInicio.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(838, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "F i l t r a r";
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFecha.Location = new System.Drawing.Point(768, 361);
            this.checkBoxFecha.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(67, 20);
            this.checkBoxFecha.TabIndex = 22;
            this.checkBoxFecha.Text = "Fecha:";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            this.checkBoxFecha.CheckedChanged += new System.EventHandler(this.checkBoxFecha_CheckedChanged);
            // 
            // checkBoxLenguaje
            // 
            this.checkBoxLenguaje.AutoSize = true;
            this.checkBoxLenguaje.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLenguaje.Location = new System.Drawing.Point(766, 271);
            this.checkBoxLenguaje.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLenguaje.Name = "checkBoxLenguaje";
            this.checkBoxLenguaje.Size = new System.Drawing.Size(86, 20);
            this.checkBoxLenguaje.TabIndex = 21;
            this.checkBoxLenguaje.Text = "Lenguaje:";
            this.checkBoxLenguaje.UseVisualStyleBackColor = true;
            this.checkBoxLenguaje.CheckedChanged += new System.EventHandler(this.checkBoxLenguaje_CheckedChanged);
            // 
            // checkBoxUsuario
            // 
            this.checkBoxUsuario.AutoSize = true;
            this.checkBoxUsuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUsuario.Location = new System.Drawing.Point(766, 225);
            this.checkBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxUsuario.Name = "checkBoxUsuario";
            this.checkBoxUsuario.Size = new System.Drawing.Size(77, 20);
            this.checkBoxUsuario.TabIndex = 20;
            this.checkBoxUsuario.Text = "Usuario:";
            this.checkBoxUsuario.UseVisualStyleBackColor = true;
            this.checkBoxUsuario.CheckedChanged += new System.EventHandler(this.checkBoxUsuario_CheckedChanged);
            // 
            // buttonXlsx
            // 
            this.buttonXlsx.BackColor = System.Drawing.Color.Black;
            this.buttonXlsx.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXlsx.ForeColor = System.Drawing.Color.White;
            this.buttonXlsx.Location = new System.Drawing.Point(249, 97);
            this.buttonXlsx.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXlsx.Name = "buttonXlsx";
            this.buttonXlsx.Size = new System.Drawing.Size(100, 43);
            this.buttonXlsx.TabIndex = 19;
            this.buttonXlsx.Text = "XLSX";
            this.buttonXlsx.UseVisualStyleBackColor = false;
            this.buttonXlsx.Click += new System.EventHandler(this.buttonXlsx_Click);
            // 
            // buttonCsv
            // 
            this.buttonCsv.BackColor = System.Drawing.Color.Black;
            this.buttonCsv.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCsv.ForeColor = System.Drawing.Color.White;
            this.buttonCsv.Location = new System.Drawing.Point(141, 97);
            this.buttonCsv.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCsv.Name = "buttonCsv";
            this.buttonCsv.Size = new System.Drawing.Size(100, 43);
            this.buttonCsv.TabIndex = 18;
            this.buttonCsv.Text = "CSV";
            this.buttonCsv.UseVisualStyleBackColor = false;
            this.buttonCsv.Click += new System.EventHandler(this.buttonCsv_Click);
            // 
            // buttonTxt
            // 
            this.buttonTxt.BackColor = System.Drawing.Color.Black;
            this.buttonTxt.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTxt.ForeColor = System.Drawing.Color.White;
            this.buttonTxt.Location = new System.Drawing.Point(33, 97);
            this.buttonTxt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTxt.Name = "buttonTxt";
            this.buttonTxt.Size = new System.Drawing.Size(100, 43);
            this.buttonTxt.TabIndex = 17;
            this.buttonTxt.Text = "TXT";
            this.buttonTxt.UseVisualStyleBackColor = false;
            this.buttonTxt.Click += new System.EventHandler(this.buttonTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "E x p o r t a r";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 362);
            this.dataGridView1.TabIndex = 15;
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(857, 221);
            this.comboBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(160, 24);
            this.comboBoxUsuario.TabIndex = 30;
            
            // 
            // comboBoxLenguaje
            // 
            this.comboBoxLenguaje.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLenguaje.FormattingEnabled = true;
            this.comboBoxLenguaje.Location = new System.Drawing.Point(857, 266);
            this.comboBoxLenguaje.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLenguaje.Name = "comboBoxLenguaje";
            this.comboBoxLenguaje.Size = new System.Drawing.Size(160, 24);
            this.comboBoxLenguaje.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 45);
            this.panel1.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(909, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "desde";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxLenguaje);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxFecha);
            this.Controls.Add(this.checkBoxLenguaje);
            this.Controls.Add(this.checkBoxUsuario);
            this.Controls.Add(this.buttonXlsx);
            this.Controls.Add(this.buttonCsv);
            this.Controls.Add(this.buttonTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Log";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxFecha;
        private System.Windows.Forms.CheckBox checkBoxLenguaje;
        private System.Windows.Forms.CheckBox checkBoxUsuario;
        private System.Windows.Forms.Button buttonXlsx;
        private System.Windows.Forms.Button buttonCsv;
        private System.Windows.Forms.Button buttonTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.ComboBox comboBoxLenguaje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}