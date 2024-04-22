using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            Acceso_Datos datos = new Acceso_Datos();
          
            try
            {
      
                datos.setearconsulta("select Id, DESCRIPCION from CATEGORIAS");
                datos.ejecutarlectura();
                while (datos.lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.nombre_categoria = (string)datos.lector["Descripcion"];
                    aux.codigo_categoria = (int)datos.lector["Id"];
                   
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
