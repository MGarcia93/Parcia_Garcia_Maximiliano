﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class ManagerAcessoDato
    {
        public static string cadenaConexion = "data source=DESKTOP-FUGKT4R\\SQLEXPRESS; initial catalog=MAGOS_DB; integrated security=sspi";
        
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public SqlCommand Comando
        {
            get { return comando; }
        }

        public ManagerAcessoDato()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        //setear consulta embebida.
        public void setearConsulta(string consulta)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        //esto para luego...
        public void setearSP(string sp)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;
        }

        public void abrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ejecutarAccion()
        {
            try
            {
                comando.Connection = conexion;
                return comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int ejecutarAccionReturn()
        {
            try
            {
                comando.Connection = conexion;
                object a = comando.ExecuteScalar();
                if (a != null)
                {
                    return (int)a;
                }
                return 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarConsulta()
        {
            try
            {
                comando.Connection = conexion;
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
