using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    public class Paciente:Persona
    {
        public Paciente(string Apellido, string Nombre, string Domicilio, string Email, int NroHistoriaClinica) : base(Apellido, Nombre, Domicilio, Email)
        {
            this.NroHistoriaClinica = NroHistoriaClinica;
        }

        private int nrohistoriaclinica;

        public int NroHistoriaClinica
        {
            get { return nrohistoriaclinica; }
            set { nrohistoriaclinica = value; }
        }



    }
}
