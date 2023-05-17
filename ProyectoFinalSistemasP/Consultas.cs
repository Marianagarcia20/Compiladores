using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ProyectoFinalSistemasP
{
    class Consultas
    {
        private string basedatos, servidor;
        private SqlConnection sqlCone;

        public Consultas()
        {
            StreamReader stream = new StreamReader("configuracion.txt");
            servidor = stream.ReadLine();
            basedatos = stream.ReadLine();
            stream.Close();
            string cadena = "Server=" + servidor + ";Database=" + basedatos + ";Trusted_Connection=True;";
            sqlCone = new SqlConnection(cadena);
        }

        public DataTable query(string query)
        {
            sqlCone.Open();
            SqlCommand comand = new SqlCommand(query,sqlCone);
            SqlDataReader data = comand.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(data);
            comand.Dispose();
            data.Close();
            sqlCone.Close();
            return table;
        }

        public void registrarUsuario(string nombres, string correo, string telefono, string contraseña)
        {
            if (query("select * from Usuarios where nombres = '"+nombres+"'").Rows.Count != 0)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre");
            }
            else
            {
                sqlCone.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCone;
                cmd.CommandText = "insert into Usuarios(nombres,correo,contraseña,telefono) values(@n,@c,@con,@t)";
                cmd.Parameters.AddWithValue("@n", nombres);
                cmd.Parameters.AddWithValue("@c", correo);
                cmd.Parameters.AddWithValue("@t", telefono);
                cmd.Parameters.AddWithValue("@con", encriptar(contraseña));
                cmd.ExecuteReader();
                sqlCone.Close();
                cmd.Dispose();
                MessageBox.Show("Registro exitoso");
            }
        }

        public int existeUsuario(string nombres,string contraseña)
        {
            int id = -1;
            sqlCone.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCone;
            cmd.CommandText = "select id_usuario from Usuarios where nombres = @n and contraseña = @c";
            cmd.Parameters.AddWithValue("@n", nombres);
            cmd.Parameters.AddWithValue("@c", encriptar(contraseña));
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(reader);
            if (tabla.Rows.Count != 0)
            {
                id = Convert.ToInt32(tabla.Rows[0]["id_usuario"]);
            }
            sqlCone.Close();
            cmd.Dispose();
            reader.Close();
            return id;
        }

        public string[] llenarCombo(string tabla,string atributo)
        {
            DataTable data = query("select "+atributo+" from "+tabla);
            string[] llenar = new string[data.Rows.Count]; 
            for(int i = 0; i<data.Rows.Count;i++)
            {
                llenar[i] = (data.Rows[i][atributo].ToString());
            }

            return llenar;
            
        }

        public void insertarLog(DateTime fecha,string archivo,int id_usuario, int id_lenguaje)
        {
            sqlCone.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCone;
            cmd.CommandText = "insert into Log(fecha,archivo,id_usuario,id_lenguaje) values(@f,@a,@u,@l)";
            cmd.Parameters.AddWithValue("@f", fecha);
            cmd.Parameters.AddWithValue("@a", archivo);
            cmd.Parameters.AddWithValue("@u", id_usuario);
            cmd.Parameters.AddWithValue("@l", id_lenguaje);
            cmd.ExecuteReader();
            sqlCone.Close();
            cmd.Dispose();
        }

        public DataTable getFiltro(bool usuario, bool lenguaje, bool fecha, string tUsuario, string tLenguaje, DateTime inicio, DateTime final)
        {
            sqlCone.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCone;
            cmd.CommandText = "select U.nombres as Nombre,L.nombre as Lenguaje_Compilado,fecha as Fecha,archivo as Archivo_de_Salida from Log,Usuarios as U,Lenguajes as L where Log.id_usuario = U.id_usuario and L.id_lenguaje = log.id_lenguaje";

            if (usuario)
            {
                cmd.CommandText += " and U.nombres = @u";
                cmd.Parameters.AddWithValue("@u", tUsuario);
            }
            if (lenguaje)
            {
                cmd.CommandText += " and L.nombre = @l";
                cmd.Parameters.AddWithValue("@l", tLenguaje);
            }
            if (fecha)
            {
                cmd.CommandText += " and fecha between @fi and @ff";
                cmd.Parameters.AddWithValue("@fi", inicio);
                cmd.Parameters.AddWithValue("@ff", final);
            }
            DataTable resultados = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            resultados.Load(reader);
            cmd.Dispose();
            reader.Close();
            sqlCone.Close();
            return resultados;
        }

        private string encriptar(string texto)
        {
            string textToEncrypt = texto;
            string ToReturn = "";
            string publickey = "12345678";
            string secretkey = "87654321";
            byte[] secretkeyByte = { };
            secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
            byte[] publickeybyte = { };
            publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
            MemoryStream ms = null;
            CryptoStream cs = null;
            byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                ms = new MemoryStream();
                cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                cs.FlushFinalBlock();
                ToReturn = Convert.ToBase64String(ms.ToArray());
            }
            return ToReturn;
        }
    }
}
