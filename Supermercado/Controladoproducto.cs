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
    public class Controladoproducto
    {
        public static List<producto> CargarDatosProductos()
        {
            List<producto> losProductos = new List<producto>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-ONQQ9QD;Database=supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT idProducto,nombreProducto,valorProducto,cantidadProducto FROM  producto";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader 
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idProducto = reader.GetInt32(0);
                    string nombreProducto = reader.GetString(1);
                    int valorProducto = reader.GetInt32(2);
                  //  int cantidadProducto = reader.GetInt32(3);
                   


                    producto agregar = new producto
                    {
                        idProducto = idProducto,
                        nombreProducto = nombreProducto,
                        valorProducto = valorProducto,
                    //    cantidadProducto = cantidadProducto,
                       

                    };
                    losProductos.Add(agregar);
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
            return losProductos;
        }
    }
}
