using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Supermercado
{
    class controladorCliente
    {
        public static List<cliente> CargarDatosClientes()
        {
            List<cliente> losClientes = new List<cliente>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-ONQQ9QD;Database=supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT idCliente,nombreCliente,apellidoCliente,cedulaCliente,direccionCliente,telefonoCliente FROM  cliente";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader 
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idCliente = reader.GetInt32(0);
                    string nombreCliente = reader.GetString(1);
                    string apellidoCliente = reader.GetString(2);
                    string cedulaCliente = reader.GetString(3);
                    string direccionCliente = reader.GetString(4);
                    string telefonoCliente = reader.GetString(5);





                    cliente agregar = new cliente
                    {
                        idCliente = idCliente,
                        nombreCliente = nombreCliente,
                        apellidoCliente = apellidoCliente,
                        cedulaCliente = cedulaCliente,
                        direccionCliente = direccionCliente,
                        telefonoCliente = telefonoCliente,
                     


                    };
                    losClientes.Add(agregar);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"emos encontrado un error ({ex.Message})");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return losClientes;
        }
    }
}
