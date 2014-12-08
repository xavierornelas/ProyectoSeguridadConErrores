using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlServerCe;

namespace DAO
{
    class DAOOfertas
    {
        public List<DTOOfertas> GetOfertas()
        {
            List<DTOOfertas> ofertas = new List<DTOOfertas>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM ofertas;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ofertas.Add(new DTOOfertas(
                    reader["id"].ToString(),
                    int.Parse(reader["cantidad"].ToString()),
                    float.Parse(reader["precio"].ToString()),
                    reader["descripcion"].ToString(),
                    reader["codigo"].ToString()
                    ));
            }
            return ofertas;
        }
        public DTOOfertas GetOferta(string id)
        {
            DTOOfertas oferta = null;
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM ofertas WHERE id='"+id+"';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                oferta = new DTOOfertas(
                    reader["id"].ToString(),
                    int.Parse(reader["cantidad"].ToString()),
                    float.Parse(reader["precio"].ToString()),
                    reader["descripcion"].ToString(),
                    reader["codigo"].ToString()
                    );
            }
        

            return oferta;
        }



        public void InsertOferta(DTOOfertas oferta)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO ofertas ([id],[cantidad],[precio],[codigo],[descripcion]) Values('"+oferta.id+"','" + oferta.cantidad + "','" + oferta.precio + "','" + oferta.codigo + "','" + oferta.descripcion+"')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void ModifyOferta(DTOOfertas oferta)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE ofertas SET cantidad='"+ oferta.cantidad + "',precio='" + oferta.precio + "',codigo='" + oferta.codigo + "',descripcion='" + oferta.descripcion + "' WHERE id='" + oferta.id+"';";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }


        public void DeleteCustomer(string id)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM ofertas WHERE id='"+id+"';";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
