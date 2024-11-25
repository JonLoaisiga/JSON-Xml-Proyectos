using JSONProyecto.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONProyecto.Formularios
{
    public partial class EmpleadoForm : Form
    {
        public Empleado Empleado { get; private set; }
        public EmpleadoForm()
        {
            InitializeComponent();
        }

        public EmpleadoForm(Empleado empleado)
        {
            InitializeComponent();
            textBoxIDEmpleado.Text = empleado.Id;
            textBoxNombre.Text = empleado.Nombre;
            textBoxApellido1.Text = empleado.Apellido1;
            textBoxApellido2.Text = empleado.Apellido2;
            textBoxEdad.Text = empleado.Edad.ToString();
            textBoxEmail.Text = empleado.Email;
        }

        private void buttonAceptarEmpl_Click(object sender, EventArgs e)
        {
            bool empleadoValido = ValidarEmpleado(out string errorMsg);
            if (empleadoValido)
            {
                Empleado = new Empleado(textBoxIDEmpleado.Text, textBoxNombre.Text, textBoxApellido1.Text, textBoxApellido2.Text, Convert.ToInt32(textBoxEdad.Text), textBoxEmail.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private bool ValidarEmpleado(out string errorMsg)
        {
            errorMsg = string.Empty;
            if (string.IsNullOrEmpty(textBoxIDEmpleado.Text))
            {
                errorMsg += "El ID del empleado no puede estar vacio." + Environment.NewLine; 
            }
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                errorMsg += "El Nombre del empleado no puede estar vacio." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(textBoxApellido1.Text))
            {
                errorMsg += "El Primer Apellido del empleado no puede estar vacio." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(textBoxApellido2.Text))
            {
                errorMsg += "El Segundo Apellido del empleado no puede estar vacio." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(textBoxEdad.Text))
            {
                errorMsg += "La Edad del empleado no puede estar vacio." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                errorMsg += "El E-Mail del empleado no puede estar vacio." + Environment.NewLine;
            }
            bool edadOk = int.TryParse(textBoxEdad.Text, out int edad);
            if (edadOk)
            {
                if (edad < 18)
                {
                    errorMsg += "La edad del empleado debe ser mayor a 18 años." + Environment.NewLine;
                }
            }
            else
            {
                errorMsg += "La edad del empleado debe ser un número válido." + Environment.NewLine;
            }
            try
            {
                new MailAddress(textBoxEmail.Text);
            }
            catch (Exception ex)
            {
                errorMsg += "El E-Mail debe tener un formato correcto." + Environment.NewLine;
            }
            return errorMsg == String.Empty;
        }
    }
}
