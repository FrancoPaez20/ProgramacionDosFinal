using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_da_Datos
{
    class MapeoCD
    {
        public List<Capa_da_Datos.ENTIDADINQUILINO> RecuperarInquilino()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<Capa_da_Datos.ENTIDADINQUILINO> Linquilino = new List<ENTIDADINQUILINO>();

            Linquilino = (from c in Mibase.ENTIDADINQUILINO select c).ToList();
            return Linquilino;

        }

        public List<Capa_da_Datos.ENTIDADDUENIO> RecuperarDuenio()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<Capa_da_Datos.ENTIDADDUENIO> LDuenio = new List<ENTIDADDUENIO>();

            LDuenio = (from c in Mibase.ENTIDADDUENIO select c).ToList();
            return LDuenio;

        }

        public List<Capa_da_Datos.ENTIDADGARANTE> RecuperarGarante()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<Capa_da_Datos.ENTIDADGARANTE> LGarante = new List<ENTIDADGARANTE>();

            LGarante = (from c in Mibase.ENTIDADGARANTE select c).ToList();
            return LGarante;

        }

        public List<Capa_da_Datos.ENTIDADCASA> RecuperarCasa()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<Capa_da_Datos.ENTIDADCASA> LCasa = new List<ENTIDADCASA>();

            LCasa = (from c in Mibase.ENTIDADCASA select c).ToList();
            return LCasa;

        }

        public List<Capa_da_Datos.ENTIDADDEPARTAMENTO> RecuperarDepartamento()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<Capa_da_Datos.ENTIDADDEPARTAMENTO> LDepartamento = new List<ENTIDADDEPARTAMENTO>();

            LDepartamento = (from c in Mibase.ENTIDADDEPARTAMENTO select c).ToList();
            return LDepartamento;

        }

        public List<Capa_da_Datos.ENTIDADCONTRATOALQUILER> RecuperarContratoAlquiler()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<Capa_da_Datos.ENTIDADCONTRATOALQUILER> LContratoAlquiler = new List<ENTIDADCONTRATOALQUILER>();

            LContratoAlquiler = (from c in Mibase.ENTIDADCONTRATOALQUILER select c).ToList();
            return LContratoAlquiler;

        }

        public List<Capa_da_Datos.ENTIDADLOCALCOMERCIAL> RecuperarLocalComercial()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<Capa_da_Datos.ENTIDADLOCALCOMERCIAL> LLocalComercial = new List<ENTIDADLOCALCOMERCIAL>();

            LLocalComercial = (from c in Mibase.ENTIDADLOCALCOMERCIAL select c).ToList();
            return LLocalComercial;

        }

     
        public List<Capa_da_Datos.ENTIDADOTROS> RecuperarOtros()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<Capa_da_Datos.ENTIDADOTROS> LOtros = new List<ENTIDADOTROS>();

            LOtros = (from c in Mibase.ENTIDADOTROS select c).ToList();
            return LOtros;

        }

        public List<Capa_da_Datos.ENTIDADRECIBOSUELDO> RecuperarReciboSueldo()
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            List<Capa_da_Datos.ENTIDADRECIBOSUELDO> LReciboSueldo = new List<ENTIDADRECIBOSUELDO>();

            LReciboSueldo = (from c in Mibase.ENTIDADRECIBOSUELDO select c).ToList();
            return LReciboSueldo;

        }

        public void AltaAlquileres(ENTIDADCONTRATOALQUILER unalquiler)
        {
            DataClasses1DataContext Mibase = new DataClasses1DataContext();
            Mibase.ENTIDADCONTRATOALQUILER.InsertOnSubmit(unalquiler);
            Mibase.SubmitChanges();
        } 

    }
}
