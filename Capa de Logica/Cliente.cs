using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_de_Logica
{
    public class Inquilino : Persona
    {
        private int IdInquilino;

        #region
        public Inquilino()
        {

            this.IdInquilino = 0;


        }
        public Inquilino(string nombre, string apellido, string direccion, int telefono, string mail, int dni, int Id) : base(nombre, apellido, direccion, telefono, mail, dni)
        {

            this.IdInquilino = Id;


        }

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


        #endregion
    }
}