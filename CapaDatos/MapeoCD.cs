using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatos
{
    public class MapeoCD
    {
        public List<CapaDatos.ENTIDADINQUILINO> RecuperarInquilino()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<CapaDatos.ENTIDADINQUILINO> Linquilino = new List<ENTIDADINQUILINO>();

            Linquilino = (from c in Mibase.ENTIDADINQUILINO select c).ToList();
            return Linquilino;

        }

        public List<CapaDatos.ENTIDADDUENIO> RecuperarDuenio()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<CapaDatos.ENTIDADDUENIO> LDuenio = new List<ENTIDADDUENIO>();

            LDuenio = (from c in Mibase.ENTIDADDUENIO select c).ToList();
            return LDuenio;

        }

        public List<CapaDatos.ENTIDADGARANTE> RecuperarGarante()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<CapaDatos.ENTIDADGARANTE> LGarante = new List<ENTIDADGARANTE>();

            LGarante = (from c in Mibase.ENTIDADGARANTE select c).ToList();
            return LGarante;

        }

        public List<CapaDatos.ENTIDADCASA> RecuperarCasa()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<CapaDatos.ENTIDADCASA> LCasa = new List<ENTIDADCASA>();

            LCasa = (from c in Mibase.ENTIDADCASA select c).ToList();
            return LCasa;

        }

        public List<CapaDatos.ENTIDADDEPARTAMENTO> RecuperarDepartamento()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<CapaDatos.ENTIDADDEPARTAMENTO> LDepartamento = new List<ENTIDADDEPARTAMENTO>();

            LDepartamento = (from c in Mibase.ENTIDADDEPARTAMENTO select c).ToList();
            return LDepartamento;

        }

        public List<CapaDatos.ENTIDADCONTRATOALQUILER> RecuperarContratoAlquiler()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<CapaDatos.ENTIDADCONTRATOALQUILER> LContratoAlquiler = new List<ENTIDADCONTRATOALQUILER>();

            LContratoAlquiler = (from c in Mibase.ENTIDADCONTRATOALQUILER select c).ToList();
            return LContratoAlquiler;

        }

        public List<CapaDatos.ENTIDADLOCALCOMERCIAL> RecuperarLocalComercial()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<CapaDatos.ENTIDADLOCALCOMERCIAL> LLocalComercial = new List<ENTIDADLOCALCOMERCIAL>();

            LLocalComercial = (from c in Mibase.ENTIDADLOCALCOMERCIAL select c).ToList();
            return LLocalComercial;

        }


        public List<CapaDatos.ENTIDADOTROS> RecuperarOtros()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<CapaDatos.ENTIDADOTROS> LOtros = new List<ENTIDADOTROS>();

            LOtros = (from c in Mibase.ENTIDADOTROS select c).ToList();
            return LOtros;

        }

        public List<CapaDatos.ENTIDADRECIBOSUELDO> RecuperarReciboSueldo()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<CapaDatos.ENTIDADRECIBOSUELDO> LReciboSueldo = new List<ENTIDADRECIBOSUELDO>();

            LReciboSueldo = (from c in Mibase.ENTIDADRECIBOSUELDO select c).ToList();
            return LReciboSueldo;

        }

        public void AltaAlquileres(ENTIDADCONTRATOALQUILER unalquiler)
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            Mibase.ENTIDADCONTRATOALQUILER.InsertOnSubmit(unalquiler);
            Mibase.SubmitChanges();
        }

        public List<CapaDatos.ENTIDADCONTRATOALQUILER> RecuperarAlquiler()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<CapaDatos.ENTIDADCONTRATOALQUILER> Lentidado = new List<ENTIDADCONTRATOALQUILER>();

            Lentidado = (from c in Mibase.ENTIDADCONTRATOALQUILER select c).ToList();
            return Lentidado;
        }

        
    }
}