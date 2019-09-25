using System.Collections.Generic;
using System;
using CapaDatos;

namespace Capa_de_Logica
{
    public class MapeoCL
    {
        public List<Inquilino> RecuperarInquilino() //INQUILINO
        {
            MapeoCD oMapeo = new MapeoCD();
            List<Inquilino> LisObjetosInquilino = new List<Inquilino>();
            List<CapaDatos.ENTIDADINQUILINO> LisEntidadInquilino = oMapeo.RecuperarInquilino();
            Inquilino oInquilino;
            foreach (CapaDatos.ENTIDADINQUILINO entidad in LisEntidadInquilino)
            {
                if (entidad.Nombre != "")
                {

                    string apellido = entidad.Apellido;
                    string nombre = entidad.Nombre;
                    int dni = int.Parse(entidad.DNI);
                    string direccion = entidad.Direccion;
                    string mail = entidad.Mail;
                    int telefono = int.Parse (entidad.Telefono);
                    int id = entidad.IdInquilino;

                    oInquilino = new Inquilino(nombre, apellido, direccion, telefono, mail, dni, id);
                    LisObjetosInquilino.Add(oInquilino);
                                                         
                }

            }

            return LisObjetosInquilino;           

        }

        public List<Duenio> RecuperarDuenio() //DUENIO
        {
            MapeoCD oMapeo = new MapeoCD();
            List<Duenio> LisObjetoDuenio = new List<Duenio>();
            List<CapaDatos.ENTIDADDUENIO> LisEntidadDuenio = oMapeo.RecuperarDuenio();
            Duenio oDuenio;
            foreach(CapaDatos.ENTIDADDUENIO entidad in LisEntidadDuenio)
            {

                if (entidad.Nombre != "")
                {

                    string apellido = entidad.Apellido;
                    string nombre = entidad.Nombre;
                    int dni = int.Parse(entidad.DNI);
                    string direccion = entidad.Direccion;
                    string mail = entidad.Mail;
                    int telefono = int.Parse(entidad.Telefono);
                    int id = entidad.IdDuenio;
                    string banco = entidad.Banco;
                    int numerocuenta = int.Parse(entidad.NumeroCuenta);

                    oDuenio = new Duenio(nombre, apellido, direccion, telefono, mail, dni, banco, numerocuenta, id);
                    LisObjetoDuenio.Add(oDuenio);

                }
            }
            return LisObjetoDuenio;

        }

        public List<Garante> RecuperarGarante() //GARANTE
        {
            MapeoCD oMapeo = new MapeoCD();
            List<Garante> LisObjetoGarante = new List<Garante>();
            List<CapaDatos.ENTIDADGARANTE> LisEntidadGarante = new List<ENTIDADGARANTE>();
            Garante oGarante;
            foreach(CapaDatos.ENTIDADGARANTE entidad in LisEntidadGarante)
            {
                if (entidad.Nombre != "")
                {
                    string apellido = entidad.Apellido;
                    string nombre = entidad.Nombre;
                    int dni = int.Parse(entidad.DNI);
                    string direccion = entidad.Direccion;
                    string mail = entidad.Mail;
                    int telefono = int.Parse(entidad.Telefono);
                    int id = entidad.IdGarante;
                    string empleo = entidad.Empleo;

                    oGarante = new Garante(nombre, apellido, direccion, telefono, mail, dni, empleo, id);
                    LisObjetoGarante.Add(oGarante);
                }

            }
            return LisObjetoGarante;

        }

        public List<Casa> RecuperarCasa() //CASA
        {
            MapeoCD oMapeo = new MapeoCD();
            List<Casa> LisObjetoCasa = new List<Casa>();
            List<CapaDatos.ENTIDADCASA> LisEntidadCasa = new List<ENTIDADCASA>();
            Casa oCasa;
            foreach(CapaDatos.ENTIDADCASA entidad in LisEntidadCasa)
            {
                if (entidad.Descipcion != "")
                {
                    string descripcion = entidad.Descipcion;
                    string direccion = entidad.Direccion;
                    int tamanio = int.Parse(entidad.Tamanio);
                    int banios = int.Parse(entidad.Banios);
                    int cantidadpisos = int.Parse(entidad.CantidadPisos);
                    int habitaciones = int.Parse(entidad.Habitaciones);
                    int tamaniojardin = int.Parse(entidad.TamanioJardin);
                    int tamaniopatio = int.Parse(entidad.TamanioPatio);
                    byte foto = 0; //ver esto
                    int id = entidad.IdCasa;
                    int cantidadambiente = int.Parse(entidad.CantidadAmbientes);


                    oCasa = new Casa(direccion, tamanio, cantidadambiente, foto, descripcion, id, cantidadpisos, habitaciones, banios, tamaniopatio, tamaniojardin);
                    LisObjetoCasa.Add(oCasa);

                }

            }
            return LisObjetoCasa;
        }

        public List<Departamento> RecuperarDepartamento() //DEPARTAMNETO
        {
            MapeoCD oMapeo = new MapeoCD();
            List<Departamento> LisObjetosDepartamento = new List<Departamento>();
            List<CapaDatos.ENTIDADDEPARTAMENTO> LisEntidadDepartamento = new List<ENTIDADDEPARTAMENTO>();
            Departamento oDepartamento; 
            foreach (CapaDatos.ENTIDADDEPARTAMENTO entidad in LisEntidadDepartamento)
            {
                if (entidad.Direccion != "")
                {

                    string descripcion = entidad.Descipcion;
                    string direccion = entidad.Direccion;
                    int tamanio = int.Parse(entidad.Tamanio);
                    int cantidadambiente = int.Parse(entidad.CantidadAmbientes);
                    byte foto = 0; //ver esto
                    int piso= int.Parse(entidad.Piso);
                    int puerta = int.Parse(entidad.Puerta);
                    bool balcones = bool.Parse(entidad.Balcones);
                    int expensas = int.Parse(entidad.Expensas);
                    int iddepartamento = entidad.IdDepartamento;
                    bool ascensor = bool.Parse(entidad.asensor);
                    bool cochera = bool.Parse(entidad.cochera);
                    bool piscina = bool.Parse(entidad.piscina);
                    bool portero = bool.Parse(entidad.portero);

                    oDepartamento = new Departamento (direccion, tamanio, cantidadambiente, foto, descripcion, piso, puerta, balcones, expensas, iddepartamento, ascensor, cochera, piscina, portero);
                    LisObjetosDepartamento.Add(oDepartamento);

                }               

            }

            return LisObjetosDepartamento;

        }

        public List<ContratoAlquiler> RecuperarContratoAlquiler() //CONTRATO ALQUILER 
        {
            MapeoCD oMapeo = new MapeoCD();
            List<ContratoAlquiler> LisObjetosContratoAlquiler = new List<ContratoAlquiler>();
            List<CapaDatos.ENTIDADCONTRATOALQUILER> LisEntidadcontratoAlquiler = new List<ENTIDADCONTRATOALQUILER>();
            ContratoAlquiler oContratoAlquiler;
            foreach (CapaDatos.ENTIDADCONTRATOALQUILER entidad in LisEntidadcontratoAlquiler)
            {
                if (entidad.IdGarante != null)
                {
                    int meses = int.Parse(entidad.Meses.ToString());
                    DateTime fecha = DateTime.Parse(entidad.FechaInicio.ToString());
                    int idcontrato = entidad.IdContratoAlquiler;


                    oContratoAlquiler = new ContratoAlquiler(meses, fecha, idcontrato);
                    LisObjetosContratoAlquiler.Add(oContratoAlquiler);
                }

            }

            return LisObjetosContratoAlquiler;

        }

        public List<LocalComercial> RecuperarLocalComercial() //CONTRATO LOCAL COMERCIAL
        {
            MapeoCD oMapeo = new MapeoCD();
            List<LocalComercial> LisObjetosLocalComercial = new List<LocalComercial>();
            List<CapaDatos.ENTIDADLOCALCOMERCIAL> LisEntidad = new List<ENTIDADLOCALCOMERCIAL>();
            LocalComercial oLocalComercial;
            foreach (CapaDatos.ENTIDADLOCALCOMERCIAL entidad in LisEntidad)
            {
                if (entidad.TamanioFente != null)
                {

                    int cantidadoficinas = int.Parse(entidad.CantidadOficinas);
                    int banios = int.Parse(entidad.Banios);
                    int taniofrente = int.Parse(entidad.TamanioFente);
                    bool cocina = bool.Parse(entidad.Cocina);
                    int tamanio = int.Parse(entidad.Tamnio);
                    int cantidadambiente = int.Parse(entidad.CantidadAmbientes);
                    string direccion = entidad.Direccion;
                    byte foto = 0; //ver esto
                    string descripcion = entidad.Descripcion;
                    int idlocal = entidad.IdLocalComercial;


                    oLocalComercial = new LocalComercial(direccion, tamanio, cantidadambiente, foto, descripcion, cantidadoficinas, banios, taniofrente, cocina, idlocal);
                    LisObjetosLocalComercial.Add(oLocalComercial);
                }

            }

            return LisObjetosLocalComercial;

        }

        public List<ReciboSueldo> RecuperarReciboSueldo() //RECIBO SUELDO
        {
            MapeoCD oMapeo = new MapeoCD();
            List<ReciboSueldo> LisObjetosResiboSueldo = new List<ReciboSueldo>();
            List<CapaDatos.ENTIDADRECIBOSUELDO> LisEntidad = new List<ENTIDADRECIBOSUELDO>();
            ReciboSueldo oReciboSueldo;
            foreach (CapaDatos.ENTIDADRECIBOSUELDO entidad in LisEntidad)
            {
                if (entidad.Detalle != "")
                {

                    string detalle = entidad.Detalle;
                    int sueldo = int.Parse(entidad.Sueldo);
                    int idsueldo = entidad.IdReciboSueldo;


                    oReciboSueldo = new ReciboSueldo(detalle, sueldo, idsueldo);
                    LisObjetosResiboSueldo.Add(oReciboSueldo);
                }

            }

            return LisObjetosResiboSueldo;

        }

        public List<Duenio> Recuperarcasaduenio (List<Duenio> Lduenio, List<Casa> Lcasa)
        {
            MapeoCD oMapeoCD = new MapeoCD();
            List<CapaDatos.ENTIDADCASA> Lentidad = oMapeoCD.RecuperarCasa();
            Duenio oDuenio;
            Casa oCasa;
            List<Duenio> Lduenios = new List<Duenio>();

            foreach (CapaDatos.ENTIDADCASA entidad in Lentidad)
            {
                oDuenio = Lduenio.Find(x => x.idduenio == entidad.IdDuenio);
                oCasa = Lcasa.Find(x => x.idcasa == entidad.IdCasa);

                if (oCasa.idcasa != 0)
                {
                    oDuenio.lcasa.Add(oCasa);
                    Lduenios.Add(oDuenio);
                }

            }

            return Lduenios;
                       
        }

        public List<Duenio> Recuperarcasaduenio(List<Duenio> Lduenio, List<Departamento> Ldepartamento)
        {
            MapeoCD oMapeoCD = new MapeoCD();
            List<CapaDatos.ENTIDADDEPARTAMENTO> Lentidad = oMapeoCD.RecuperarDepartamento();
            Duenio oDuenio;
            Departamento oDepartamento;
            List<Duenio> Lduenios = new List<Duenio>();

            foreach (CapaDatos.ENTIDADDEPARTAMENTO entidad in Lentidad)
            {
                oDuenio = Lduenio.Find(x => x.idduenio == entidad.IdDuenio);
                oDepartamento = Ldepartamento.Find(x => x.iddepartamento == entidad.IdDepartamento);

                if (oDepartamento.iddepartamento != 0)
                {
                    oDuenio.ldepartamento.Add(oDepartamento);
                    Lduenios.Add(oDuenio);
                }

            }

            return Lduenios;

        }


        public List<Duenio> Recuperarcasaduenio(List<Duenio> Lduenio, List<LocalComercial> Llocalcomercial)
        {
            MapeoCD oMapeoCD = new MapeoCD();
            List<CapaDatos.ENTIDADLOCALCOMERCIAL> Lentidad = oMapeoCD.RecuperarLocalComercial();
            Duenio oDuenio;
            LocalComercial oLocalComercial;
            List<Duenio> Lduenios = new List<Duenio>();

            foreach (CapaDatos.ENTIDADLOCALCOMERCIAL entidad in Lentidad)
            {
                oDuenio = Lduenio.Find(x => x.idduenio == entidad.IdDuenio);
                oLocalComercial = Llocalcomercial.Find(x => x.idlocalcomercial == entidad.IdLocalComercial);

                if (oLocalComercial.idlocalcomercial != 0)
                {
                    oDuenio.llocalcomercial.Add(oLocalComercial);
                    Lduenios.Add(oDuenio);
                }

            }

            return Lduenios;

        }

        public List<Garante> RecuperarReciboSueldo(List<Garante> Lgarante, List<ReciboSueldo> Lrecibosueldo)
        {
            MapeoCD oMapeoCD = new MapeoCD();
            List<CapaDatos.ENTIDADRECIBOSUELDO> Lentidad = oMapeoCD.RecuperarReciboSueldo(); //ver esto con NICO
            Garante oGarente;
            ReciboSueldo oReciboSueldo;
            List<Garante> Lgarantes = new List<Garante>();

            foreach (CapaDatos.ENTIDADRECIBOSUELDO entidad in Lentidad)
            {
                oGarente = Lgarante.Find(x => x.idgarante == int.Parse(entidad.IdGarante));
                oReciboSueldo = Lrecibosueldo.Find(x => x.idsueldo == entidad.IdReciboSueldo);

                if (oReciboSueldo.idsueldo != 0)
                {
                    oGarente.lrecibosueldo.Add(oReciboSueldo);
                    Lgarantes.Add(oGarente);
                }

            }

            return Lgarantes;

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<ContratoAlquiler> RecuperarContratoAlquiler(List<ContratoAlquiler> Lcontratoalquiler, List<Casa> Lcasa)
        {
            MapeoCD oMapeoCD = new MapeoCD();
            List<CapaDatos.ENTIDADCONTRATOALQUILER> Lentidad = oMapeoCD.RecuperarContratoAlquiler();
            ContratoAlquiler OContratoAlquiler;
            Casa oCasa;
            List<ContratoAlquiler> Lcontratoalquileres = new List<ContratoAlquiler>();

            foreach (CapaDatos.ENTIDADCONTRATOALQUILER entidad in Lentidad)
            {
                OContratoAlquiler = Lcontratoalquiler.Find(x => x.idcontrato == entidad.IdContratoAlquiler);
                oCasa = Lcasa.Find(x => x.idcasa == entidad.IdInmueble);

                if (OContratoAlquiler.idcontrato != 0)
                {
                    OContratoAlquiler.ocasa = oCasa;
                    Lcontratoalquiler.Add(OContratoAlquiler);
                }

            }

            return Lcontratoalquileres;

        }

        public List<ContratoAlquiler> RecuperarContratoAlquiler(List<ContratoAlquiler> Lcontratoalquiler, List<Departamento> Ldepartamento)
        {
            MapeoCD oMapeoCD = new MapeoCD();
            List<CapaDatos.ENTIDADCONTRATOALQUILER> Lentidad = oMapeoCD.RecuperarContratoAlquiler();
            ContratoAlquiler OContratoAlquiler;
            Departamento oDepartamento;
            List<ContratoAlquiler> Lcontratoalquileres = new List<ContratoAlquiler>();

            foreach (CapaDatos.ENTIDADCONTRATOALQUILER entidad in Lentidad)
            {
                OContratoAlquiler = Lcontratoalquiler.Find(x => x.idcontrato == entidad.IdContratoAlquiler);
                oDepartamento = Ldepartamento.Find(x => x.iddepartamento == entidad.IdInmueble);

                if (OContratoAlquiler.idcontrato != 0)
                {
                    OContratoAlquiler.odepartamento = oDepartamento;
                    Lcontratoalquiler.Add(OContratoAlquiler);
                }

            }

            return Lcontratoalquileres;

        }

        public List<ContratoAlquiler> RecuperarContratoAlquiler(List<ContratoAlquiler> Lcontratoalquiler, List<LocalComercial> Llocalcomercial)
        {
            MapeoCD oMapeoCD = new MapeoCD();
            List<CapaDatos.ENTIDADCONTRATOALQUILER> Lentidad = oMapeoCD.RecuperarContratoAlquiler();
            ContratoAlquiler OContratoAlquiler;
            LocalComercial oLocalComercial;
            List<ContratoAlquiler> Lcontratoalquileres = new List<ContratoAlquiler>();

            foreach (CapaDatos.ENTIDADCONTRATOALQUILER entidad in Lentidad)
            {
                OContratoAlquiler = Lcontratoalquiler.Find(x => x.idcontrato == entidad.IdContratoAlquiler);
                oLocalComercial = Llocalcomercial.Find(x => x.idlocalcomercial == entidad.IdInmueble);

                if (OContratoAlquiler.idcontrato != 0)
                {
                    OContratoAlquiler.olocalcomercial = oLocalComercial;
                    Lcontratoalquiler.Add(OContratoAlquiler);
                }

            }

            return Lcontratoalquileres;

        }

        public void GuardarAltaAlquiler(ContratoAlquiler oContratoAlquiler)
        {

            ENTIDADCONTRATOALQUILER entidad = new ENTIDADCONTRATOALQUILER();
            entidad.IdContratoAlquiler = oContratoAlquiler.idcontrato;
            Garante oGarante = oContratoAlquiler.ogarante;
            entidad.IdGarante = oGarante.idgarante;

            Inquilino oInquilino = oContratoAlquiler.oinquilino;
            entidad.IdInquilino = oInquilino.idinquilino;

            Duenio oDuenio = oContratoAlquiler.oduenio;
            entidad.IdDuenio = oDuenio.idduenio;

            Casa oCasa = oContratoAlquiler.ocasa;
            if (oCasa.idcasa == 0)
            {
                entidad.IdInmueble = oCasa.idcasa;
            }

            Departamento oDepartamento = oContratoAlquiler.odepartamento;
            if (oDepartamento.iddepartamento == 0)
            {
                entidad.IdInmueble = oDepartamento.iddepartamento;
            }

            LocalComercial oLocalComercial = oContratoAlquiler.olocalcomercial;
            if (oLocalComercial.idlocalcomercial == 0)
            {
                entidad.IdInmueble = oLocalComercial.idlocalcomercial;
            }



        }

    }
}
