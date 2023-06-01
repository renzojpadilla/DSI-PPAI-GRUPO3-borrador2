using PPAI.BaseDatos;
using PPAI.Entidades;
using PPAI.Interfaces_de_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace PPAI.Servicios
{
    public class Gestor
    {

        public frmPantallaConsulEnc PantallaConsulEnc;


        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public Llamada llamada { get; set; }
        public List<Llamada> llamadasEnPeriodoYConEncuestaRespondida { get; set; }
        public List<Llamada> llamadasIndividuales { get; set; }
        public List<Llamada> llamadaSeleccionada { get; set; }

        public Gestor(frmPantallaConsulEnc pantallaConsultEnc)
        {
            PantallaConsulEnc = pantallaConsultEnc;
        }
        
        public void NuevaConsultarEncuestas()
        {
            PantallaConsulEnc.SolitarIngresarPeriodo();
        }

        public List<Llamada> TomarPeriodoAFiltrar(DateTime FechaInicio, DateTime FechaFin)
        {
            fechaFin = FechaFin;
            fechaInicio = FechaInicio;
            return ListarLlamadas(fechaInicio, fechaFin); 
        }

        private List<Llamada> ListarLlamadas(DateTime FechaInicio, DateTime FechaFin)
        {

            BD llamada = new BD();

            List<Llamada> todasLlamadas = new List<Llamada>();
            todasLlamadas = llamada.LlamadaLista();


            List<Llamada> llamadasEnPeriodoYConEncuestaRespondida = new List<Llamada>();
            for (int i = 0; i <= todasLlamadas.Count - 1; i++)
            {
                if (todasLlamadas[i].EsDePeriodo(FechaInicio, FechaFin) && todasLlamadas[i].EstaRespondida(todasLlamadas[i]))
                {
                    llamadasEnPeriodoYConEncuestaRespondida.Add(todasLlamadas[i]);
                }
            }

            llamadasEnPeriodoYConEncuestaRespondida =  LlamadasDuplicadas(llamadasEnPeriodoYConEncuestaRespondida);
            MessageBox.Show("Se entraron : " + llamadasEnPeriodoYConEncuestaRespondida.Count.ToString() + " llamadas.");
            return llamadasEnPeriodoYConEncuestaRespondida;

        }
        
        public List<Llamada> LlamadasDuplicadas(List<Llamada> llamadasEnPeriodo)
        {
            llamadasIndividuales = new List<Llamada>();

            for (int i = 0; i <= llamadasEnPeriodo.Count - 1; i++)
            {
                if (llamadasIndividuales.Count == 0)
                {
                    llamadasIndividuales.Add(llamadasEnPeriodo[i]);
                }
                else
                {
                    for (int j = 0; j <= llamadasIndividuales.Count - 1; j++)
                    {
                        if (llamadasEnPeriodo[i].id == llamadasIndividuales[j].id)
                        {
                            if (llamadasEnPeriodo[i].cambioEstado.fechaHoraInicio >= llamadasIndividuales[j].cambioEstado.fechaHoraInicio)
                            {
                                llamadasIndividuales.Add(llamadasEnPeriodo[i]);
                                llamadasIndividuales.Remove(llamadasIndividuales[j]);
                            }
                        }
                        else
                        {
                            llamadasIndividuales.Add(llamadasEnPeriodo[i]);
                        }
                    }
                }
            }

            return llamadasIndividuales;
        }

        public void TomarSeleccionLlamada(Llamada llamada)
        {
            BuscarDatosCliente(llamada);
        }

        public void BuscarDatosCliente(Llamada llamada)
        {
            Llamada llamadaABuscar = llamada;
            Encuesta encuestaABuscar = new Encuesta("", DateTime.Now, null);
            
            string nomCli = llamadaABuscar.cliente.getNombre;
            string nomUltEstado = llamadaABuscar.cambioEstado.estado.nombre;
            long duracion = llamadaABuscar.duracion;
            encuestaABuscar = encuestaABuscar.GetDescripcionEncuesta(llamadaABuscar.fechaLlamada);
            Pregunta[] preguntasEncuesta = encuestaABuscar.pregunta;

            PantallaConsulEnc.MostrarDatosLlamada(nomCli, nomUltEstado, duracion, encuestaABuscar, preguntasEncuesta);
            PantallaConsulEnc.SolicitarFormaDeVisualizacion();

        }


    }  



}
