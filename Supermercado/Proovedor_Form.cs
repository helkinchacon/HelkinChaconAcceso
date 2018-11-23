using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Supermercado
{
    public partial class Proovedor_Form : Form
    {
        public Proovedor_Form()
        {
            InitializeComponent();
        }

        private void Proovedor_Form_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExisteRegistro(nitp_txt.Text))
            {
                MessageBox.Show("Ya fue creado este proovedor");
                return;
            }
            //ADO.NET
            //Activex Data Object

            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-ONQQ9QD;Database=supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"INSERT INTO proovedor (nombreProovedor,direccionProovedor,nitProovedor,telefonoProovedor)
                                VALUES(@nombreProovedor,@direccionProovedor,@nitProovedor,@telefonoProovedor)";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@nombreProovedor", nomp_txt.Text);
                comando.Parameters.AddWithValue("@direccionProovedor", dirp_txt.Text);
                comando.Parameters.AddWithValue("@nitProovedor", nitp_txt.Text);
                comando.Parameters.AddWithValue("@telefonoProovedor", telp_txt.Text);



                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("El registro se insertó");
                }
                else
                {
                    MessageBox.Show("Encontramos un error :(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hemos encontrado un error  ({ex.Message})");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }
        public bool ExisteRegistro(string nitProovedor)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-ONQQ9QD;Database=supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT nitProovedor FROM proovedor WHERE nitProovedor=@nitProovedor";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@nitProovedor", nitProovedor);

                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                object data = comando.ExecuteScalar();

                return data != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hemos encontrado un error ({ex.Message})");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return false;
        }
    }
}
