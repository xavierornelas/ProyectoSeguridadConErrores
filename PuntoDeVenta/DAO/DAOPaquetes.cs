using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOPaquetes
    {

        public List<Paquetes> GetPaquetes()
        {
            List<Paquetes> paquetes = new List<Paquetes>();
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                //commands represent a query or a stored procedure
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM paquetes";
                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Paquetes paquete = new Paquetes();
                    paquete.Id = int.Parse(reader["idpaquete"].ToString());
                    paquete.nombre = reader["nombre"].ToString();
                    paquete.contrasenia = reader["clave"].ToString();
                    paquete.activado = reader["habilitado"].ToString();
                    paquetes.Add(paquete);
                }
            }
            finally
            {
                conn.Close();
            }
            return paquetes;
        }
        public Paquetes GetPaquetePorClave(string clave)
        {
            Paquetes paquete = null;
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM paquetes WHERE clave='" + clave + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                paquete = new Paquetes(
                        int.Parse(reader["idpaquete"].ToString()),
                        reader["nombre"].ToString(),
                        reader["clave"].ToString(),
                        reader["habilitado"].ToString()                        
                        );
            }
            conn.Close();
            return paquete;
        }
        public Paquetes GetPaquete(string nombre)
        {
            Paquetes paquete = null;
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM paquetes WHERE nombre='" + nombre + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                paquete = new Paquetes(
                        int.Parse(reader["idpaquete"].ToString()),
                        reader["nombre"].ToString(),
                        reader["clave"].ToString(),
                        reader["habilitado"].ToString()                        
                        );
            }
            conn.Close();
            return paquete;
        }
        public bool VerificarPaqueteInstalado()
        {
            bool activado = false;
           
            List<Paquetes> paquetes = new List<Paquetes>();
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                //commands represent a query or a stored procedure
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM paquetes";
                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Paquetes paquete = new Paquetes();
                    paquete.Id = int.Parse(reader["idpaquete"].ToString());
                    paquete.nombre = reader["nombre"].ToString();
                    paquete.contrasenia = reader["clave"].ToString();
                    paquete.activado = reader["habilitado"].ToString();
                    paquetes.Add(paquete);
                }
            }
            finally
            {
                conn.Close();
            }
            foreach (Paquetes temp in paquetes)
            {
                if (temp.activado.Equals("1"))
                {
                    activado = true;
                    break;
                }
            }
            return activado;
        }
        public void ReactivarPaquete(string clave) 
        {
            Paquetes paqueteAdquirido = GetPaqueteActivado();
            DesactivarPaquete(paqueteAdquirido.contrasenia);
            ActivarPaquete(clave);

        }
        public Paquetes GetPaqueteActivado()
        {
            Paquetes paqueteAdquirido = null;
            List<Paquetes> paquetes = new List<Paquetes>();
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                //commands represent a query or a stored procedure
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM paquetes";
                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Paquetes paquete = new Paquetes();
                    paquete.Id = int.Parse(reader["idpaquete"].ToString());
                    paquete.nombre = reader["nombre"].ToString();
                    paquete.contrasenia = reader["clave"].ToString();
                    paquete.activado = reader["habilitado"].ToString();
                    paquetes.Add(paquete);
                }
            }
            finally
            {
                conn.Close();
            }
            foreach(Paquetes temp in paquetes)
            {
                if(temp.activado.Equals("1"))
                {
                    paqueteAdquirido = temp;
                    break;
                }
            }
            return paqueteAdquirido;
        }
        public void ActivarPaquete(string codigo)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE paquetes SET habilitado=1 WHERE clave='" + codigo + "';";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void DesactivarPaquete(string codigo)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE paquetes SET habilitado=0 WHERE clave='" + codigo + "';";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
