using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class LocalComercial : Inmuebles
    {
        private int CantidadOficinas;
        private int Banios;
        private int TamanioFrente;
        private int Cocina;
        private int IdLocal;

        #region CONSTRUCTOR
        public LocalComercial()
        {

            this.CantidadOficinas = 0;
            this.Banios = 0;
            this.TamanioFrente = 0;
            this.Cocina = 0;
            this.IdLocal = 0;

        }
        public LocalComercial(string direccion, int tamanio, int cantidadambiente, byte foto, string descripcion, int cantidadoficinas, int banios, int tamaniofrente, int cocina, int idlocal) : base(direccion, tamanio, cantidadambiente, foto, descripcion)
        {

            this.CantidadOficinas = cantidadoficinas;
            this.Banios = banios;
            this.TamanioFrente = tamaniofrente;
            this.Cocina = cocina;
            this.IdLocal = idlocal;

        }

        #endregion

        #region Propiedades

        public int idlocalcomercial
        {
            get
            {
                return this.IdLocal;
            }
            set
            {
                this.IdLocal = value;
            }
        }

        public int cantidadoficinas
        {
            get
            {
                return this.CantidadOficinas;
            }
            set
            {
                this.CantidadOficinas = value;
            }
        }

        public int banios
        {
            get
            {
                return this.Banios;
            }
            set
            {
                this.Banios = value;
            }
        }

        public int tamaniofrente
        {
            get
            {
                return this.TamanioFrente;
            }
            set
            {
                this.TamanioFrente = value;
            }
        }

        public int cocian
        {
            get
            {
                return this.Cocina;
            }
            set
            {
                this.Cocina = value;
            }
        }





        #endregion
    }

}