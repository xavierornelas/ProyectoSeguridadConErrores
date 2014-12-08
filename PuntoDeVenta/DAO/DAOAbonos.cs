using PuntoDeVenta.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DAO
{
    public class DAOAbonos
    {
        public List<Abonos> GetAbonos(int id_cliente)
        {
            List<Abonos> correo = new List<Abonos>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM abonos_clientes WHERE id_cliente="+id_cliente+";";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                correo.Add(new Abonos(
                    int.Parse(reader["id_cliente"].ToString()),
                    reader["fecha"].ToString(),
                    float.Parse(reader["abono"].ToString())
                    ));
            }
            return correo;
        }
        public void InsertAbono(Abonos abono)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();
                //Checar tabla de abonos cliente
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO abonos_clientes ([id_cliente],[fecha],[abono]) Values ('" + abono.id_cliente + "','" + abono.fecha + "','" + abono.abono + "')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteAbono(string fecha, int id_cliente)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM abonos_clientes WHERE fecha='" + fecha + "' AND id_cliente="+id_cliente;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
