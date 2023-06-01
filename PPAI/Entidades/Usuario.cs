using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string contrasenia { get; set; }

        public Usuario(string nombreUsu, string contraUsu)
        {
            nombre = nombreUsu;
            contrasenia = contraUsu;
        }
        public bool ValidarUsuario(string nombre, string clave)
        {
            Usuario miUsuario = new Usuario("coordinador", "coord");
            if (nombre == miUsuario.nombre && clave == miUsuario.contrasenia)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
    
}
