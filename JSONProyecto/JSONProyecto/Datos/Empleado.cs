using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONProyecto.Datos
{
    public class Empleado
    {
        public string Id { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido1 { get; private set; }
        public string Apellido2 { get; private set; }
        public int Edad { get; private set; }
        public string Email { get; private set; }

        public Empleado(string id, string nombre, string apellido1, string apellido2, int edad, string email)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Edad = edad;
            this.Email = email;
        }
    }
}
