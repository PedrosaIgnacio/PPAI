using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Estado
    {
        // ATRIBUTOS PRIVADOS

        private string nombre;

        private string descripcion;

        private string ambito;

        private bool esReservable;

        private bool esCancelable;

        // GET Y SET

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Ambito
        {
            get { return ambito; }
            set { ambito = value; }
        }

        public bool EsReservable
        {
            get { return esReservable; }
            set { esReservable = value; }
        }

        public bool EsCancelable
        {
            get { return esCancelable; }
            set { esCancelable = value; }
        }

        // MÉTODOS
        public bool esAmbitoTurno()
        {
            if (this.ambito == "Turno")
            {
                return true;
            }
            return false;
        }
     
    }
}
