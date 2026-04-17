using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo13A
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private List<Articulo> listaArticulosOriginal; //esto es lo de la prueba, eliminar cuando se haga la base de datos
        //Datos de prueba, que la base de datos sea problema para mas tarde jajsajs
        private void CargarDatosDePrueba()
        {
            listaArticulosOriginal = new List<Articulo>();

            Marca marca1 = new Marca { Id = 1, Descripcion = "Swarovski" };
            Marca marca2 = new Marca { Id = 2, Descripcion = "Casio" };
            Marca marca3 = new Marca { Id = 3, Descripcion = "Cartier" };

            Categoria cat1 = new Categoria { Id = 1, Descripcion = "Anillos" };
            Categoria cat2 = new Categoria { Id = 2, Descripcion = "Relojes" };
            Categoria cat3 = new Categoria { Id = 3, Descripcion = "Collares" };

            listaArticulosOriginal.Add(new Articulo { Id = 1, Codigo = "AN-001", Nombre = "Anillo de Compromiso Plata", Descripcion = "Anillo de plata 925 con circón", Precio = 45000, Marca = marca1, Categoria = cat1 });
            listaArticulosOriginal.Add(new Articulo { Id = 2, Codigo = "RE-105", Nombre = "Reloj Analógico Clásico", Descripcion = "Reloj sumergible malla de cuero", Precio = 120000, Marca = marca2, Categoria = cat2 });
            listaArticulosOriginal.Add(new Articulo { Id = 3, Codigo = "CO-022", Nombre = "Collar Gota de Cristal", Descripcion = "Cadena de acero quirúrgico", Precio = 25000, Marca = marca1, Categoria = cat3 });
            listaArticulosOriginal.Add(new Articulo { Id = 4, Codigo = "AN-002", Nombre = "Anillo Sello Oro", Descripcion = "Anillo de oro 18k", Precio = 180000, Marca = marca3, Categoria = cat1 });
        }
        

        private void MainMenu_Cargar(object sender, EventArgs e)
        {
            criterioBusqueda.Items.Add("Nombre");
            criterioBusqueda.Items.Add("Marca");
            criterioBusqueda.Items.Add("Categoria");

            criterioBusqueda.SelectedIndex = 0;

            CargarDatosDePrueba();
        }

        private void btnListadoArt_Click(object sender, EventArgs e)
        {
            Articulos formArticulo = new Articulos();
            formArticulo.ShowDialog();
        }


        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingrese_Click(object sender, EventArgs e)
        {

        }

        private void criterioBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string filtro = textBox_usuario.Text.ToUpper();
            string criterio = criterioBusqueda.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(textBox_usuario.Text))
            {
                MessageBox.Show("Por favor, escriba lo que quiere buscar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Articulo> listaFiltrada;


            if (!string.IsNullOrEmpty(filtro))
            {
                if (criterio == "Nombre")
                {
                    listaFiltrada = (from articulo in listaArticulosOriginal
                                     where articulo.Nombre.ToUpper().Contains(filtro)
                                     select articulo).ToList();
                }
                else if (criterio == "Marca")
                {
                    listaFiltrada = (from articulo in listaArticulosOriginal
                                     where articulo.Marca.Descripcion.ToUpper().Contains(filtro)
                                     select articulo).ToList();
                } else
                {
                    listaFiltrada = (from articulo in listaArticulosOriginal
                                     where articulo.Categoria.Descripcion.ToUpper().Contains(filtro)
                                     select articulo).ToList();
                }
            } else { listaFiltrada = listaArticulosOriginal; }

                dgvArticulos.DataSource = listaFiltrada; 

        }

        private void groupBox_articulos_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
