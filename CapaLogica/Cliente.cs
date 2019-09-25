using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Inquilino : Persona
    {
        private int IdInquilino;
        private Garante oGarante;

        #region Constructor

        public Inquilino()
        {

            this.IdInquilino = 0;
            Garante ogtarante = new Garante();
            this.oGarante = ogtarante;


        }
        public Inquilino(string nombre, string apellido, string direccion, string telefono, string mail, int dni, int Id) : base(nombre, apellido, direccion, telefono, mail, dni)
        {

            this.IdInquilino = Id;
            Garante ogtarante = new Garante();
            this.oGarante = ogtarante;

        }

        #endregion

        #region Propiedades

        public int idinquilino
        {
            get
            {
                return this.IdInquilino;
            }
            set
            {
                this.IdInquilino = value;
            }
        }

        public Garante ogarante
        {
            get
            {
                return this.oGarante;
            }
            set
            {
                this.oGarante = value;
            }
        }

        #endregion
    }
}