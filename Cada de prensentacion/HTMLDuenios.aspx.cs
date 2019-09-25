using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace Cada_de_prensentacion
{
    public partial class HTMLDuenios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void buscarduenios(object sender, EventArgs e)
        {
            int DNI = int.Parse(midni.Value);
            Duenio oDuenio = LDuenio.Find(x => x.dni == DNI);
            if(oDuenio != null)
            {
                inputapellido.Value = oDuenio.apellido;
                inputnombre.Value = oDuenio.nombre;
                inputdireccion.Value = oDuenio.direccion;
                inputtelefono.Value = oDuenio.telefono;
                inputmail.Value = oDuenio.mail;
                inputbanco.Value = oDuenio.banco;
                inputnumcuenta.Value = oDuenio.numerocuenta.ToString();
                CargarGrid(oDuenio);

            }
            

        }

        private void CargarGrid(Duenio oDuenio)
        {
            GridView1.DataSource = oDuenio.lcasa;
            GridView1.DataBind();
            GridView2.DataSource = oDuenio.ldepartamento;
            GridView2.DataBind();
            GridView3.DataSource = oDuenio.llocalcomercial;
            GridView3.DataBind();
        }
    }
}