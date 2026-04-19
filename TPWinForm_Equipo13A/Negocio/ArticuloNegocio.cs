using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();

			AccesoDatos Datos = new AccesoDatos();

			try
            { 
				Datos.setearConsulta("Select Id, Codigo, Nombre, Descripcion, Precio from ARTICULOS");
				Datos.ejecutarLectura();

				while(Datos.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.Id = Datos.Lector.GetInt32(0);
					aux.Nombre = (String)Datos.Lector["Nombre"];
					aux.Codigo = (String)Datos.Lector["Codigo"];
					aux.Descripcion = (String)Datos.Lector["Descripcion"];
					aux.Precio = (Decimal)Datos.Lector["Precio"];

					lista.Add(aux);
				}

				Datos.CerrarConexion();
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
				
			}
        }
    }
}
