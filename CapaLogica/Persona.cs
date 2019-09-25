using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private string Direccion;
        private string Telefono;
        private string Mail;
        private int DNI;

        #region constructor 

        public Persona()
        {
         this.Nombre = string.Empty;            
         this.Apellido = string.Empty;
         this.Direccion = string.Empty;
         this.Telefono = string.Empty;
         this.Mail = string.Empty;
         this.DNI = 0;
    }
        public Persona(string nombre, string apellido, string direccion, string telefono, string mail, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Mail = mail;
            this.DNI = dni;
        }

        #endregion

        #region Propiedades

        public int dni  
        {

            get
            {

                return this.DNI;

            }
            set
            {

                this.DNI = value;

            }

        }

        public string nombre
        {

            get
            {

                return this.Nombre;

            }

            set
            {

                this.Nombre = value;

            }

        }

        public string apellido
        {

            get
            {

                return this.Apellido;

            }

            set
            {

                this.Apellido = value;

            }

        }

        public string direccion 
        {

            get
            {

                return this.Direccion;

            }

            set
            {

                this.Direccion = value;

            }

        }

        public string telefono
        {

            get
            {

                return this.Telefono;

            }

            set
            {

                this.Telefono = value;

            }

        }

        public string mail
        {

            get
            {

                return this.Mail;

            }

            set
            {

                this.Mail = value;

            }


        }
        #endregion

    }
}