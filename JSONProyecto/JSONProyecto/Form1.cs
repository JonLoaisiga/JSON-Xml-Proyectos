using JSONProyecto.Datos;
using JSONProyecto.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EmpleadorRepositorio.InicializarRepositorio();
            VisualizarEmpleados();
        }

        private void VisualizarEmpleados()
        {
            dataGridView1.Rows.Clear();
            foreach (Empleado empleado in EmpleadorRepositorio.Empleados)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = empleado.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = empleado.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = empleado.Apellido1.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = empleado.Apellido2.ToString();
                dataGridView1.Rows[rowIndex].Cells[4].Value = empleado.Edad.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = empleado.Email.ToString();
            }
        }

        private void pictureBoxAñadir_Click(object sender, EventArgs e)
        {
            EmpleadoForm empleadoForm = new EmpleadoForm();
            DialogResult dialogResult = empleadoForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                EmpleadorRepositorio.AñadirEmpleado(empleadoForm.Empleado);
                VisualizarEmpleados();
            }
        }

        private void pictureBoxEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idEmpleadoEliminar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                EmpleadorRepositorio.EliminarEmpleado(idEmpleadoEliminar);
                VisualizarEmpleados();
            }
            else
            {
                MessageBox.Show("No has seleccionado ningún empelado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idEmpleadoEditado = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombreEmpleadoEditado = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string apellido1EmpleadoEditado = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string apellido2EmpleadoEditado = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                int edadEmpleadoEditado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                string emailEmpleadoEditado = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                Empleado empleadoEditado = new Empleado(idEmpleadoEditado, nombreEmpleadoEditado, apellido1EmpleadoEditado, apellido2EmpleadoEditado, edadEmpleadoEditado, emailEmpleadoEditado);
                EmpleadoForm empleadoForm = new EmpleadoForm(empleadoEditado);
                DialogResult dialongResult = empleadoForm.ShowDialog();
                if (dialongResult == DialogResult.OK)
                {
                    EmpleadorRepositorio.ActualizarEmpleado(idEmpleadoEditado, empleadoForm.Empleado);
                    VisualizarEmpleados();
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ningún empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
