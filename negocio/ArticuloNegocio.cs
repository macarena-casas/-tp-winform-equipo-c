using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticulosNegocio
    {
        public List <Articulos> listar()
        {
            List <Articulos> lista = new List <Articulos>();
            Acceso_Datos datos = new Acceso_Datos(); 
           
            try
            {
               
                datos.setearconsulta("select Codigo, Nombre, Precio, A.Id , Descripcion, I.ImagenUrl from ARTICULOS A,IMAGENES I where I.Idarticulo=A.Id");
                datos.ejecutarlectura();               
                    while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.nombre_articulo =(string)datos.lector["Nombre"];
                    aux.precio_articulo =(decimal)datos.lector["Precio"];
                    aux.codigo_articulo = (string)datos.lector["Codigo"];
                    aux.descripcion_articulo = (string)datos.lector["Descripcion"];
                    aux.Id_articulo = (int)datos.lector["Id"];
                    aux.imagen_articulo = new Imagen ();
                    aux.imagen_articulo.Nombre_imagen = (string)datos.lector["ImagenUrl"];

                    lista.Add(aux);


                }
                
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }
    }
}
