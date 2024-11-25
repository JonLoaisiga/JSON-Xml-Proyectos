using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void OpenFormCompra(string nombreJuego)
        {
           
        }

        private void butSparking_Click(object sender, EventArgs e)
        {
            Image imagenJuego = picZero.Image;
            var juegoSeleccionado = CargarVideogamesDesdeXML().FirstOrDefault(v => v.Nombre == "Edición Ultimate de DRAGON BALL: Sparking! ZERO");
            FormCompra formCompra = new FormCompra(juegoSeleccionado,imagenJuego);
            formCompra.Show();
        }

        private void butGTA_Click(object sender, EventArgs e)
        {
            Image imagenJuego = picGTAV.Image;
            var juegoSeleccionado = CargarVideogamesDesdeXML().FirstOrDefault(v => v.Nombre == "Grand theft Auto V");
            FormCompra formCompra = new FormCompra(juegoSeleccionado,imagenJuego);
            formCompra.Show();
        }

        private void butRojoFire_Click(object sender, EventArgs e)
        {
            Image imagenJuego = picPokemon.Image;
            var juegoSeleccionado = CargarVideogamesDesdeXML().FirstOrDefault(v => v.Nombre == "Pokemon Rojo Fuejo");
            FormCompra formCompra = new FormCompra(juegoSeleccionado,imagenJuego);
            formCompra.Show();
        }

        private void butMinecraft_Click(object sender, EventArgs e)
        {
            Image imagenJuego = picMinecraft.Image;
            var juegoSeleccionado = CargarVideogamesDesdeXML().FirstOrDefault(v => v.Nombre == "Minecraft");
            FormCompra formCompra = new FormCompra(juegoSeleccionado,imagenJuego);
            formCompra.Show();
        }

        private void butFortnite_Click(object sender, EventArgs e)
        {
            Image imagenJuego = picFornite.Image;
            var juegoSeleccionado = CargarVideogamesDesdeXML().FirstOrDefault(v => v.Nombre == "Fortnite");
            FormCompra formCompra = new FormCompra(juegoSeleccionado,imagenJuego);
            formCompra.Show();
        }

        private void butREDEAD_Click(object sender, EventArgs e)
        {
            Image imagenJuego = picDEADll.Image;
            var juegoSeleccionado = CargarVideogamesDesdeXML().FirstOrDefault(v => v.Nombre == "Red Dead Redemption 2: Ultimate Edition");
            FormCompra formCompra = new FormCompra(juegoSeleccionado,imagenJuego);
            formCompra.Show();
        }

        public List<Videogame> CargarVideogamesDesdeXML()
        {
            List<Videogame> videogames = new List<Videogame>();

            XDocument doc = XDocument.Load(@"C:\Users\Edward Romero\source\repos\WindowsFormsApp1\WindowsFormsApp1\Videogames.xml");
           
            var videojuegosXml = doc.Descendants("Videogame");

            foreach (var videojuego in videojuegosXml)
            {
                videogames.Add(new Videogame
                {
                    Nombre = videojuego.Element("Nombre")?.Value ?? "Desconocido", // Asigna un valor predeterminado si el elemento no existe
                    Genero = videojuego.Element("Genero")?.Value ?? "Desconocido",
                    Plataforma = videojuego.Element("Plataforma")?.Value ?? "Desconocido",
                    Año = int.TryParse(videojuego.Element("Año")?.Value, out int año) ? año : 0,  // Asigna 0 si el valor no es válido
                    Peso = int.TryParse(videojuego.Element("Peso")?.Value, out int peso) ? peso : 0,  
                    Precio = videojuego.Element("Precio")?.Value ?? "No disponible" 
                });
            }
            return videogames;
        }
    }
}
