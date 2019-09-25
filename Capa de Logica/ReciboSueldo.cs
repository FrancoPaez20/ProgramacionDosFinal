using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_de_Logica
{
    public class ReciboSueldo
    {
        private string Detalle;
        private int Sueldo;
        private int IdSueldo;

        #region CONSTRUCTOR
        public ReciboSueldo(string detalle, int sueldo, int idsueldo)
        {

            this.Detalle = detalle;
            this.Sueldo = sueldo;
            this.IdSueldo = idsueldo;

        }

        #endregion


        public int idsueldo
        {
            get
            {
                return this.IdSueldo;
            }
            set
            {
                this.IdSueldo = value;
            }
        }
    }
}