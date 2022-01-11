using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    public abstract class Persona
    {
        public Persona(string Apellido, string Nombre, string Domicilio, string Email) {
            this.Apellido = Apellido;
            this.Nombre = Nombre;
            this.Domicilio = Domicilio;
            this.Email = Email;
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string domicilio;

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }




    }
}
