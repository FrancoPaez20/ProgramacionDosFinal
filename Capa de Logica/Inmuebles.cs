using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_de_Logica
{
    public class Inmuebles
    {
        private string Direccion;
        private int Tamanio;
        private int CantidadAmbiente;
        private byte Foto;
        private string Descripcion;
        private Inquilino OInquilino;

        #region constructor
        public Inmuebles()
        {

            this.Direccion = "";
            this.Tamanio = 0;
            this.CantidadAmbiente = 0;
            this.Foto = 0 ;
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

    }
}