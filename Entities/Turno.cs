using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Turno
    {
        // ATRIBUTOS PRIVADOS

        private DateTime fechaGeneracion;

        private string diaSemana;

        private DateTime fechaHoraInicio;

        private DateTime fechaHoraFin;

        private CambioEstadoTurno cambioEstadoTurno;

        // GET Y SET

        public DateTime FechaGeneracion
        {
            get { return fechaGeneracion; }
            set { fechaGeneracion = value; }
        }

        public string DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
        }

        public DateTime FechaHoraInicio
        {
            get { return fechaHoraInicio; }
            set { fechaHoraInicio = value; }
        }

        public DateTime FechaHoraFin
        {
            get { return fechaHoraFin; }
            set { fechaHoraFin = value; }
        }

        // MÉTODOS

        public bool esPosteriorFechaHoraActual(DateTime fechaActual)
        {
            if (this.fechaHoraInicio > fechaActual)
            {
                return true;
            }
            return false;
        }

        public string buscarEstado(List<CambioEstadoTurno> listaCambioEstadoTurno)
        {
            for (int i = 0; i < listaCambioEstadoTurno.Count; i++)
            {
                if (listaCambioEstadoTurno[i].esActual())
                {
                    return listaCambioEstadoTurno[i].buscarEstado();
                }
            }
            return null;
        }

        public void reservar()
        {

        }

    }
}
