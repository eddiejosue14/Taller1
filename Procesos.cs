using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Procesos
    {
        Publicacion objPubli = new Publicacion();
        Usuario objUser = new Usuario(); 


        public void nuevaPublicacion()
        {
            Console.WriteLine("Ingrese su publicacion");
            objPubli.Contenido = Console.ReadLine();
            objPubli.listPublicacion.Add(objPubli); 

        }

        public void validarUsuario()
        {
            Console.WriteLine("Ingrese el tipo de usuario");
            objUser.Tipo = Console.ReadLine();
            if (objUser.Tipo == "editor")
            {
                Console.WriteLine("¿que desea hacer? Digite 1 para crear una publicacion o Digite 2 para ver la lista de publicaciones");
                string desicion = Console.ReadLine();
                if (desicion == "1")
                {
                    nuevaPublicacion();
                }

                if (objUser.Tipo == "invitado")
                {
                    Console.WriteLine("¿que desea hacer? Digite 1 para crear un comentario a una publicacion existente o Digite 2 para ver la lista de publicaciones");
                }
            }
        }

    }
}
