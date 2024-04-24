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
               
                datos.setearconsulta("select Codigo, Nombre, Precio, A.Id , A.Descripcion, I.ImagenUrl,M.Descripcion Mar,C.Descripcion Cat from ARTICULOS A,IMAGENES I,MARCAS M, CATEGORIAS C where I.Idarticulo=A.Id and A.Id=M.Id and A.Id=C.Id");
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
                    aux.categoria_articulo = new Categoria();
                    aux.categoria_articulo.nombre_categoria = (string)datos.lector["Cat"];
                     aux.marca_articulo = new Marca();
                    aux.marca_articulo.Nombre = (string)datos.lector["Mar"];
                    
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

        public void agregar(Articulos nuevo)
        {
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearconsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,Precio) values ('" + nuevo.codigo_articulo + "','" + nuevo.nombre_articulo + "','" + nuevo.descripcion_articulo + "'," + nuevo.precio_articulo + ")");
               // datos.setearconsulta("insert into ARTICULOS values ('" + nuevo.codigo_articulo + "','" + nuevo.nombre_articulo + "','" + nuevo.descripcion_articulo + "',@categoria,@marca , " + nuevo.precio_articulo + ")");
                //datos.agregarParametro("@categoria", nuevo.categoria_articulo);
                //datos.agregarParametro("@marca", nuevo.marca_articulo);
                
                datos.ejecutaraccion();
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
