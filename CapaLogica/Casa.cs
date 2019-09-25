using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Casa : Inmuebles
    {
        private int CantidadPisos;
        private int Habitaciones;
        private int Banios;
        private int TamanioPatio;
        private int TamanioJardin;
        private int IdCasa;

        #region constructor

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

        #region propiedades

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

        public int cantidadpisos
        {
            get
            {
                return this.CantidadPisos;
            }
            set
            {
                this.CantidadPisos = value;
            }
        }

        public int habitaciones
        {
            get
            {
                return this.Habitaciones;
            }
            set
            {
                this.Habitaciones = value;
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

        public int tamaniopatio
        {
            get
            {
                return this.TamanioPatio;
            }
            set
            {
                this.TamanioPatio = value;
            }
        }

        public int tamaniojardin
        {
            get
            {
                return this.TamanioJardin;
            }
            set
            {
                this.TamanioJardin = value;
            }
        }

        #endregion

    }
}