using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace Cada_de_prensentacion
{
    public partial class Index : System.Web.UI.Page
    {
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
        protected void Page_Load(object sender, EventArgs e)
        {//imuebles oinquilinos no se usa
            if (!IsPostBack)
            {
               
                MapeoCL omapeo = new MapeoCL();
                LDuenio = omapeo.RecuperarDuenio();
                LGarante = omapeo.RecuperarGarante();
                LInquilino = omapeo.RecuperarInquilino();
                Lcasa = omapeo.RecuperarCasa();
                LDepartamento = omapeo.RecuperarDepartamento();
                LLocalComercial = omapeo.RecuperarLocalComercial();
                LReciboSueldo = omapeo.RecuperarReciboSueldo();
                LContratoAlquiler = omapeo.RecuperarContratoAlquiler();
                List<Duenio> LnDuenio = omapeo.Recuperarcasaduenio(LDuenio, Lcasa);// LnDuenio lista nueva para no sobreescribir la anterior
                LnDuenio = omapeo.Recuperardepartamentoduenio(LDuenio, LDepartamento);
                LnDuenio = omapeo.Recuperarlocalduenio(LDuenio, LLocalComercial);
                List<Garante> LNGarante = omapeo.RecuperarRecibosSueldo(LGarante, LReciboSueldo);
                List<ContratoAlquiler> LnContrato = omapeo.RecuperarContratocasa(LContratoAlquiler, Lcasa);
                LnContrato = omapeo.RecuperarContratodepartamento(LContratoAlquiler, LDepartamento);
                LnContrato = omapeo.RecuperarContratoLlocalcomercial(LContratoAlquiler, LLocalComercial);
                omapeo.RecuperarContratoduenio(LContratoAlquiler, LDuenio);
                omapeo.RecuperarContratoinquilino(LContratoAlquiler, LInquilino);
                omapeo.RecuperarContratoGarante(LContratoAlquiler, LGarante);
                omapeo.RecuperarInquilinoGarante(LInquilino, LGarante);
                
            }
            CargarTablas();
        }

        public void CargaBoton(){
            if (Page.IsValid)
            {
                
                //validar
                int meses= 0; // input mes
                int idinmueble= 0; //recuperar el id del inmueble
                DateTime Inicio= DateTime.Parse("15/02/1995"); //input fecha
                string precio = "0";
                int idcontrato = LContratoAlquiler.Last().idcontrato + 1;// Aca tenes que buscar la id del anterior de la lista
                Casa oCasa = Lcasa.Find(x => x.idcasa == idinmueble);
                Departamento oDepartamento = LDepartamento.Find(x => x.iddepartamento == idinmueble);
                LocalComercial oLocal = LLocalComercial.Find(x => x.idlocalcomercial == idinmueble);
                int dni = 0; //Valor del input 
                ContratoAlquiler oAlquiler = new ContratoAlquiler(meses, Inicio, idcontrato, precio);

                Inquilino inquilino = LInquilino.Find(x => x.dni == dni);

                int obtenergarante = 0; //DNI del Garante 

                Garante oGarente = LGarante.Find(x => x.dni == obtenergarante);

                oAlquiler.ogarante = oGarente;
                oAlquiler.oinquilino = inquilino;

                if (oCasa != null)
                {
                    oAlquiler.ocasa = oCasa;
                    Duenio oDuenio = new Duenio();
                    foreach(Duenio x in LDuenio)
                    {
                        if(x.lcasa.Exists(t => t.idcasa == oCasa.idcasa))
                        {
                            oDuenio = x;

                        }
                            
                    }

                    oAlquiler.oduenio = oDuenio;

                }

                if (oDepartamento != null)
                {
                    oAlquiler.odepartamento = oDepartamento;
                    Duenio oDuenio = new Duenio();
                    foreach (Duenio x in LDuenio)
                    {
                        if (x.ldepartamento.Exists(t => t.iddepartamento == oDepartamento.iddepartamento))
                        {
                            oDuenio = x;

                        }

                    }

                    oAlquiler.oduenio = oDuenio;

                }

                if (oLocal != null)
                {
                    oAlquiler.olocalcomercial = oLocal;
                    Duenio oDuenio = new Duenio();
                    foreach (Duenio x in LDuenio)
                    {
                        if (x.llocalcomercial.Exists(t => t.idlocalcomercial == oLocal.idlocalcomercial))
                        {
                            oDuenio = x;

                        }

                    }

                    oAlquiler.oduenio = oDuenio;

                }

            }

        }

        protected void buscarduenios(object sender, EventArgs e)
        {
            int DNI = int.Parse(midni.Value);
            Duenio oDuenio = LDuenio.Find(x => x.dni == DNI);
            if (oDuenio != null)
            {
                inputapellido.Value = oDuenio.apellido;
                inputnombre.Value = oDuenio.nombre;
                inputdireccion.Value = oDuenio.direccion;
                inputtelefono.Value = oDuenio.telefono;
                inputmail.Value = oDuenio.mail;
                inputbanco.Value = oDuenio.banco;
                inputnumcuenta.Value = oDuenio.numerocuenta.ToString();

            }

        }

        protected void buscarinquilinos(object sender, EventArgs e)
        {
            int DNI = int.Parse(midni1.Value);
            Inquilino oInquilino = LInquilino.Find(x => x.dni == DNI);
            Text1.Value = oInquilino.apellido;
            Text2.Value = oInquilino.nombre;
            Text3.Value = oInquilino.direccion;
            Text4.Value = oInquilino.telefono;
            Text5.Value = oInquilino.mail;


            text6.Value = oInquilino.ogarante.dni.ToString();
            text7.Value = oInquilino.ogarante.apellido;
            text8.Value = oInquilino.ogarante.nombre;
            text9.Value = oInquilino.ogarante.direccion;
            text10.Value = oInquilino.ogarante.telefono;
            text11.Value = oInquilino.ogarante.mail;
            text12.Value = oInquilino.ogarante.empleo;

        }


        protected void CargarCasa(object sender, EventArgs e)
        {
            txtinmueble.Value = GridView1.SelectedRow.Cells[1].Text;

        }

        protected void CargarDepartamento(object sender, EventArgs e)
        {
            txtinmueble.Value= GridView2.SelectedRow.Cells[1].Text;

        }

        protected void CargarLocalComercial(object sender, EventArgs e)
        {
            txtinmueble.Value = GridView3.SelectedRow.Cells[1].Text;

        }

        public void CargarTablas()
        {
            List<Casa> Lcasaaux = Lcasa;
            foreach (ContratoAlquiler contrato in LContratoAlquiler)
            {
                if (Lcasaaux.Exists(x => x == contrato.ocasa))
                {
                    Lcasaaux.Remove(contrato.ocasa);
                }

            }

            GridView1.DataSource = Lcasaaux;
            GridView1.DataBind();

            List<Departamento> Ldepartamentoaux = LDepartamento;
            foreach (ContratoAlquiler contrato in LContratoAlquiler)
            {
                if (Ldepartamentoaux.Exists(x => x == contrato.odepartamento))
                {
                    Ldepartamentoaux.Remove(contrato.odepartamento);
                }

            }

            GridView2.DataSource = Ldepartamentoaux;
            GridView2.DataBind();

            List<LocalComercial> Llocalcomercialaux = LLocalComercial;
            foreach (ContratoAlquiler contrato in LContratoAlquiler)
            {
                if (Llocalcomercialaux.Exists(x => x== contrato.olocalcomercial))
                {
                    Llocalcomercialaux.Remove(contrato.olocalcomercial);
                }

            }

            GridView3.DataSource = Llocalcomercialaux;
            GridView3.DataBind();
        }

        public void CargaBoton(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {

                //validar
                int meses = int.Parse(mesesalquiler.Value); // input mes

                int idinmueble = int.Parse(txtinmueble.Value); //recuperar el id del inmueble
                DateTime Inicio = DateTime.Parse(fechaAlquiler.Value); //input fecha
                int idcontrato;
                if (LContratoAlquiler.Count == 0)
                {
                    idcontrato = 1;
                }
                else
                {
                    idcontrato = LContratoAlquiler.Last().idcontrato + 1;

                }
                // Aca tenes que buscar la id del anterior de la lista
                Casa oCasa = Lcasa.Find(x => x.idcasa == idinmueble);
                Departamento oDepartamento = LDepartamento.Find(x => x.iddepartamento == idinmueble);
                LocalComercial oLocal = LLocalComercial.Find(x => x.idlocalcomercial == idinmueble);
                string dnis = midni1.Value;
                int dni = int.Parse(dnis);//valor del input
                Inquilino oInquilino = LInquilino.Find(x => x.dni == dni);
                
                int obtenerGarante = int.Parse(text6.Value);//poner dni de garante

                Garante oGarante = LGarante.Find(x => x.dni == obtenerGarante);
                string precio = precioalquiler.Value;
                ContratoAlquiler oAlquiler = new ContratoAlquiler(meses, Inicio, idcontrato, precio);
                oAlquiler.oinquilino = oInquilino;
                oAlquiler.ogarante = oGarante;

                
                Casa casa = new Casa();
                oAlquiler.ocasa = casa;
                Departamento dep = new Departamento();
                oAlquiler.odepartamento = dep;
                LocalComercial Local = new LocalComercial();
                oAlquiler.olocalcomercial = Local;



                if (oCasa != null)
                {

                    oAlquiler.ocasa = oCasa;

                    Duenio oDuenio = new Duenio();
                    foreach (Duenio x in LDuenio)
                    {
                        if (x.lcasa.Exists(t => t.idcasa == oCasa.idcasa))
                        {
                            oDuenio = x;


                        }

                    }
                    oAlquiler.oduenio = oDuenio;


                }

                if (oDepartamento != null)
                {

                    oAlquiler.odepartamento = oDepartamento;
                    Duenio oDuenio = new Duenio();
                    foreach (Duenio x in LDuenio)
                    {
                        if (x.ldepartamento.Exists(t => t.iddepartamento == oDepartamento.iddepartamento))
                        {
                            oDuenio = x;


                        }

                    }
                    oAlquiler.oduenio = oDuenio;


                }

                if (oLocal != null)
                {

                    oAlquiler.olocalcomercial = oLocal;
                    Duenio oDuenio = new Duenio();
                    foreach (Duenio x in LDuenio)
                    {
                        if (x.llocalcomercial.Exists(t => t.idlocalcomercial == oLocal.idlocalcomercial))
                        {
                            oDuenio = x;


                        }

                    }
                    oAlquiler.oduenio = oDuenio;


                }


                LContratoAlquiler.Add(oAlquiler);
                MapeoCL oMapeo = new MapeoCL();
                oMapeo.GuardarAltaAlquiler(oAlquiler);
            }

        }
    }
}