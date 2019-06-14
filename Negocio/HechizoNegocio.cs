using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class HechizoNegocio
    {
        public static List<Hechizo> listar(int mago)
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            List<Hechizo> lista = new List<Hechizo>();
            Hechizo hechizo = new Hechizo();
            try
            {
                db.setearConsulta("select h.Nombre,h.Descripcion from hechizos as h inner join HechizosMagos as hm on hm.idHechizo=h.id  where hm.IdMago=" + mago);
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    hechizo = new Hechizo();
                    hechizo.nombre = (string)db.Lector["Nombre"].ToString();
                    hechizo.descripcion = (string)db.Lector["descripcion"].ToString();
                    lista.Add(hechizo);
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

        public static List<Hechizo> listar()
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            List<Hechizo> lista = new List<Hechizo>();
            Hechizo hechizo = new Hechizo();
            try
            {
                db.setearConsulta("select h.id,h.Nombre,h.Descripcion,h.IdHechizoQueLoVence as idLoVence,hv.Descripcion as loVence  from hechizos as h inner join HechizosMagos as hm on hm.idHechizo=h.id inner join HECHIZOS as hV on hv.Id=h.IdHechizoQueLoVence");
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    hechizo = new Hechizo();
                    hechizo.id = (int)db.Lector["id"];
                    hechizo.nombre = (string)db.Lector["Nombre"].ToString();
                    hechizo.descripcion = (string)db.Lector["descripcion"].ToString();                   
                    hechizo.loVence = (string)db.Lector["loVence"];
                    lista.Add(hechizo);
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
