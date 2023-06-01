using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Cliente
    {
        private string nombreCliente;

        public Cliente(string nombre)
        {
            this.nombreCliente = nombre;
        }

        public string getNombre
        {
            get => nombreCliente; 
        }
    }

    
}
