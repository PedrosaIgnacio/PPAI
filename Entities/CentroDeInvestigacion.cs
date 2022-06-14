using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CentroDeInvestigacion
    {

        // ATRIBUTOS PRIVADOS

        private string nombre;

        private string sigla;

        private string direccion;

        private string edificio;

        private int piso;

        private float coordenadas;

        private List<AsignacionCientificoDelCI> cientificos;

        private List<RecursoTecnologico> recursoTecnologicos;


        // GET Y SET

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Edificio
        {
            get { return edificio; }
            set { edificio = value; }
        }

        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        public float Coordenadas
        {
            get { return coordenadas; }
            set { coordenadas = value; }
        }

    }
}
