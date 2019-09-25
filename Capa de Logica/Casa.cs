using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_de_Logica
{
    public class Casa : Inmuebles
    {
        private int CantidadPisos;
        private int Habitaciones;
        private int Banios;
        private int TamanioPatio;
        private int TamanioJardin;
        private int IdCasa;

        #region

        public Casa() 
        {
            this.CantidadPisos = 0;
            this.Habitaciones = 0;
            this.Banios = 0;
            this.TamanioPatio = 0;
            this.TamanioJardin = 0;
            this.IdCasa = 0;

        }
        public Casa (string direccion, int tamanio, int cantidadambiente, byte foto, string descripcion, int id, int cantidadpisos, int habitaciones, int banios, int tamaniopatio, int tamaniojardin) :base(direccion,tamanio,cantidadambiente,foto,descripcion)
        {
            this.CantidadPisos = cantidadpisos;
            this.Habitaciones = habitaciones;
            this.Banios = banios;
            this.TamanioPatio = tamaniopatio;
            this.TamanioJardin = tamaniojardin;
            this.IdCasa = id;

        }

        #endregion

        #region
        public int idcasa
        {
            get
            {
                return this.IdCasa;
            }
            set
            {
                this.IdCasa = value;
            }
        }

        #endregion

    }
}