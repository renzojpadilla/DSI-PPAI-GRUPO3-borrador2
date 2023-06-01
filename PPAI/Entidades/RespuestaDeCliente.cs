using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class RespuestaDeCliente
    {
        public DateTime fechaEncuesta { get; set; }

        public RespuestaDeCliente(DateTime fechaEncuesta)
        {
            this.fechaEncuesta = fechaEncuesta;

        }

        
    }

}
