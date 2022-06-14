using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CambioEstadoTurno
    {
        // ATRIBUTOS PRIVADOS

        private DateTime fechaHoraDesde;

        private DateTime fechaHoraHasta;

        private Estado estado;

        // GET Y SET

        public DateTime FechaHoraDesde
        {
            get { return fechaHoraDesde; }
            set { fechaHoraDesde = value; }
        }

        public DateTime FechaHoraHasta
        {
            get { return FechaHoraHasta; }
            set { fechaHoraHasta = value; }
        }

        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        // MÉTODOS

        public bool esActual()
        {
            if (this.fechaHoraHasta == null)
            {
                return true;
            }
            return false;
        }

        public string buscarEstado()
        {
            return this.estado.Nombre;
        }


    }
}
