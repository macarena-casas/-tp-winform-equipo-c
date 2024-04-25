
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;



namespace negocio
{
    public class imagen_negocio
    {    

        private List<Imagen> imagenList;

        public void eliminar(int id)
        {
            try
            {
                Acceso_Datos datos = new Acceso_Datos();
                datos.setearconsulta("DELETE FROM IMAGENES WHERE Id = @Id");
                datos.setearparametro("@Id", id);
                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void agregar(Imagen nuevo)
        {
            Acceso_Datos datos = new Acceso_Datos();    
            try
            {
                datos.setearconsulta("insert into IMAGENES(IdArticulo, ImagenUrl) values(" + nuevo.id_articulo + ",'"+ nuevo.Nombre_imagen + "')");
                datos.ejecutaraccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }

        public  List <Imagen> Listar()
        {
            List<Imagen> Lista_imagen = new List<Imagen>();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearconsulta("SELECT IdArticulo,Id, ImagenUrl FROM IMAGENES");
                datos.ejecutarlectura();
                while(datos.lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.id_imagen = (int)datos.lector["Id"];
                    aux.id_articulo = (int)datos.lector["IdArticulo"];        
                    aux.Nombre_imagen = (string)datos.lector["ImagenUrl"];
                    
                    Lista_imagen.Add(aux);
                }                
                return Lista_imagen;
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
