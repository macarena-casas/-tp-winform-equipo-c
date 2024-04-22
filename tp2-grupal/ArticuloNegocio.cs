using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace tp2_grupal
{
    class ArticulosNegocio
    {
        public List <Articulos> listar()
        {
            List <Articulos> lista = new List <Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, Nombre, Precio, A.Id , Descripcion, I.ImagenUrl from ARTICULOS A,IMAGENES I where I.Idarticulo=A.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.nombre_articulo =(string)lector["Nombre"];
                    //aux.precio_articulo =(float)lector["Precio"];
                    aux.codigo_articulo = (string)lector["Codigo"];
                    aux.descripcion_articulo = (string)lector["Descripcion"];
                    aux.Id_articulo = (int)lector["Id"];
                    aux.imagen_articulo = new Imagen ();
                    aux.imagen_articulo.Nombre_imagen = (string)lector["ImagenUrl"];

                    lista.Add(aux);


                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
