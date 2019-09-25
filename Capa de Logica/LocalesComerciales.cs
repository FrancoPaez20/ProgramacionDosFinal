using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_de_Logica
{
    public class LocalComercial : Inmuebles
    {
        private int CantidadOficinas;
        private int Banios;
        private int TanioFrente;
        private bool Cocina;
        private int IdLocal;

        #region CONSTRUCTOR
        public LocalComercial()
        {

            this.CantidadOficinas = 0;
            this.Banios = 0;
            this.TanioFrente = 0;
            this.Cocina = false;
            this.IdLocal = 0;

        }
        public LocalComercial(string direccion, int tamanio, int cantidadambiente, byte foto, string descripcion, int cantidadoficinas, int banios, int taniofrente, bool cocina, int idlocal) : base(direccion, tamanio, cantidadambiente, foto, descripcion)
        {

            this.CantidadOficinas = cantidadoficinas;
            this.Banios = banios;
            this.TanioFrente = taniofrente;
            this.Cocina = cocina;
            this.IdLocal = idlocal;

        }

        #endregion

        #region
        public int idlocalcomercial
        {
            get
            {
                return this.idlocalcomercial;
            }
            set
            {
                this.idlocalcomercial = value;
            }
        }

        #endregion
    }

}