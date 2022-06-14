using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Marca
    {
        //ATRIBUTOS PRIVADOS
        private string nombre;
        private List<Modelo> modelos;

        //GET Y SET
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public List<Modelo> Modelos
        {
            get { return modelos; }
            set { modelos = value; }
        }

        //METODOS
        public bool esTuModelo(Modelo modelo)
        {
            for (int i = 0; i < this.modelos.Count; i++)
            {
                if (this.modelos[i] == modelo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
