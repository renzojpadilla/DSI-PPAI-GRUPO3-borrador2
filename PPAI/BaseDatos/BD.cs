using PPAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.BaseDatos
{

    public class BD
    {
        public List<Cliente> Clientes { get; set; }
        public List<Cliente> ClienteList()
        {
            List<Cliente> Clientes = new List<Cliente>();

            Cliente cliente1 = new Cliente("Santiago");
            Cliente cliente2 = new Cliente("Nico");
            Cliente cliente3 = new Cliente("Luciano");
            Cliente cliente4 = new Cliente("Renzo");

            Clientes.Add(cliente1);
            Clientes.Add(cliente2);
            Clientes.Add(cliente3);
            Clientes.Add(cliente4);

            return Clientes;
        }

        public List<Cambio_Estado> CambioEstadoList()
        {
            List<Cambio_Estado> listCambioEstado = new List<Cambio_Estado>();

            Estado estado = new Estado("");
            List<Estado> listEstado = new List<Estado>();
            listEstado = EstadoList();

            Cambio_Estado cambio1 = new Cambio_Estado(new DateTime(2023, 2, 23, 15, 30, 56), listEstado[2]);
            Cambio_Estado cambio2 = new Cambio_Estado(new DateTime(2023, 5, 23, 17, 0, 20), listEstado[1]);
            Cambio_Estado cambio3 = new Cambio_Estado(new DateTime(2023, 5, 23, 18, 45, 01), listEstado[0]);
            listCambioEstado.Add(cambio1);
            listCambioEstado.Add(cambio2);
            listCambioEstado.Add(cambio3);

            return listCambioEstado;
        }
        public List<Encuesta> EncuestasList()
        {
            List<Encuesta> encuestas = new List<Encuesta>();

            Pregunta pregunta = new Pregunta("", null);
            List<Pregunta> listPreguntas = new List<Pregunta>();


            Pregunta[] pregEnc1 = { PreguntasLista()[0], PreguntasLista()[1] };
            Pregunta[] pregEnc2 = { PreguntasLista()[2], PreguntasLista()[3] };

            Encuesta encuesta1 = new Encuesta("Encuesta de satisfaccion", new DateTime(2023, 5, 23), pregEnc1);
            Encuesta encuesta2 = new Encuesta("Encuesta de atencion", new DateTime(2023, 7, 23), pregEnc2);

            encuestas.Add(encuesta1);
            encuestas.Add(encuesta2);

            return encuestas;

        }
        public List<Estado> EstadoList()
        {
            List<Estado> listEstados = new List<Estado>();
            Estado estadoCancelado = new Estado("Cancelado");
            Estado estadoFinalizado = new Estado("Finalizado");
            Estado estadoEnCurso = new Estado("EnCurso");
            listEstados.Add(estadoEnCurso);
            listEstados.Add(estadoFinalizado);
            listEstados.Add(estadoCancelado);

            return listEstados;
        }
        public List<Llamada> LlamadaLista()
        {
            List<Llamada> listaLlamada = new List<Llamada>();

            Cambio_Estado cambio_Estado = new Cambio_Estado(DateTime.Now, null);
            List<Cambio_Estado> listaCambioEstado = new List<Cambio_Estado>();
            listaCambioEstado = CambioEstadoList();

            RespuestaDeCliente respuestaDeCliente = new RespuestaDeCliente(DateTime.Now);
            List<RespuestaDeCliente> listaRespuestaCli = new List<RespuestaDeCliente>();
            listaRespuestaCli = ListaRespuestaDeCliente();

            Cliente cliente = new Cliente("");
            List<Cliente> listaCliente = new List<Cliente>();
            listaCliente = ClienteList();



            Llamada llamada1 = new Llamada(1, 56, new DateTime(2023, 5, 23),
               CambioEstadoList()[1], ClienteList()[0], ListaRespuestaDeCliente()[0]);
            Llamada llamada1_1 = new Llamada(1, 56, new DateTime(2023, 5, 23),
                CambioEstadoList()[2], ClienteList()[0], ListaRespuestaDeCliente()[1]);
            Llamada llamada2 = new Llamada(2, 32, new DateTime(2023, 2, 23),
                CambioEstadoList()[0], ClienteList()[1], ListaRespuestaDeCliente()[2]);
            Llamada llamada3 = new Llamada(3, 84, new DateTime(2023, 5, 23),
                CambioEstadoList()[1], ClienteList()[2], null);
            Llamada llamada4 = new Llamada(4, 69, new DateTime(2023, 5, 25),
                CambioEstadoList()[1], ClienteList()[3], ListaRespuestaDeCliente()[3]);

            listaLlamada.Add(llamada1);
            listaLlamada.Add(llamada1_1);
            listaLlamada.Add(llamada2);
            listaLlamada.Add(llamada3);
            listaLlamada.Add(llamada4);

            return listaLlamada;
        }
        public List<Pregunta> PreguntasLista()
        {
            List<Pregunta> preguntas = new List<Pregunta>();

            RespuestaPosible respuestaPosible = new RespuestaPosible("", null);
            List<RespuestaPosible> listRespuestaPosible = new List<RespuestaPosible>();

            Pregunta pregunta1_1 = new Pregunta("¿Que tan satisfecho esta con su atencion?", RespuestaPosibleList()[0]);
            Pregunta pregunta1_2 = new Pregunta("¿Resolvio su problema?", RespuestaPosibleList()[1]);
            Pregunta pregunta2_1 = new Pregunta("¿Fue bien atendido?", RespuestaPosibleList()[0]);
            Pregunta pregunta2_2 = new Pregunta("¿Se sintio comodo con el sistema?", RespuestaPosibleList()[1]);

            preguntas.Add(pregunta1_1);
            preguntas.Add(pregunta1_2);
            preguntas.Add(pregunta2_1);
            preguntas.Add(pregunta2_2);

            return preguntas;

        }
        public List<RespuestaDeCliente> ListaRespuestaDeCliente()
        {
            List<RespuestaDeCliente> listRespuestaDeClientes = new List<RespuestaDeCliente>();

            int[] cant = { };
            RespuestaPosible respuestaPosible = new RespuestaPosible("", cant);
            List<RespuestaPosible> listaRespuestaPosibles = new List<RespuestaPosible>();
            listaRespuestaPosibles = RespuestaPosibleList();


            RespuestaDeCliente respuesta1 = new RespuestaDeCliente(new DateTime(2023, 5, 23));
            RespuestaDeCliente respuesta2 = new RespuestaDeCliente(new DateTime(2023, 5, 23));
            RespuestaDeCliente respuesta3 = new RespuestaDeCliente(new DateTime(2023, 5, 23));
            RespuestaDeCliente respuesta4 = new RespuestaDeCliente(new DateTime(2023, 5, 28));
            RespuestaDeCliente respuesta5 = new RespuestaDeCliente(new DateTime(2023, 5, 23));
            RespuestaDeCliente respuesta6 = new RespuestaDeCliente(new DateTime(2023, 5, 23));
            RespuestaDeCliente respuesta7 = new RespuestaDeCliente(new DateTime(2023, 5, 28));


            listRespuestaDeClientes.Add(respuesta1);
            listRespuestaDeClientes.Add(respuesta2);
            listRespuestaDeClientes.Add(respuesta3);
            listRespuestaDeClientes.Add(respuesta4);
            listRespuestaDeClientes.Add(respuesta5);
            listRespuestaDeClientes.Add(respuesta6);
            listRespuestaDeClientes.Add(respuesta7);

            return listRespuestaDeClientes;
        }
        public List<RespuestaPosible> RespuestaPosibleList()
        {
            List<RespuestaPosible> list = new List<RespuestaPosible>();
            int[] valor10 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] valor5 = { 1, 2, 3, 4, 5 };

            RespuestaPosible respuestaPosible1 = new RespuestaPosible("Escala del 1 al 10", valor10);
            RespuestaPosible respuestaPosible2 = new RespuestaPosible("Escala del 1 al 5", valor5);

            list.Add(respuestaPosible1);
            list.Add(respuestaPosible2);

            return list;
        }
    }
}
