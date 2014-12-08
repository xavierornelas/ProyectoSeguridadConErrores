using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;
using System.Data.SqlServerCe;

namespace DAO
{
    public class DAOCodigoGenerado
    {
        public List<Codigos_generados> GetCodigo()
        {
            List<Codigos_generados> codigo = new List<Codigos_generados>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM codigosGenerados;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                codigo.Add(new Codigos_generados(
                    reader["codigo"].ToString(),
                    reader["descripcion"].ToString(),
                    reader["ruta"].ToString()));
            }

            return codigo;
        }

        public Codigos_generados GetCodigo(Codigos_generados temp)
        {
            Codigos_generados codigo = new Codigos_generados();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM codigosGenerados WHERE codigo='" + temp.codigo + "' AND descripcion='" + temp.descripcion + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                codigo = new Codigos_generados(
                    reader["codigo"].ToString(),
                    reader["descripcion"].ToString(),
                    reader["ruta"].ToString());
            }

            return codigo;
        }

        public void InsertCodigoGenerado(Codigos_generados codigo)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO codigosGenerados ([codigo],[descripcion],[ruta]) Values('" + codigo.codigo + "','" + codigo.descripcion + "','" + codigo.ruta + "')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }            
        }

        public void ModificarCodigo(Codigos_generados codigo)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE codigosGenerados SET descripcion='" + codigo.descripcion + "' WHERE codigo ='" + codigo.codigo + "'";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
