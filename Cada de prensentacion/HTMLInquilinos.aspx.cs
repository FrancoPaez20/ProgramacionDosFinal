using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace Cada_de_prensentacion
{
    public partial class HTMLInquilinos : System.Web.UI.Page
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

        protected void buscarinquilinos(object sender, EventArgs e)
        {
            int DNI = int.Parse(midni.Value);
            Inquilino oInquilino = LInquilino.Find(x => x.dni == DNI);
            inputapellido.Value = oInquilino.apellido;
            inputnombre.Value = oInquilino.nombre;
            inputdireccion.Value = oInquilino.direccion;
            inputtelefono.Value = oInquilino.telefono;
            inputmail.Value = oInquilino.mail;

            CargarGrid(oInquilino);

        }

        private void CargarGrid(Inquilino oInquilino)
        {
            List<ContratoAlquiler> LcontratoIquilino = new List<ContratoAlquiler>();
            LcontratoIquilino = LContratoAlquiler.FindAll(x => x.oinquilino.idinquilino == oInquilino.idinquilino);

            List<Casa> ListaCasa = new List<Casa>();

            List<Departamento> ListaDepartamento = new List<Departamento>();

            List<LocalComercial> ListaLocalComercial = new List<LocalComercial>();

            foreach(ContratoAlquiler oContratoAlquiler in LcontratoIquilino){

                ListaCasa.Add(oContratoAlquiler.ocasa);
                if (oContratoAlquiler.odepartamento != null)
                {
                    ListaDepartamento.Add(oContratoAlquiler.odepartamento);
                }

                if (oContratoAlquiler.olocalcomercial != null)
                {
                    ListaLocalComercial.Add(oContratoAlquiler.olocalcomercial);
                }
                
            }
            if (ListaCasa.Count != 0)
            {
                GridView1.DataSource = ListaCasa;
                GridView1.DataBind();
            }
            if (ListaDepartamento.Count != 0)
            {
                GridView2.DataSource = ListaDepartamento;
                GridView2.DataBind();
            }
            
            if (ListaLocalComercial.Count != 0)
            {
                GridView3.DataSource = ListaDepartamento;
                GridView3.DataBind();
            }
            
        }
    }
}