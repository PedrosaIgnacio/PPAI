using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class CambioEstadoRT
    {
        // ATRIBUTOS PRIVADOS

        private DateTime? fechaHoraDesde;

        private DateTime? fechaHoraHasta;

        private Estado estado;


        // GET y SET

        public DateTime? FechaHoraDesde
        {
            get { return fechaHoraDesde; }
            set { fechaHoraDesde = value; }
        }

        public DateTime? FechaHoraHasta
        {

            get { return fechaHoraHasta; }
            set { fechaHoraHasta = value; }
        }

        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public bool esActual()
        {
            if (this.fechaHoraHasta == null)
            {
                return true;
            }
            return false;
        }

        // MÉTODOS

        public bool esEstadoReservable()
        {
            if (this.estado.EsReservable == true)
            {
                return true;
            }
            return false;
        }

    }
}
