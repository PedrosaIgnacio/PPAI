using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Modelo
    {
        // ATRIBUTOS PRIVADOS

        private string nombre;

        // GET Y SET

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        // MÉTODOS
        public bool esTuMarca(Marca marca)
        {
            if (marca.esTuModelo(this))
            {
                return true;
            }
            return false;
        }

    }
}
