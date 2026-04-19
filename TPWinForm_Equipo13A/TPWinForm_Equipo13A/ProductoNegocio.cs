using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TPWinForm_Equipo13A
{
    internal class ProductoNegocio
    {
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;

			try
            { //A mi la base de datos me funciona asi =>>> Valen la puso como "server=.\\SQLEXPRESS"... Habria que preguntar a algun profe por que o que...
			//sera por diferentes programas?? yo uso el sql manager studio.
                conexion.ConnectionString = "server=(localdb)\\MSSQLLocalDB;database=CATALOGO_P3_DB;integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "Select Id, Codigo, Nombre, Descripcion, Precio from ARTICULOS";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();

				while(lector.Read())
				{
					Articulo aux = new Articulo();
					aux.Id = lector.GetInt32(0);
					aux.Nombre = (String)lector["Nombre"];
					aux.Codigo = (String)lector["Codigo"];
					aux.Descripcion = (String)lector["Descripcion"];
					aux.Precio = (Decimal)lector["Precio"];

					lista.Add(aux);
				}

				conexion.Close();
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
				
			}
        }
    }
}
