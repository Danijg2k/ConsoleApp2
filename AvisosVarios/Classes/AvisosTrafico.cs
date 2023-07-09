using AvisosVarios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios.Classes
{
    internal class AvisosTrafico : IAvisos
    {
        // Propiedades 
        private string remitente;
        private string mensaje;
        private string fecha;

        // Constructores
        public AvisosTrafico() 
        {
            remitente = "DGT";
            mensaje = "Sanción cometida. Pague antes de 3 días y se beneficiará de una reducción en la sanción del 50%.";
            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        // Métodos
        public string GetFecha()
        {
            return fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el día {2}", mensaje, remitente, fecha);
        }
    }
}
