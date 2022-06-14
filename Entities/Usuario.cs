using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuario
    {

        // ATRIBUTOS PRIVADOS

        private string clave;

        private string nombre;

        private bool habilitado;

        private PersonalCientifico personalCientifico;

        // GET Y SET

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

        public PersonalCientifico PersonalCientifico
        {
            get { return personalCientifico; }
            set { personalCientifico = value; }
        }

    }
}
