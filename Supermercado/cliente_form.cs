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
    public partial class cliente_form : Form
    {
        public cliente_form()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ExisteRegistro(cedc_text.Text))
            {
                MessageBox.Show("Ya fue creado este cliente");
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
                string sql = @"INSERT INTO cliente (nombreCliente,apellidoCliente,cedulaCliente,direccionCliente,telefonoCliente)
                                VALUES(@nombreCliente,@apellidoCliente,@cedulaCliente,@direccionCliente,@telefonoCliente)";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@nombreCliente", nomc_text.Text);
                comando.Parameters.AddWithValue("@apellidoCliente", apec_text.Text);
                comando.Parameters.AddWithValue("@cedulaCliente", cedc_text.Text);
                comando.Parameters.AddWithValue("@direccionCliente", dirc_text.Text);
                comando.Parameters.AddWithValue("@telefonoCliente", telc_text.Text);



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
        public bool ExisteRegistro(string cedulaCliente)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-ONQQ9QD;Database=supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT cedulaCliente FROM cliente WHERE cedulaCliente=@cedulaCliente";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@cedulaCliente", cedulaCliente);

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

        private void telc_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
