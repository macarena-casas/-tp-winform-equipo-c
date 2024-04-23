using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
     public class Imagen
    {
        public string Nombre_imagen { get; set; }
        public int Codigo_imagen { get; set; }

        public override string ToString()
        {
            return Nombre_imagen;
        }
        public void Cargar_imagen()
        {

        }
        public void Eliminar_imagen()
        {

        }
    }
}
