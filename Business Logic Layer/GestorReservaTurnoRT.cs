using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class GestorReservaTurnoRT
    {
        private string tipoRecursoSeleccionado;
        private List<RecursoTecnologico> recursosTecnologicosDelTipoSelec;
        public string TipoRecursoSeleccionado
        {
            get { return tipoRecursoSeleccionado; }
            set { tipoRecursoSeleccionado = value; }
        }
        public List<RecursoTecnologico> RecursosTecnologicosDelTipoSelec
        {
            get { return recursosTecnologicosDelTipoSelec;}
            set { recursosTecnologicosDelTipoSelec = value; }
        }
        //DEVUELVE TODOS LOS NOMBRES DE LOS TIPOS DE RECURSO
        public List<string> buscarTipoRecurso(List<TipoRecursoTecnologico> listaTipoRT)
        {
            List<string> lstTipoRT = new List<string>();

            for (int i = 0; i < listaTipoRT.Count; i++)
            {
                lstTipoRT.Add(listaTipoRT[i].Nombre);
            }

            return lstTipoRT;
        }
        //TOMAR EL TIPO DE RECURSO SELECCIONADO Y SETEAR EL ATRIBUTO DE LA CLASE GESTOR (EJECUTAR buscarRT())
        public void TomarTipoRT(string tipoRT, List<RecursoTecnologico>listaRT)
        {
            this.TipoRecursoSeleccionado = tipoRT;
            buscarRT(listaRT);
        }
        //BUSCA Y DEVUELVE UNA LISTA DE RECURSOS TECNOLOGICOS PERTENECIENTES AL TIPO SELECCIONADO
        public void buscarRT(List<RecursoTecnologico> lstRT)
        {
            List<RecursoTecnologico> lstRecTec = new List<RecursoTecnologico>();

            if (this.TipoRecursoSeleccionado == "Todos")
            {
                this.RecursosTecnologicosDelTipoSelec = lstRT;
            }
            for (int i = 0; i < lstRT.Count; i++)
            {

                if (lstRT[i].esTuTipoRT(this.TipoRecursoSeleccionado))
                {
                    if (lstRT[i].esReservable())
                    {
                        lstRecTec.Add(lstRT[i]);
                    }
                }

            }
            this.RecursosTecnologicosDelTipoSelec = lstRT;
        }

        public  buscarDatosRT()
        {

        }
        //private Marca obtenerMarcaModelo(Modelo modelo)
        //{
        //    List<Marca> lstMarca = (List<Marca>)ViewState["ListaMarcas"];
        //    for (int i = 0; i < lstMarca.Count; i++)
        //    {
        //        for (int j = 0; j < lstMarca[i].Modelos.Count; j++)
        //        {
        //            if (lstMarca[i].Modelos[j].esTuMarca(lstMarca[i]))
        //            {
        //                return lstMarca[i];
        //            }
        //        }
        //    }
        //    return null;
        //}
    }

}
