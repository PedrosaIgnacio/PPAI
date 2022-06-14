using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AsignacionCientificoDelCI
    {
        // ATRIBUTOS PRIVADOS

        private DateTime fechaDesde;

        private DateTime fechaHasta;

        private PersonalCientifico personalCientifico;

        private List<Turno> turnos;

        // GET Y SET

        public DateTime FechaDesde
        {
            get { return fechaDesde; }
            set { fechaDesde = value; }
        }
        public DateTime FechaHasta
        {
            get { return fechaHasta; }
            set { fechaHasta = value; }
        }
        public PersonalCientifico PersonalCientifico
        {
            get { return personalCientifico; }
            set { personalCientifico = value; }
        }
        public List<Turno> Turnos
        {
            get { return turnos; }
            set { turnos = value; }
        }
    }
}

