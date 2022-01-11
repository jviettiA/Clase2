using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    public class Medico:Persona
    {
        public Medico(string Apellido, string Nombre, string Domicilio, string Email, string Matricula, string Especialidad):base(Apellido, Nombre, Domicilio, Email)
        {
            this.Matricula = Matricula;
            this.Especialidad = Especialidad;
        }



        private string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        private string especialidad;

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }


    }
}
