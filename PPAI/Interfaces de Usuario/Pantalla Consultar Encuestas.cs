    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using PPAI.Entidades;
using PPAI.Interfaces_de_Usuario.CSV;
using PPAI.Servicios;

namespace PPAI.Interfaces_de_Usuario
{

    public partial class frmPantallaConsulEnc : Form
    {

        public DateTime fechaInicio;
        public DateTime fechaFin;
        private Gestor gestor;
        private List<Llamada> llamadas;
        private readonly FrmCSV frmCSV;

        public frmPantallaConsulEnc(frmPantallaPrinCoord menu)
        {

            InitializeComponent();
            llamadas = new List<Llamada>();
            gestor = new Gestor(this);
            


        }



        public void CerrarFormulario()
        {
            this.Dispose();
        }

        public void SolitarIngresarPeriodo()
        {
            MessageBox.Show("Ingresar período de llamada");
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            List<Llamada> llamadasEnPeriodoYConEncRespondidas = new List<Llamada>();

            fechaInicio = dtpFechaInicio.Value;
            fechaFin = dtpFechaFin.Value;

            llamadasEnPeriodoYConEncRespondidas = gestor.TomarPeriodoAFiltrar(fechaInicio, fechaFin);
            MostrarLlamadas(llamadasEnPeriodoYConEncRespondidas);
        }

        private void MostrarLlamadas(List<Llamada> llamadasEnPeriodoYConEncRespondidas)
        {
            lblLlamadasEncontradas.Show();
            cmbLlamadasAMostrar.Show();
            cmbLlamadasAMostrar.Items.Clear();
            foreach (Llamada llamadas in llamadasEnPeriodoYConEncRespondidas)
            {

                cmbLlamadasAMostrar.Items.Add($"Llamada n°: {llamadas.id} - De la fecha: {llamadas.fechaLlamada}");
               
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(llamadas.Count.ToString());
        }

        private void frmPantallaConsulEnc_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            timer.Stop();
            gestor.NuevaConsultarEncuestas();
        }

        private void frmPantallaConsulEnc_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void cmbLlamadasAMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Llamada llamadaSeleccionada = new Llamada(0,0,DateTime.Now,null,null,null);

            string strIdLlamada = cmbLlamadasAMostrar.Text[12].ToString();
            int idLlamada = int.Parse(strIdLlamada);

            llamadaSeleccionada = llamadaSeleccionada.ObtenerLlamadaSeleccionada(idLlamada);
            gestor.TomarSeleccionLlamada(llamadaSeleccionada);
            

        }
        
        public void MostrarDatosLlamada(string nomCli, string nomUltEstado, long duracion, Encuesta encuestaABuscar, Pregunta[] preguntasEncuesta)
        {
            string strNomCli = nomCli;
            string strUltEstado = nomUltEstado;
            long longDuracion = duracion;
            Encuesta encuesta = encuestaABuscar;
            Pregunta[] preguntas = preguntasEncuesta;

            lblMostrarDatosLlamada.Show();
            lblMostrarDatosLlamada.Text = $"Nombre del Cliente: {strNomCli} \n UltimoEstado: {strUltEstado} " +
                $"\n Duracion: {longDuracion} \n Encuesta: {encuesta.descripcion}";

        }

        public void SolicitarFormaDeVisualizacion()
        {
            var resultado = MessageBox.Show("¿Esta seguro de confirmar la consulta?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Elegir la forma de visualizacion deseada");
                lblFormaVisualizacion.Show();
                cbCSV.Show();
                cbImprimir.Show();
            }
        }

        private void cbImprimir_CheckedChanged(object sender, EventArgs e)
        {
            if (cbImprimir.Checked)
            {
                MessageBox.Show("No esta habilitada la Impresion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbImprimir.Checked = false;
            }
        }

        public void cbCSV_CheckedChanged(object sender, EventArgs e)
        {
            
            var login = new FrmCSV();
            this.Dispose();
            login.ShowDialog();



        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblMostrarDatosLlamada_Click(object sender, EventArgs e)
        {

        }
    }
}
