using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_de_Logica
{
    public class Garante : Persona
    {
        private string Empleo;
        private List<ReciboSueldo> LReciboSueldo;
        private int IdGarante;

        #region
        public Garante()
        {
            this.IdGarante = 0;
            this.Empleo = string.Empty;
            List<ReciboSueldo> Lrecibosueldo = new List<ReciboSueldo>();
            this.LReciboSueldo = Lrecibosueldo;
            
        }

        public Garante(string nombre, string apellido, string direccion, int telefono, string mail, int dni, string empleo, int id)
        {
            this.Empleo = empleo;
            this.IdGarante = id;
            List<ReciboSueldo> Lrecibosueldo = new List<ReciboSueldo>();
            this.LReciboSueldo = Lrecibosueldo;

        }

        #endregion

        #region
        public int idgarante
        {
            get
            {
                return this.IdGarante;
            }
            set
            {
                this.IdGarante = value;
            }
        }

        public List<ReciboSueldo> lrecibosueldo
        {
            get
            {
                return this.LReciboSueldo;
            }
            set
            {
                this.LReciboSueldo = value;
            }
        }
        #endregion
    }
}