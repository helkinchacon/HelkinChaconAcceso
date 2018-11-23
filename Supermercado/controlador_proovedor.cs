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
    class controlador_proovedor
    {
        public static List<proovedor> CargarDatosProovedores()
        {
            List<proovedor> losProovedores = new List<proovedor>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-ONQQ9QD;Database=supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT idProovedor,nombreProovedor,direccionProovedor,nitProovedor,telefonoProovedor FROM  proovedor";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader 
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idProovedor = reader.GetInt32(0);
                    string nombreProovedor = reader.GetString(1);
                    string direccionProovedor = reader.GetString(2);
                    string nitProovedor = reader.GetString(3);
                    string telefonoProovedor = reader.GetString(4);



                    proovedor agregar = new proovedor
                    {
                       idProovedor = idProovedor,
                       nombreProovedor = nombreProovedor,
                       direccionProovedor = direccionProovedor,
                       nitProovedor = nitProovedor,
                       telefonoProovedor = telefonoProovedor,


                    };
                    losProovedores.Add(agregar);
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
            return losProovedores;
        }
    }
}
