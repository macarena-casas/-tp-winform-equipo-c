using dominio;
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
        public  List <Imagen> Listar()
        {
            List<Imagen> Lista_imagen = new List<Imagen>();
            Acceso_Datos datos = new Acceso_Datos();
            try
            {
                datos.setearconsulta("select Id,IdArticulo,ImagenUrl from IMAGENES");
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
