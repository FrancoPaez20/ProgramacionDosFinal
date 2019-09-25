using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_de_Logica
{
    public class Departamento : Inmuebles
    {
        private int Piso;
        private int Puerta;
        private bool Balcones;
        private int Expensas;
        private int IdDepartamento;
        private bool Ascensor;
        private bool Cochera;
        private bool Piscina;
        private bool Portero;


        #region CONSTRUCTOR
        public Departamento()
        {

            this.Piso = 0;
            this.Puerta = 0;
            this.Balcones = false;
            this.Expensas = 0;
            this.IdDepartamento = 0;
            this.Ascensor = false;
            this.Cochera = false;
            this.Piscina = false;
            this.Portero = false;

        }
        public Departamento(string direccion, int tamanio, int cantidadambiente, byte foto, string descripcion, int piso, int puerta, bool balcones, int expensas, int iddepartamento, bool ascensor, bool cochera, bool piscina, bool portero) :base(direccion, tamanio, cantidadambiente, foto, descripcion)
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


        #region
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

        #endregion
    }
}