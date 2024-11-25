using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCompra : Form
    {
        private Videogame videojuego;
        private Image imagenJuego;

        public FormCompra(Videogame videojuegoSelecionado, Image imagen)
        {
            InitializeComponent();
            videojuego = videojuegoSelecionado;
            imagenJuego = imagen;
        }
        private void FormCompra_Load(object sender, EventArgs e)
        {
            if (videojuego != null)
            {
                lblNombre.Text = videojuego.Nombre;
                lblGenero.Text = videojuego.Genero;
                lblPlataforma.Text = videojuego.Plataforma;
                lblAño.Text = videojuego.Año.ToString();
                lblPeso.Text = videojuego.Peso + " GB"; 
                lblPrecio.Text = videojuego.Precio + "$";
                pictureBoxJuego.Image = imagenJuego;
            }
        }

        private void butCOMPRAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su compra se ha realizado con exito ");
            this.Close();
        }
    }
}
