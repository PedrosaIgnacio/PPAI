using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class RecursoTecnologico
    {
        // ATRIBUTOS PRIVADOS

        private int numeroRT;

        private string fechaAlta;

        private Modelo modelo;

        private TipoRecursoTecnologico tipoRecursoTecnologico;

        private List<CambioEstadoRT> cambiosDeEstadoRT;


        // GET Y SET

        public int NumeroRT
        {
            get { return numeroRT; }
            set { numeroRT = value; }
        }
        public string FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        public Modelo Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public TipoRecursoTecnologico TipoRecursoTecnologico
        {
            get { return tipoRecursoTecnologico; }
            set { tipoRecursoTecnologico = value; }
        }
        public List<CambioEstadoRT> CambiosDeEstadoRT
        {
            get { return cambiosDeEstadoRT; }
            set { cambiosDeEstadoRT = value; }
        }

        public bool esReservable()
        {
            for (int i = 0; i < this.cambiosDeEstadoRT.Count; i++)
            {
                if (cambiosDeEstadoRT[i].esActual())
                {
                    if (cambiosDeEstadoRT[i].esEstadoReservable())
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        public void getDatos()
        {

        }
        public bool esTuTipoRT(string nombreTipoRT)
        {
            if (this.tipoRecursoTecnologico.Nombre == nombreTipoRT)
            {
                return true;
            }
            return false;
        }

    }
}
