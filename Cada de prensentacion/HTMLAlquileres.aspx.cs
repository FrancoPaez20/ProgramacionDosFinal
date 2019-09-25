using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace Cada_de_prensentacion
{
    public partial class HTMLAlquileres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            cargartabla();

        }

        public List<Duenio> LDuenio
        {
            get
            {
                if (Session["ListaDuenio"] == null)
                    Session["ListaDuenio"] = new List<Duenio>();
                return (List<Duenio>)Session["ListaDuenio"];
            }
            set
            {
                Session["ListaDuenio"] = value;
            }
        }
        public List<Inquilino> LInquilino
        {
            get
            {
                if (Session["ListaInquilino"] == null)
                    Session["ListaInquilino"] = new List<Inquilino>();
                return (List<Inquilino>)Session["ListaInquilino"];
            }
            set
            {
                Session["ListaInquilino"] = value;
            }
        }
        public List<Garante> LGarante
        {
            get
            {
                if (Session["ListaGarante"] == null)
                    Session["Listagarante"] = new List<Garante>();
                return (List<Garante>)Session["ListaGarante"];
            }
            set
            {
                Session["ListaGarante"] = value;
            }
        }
        public List<Casa> Lcasa
        {
            get
            {
                if (Session["ListaCasa"] == null)
                    Session["ListaCasa"] = new List<Casa>();
                return (List<Casa>)Session["ListaCasa"];
            }
            set
            {
                Session["ListaCasa"] = value;
            }
        }
        public List<Departamento> LDepartamento
        {
            get
            {
                if (Session["ListaDepartamento"] == null)
                    Session["ListaDepartamento"] = new List<Departamento>();
                return (List<Departamento>)Session["ListaDepartamento"];
            }
            set
            {
                Session["ListaDepartamento"] = value;
            }
        }
        public List<LocalComercial> LLocalComercial
        {
            get
            {
                if (Session["ListaLocalComercial"] == null)
                    Session["ListalocalComercial"] = new List<LocalComercial>();
                return (List<LocalComercial>)Session["ListaLocalComercial"];
            }
            set
            {
                Session["ListaLocalComercial"] = value;
            }
        }
        public List<ContratoAlquiler> LContratoAlquiler
        {
            get
            {
                if (Session["ListaContratoAlquiler"] == null)
                    Session["ListaContratoAlquiler"] = new List<ContratoAlquiler>();
                return (List<ContratoAlquiler>)Session["ListaContratoAlquiler"];
            }
            set
            {
                Session["ListaContratoAlquiler"] = value;
            }
        }
        public List<ReciboSueldo> LReciboSueldo
        {
            get
            {
                if (Session["ListaReciboSueldo"] == null)
                    Session["ListaReciboSueldo"] = new List<ReciboSueldo>();
                return (List<ReciboSueldo>)Session["ListaReciboSueldo"];
            }
            set
            {
                Session["ListareciboSueldo"] = value;
            }
        }

        public void cargartabla()
        {
            GridView1.DataSource = LContratoAlquiler;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idContratoAlquiler = int.Parse(GridView1.SelectedRow.Cells[3].Text);
            ContratoAlquiler oContrato = LContratoAlquiler.Find(x => x.idcontrato == idContratoAlquiler);
            Garante oGarante = oContrato.ogarante;



            text6.Value = oGarante.dni.ToString();
            text7.Value = oGarante.apellido;
            text8.Value = oGarante.nombre;
            text9.Value = oGarante.direccion;
            text10.Value = oGarante.telefono;
            text11.Value = oGarante.mail;
            text12.Value = oGarante.empleo;

            GridView2.DataSource = oGarante.lrecibosueldo;
            GridView2.DataBind();

            text1.Value = oContrato.fechainicio.ToString();
            DateTime miDato = oContrato.fechainicio;
            DateTime miDatoMas = miDato.AddMonths(oContrato.meses);
            text2.Value = miDatoMas.ToString();
            text3.Value = (int.Parse(oContrato.precio) / oContrato.meses).ToString();

            string tipo = buscartipoinmueble(oContrato);

            text4.Value = tipo;

        }

        private string buscartipoinmueble(ContratoAlquiler oContrato)
        {

            string tipo = "";
            //  Casa oCasa = Lcasa.Find(x => x.idcasa == oContrato.ocasa.idcasa);

            if (oContrato.ocasa != null)
            {

                tipo = "Casa";
                return tipo;

            }

            //Departamento oDepartamento = LDepartamento.Find(x => x.iddepartamento == oContrato.odepartamento.iddepartamento);
            if (oContrato.odepartamento != null)
            {

                tipo = "Departamento";
                return tipo;

            }


            // LocalComercial oLocal = LLocalComercial.Find(x => x.idlocalcomercial == oContrato.olocalcomercial.idlocalcomercial);
            if (oContrato.olocalcomercial != null)
            {

                tipo = "Local Comercial";
                return tipo;

            }

            return tipo;
        }
    }
}