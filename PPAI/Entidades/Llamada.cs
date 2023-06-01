using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.BaseDatos;

namespace PPAI.Entidades
{
    public class Llamada
    {
        public long id { get; set; }
        public long duracion { get; set; }
        public DateTime fechaLlamada { get; set; }
        public Cambio_Estado cambioEstado { get; set; }
        public Cliente cliente { get; set; }
        public RespuestaDeCliente respuestaDeCliente { get; set; }


        public Llamada(long id, long duracion, DateTime fechaLlamada, Cambio_Estado cambioEstado, Cliente cliente, RespuestaDeCliente respuestaDeCliente)
        {
            this.id = id;
            this.duracion = duracion;
            this.fechaLlamada = fechaLlamada;
            this.cambioEstado = cambioEstado;
            this.cliente = cliente;
            this.respuestaDeCliente = respuestaDeCliente;
            
        }


        public bool EsDePeriodo(DateTime FechaInicio, DateTime FechaFin)
        {
            if (FechaFin >= fechaLlamada && FechaInicio <= fechaLlamada)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EstaRespondida(Llamada listaLlamadas)
        {

            if (listaLlamadas.respuestaDeCliente != null)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        public Llamada ObtenerLlamadaSeleccionada(int idLlamada)
        {
            BD llamadaSelecc = new BD();
            List<Llamada> llamadaList = new List<Llamada>();
            llamadaList = llamadaSelecc.LlamadaLista();
            Llamada llamadaBuscada = new Llamada(0,0,DateTime.MinValue,null,null,null);
            DateTime anterior = DateTime.MinValue;

            foreach (Llamada llamada in llamadaList)
            {
                if (llamada.id == idLlamada && llamada.fechaLlamada >= anterior)
                {
                    llamadaBuscada = llamada;
                }
            }
            return llamadaBuscada;
        }
    }
}
