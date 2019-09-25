using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Departamento : Inmuebles
    {
        private int Piso;
        private int Puerta;
        private int Balcones;
        private int Expensas;
        private int IdDepartamento;
        private int Ascensor;
        private int Cochera;
        private int Piscina;
        private int Portero;


        #region CONSTRUCTOR
        public Departamento()
        {

            this.Piso = 0;
            this.Puerta = 0;
            this.Balcones = 0;
            this.Expensas = 0;
            this.IdDepartamento = 0;
            this.Ascensor = 0;
            this.Cochera = 0;
            this.Piscina = 0;
            this.Portero = 0;

        }
        public Departamento(string direccion, int tamanio, int cantidadambiente, byte foto, string descripcion, int piso, int puerta, int balcones, int expensas, int iddepartamento, int ascensor, int cochera, int piscina, int portero) :base(direccion, tamanio, cantidadambiente, foto, descripcion)
        {

            this.Piso = piso;
            this.Puerta = puerta;
            this.Balcones = balcones;
            this.Expensas = expensas;
            this.IdDepartamento = iddepartamento;
            this.Ascensor = ascensor;
            this.Cochera = cochera;
            this.Piscina = piscina;
            this.Portero = portero;

        }

        #endregion


        #region Propiedades

        public int iddepartamento
        {
            get
            {
                return this.IdDepartamento;
            }
            set
            {
                this.IdDepartamento = value;
            }
        }

        public int piso
        {
            get
            {
                return this.Piso;
            }
            set
            {
                this.Piso = value;
            }
        }

        public int puerta
        {
            get
            {
                return this.Puerta;
            }
            set
            {
                this.Puerta = value;
            }
        }

        public int expensas
        {
            get
            {
                return this.Expensas;
            }
            set
            {
                this.Expensas = value;
            }
        }

        public int balcones
        {
            get
            {
                return this.Balcones;
            }
            set
            {
                this.Balcones = value;
            }
        }

        public int ascensor
        {
            get
            {
                return this.Ascensor;
            }
            set
            {
                this.Ascensor = value;
            }
        }

        public int cochera
        {
            get
            {
                return this.Cochera;
            }
            set
            {
                this.Cochera = value;
            }
        }

        public int pisina
        {
            get
            {
                return this.Piscina;
            }
            set
            {
                this.Piscina = value;
            }
        }

        public int portedo
        {
            get
            {
                return this.Portero;
            }
            set
            {
                this.Portero = value;
            }
        }
            
        #endregion
    }
}