using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class ContratoAlquiler
    {
        private Inquilino OInquilino;
        private Garante OGarante; 
        private Duenio ODuenio; 
        private int Meses;
        private DateTime FechaInicio;
        private int IdContrato;
        private Casa Ocasa;
        private Departamento Odepartamento;
        private LocalComercial Olocal;
        private string Precio;

        #region contstructor

        public ContratoAlquiler()
        {
            this.Meses = 0;
            this.FechaInicio = DateTime.Parse("0000 - 00 - 00");
            this.IdContrato = 0;
            Inquilino oInquilino = new Inquilino();
            this.OInquilino = oInquilino;
            Garante oGarante = new Garante();
            this.OGarante = oGarante;
            this.ODuenio = new Duenio();
            this.Ocasa = new Casa();
            this.Odepartamento = new Departamento();
            this.Olocal = new LocalComercial();
            this.Precio = string.Empty;


        }

        public ContratoAlquiler(int meses, DateTime fechainicio, int idcontrato, string precio)
        {
            this.Meses = meses;
            this.FechaInicio = fechainicio;
            this.IdContrato = idcontrato;
            this.Precio = precio;
            Inquilino oInquilino = new Inquilino();
            this.OInquilino = oInquilino;
            Garante oGarante = new Garante();
            this.OGarante = oGarante;
            this.ODuenio = new Duenio();
            this.Ocasa = new Casa();
            this.Odepartamento = new Departamento();
            this.Olocal = new LocalComercial();


        }

        #endregion

        #region propiedades

        public string precio
        {

            get
            {

                return this.Precio;

            }

            set
            {

                this.Precio = value;

            }

        }

        public DateTime fechainicio
        {
            get
            {
                return this.FechaInicio;
            }
            set
            {
                this.FechaInicio = value;
            }
        }

        public int idcontrato
        {
            get
            {
                return this.IdContrato;
            }
            set
            {
                this.IdContrato = value;
            }
        }

        public int meses
        {
            get
            {
                return this.Meses;
            }
            set
            {
                this.Meses = value;
            }
        }

        public Duenio oduenio
        {
            get
            {
                return this.ODuenio;
            }
            set
            {
                this.ODuenio = value;
            }
        }

        public Garante ogarante
        {
            get
            {
                return this.OGarante;
            }
            set
            {
                this.OGarante = value;
            }
        }

        public Inquilino oinquilino
        {
            get
            {
                return this.OInquilino;
            }
            set
            {
                this.OInquilino = value;
            }
        }

        public Casa ocasa
        {
            get
            {
                return this.Ocasa;
            }
            set
            {
                this.Ocasa = value;
            }
        }

        public Departamento odepartamento
        {
            get
            {
                return this.Odepartamento;
            }
            set
            {
                this.Odepartamento = value;
            }
        }

        public LocalComercial olocalcomercial
        {
            get
            {
                return this.Olocal;
            }
            set
            {
                this.Olocal = value;
            }
        }

        #endregion

    }
    
}