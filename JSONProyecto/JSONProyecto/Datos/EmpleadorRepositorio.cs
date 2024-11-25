using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JSONProyecto.Datos
{
    public class EmpleadorRepositorio
    {
        private static readonly string RUTA_FICHERO_EMPLEADOS = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "Empleados.json");

        public static List<Empleado> Empleados { get; private set; }

        public static void InicializarRepositorio()
        {
            if (File.Exists(RUTA_FICHERO_EMPLEADOS))
            {
                string json = File.ReadAllText(RUTA_FICHERO_EMPLEADOS);
                Empleados = JsonConvert.DeserializeObject<List<Empleado>>(json) ?? new List<Empleado>();
            }
            else
            {
                Empleados = new List<Empleado>();
            }
        }

        public static void AñadirEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
            GuardarCambios();
        }

        public static void EliminarEmpleado(string id)
        {
            Empleados.RemoveAll(e => e.Id.Equals(id));
            GuardarCambios();
        }

        public static void ActualizarEmpleado(string idEmpleadoOrigen, Empleado empleadoModificado)
        {
            int indiceEmpleadoOriginal = Empleados.FindIndex(e => e.Id == idEmpleadoOrigen);
            if (indiceEmpleadoOriginal != -1)
            {
                Empleados[indiceEmpleadoOriginal] = empleadoModificado;
                GuardarCambios();
            }
        }

        private static void GuardarCambios()
        {
            string json = JsonConvert.SerializeObject(Empleados, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_EMPLEADOS, json);
        }
    }
}
