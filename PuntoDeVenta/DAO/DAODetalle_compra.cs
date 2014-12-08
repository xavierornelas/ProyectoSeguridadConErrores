using PuntoDeVenta.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DAO
{
    public class DAODetalle_compra
    {
        public List<Detalle_compra> GetDetalle_Compra()
        {
            List<Detalle_compra> compras = new List<Detalle_compra>();
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                //commands represent a query or a stored procedure
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM detalle_compra";
                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Detalle_compra compra = new Detalle_compra();
                    compra.id_compra = reader["id_compra"].ToString();
                    compra.id_producto = reader["id_producto"].ToString();
                    compra.id_proveedor = int.Parse( reader["id_proveedor"].ToString());
                    compra.cantidad = int.Parse(reader["cantidad"].ToString());
                    compra.precio = float.Parse(reader["precio"].ToString());                    
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
        public List<Detalle_compra> GetDetalle_Compras(string codigo)
        {
            List<Detalle_compra> compras = new List<Detalle_compra>();
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                //commands represent a query or a stored procedure
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM detalle_compra WHERE id_compra='"+codigo+"'";
                SqlCeDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Detalle_compra compra = new Detalle_compra();
                    compra.id_compra = reader["id_compra"].ToString();
                    compra.id_producto = reader["id_producto"].ToString();
                    compra.id_proveedor = int.Parse(reader["id_proveedor"].ToString());
                    compra.cantidad = int.Parse(reader["cantidad"].ToString());
                    compra.precio = float.Parse(reader["precio"].ToString());
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
        public void InsertDetalle_Compra(Detalle_compra compra)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO detalle_compra ([id_compra],[id_producto],[id_proveedor],[cantidad],[precio],[total]) Values('" + compra.id_compra + "','" + compra.id_producto + "'," + compra.id_proveedor + "," + compra.cantidad + "," + compra.precio + "," + compra.total + ")";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public Detalle_compra GetDetalle_Compra(string id)
        {
            Detalle_compra compra = null;
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM detalle_compra WHERE id_compra='" + id + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                
                compra.id_compra = reader["id_compra"].ToString();
                compra.id_producto = reader["id_producto"].ToString();
                compra.id_proveedor = int.Parse(reader["id_proveedor"].ToString());
                compra.cantidad = int.Parse(reader["cantidad"].ToString());
                compra.precio = float.Parse(reader["precio"].ToString());
                compra.total = float.Parse(reader["total"].ToString());
            }
            conn.Close();
            return compra;
        }
    }
}
