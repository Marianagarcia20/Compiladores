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

namespace ProyectoFinalSistemasP
{
    public partial class Log : Form
    {
        private Consultas consultar;

        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            consultar = new Consultas();
            noFiltros();
            comboBoxLenguaje.DataSource = consultar.llenarCombo("Lenguajes", "nombre");
            comboBoxLenguaje.SelectedIndex = 0;
            comboBoxUsuario.DataSource = consultar.llenarCombo("Usuarios", "nombres");
            comboBoxUsuario.SelectedIndex = 0;
        }

        private void noFiltros()
        {
            if(!checkBoxFecha.Checked && !checkBoxUsuario.Checked && !checkBoxLenguaje.Checked)
            {
                dataGridView1.DataSource = consultar.query("select U.nombres as Nombre,L.nombre as Lenguaje_Compilado,fecha as Fecha,archivo as Archivo_de_Salida from Log,Usuarios as U,Lenguajes as L where Log.id_usuario = U.id_usuario and L.id_lenguaje = log.id_lenguaje");
            }
        }

        private void checkBoxUsuario_CheckedChanged(object sender, EventArgs e)
        {
            noFiltros();
        }

        private void checkBoxLenguaje_CheckedChanged(object sender, EventArgs e)
        {
            noFiltros();
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            noFiltros();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = consultar.getFiltro(checkBoxUsuario.Checked,checkBoxLenguaje.Checked,checkBoxFecha.Checked,comboBoxUsuario.Text,comboBoxLenguaje.Text,dateTimePickerInicio.Value,dateTimePickerFinal.Value);
        }

        private void buttonTxt_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog exportar = new SaveFileDialog();
                exportar.DefaultExt = "txt";
                exportar.Filter = "Text Files (*.txt)|*.txt";
                exportar.ShowDialog();
                StreamWriter sw = new StreamWriter(exportar.FileName);
                foreach (DataGridViewRow linea in dataGridView1.Rows)
                {
                    sw.WriteLine(linea.Cells[0].Value + " " + linea.Cells[1].Value + " " + linea.Cells[2].Value + " " + linea.Cells[3].Value);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo exportar");
            }
        }

        private void buttonCsv_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog exportar = new SaveFileDialog();
                exportar.DefaultExt = "csv";
                exportar.Filter = "CSV Files (*.csv)|*.csv";
                exportar.ShowDialog();
                StreamWriter sw = new StreamWriter(exportar.FileName);
                foreach (DataGridViewRow linea in dataGridView1.Rows)
                {
                    sw.WriteLine(linea.Cells[0].Value + "," + linea.Cells[1].Value + "," + linea.Cells[2].Value + "," + linea.Cells[3].Value);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo exportar");
            }
        }

        private void buttonXlsx_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog exportar = new SaveFileDialog();
                exportar.Filter = "Excel (*.xls)|*.xls";
                if (exportar.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    libros_trabajo.SaveAs(exportar.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo exportar");
            }
        }


    }
}
