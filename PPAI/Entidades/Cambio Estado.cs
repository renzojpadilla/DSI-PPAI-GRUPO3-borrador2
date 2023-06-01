using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.Entidades;

namespace PPAI.Entidades
{
    public class Cambio_Estado
    {

        public DateTime fechaHoraInicio { set; get; }
        public Estado estado { set; get; }

        public Cambio_Estado(DateTime fechahorainicio, Estado nombreEstado)
        {

            this.fechaHoraInicio = fechahorainicio;
            this.estado = nombreEstado;

        }
        
        



        
    }
}
