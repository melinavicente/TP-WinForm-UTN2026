using dominio;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                Datos.ejecutarLectura();
                while (Datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = Datos.Lector.GetInt32(0);
                    aux.Descripcion = (String)Datos.Lector["Descripcion"];
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