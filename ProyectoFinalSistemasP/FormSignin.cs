using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalSistemasP
{
    public partial class FormSignin : Form
    {
        public FormSignin()
        {
            InitializeComponent();
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            Consultas signin = new Consultas();
            try
            {
                signin.registrarUsuario(textUsuario.Text,textBoxCorreo.Text,textBoxTelefono.Text,textContraseña.Text);
                Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
