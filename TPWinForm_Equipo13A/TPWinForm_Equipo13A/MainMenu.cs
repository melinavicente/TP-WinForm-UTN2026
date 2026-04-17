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

        private void btnListadoArt_Click(object sender, EventArgs e)
        {
            Articulos formArticulo = new Articulos();
            formArticulo.ShowDialog();
        }
    }
}
