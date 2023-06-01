using PPAI.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Entidades
{
    public class Encuesta
    {
        public string descripcion { get; set; }
        public DateTime fechaFinVigencia { get; set; }
        public Pregunta[] pregunta { get; set; }

        public Encuesta(string descripcion, DateTime fechaFinVigencia, Pregunta[] pregunta)
        {
            this.descripcion = descripcion;
            this.fechaFinVigencia = fechaFinVigencia;
            this.pregunta = pregunta;
        }
        

        public Encuesta GetDescripcionEncuesta(DateTime fecha)
        {
            BD encuesta1 = new BD();
            List<Encuesta> encuestaList = new List<Encuesta>();
            encuestaList = encuesta1.EncuestasList();
            Encuesta encuestaList2 = new Encuesta("",DateTime.MinValue, null);
            

            foreach (Encuesta encuesta in encuestaList)
            {
                if (encuesta.fechaFinVigencia >= fecha )
                {
                    encuestaList2 = encuesta;
                    break;
                }
                
            }
            return encuestaList2;
        }
    }
}
