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
    class ControladorCompra
    {
        public static List<compra> CargarDatosCompras()
        {
            List<compra> losCompras = new List<compra>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-ONQQ9QD;Database=supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT idCompra,idProducto,idProovedor,cantidadCompra,valorCompra,fechaCompra FROM  compra"
;

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader 
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idCompra = reader.GetInt32(0);
                    int idProducto = reader.GetInt32(1);
                    int idProovedor = reader.GetInt32(2);
                    int cantidadCompra = reader.GetInt32(3);
                    int valorCompra = reader.GetInt32(4);
                      DateTime fechaCompra = reader.GetDateTime(5);





                    compra agregar = new compra
                    {
                        idCompra = idCompra,
                        idProducto = idProducto,
                        idProovedor = idProovedor,
                        cantidadCompra = cantidadCompra,
                        valorCompra =valorCompra,
                        fechaCompra = fechaCompra,




                    };
                    losCompras.Add(agregar);
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
            return losCompras;
        }

    }
}
