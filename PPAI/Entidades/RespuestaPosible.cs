using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class RespuestaPosible
    {
        public string descripcion { get; set; }
        public int[] valor { get; set; }

        public RespuestaPosible(string descripcion, int[] valor)
        {
            this.descripcion = descripcion;
            this.valor = valor;
        }

        
    }
}
