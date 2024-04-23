using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace tp2_grupal
{
    public class marca_negocio
    {
        public List<Marca> Listar()
        {
            List<Marca> Lista_marca = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Descripcion from MARCAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Codigo = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Descripcion"];

                    Lista_marca.Add(aux);
                }
                conexion.Close();
                return Lista_marca;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}

