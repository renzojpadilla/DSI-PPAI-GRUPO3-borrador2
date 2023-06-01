using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Pregunta
    {
        public string strPregunta { get; set; }
        public RespuestaPosible respuestaPosible { get; set; }

        public Pregunta(string pregunta, RespuestaPosible respuestaPosible)
        {
            this.strPregunta = pregunta;
            this.respuestaPosible = respuestaPosible;
        }

        
    }
}
