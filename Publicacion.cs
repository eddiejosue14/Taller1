using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Publicacion
    {
        public String Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public String Autor { get; set; }

       public List<Publicacion> listPublicacion = new List<Publicacion>();

        public Publicacion(string contenido, DateTime fecha, string autor)
        {
            this.Contenido = contenido;
            this.Fecha = fecha;
            this.Autor = autor;
        }

       public  Publicacion()
        { }

    }
}
