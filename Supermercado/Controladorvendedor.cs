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
    class Controladorvendedor
    {
        public static List<vendedor> CargarDatosVendedores()
        {
            List<vendedor> losVendedores = new List<vendedor>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-ONQQ9QD;Database=supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT idVendedor,nombreVendedor,apellidoVendedor,cedulaVendedor FROM  vendedor";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader 
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idVendedor = reader.GetInt32(0);
                    string nombreVendedor = reader.GetString(1);
                    string apellidoVendedor = reader.GetString(2);
                    string cedulaVendedor = reader.GetString(3);
                




                    vendedor agregar = new vendedor
                    {
                        idVendedor = idVendedor,
                        nombreVendedor = nombreVendedor,
                        apellidoVendedor = apellidoVendedor,
                        cedulaVendedor = cedulaVendedor,
                      



                    };
                    losVendedores.Add(agregar);
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
            return losVendedores;
        }
    }
}
