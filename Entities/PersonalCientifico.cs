using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PersonalCientifico
    {
        // ATRIBUTOS PRIVADOS

        private int legajo;

        private string nombre;

        private string apellido;

        private int numeroDocumento;

        private string correoElectronicoInstitucional;

        private string correoElectronicoPersonal;

        private int telefonoCelular;

        // GET Y SET

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }

        public string CorreoElectronicoInstitucional
        {
            get { return correoElectronicoInstitucional; }
            set { correoElectronicoInstitucional = value; }
        }

        public string CorreoElectronicoPersonal
        {
            get { return correoElectronicoPersonal; }
            set { correoElectronicoPersonal = value; }
        }

        public int TelefonoCelular
        {
            get { return telefonoCelular; }
            set { telefonoCelular = value; }
        }
    }
}