using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Inmuebles
    {
        private string Direccion;
        private int Tamanio;
        private int CantidadAmbiente;
        private byte Foto;  //no tenemos este
        private string Descripcion;

        #region constructor
        public Inmuebles()
        {

            this.Direccion = "";
            this.Tamanio = 0;
            this.CantidadAmbiente = 0;
            this.Foto = 0;
            this.Descripcion = "";
        }

        public Inmuebles(string direccion, int tamanio, int cantidadambiente, byte foto, string descripcion)
        {

            this.Direccion = direccion;
            this.Tamanio = tamanio;
            this.CantidadAmbiente = cantidadambiente;
            this.Foto = foto;
            this.Descripcion = descripcion;
        }

        #endregion

        #region Propiedades

        public string direccion
        {

            get
            {
                return this.Direccion;
            }

            set
            {
                this.Direccion = value;
            }

        }

        public int tamanio
        {

            get
            {
                return this.Tamanio;
            }

            set
            {
                this.Tamanio = value;
            }

        }

        public int cantidadambiente
        {

            get
            {
                return this.CantidadAmbiente;
            }

            set
            {
                this.CantidadAmbiente = value;
            }

        }

        public string descripcion
        {

            get
            {
                return this.Descripcion;
            }

            set
            {
                this.Descripcion = value;
            }

        }

        #endregion

    }
}