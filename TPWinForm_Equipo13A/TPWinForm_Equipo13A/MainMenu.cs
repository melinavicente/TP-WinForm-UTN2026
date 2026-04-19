using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;

namespace TPWinForm_Equipo13A
{
    public partial class MainMenu : Form
    {
        private List<Articulo> listaArticulosOriginal;

        public MainMenu()
        {
            InitializeComponent();

            listaArticulosOriginal = new List<Articulo>();
        }

        private void MainMenu_Cargar(object sender, EventArgs e)
        {
            criterioBusqueda.Items.Add("Nombre");
            criterioBusqueda.Items.Add("Marca");
            criterioBusqueda.Items.Add("Categoria");
            criterioBusqueda.SelectedIndex = 0;

            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                dgvArticulos.DataSource = null;
                listaArticulosOriginal = negocio.listar();
                dgvArticulos.DataSource = listaArticulosOriginal
                    .Select(a => new {
                        a.Id,
                        a.Codigo,
                        a.Nombre,
                        a.Descripcion,
                        a.Precio,
                        Marca = a.Marca.Descripcion,
                        Categoria = a.Categoria.Descripcion
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (listaArticulosOriginal == null || listaArticulosOriginal.Count == 0)
            {
                MessageBox.Show("No hay datos cargados para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_usuario.Text))
            {
                cargar();
                return;
            }

            string filtro = textBox_usuario.Text.ToUpper();
            string criterio = criterioBusqueda.SelectedItem.ToString();
            List<Articulo> listaFiltrada;


            //Esto es la forma resumida de lo que habia hecho con LINQ ->>>>
            if (criterio == "Nombre")
            {
                listaFiltrada = listaArticulosOriginal.Where(x => x.Nombre.ToUpper().Contains(filtro)).ToList();
            }
            else if (criterio == "Marca")
            {
                listaFiltrada = listaArticulosOriginal.Where(x => x.Marca.Descripcion.ToUpper().Contains(filtro)).ToList();
            }
            else
            {
                listaFiltrada = listaArticulosOriginal.Where(x => x.Categoria.Descripcion.ToUpper().Contains(filtro)).ToList();
            }

            dgvArticulos.DataSource = listaFiltrada
            .Select(a => new {
            a.Id,
            a.Codigo,
            a.Nombre,
            a.Descripcion,
            a.Precio,
            Marca = a.Marca.Descripcion,
            Categoria = a.Categoria.Descripcion
            }).ToList();
        }

        private void btnListadoArt_Click(object sender, EventArgs e)
        {
            Articulos formArticulo = new Articulos();
            formArticulo.ShowDialog();
        }

        //Tire todos los vacios para abajo de todo
        private void criterioBusqueda_SelectedIndexChanged(object sender, EventArgs e) { }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void Ingrese_Click(object sender, EventArgs e) { }

        private void textBox_usuario_TextChanged(object sender, EventArgs e) { }

    }
}