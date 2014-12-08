using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Xml;

namespace DAO
{
    public class DAOCredito
    {
        public List<Credito> GetCredito()
        {
            List<Credito> credito = new List<Credito>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM creditos;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                credito.Add(new Credito(
                    int.Parse(reader["id_cliente"].ToString()),                    
                    
                    float.Parse(reader["deuda"].ToString())));                   
            }
            return credito;
        }

        public Credito GetCredito(int id)
        {
            Credito credito = new Credito();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM creditos WHERE id_cliente='"+id+"'";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                credito = new Credito(int.Parse(reader["id_cliente"].ToString()),
                    
                    float.Parse(reader["deuda"].ToString()));                    
            }
            return credito;
        }

        public void IncrementarDeudaCliente(Credito credito)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();
               // Credito credito = new Credito();
                //credito = GetCredito(Convert.ToInt16(id));
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE creditos set deuda='"  + credito.deuda + "' WHERE id_cliente ='"+credito.id_cliente+"'";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void DecrementarDeudaCliente(Credito credito)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE creditos set deuda='" + credito.deuda + "' WHERE id_cliente ='" + credito.id_cliente + "'";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsertCredito(Credito credito)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO creditos ([id_cliente],[deuda]) Values('" + credito.id_cliente + "','" + credito.deuda + "')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteCredito(int id)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM creditos WHERE id_cliente="+ id;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
