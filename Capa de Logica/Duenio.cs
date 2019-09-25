using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_de_Logica
{
    public class Duenio : Persona
    {
        private int NumeroCuenta;
        private string Banco;
        private int IdDuenio;
        private List<Casa> Lcasa;   
        private List<Departamento> Ldepartamento;
        private List<LocalComercial> Llocalcomercial;

        #region constructor
        public Duenio()
        {
            this.IdDuenio = 0;
            this.Banco = string.Empty;
            this.NumeroCuenta = 0;

        }

        public Duenio (string nombre, string apellido, string direccion, int telefono, string mail, int dni, string banco, int numerocuenta, int Id) : base (nombre, apellido, direccion, telefono, mail, dni)
        {
            this.Banco = banco;
            this.NumeroCuenta = numerocuenta;
            this.IdDuenio = Id;
            this.Lcasa = new List<Casa>();
            this.Ldepartamento = new List<Departamento>();
            this.Llocalcomercial = new List<LocalComercial>();

        }



        #endregion


        #region propiedades
        public int idduenio
        {
            get
            {
                return this.IdDuenio;
            }
            set
            {
                this.IdDuenio= value;
            }
        }
        public List<Casa>lcasa
        {
            get
            {
                return this.Lcasa;
            }
            set
            {
                this.Lcasa = value;
            }
        }

        public List<Departamento> ldepartamento
        {
            get
            {
                return this.Ldepartamento;
            }
            set
            {
                this.Ldepartamento = value;
            }
        }

        public List<LocalComercial> llocalcomercial
        {
            get
            {
                return this.Llocalcomercial;       
             }
            set
            {
                this.Llocalcomercial = value;
            }
        }



        #endregion

    }



}