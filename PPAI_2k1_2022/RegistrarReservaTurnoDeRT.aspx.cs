using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
namespace PPAI_2k1_2022
{
    public partial class RegistrarReservaTurnoDeRT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlRegistrarReserva.Visible = false;
                pnl_SinRT.Visible = false;


                ////MODELOS
                //Modelo modelo1 = new Modelo();
                //modelo1.Nombre = "TXB622L";
                //Modelo modelo2 = new Modelo();
                //modelo2.Nombre = "GJ123K";
                //Modelo modelo3 = new Modelo();
                //modelo3.Nombre = "MBKAOW";
                //Modelo modelo4 = new Modelo();
                //modelo4.Nombre = "2ALSK2";

                ////LISTA DE MARCAS
                //List<Marca> lstMarcas = new List<Marca>();
                //List<Modelo> lstModelosMarca1 = new List<Modelo>();
                //lstModelosMarca1.Add(modelo1);
                //lstModelosMarca1.Add(modelo1);

                //Marca marca1 = new Marca();
                //marca1.Nombre = "BMW";
                //marca1.Modelos = lstModelosMarca1;

                //lstMarcas.Add(marca1);
                //ViewState["ListaMarcas"] = lstMarcas;

                ////LISTA DE TIPOS DE RECURSOS TECNOLOGICOS
                //List<TipoRecursoTecnologico> listaTipoRT = new List<TipoRecursoTecnologico>();

                //TipoRecursoTecnologico tipoRT1 = new TipoRecursoTecnologico();
                //tipoRT1.Nombre = "Microscopios";
                //tipoRT1.Descripcion = "";

                //TipoRecursoTecnologico tipoRT2 = new TipoRecursoTecnologico();
                //tipoRT2.Nombre = "Balanzas de Precision";
                //tipoRT2.Descripcion = "";

                //TipoRecursoTecnologico tipoRT3 = new TipoRecursoTecnologico();
                //tipoRT3.Nombre = "Rasonadores Magnéticos";
                //tipoRT3.Descripcion = "";

                //listaTipoRT.Add(tipoRT1);
                //listaTipoRT.Add(tipoRT2);
                //listaTipoRT.Add(tipoRT3);

                //List<string> listaDeRecursTecno = buscarTipoRT(listaTipoRT);
                //cbo_tipoRT.DataSource = listaDeRecursTecno;
                //cbo_tipoRT.DataBind();
                //cbo_tipoRT.Items.Insert(0, new ListItem("Todos", "Todos"));

                ////LISTA DE RT
                //List<RecursoTecnologico> lstRT = new List<RecursoTecnologico>();



                //// LISTA GENERAL DE ESTADOS
                //List<Estado> lstEstados = new List<Estado>();

                //// ESTADO 1
                //Estado est1 = new Estado();
                //est1.Nombre = "Ingresado";
                //est1.Ambito = "Recurso Tecnologico";
                //est1.Descripcion = "Recurso dado de alta";
                //est1.EsReservable = true;

                //// ESTADO 2
                //Estado est2 = new Estado();
                //est2.Nombre = "Habilitado";
                //est2.Ambito = "Recurso Tecnologico";
                //est2.Descripcion = "Recurso tecnologico en calibracion";
                //est2.EsReservable = true;

                //// ESTADO 3
                //Estado est3 = new Estado();
                //est3.Nombre = "Baja tecnica";
                //est3.Ambito = "Recurso Tecnologico";
                //est3.Descripcion = "Recurso dado de baja tecnica";
                //est3.EsReservable = false;

                //// ESTADO 4
                //Estado est4 = new Estado();
                //est4.Nombre = "Baja fisica";
                //est4.Ambito = "Recurso Tecnologico";
                //est4.Descripcion = "Recurso dado de baja fisica";
                //est4.EsReservable = false;

                ////ESTADOS AGREGADOS A UNA LISTA GENERAL DE ESTADOS
                //lstEstados.Add(est1);
                //lstEstados.Add(est2);
                //lstEstados.Add(est3);
                //lstEstados.Add(est4);

                ////LISTA CAMBIOS DE ESTADO RT 1
                //List<CambioEstadoRT> listaCambiosEstados1 = new List<CambioEstadoRT>();
                //CambioEstadoRT cambioEst1 = new CambioEstadoRT();
                //cambioEst1.Estado = est1;
                //cambioEst1.FechaHoraDesde = DateTime.Parse("2022-05-06");
                //cambioEst1.FechaHoraDesde = null;

                //listaCambiosEstados1.Add(cambioEst1);

                ////LISTA CAMBIOS DE ESTADO RT2
                //List<CambioEstadoRT> listaCambiosEstados2 = new List<CambioEstadoRT>();

                //CambioEstadoRT cambioEst2 = new CambioEstadoRT();
                //cambioEst2.Estado = est4;
                //cambioEst2.FechaHoraDesde = DateTime.Parse("2022-05-06");
                //cambioEst2.FechaHoraHasta = DateTime.Parse("2022-06-06");

                //CambioEstadoRT cambioEst3 = new CambioEstadoRT();
                //cambioEst3.Estado = est4;
                //cambioEst3.FechaHoraDesde = DateTime.Parse("2022-05-06");
                //cambioEst3.FechaHoraHasta = null;
                //listaCambiosEstados2.Add(cambioEst2);
                //listaCambiosEstados2.Add(cambioEst3);


                ////RECURSOS TECNOLOGICOS
                //RecursoTecnologico RT1 = new RecursoTecnologico();
                //RT1.NumeroRT = 1;
                //RT1.FechaAlta = DateTime.Parse("2022-07-06").ToShortDateString();
                //RT1.TipoRecursoTecnologico = tipoRT1;
                //RT1.Modelo = modelo1;
                //RT1.CambiosDeEstadoRT = listaCambiosEstados1;

                //RecursoTecnologico RT2 = new RecursoTecnologico();
                //RT2.NumeroRT = 2;
                //RT2.FechaAlta = DateTime.Parse("2022-08-06").ToShortDateString();
                //RT2.TipoRecursoTecnologico = tipoRT1;
                //RT2.Modelo = modelo2;
                //RT2.CambiosDeEstadoRT = listaCambiosEstados2;

                //lstRT.Add(RT1);
                //lstRT.Add(RT2);

                //ViewState["ListaRT"] = lstRT;
            }
        }

        protected void btn_Reservar_Click(object sender, EventArgs e)
        {

            if (txtFecha.Text == "2022-08-08")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Error!", "wrongAlert('No hay mas turnos disponibles para la fecha seleccionada')", true);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Bien!", "okAlert('Turno Reservado')", true);
            }
        }


        protected void btn_tomarOpcionRegistrarReservaRT_Click(object sender, EventArgs e)
        {
            pnlRegistrarReserva.Visible = true;

        }


    }
}