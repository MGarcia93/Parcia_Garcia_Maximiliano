using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class CasaNegocio
    {
        public static List<Casa> lista()
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            List<Casa> lista = new List<Casa>();
            Casa casa;
            try
            {
                db.setearConsulta("select id,Descripcion from Casas");
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    casa = new Casa();
                    casa.id = (int)db.Lector["id"];
                    casa.descripcion = (string)db.Lector["Descripcion"];
                    lista.Add(casa);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                db.cerrarConexion();
            }
        }
    }
}
