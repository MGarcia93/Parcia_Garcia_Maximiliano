using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class MagoNegocio
    {
        public static List<Mago> lista()
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            List<Mago> lista = new List<Mago>();
            Mago mago;
            try
            {
                db.setearConsulta("select m.id,m.Nombre,c.Descripcion as casa from MAGOS as m inner join CASAS as c on m.IdCasa=c.Id");
                db.abrirConexion();
                db.ejecutarConsulta();
                while (db.Lector.Read())
                {
                    mago = new Mago();
                    mago.id = (int)db.Lector["id"];
                    mago.nombre = (string)db.Lector["Nombre"];
                    mago.casa.descripcion = (string)db.Lector["casa"];
                    lista.Add(mago);
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


        public static int Agregar(Mago dato)
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            try
            {
                db.setearConsulta("insert into magos(Nombre,idCasa) values(@nombre,@idCasa)");
                db.Comando.Parameters.Clear();
                db.Comando.Parameters.AddWithValue("@nombre", dato.nombre);
                db.Comando.Parameters.AddWithValue("@idCasa", dato.casa.id);
                db.abrirConexion();
            if (db.ejecutarAccion() == 1)
            {
                db.setearConsulta("select max(id) as id from magos");
                db.ejecutarConsulta();
                db.Lector.Read();
                return (int)db.Lector["id"];
            }
            else
            {
                return -1;
            }
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


        public static bool agregarHechizo(int mago, int hechizo)
        {
            ManagerAcessoDato db = new ManagerAcessoDato();
            try
            {
                db.setearConsulta("insert into HECHIZOSMAGOS(idMago,idHechizo) values(@mago,@hechizo)");
                db.Comando.Parameters.Clear();
                db.Comando.Parameters.AddWithValue("@mago", mago);
                db.Comando.Parameters.AddWithValue("@hechizo", hechizo);
                db.abrirConexion();
                if (db.ejecutarAccion() == 1)
                {
                    return true;
                }
                return false;
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
