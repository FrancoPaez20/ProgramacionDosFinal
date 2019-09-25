using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_de_Logica
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private string Direccion;
        private int Telefono;
        private string Mail;
        private int DNI;

        #region constructor 
        public Persona()
        {
         this.Nombre = string.Empty;            
         this.Apellido = string.Empty;
         this.Direccion = string.Empty;
         this.Telefono = 0;
         this.Mail = string.Empty;
         this.DNI = 0;
    }
        public Persona(string nombre, string apellido, string direccion, int telefono, string mail, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = 0;
            this.Mail = mail;
            this.DNI = 0;
        }

        #endregion


    }
}