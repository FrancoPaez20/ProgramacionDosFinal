using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
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

        #region Propiedades

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

        public int sueldo
        {

            get
            {

                return this.Sueldo;

            }
            set
            {

                this.Sueldo = value;

            }

        }

        public string detalle
        {

            get
            {

                return this.Detalle;

            }
            set
            {

                this.Detalle = value;

            }

        }

        #endregion
    }

}