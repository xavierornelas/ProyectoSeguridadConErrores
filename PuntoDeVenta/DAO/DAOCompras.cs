using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data.SqlServerCe;

namespace DAO
{
    class DAOCompras
    {
        public List<Compras> GetComprasCorte(string fecha1, string fecha2)
        {
            List<Compras> compras = new List<Compras>();
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                //commands represent a query or a stored procedure
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM compras WHERE fecha > '"+fecha1+"' AND fecha < '"+fecha2+"'";
                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Compras compra = new Compras();
                    compra.id_compra = reader["id_compras"].ToString();
                    compra.fecha = reader["fecha"].ToString();
                    compra.usuario = reader["usuario"].ToString();
                    compra.tipo = reader["tipo"].ToString();
                    compra.hora = reader["hora"].ToString();                    
                    compra.total = float.Parse(reader["total"].ToString());          


                    compras.Add(compra);
                }
            }
            finally
            {
                conn.Close();
            }
            return compras;
        }
        public List<Compras> GetCompras(string fecha1)
        {
            List<Compras> compras = new List<Compras>();
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                //commands represent a query or a stored procedure
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM compras WHERE fecha='" + fecha1 + "'";
                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Compras compra = new Compras();
                    compra.id_compra = reader["id_compras"].ToString();
                    compra.fecha = reader["fecha"].ToString();
                    compra.usuario = reader["usuario"].ToString();
                    compra.tipo = reader["tipo"].ToString();
                    compra.hora = reader["hora"].ToString();
                    compra.total = float.Parse(reader["total"].ToString());


                    compras.Add(compra);
                }
            }
            finally
            {
                conn.Close();
            }
            return compras;
        }
        public List<Compras> GetCompras(string fecha1,string usuario)
        {
            List<Compras> compras = new List<Compras>();
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                //commands represent a query or a stored procedure
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM compras WHERE fecha='" + fecha1 + "' AND usuario='"+usuario+"'";
                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Compras compra = new Compras();
                    compra.id_compra = reader["id_compras"].ToString();
                    compra.fecha = reader["fecha"].ToString();
                    compra.usuario = reader["usuario"].ToString();
                    compra.tipo = reader["tipo"].ToString();
                    compra.hora = reader["hora"].ToString();
                    compra.total = float.Parse(reader["total"].ToString());


                    compras.Add(compra);
                }
            }
            finally
            {
                conn.Close();
            }
            return compras;
        }
        public List<Compras> GetCompras()
        {
            List<Compras> compras = new List<Compras>();
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                //commands represent a query or a stored procedure
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM compras";
                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Compras compra = new Compras();
                    compra.id_compra = reader["id_compras"].ToString();
                    compra.fecha = reader["fecha"].ToString();
                    compra.usuario = reader["usuario"].ToString();
                    compra.tipo = reader["tipo"].ToString();
                    compra.hora = reader["hora"].ToString();
                    compra.total = float.Parse(reader["total"].ToString());       
                    compras.Add(compra);
                }
            }
            finally
            {
                conn.Close();
            }
            return compras;
        }
        public Compras GetCompra(string id)
        {
            Compras compra = null;
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM compras WHERE id_compras='" + id + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                compra = new Compras(
                        
                        reader["id_compras"].ToString(),
                       reader["fecha"].ToString(),
                       reader["usuario"].ToString(),
                       reader["tipo"].ToString(),
                       reader["hora"].ToString(),
                        float.Parse(reader["total"].ToString())                   
                    
                        );
            }
            conn.Close();
            return compra;
        }


        public void InsertCompra(Compras compra)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO compras ([id_compras],[fecha],[usuario],[tipo],[hora],[total]) Values('" + compra.id_compra + "','" + compra.fecha + "','" + compra.usuario + "','" + compra.tipo + "','" + compra.hora + "','" + compra.total+ "')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
