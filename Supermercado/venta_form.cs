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
    public partial class venta_form : Form
    {
        public venta_form()
        {
            InitializeComponent();
        }

        private void venta_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
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
                string sql = @"INSERT INTO venta (idProducto,idVendedor,idCliente,cantidadVenta,valorVenta,fechaVenta)
                                VALUES(@idProducto,@idVendedor,@idCliente,@cantidadVenta,@valorVenta,@fechaVenta)";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@idProducto", idpdvn_txt.Text);
                comando.Parameters.AddWithValue("@idVendedor", idvevn_txt.Text);
                comando.Parameters.AddWithValue("@idCliente", idclivn_txt.Text);
                comando.Parameters.AddWithValue("@cantidadVenta", cantvn_txt.Text);
                comando.Parameters.AddWithValue("@valorVenta", valvn_txt.Text);
                comando.Parameters.AddWithValue("@fechaVenta", fecvn_txt.Text);




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
       
    }
}
