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
    class Controladorventa
    {
        public static List<venta> CargarDatosVentas()
        {
            List<venta> losVentas = new List<venta>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-ONQQ9QD;Database=supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT idVenta,idProducto,idCliente,idVendedor,valorVenta,cantidadVenta,fechaVenta FROM  venta";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader 
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idVenta = reader.GetInt32(0);
                    int idProducto = reader.GetInt32(1);
                    int idCliente = reader.GetInt32(2);
                    int idVendedor = reader.GetInt32(3);
                    int valorVenta = reader.GetInt32(4);
                    int cantidadVenta = reader.GetInt32(5);
                    DateTime fechaventa = reader.GetDateTime(6);



                    venta agregar = new venta
                    {
                        idVenta = idVenta,
                        idProducto = idProducto,
                        idCliente = idCliente,
                        idVendedor = idVendedor,
                        valorVenta = valorVenta, 
                        cantidadVenta = cantidadVenta,
                        FechaVenta = fechaventa,


                    };
                    losVentas.Add(agregar);
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
            return losVentas;
        }

    }
}
