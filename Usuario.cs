using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Usuario
    {
        private string tipo;
        private string v1;
        private string v2;
        private DateTime today;

        public String Nombre { get; set; }

        internal void FormatIdAndName()
        {
            throw new NotImplementedException();
        }

        public String Apellido { get; set; }
        public String Tipo { get; set; }
        public DateTime Fecha { get; set; }



        public Usuario(string nombre, string apellido, string tipo, DateTime fecha)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Tipo = tipo;
            this.Fecha = fecha;
        }

        public Usuario()
        {
        }

        public string FormatIdAndName(string nombre, string apellido, string tipo, DateTime fecha)
        {
            return FormatIdAndName( nombre,  apellido,  tipo,  fecha);
        }

        //public virtual string GetSummary()
        //{
        //    return Nombre + " " + Apellido + " " + Fecha;
        //}

    }
}
