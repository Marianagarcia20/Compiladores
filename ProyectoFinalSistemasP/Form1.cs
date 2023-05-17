using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace ProyectoFinalSistemasP
{

    public partial class Form1 : Form
    {
        static int estado;
        static int columna;
        int[,] matriz = new int[estado, columna];
        string wlinea;
        dynamic encontro, token, espalabrareservada, direccion, posicion;
        char caracter;
        Consultas consultar;
        int idusuario;

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBoxCargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var archivo = openFileDialog1.FileName;
            System.IO.StreamReader fileReader;
  
            fileReader = new StreamReader(archivo);

            while (!(fileReader.EndOfStream))
            {
                wlinea = fileReader.ReadLine();
                listBoxEntrada.Items.Add(wlinea); 
            }
        }

        private void PictureBoxCompilar_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            var Renglon = 0;

            while ((Renglon < listBoxEntrada.Items.Count)) 
            {
                listBoxEntrada.SelectedIndex = Renglon; 
                wlinea = listBoxEntrada.Text; 
                BuscaTokens();
                Renglon = Renglon + 1;
            }

            DateTime FechaActual = DateTime.Now;
            string fecha = FechaActual.ToString();
            string dia = fecha.Substring(0, 2);
            string mes = fecha.Substring(3, 2);
            string año = fecha.Substring(6, 4);
            string hra = fecha.Substring(11, 2);
            string min = fecha.Substring(14, 2);
            string seg = fecha.Substring(17, 2);
            string output = "output" + comboBoxLenguaje.Text + textUsuario.Text + dia + "_" + mes + "_" + año + "_" + hra + "_" + min + "_" + seg+".txt";

            StreamWriter stream = new StreamWriter("output/"+output);
            foreach(DataGridViewRow row in DataGridView1.Rows)
            {
                string token = "";
                string tipo = "";
                string direccion = "";
                if (row.Cells[0].Value != null)
                {
                    token = row.Cells[0].Value.ToString();
                }
                if (row.Cells[1].Value != null)
                {
                    tipo = row.Cells[1].Value.ToString();
                }
                if (row.Cells[2].Value != null)
                {
                    direccion = row.Cells[2].Value.ToString();
                } 
                    
                stream.WriteLine(token+" "+tipo+" "+direccion);
            }
            stream.Close();
            consultar.insertarLog(FechaActual, output, idusuario, comboBoxLenguaje.SelectedIndex + 1);
        }

        private void BuscaReservadas()
        {
            var Renglon1 = 0;
            encontro = false; 
                              
            while ((!(encontro)) & (Renglon1 < listBoxPR.Items.Count)) 
            {
                listBoxPR.SelectedIndex = Renglon1;  

                if ((token.Equals(listBoxPR.Text,StringComparison.OrdinalIgnoreCase)))
                {
                    encontro = true;
                    direccion = Renglon1;
                    espalabrareservada = true;
                }
                direccion = Renglon1;
                Renglon1 = Renglon1 + 1;  
            }
        }

        private void BuscaIdentificadores()
        {
            var Renglon2 = 0;
            while ((!(encontro)) & (Renglon2 < listBoxIds.Items.Count)) 
            {
                listBoxIds.SelectedIndex = Renglon2; 
            
                if ((string.Equals(token, listBoxIds.Text, StringComparison.OrdinalIgnoreCase)))
                    encontro = true;
                direccion = Renglon2;
                Renglon2 = Renglon2 + 1; 
            }

            if ((!encontro))
            {
                listBoxIds.Items.Add(token);
                direccion = Renglon2;
            }
        }

        private void BuscaCEnteras()
        {
            var Renglon3 = 0;
            encontro = false;

            while ((!(encontro)) & (Renglon3 < ListBoxEnteras.Items.Count))
            {
                ListBoxEnteras.SelectedIndex = Renglon3;
                if ((token == ListBoxEnteras.Text))
                    encontro = true;
                direccion = Renglon3;
                Renglon3 = Renglon3 + 1;
            }

            if ((!encontro))
            {
                ListBoxEnteras.Items.Add(token);
                direccion = Renglon3;
            }
        }

        private void BuscaCReales()
        {
            var Renglon4 = 0;
            encontro = false;

            while ((!(encontro)) & (Renglon4 < ListBoxReales.Items.Count))
            {
                ListBoxReales.SelectedIndex = Renglon4;
                if ((token == ListBoxReales.Text))
                    encontro = true;
                direccion = Renglon4;
                Renglon4 = Renglon4 + 1;
            }

            if ((!encontro))
            {
                ListBoxReales.Items.Add(token);
                direccion = Renglon4;
            }
        }

        private void BuscaCStrings()
        {
            var Renglon5 = 0;
            encontro = false;

            while ((!(encontro)) & (Renglon5 < ListBoxStrings.Items.Count))
            {
                ListBoxStrings.SelectedIndex = Renglon5;
                if ((string.Equals(token, ListBoxStrings.Text, StringComparison.OrdinalIgnoreCase)))
                    encontro = true;
                direccion = Renglon5;
                Renglon5 = Renglon5 + 1;
            }

            if ((!encontro))
            {
                ListBoxStrings.Items.Add(token);
                direccion = Renglon5;
            }
        }

        private void BuscaTokens()
        {
            posicion = 1;
            token = "";
            estado = 0;
            var lugar = token.Length;
            
            while ((posicion <= (wlinea.Length)))
            {
                caracter = Convert.ToChar(Strings.Mid(wlinea, posicion, 1)); 
                CalculaColumna();
                estado = matriz[estado, columna];

                if ((estado >= 100))
                {
                    if (((token.Length) > 0))
                        ReconoceTokens();
                    if ((caracter != null) & ((token.Length) == 0))
                        ReconoceTokens();
                    estado = 0;
                    token = "";
                }
                else if ((estado != 0))
                    token = token + caracter;
                posicion = posicion + 1;
            }

            if (estado == 6 & lugar <= (token.Length))
            {
                if (caracter != Strings.Chr(34))
                    MessageBox.Show("Las constantes strings deben de terminar con comillas dobles");
            }

            if ((estado != 0))
            {
                caracter = ' ';
                CalculaColumna();
                estado = matriz[estado, columna];
                ReconoceTokens();
            }
        }

        private void CalculaColumna()
        {
            if (((int)caracter >= 65 & (int)caracter <= 90) | ((int)caracter >= 97 & (int)caracter <= 122))
                columna = 0;
            if (((int)caracter >= 48 ) & ((int)caracter <= 57))
                columna = 1;
            if ((caracter == '.'))
                columna = 2;
            if (((int)caracter == 34)) //comillas
                columna = 3;
            if ((caracter == '/'))
                columna = 4;
            if ((caracter == '*'))
                columna = 5;
            if ((caracter == '$'))
                columna = 6;
            if ((caracter == ','))
                columna = 7;
            if ((caracter == ';'))
                columna = 8;
            if ((caracter == '('))
                columna = 9;
            if ((caracter == ')'))
                columna = 10;
            if ((caracter == '{'))
                columna = 11;
            if ((caracter == '}'))
                columna = 12;
            if ((caracter == '+'))
                columna = 13;
            if ((caracter == '-'))
                columna = 14;
            if ((caracter == '='))
                columna = 15;
            if ((caracter == '<'))
                columna = 16;
            if ((caracter == '>'))
                columna = 17;
            if ((caracter == '_'))
                columna = 18;
            if (((int)caracter == 32)) //espacio
                columna = 19;
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            FormSignin signin = new FormSignin();
            signin.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                idusuario = consultar.existeUsuario(textUsuario.Text, textContraseña.Text);
                if (idusuario != -1)
                {
                    ListBoxEnteras.Items.Clear();
                    ListBoxReales.Items.Clear();
                    ListBoxStrings.Items.Clear();
                    listBoxEntrada.Items.Clear();
                    listBoxIds.Items.Clear();
                    listBoxPR.Items.Clear();
                    DataGridView1.Rows.Clear();
                    string ruta = "matrices/"+comboBoxLenguaje.Text+".txt";
                    StreamReader stream = new StreamReader(ruta);
                    int lineas = getI(new StreamReader(ruta));
                    int columnas = getJ(new StreamReader(ruta));
                    matriz = new int[lineas, columnas];
                    int i = 0;

                    while (!stream.EndOfStream)
                    {
                        string[] fila = stream.ReadLine().Split(',');
                        for (int j = 0; j < columnas; j++)
                        {
                            matriz[i, j] = Convert.ToInt32(fila[j]);
                        }
                        i++;
                    }
                    stream.Close();
                    stream = new StreamReader("palabrasReservadas/" + comboBoxLenguaje.Text + ".txt");

                    foreach (string palabra in stream.ReadLine().Split(','))
                    {
                        listBoxPR.Items.Add(palabra);
                    }
                    label10.Text = textUsuario.Text;
                    Label5.Text = "Compilador " + comboBoxLenguaje.Text;
                    panelCompilador.Visible = true;
                    panelLogin.Visible = false;
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            panelCompilador.Visible = false;
            panelLogin.Visible = true;
        }

        private void pictureBoxLog_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            log.Show();
        }


        private void ReconoceTokens()
        {
            if ((estado == 100))
            {
                espalabrareservada = false;
                BuscaReservadas();
                if (espalabrareservada)
                    DataGridView1.Rows.Add(token, "PR", direccion);
                else
                {
                    BuscaIdentificadores();
                    DataGridView1.Rows.Add(token, "ID", direccion);
                }
                posicion = posicion - 1; // estado aceptor con regresión
            }

            if ((estado == 101))
            {
                BuscaCEnteras();
                DataGridView1.Rows.Add(token, "Constante entera", direccion);
                posicion = posicion - 1; // estado aceptor con regresión
            }

            if ((estado == 102))
            {
                BuscaCReales();
                DataGridView1.Rows.Add(token, "Constante real", direccion);
                posicion = posicion - 1; // estado aceptor con regresión
            }

            if ((estado == 103))
            {
                token = token + caracter;
                BuscaCStrings();
                DataGridView1.Rows.Add(token, "Constante string", direccion);
            }

            if ((estado == 104))
            {
                DataGridView1.Rows.Add(token, "Caracter especial");
                posicion = posicion - 1; // estado aceptor con regresión
            }

            if ((estado == 105))
            {
                token = token + caracter;
                DataGridView1.Rows.Add(token, "Comentario");
            }

            if ((estado == 106))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            if ((estado == 107))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            if ((estado == 108))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            if ((estado == 109))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            if ((estado == 110))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            if ((estado == 111))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            if ((estado == 112))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            if ((estado == 113))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            if ((estado == 114))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            if ((estado == 115))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            if ((estado == 116))
            {
                token = token + caracter;
                DataGridView1.Rows.Add(token, "Caracter especial");
            }

            if ((estado == 117))
            {
                DataGridView1.Rows.Add(token, "Caracter especial");
                posicion = posicion - 1; // estado aceptor con regresión
            }

            if ((estado == 118))
            {
                token = token + caracter;
                DataGridView1.Rows.Add(token, "Caracter especial");
            }

            if ((estado == 119))
            {
                token = token + caracter;
                DataGridView1.Rows.Add(token, "Caracter especial");
            }

            if ((estado == 120))
            {
                DataGridView1.Rows.Add(token, "Caracter especial");
                posicion = posicion - 1; // estado aceptor con regresión
            }

            if ((estado == 121))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            if ((estado == 122))
                DataGridView1.Rows.Add(caracter, "Caracter especial");

            
            if ((estado == 301))
                MessageBox.Show("Error. El nombre del identificador no es válido. Se esperaba letra o dígito");

            if ((estado == 302))
                MessageBox.Show("Error. se esperaba un dígito después del punto");

            if ((estado == 303))
                MessageBox.Show("Error. Los comentarios deben terminar con */");
        }

        private int getI(StreamReader stream)
        {
            int i = 0;
            while (!stream.EndOfStream)
            {
                stream.ReadLine();
                i++;
            }
            stream.Close();
            return i;
        }

        private int getJ(StreamReader stream)
        {
            int n = stream.ReadLine().Split(',').Length;
            stream.Close();
            return n;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            consultar = new Consultas();
            comboBoxLenguaje.DataSource = consultar.llenarCombo("Lenguajes","nombre");
            comboBoxLenguaje.SelectedIndex = 0;
        }
    }
}

