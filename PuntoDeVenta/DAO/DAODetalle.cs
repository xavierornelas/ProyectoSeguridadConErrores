using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using DTO;
using System.Data.SqlServerCe;

namespace DAO
{
    public class DAODetalle
    {
        public List<Detalle> GetDetails()
        {
            List<Detalle> detalle = new List<Detalle>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM detalle_venta;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                detalle.Add(new Detalle(
                    reader["id_venta"].ToString(),
                    reader["id_producto"].ToString(),
                    int.Parse(reader["cantidad"].ToString()),
                    float.Parse(reader["precio"].ToString()),
                    float.Parse(reader["total"].ToString())
                    ));
            }
            return detalle;
        }
        public List<Detalle> GetDetails(string id_venta)
        {
            List<Detalle> detalle = new List<Detalle>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM detalle_venta WHERE id_venta='"+id_venta+"';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                detalle.Add(new Detalle(
                    reader["id_venta"].ToString(),
                    reader["id_producto"].ToString(),
                    int.Parse(reader["cantidad"].ToString()),
                    float.Parse(reader["precio"].ToString()),
                    float.Parse(reader["total"].ToString())
                    ));
            }
            return detalle;
        }
        public void InsertDetails(Detalle detalle)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO detalle_venta ([id_venta], [id_producto],[cantidad],[precio],[total]) Values('" + detalle.id_venta + "','" + detalle.id_producto + "','" + detalle.cantidad + "','" + detalle.precio + "','" + detalle.total + "')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void InsertDetails(List<Detalle> Listadetalle)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                foreach (Detalle detalle in Listadetalle)
                {
                    cmd.CommandText = "INSERT INTO detalle_venta ([id_venta], [id_producto],[cantidad],[precio],[total]) Values('" + detalle.id_venta + "','" + detalle.id_producto + "','" + detalle.cantidad + "','" + detalle.precio + "','" + detalle.total + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                conn.Close();
            }
        }
        public void ModificarDetalle(Detalle correo)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE detalle_venta SET cantidad='" + correo.cantidad + "', total='" + correo.total + "' WHERE id_venta='" + correo.id_venta+"' AND id_producto='"+correo.id_producto+"'";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteDetalle(int id_venta,int id_producto)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM detalle_venta WHERE id_venta=" + id_venta+"AND id_producto="+id_producto;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
