using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_venta.DAO
{
    public class DAOCortes
    {
        public List<Detalle> GetCorte(string fecha,string usuario)
        {
            //Corte del dia y por usuario
            List<Ventas> ventas = new List<Ventas>();
            List<Detalle> detalle = new List<Detalle>();
            ventas = new DAOVentas().GetVentas(fecha,usuario);
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            
            foreach (Ventas venta in ventas)
            {
                cmd.CommandText = "SELECT * FROM detalle_venta WHERE id_venta='"+venta.Id+"'";
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
            }
            return detalle;
        }
        public List<Detalle> GetCorte(string fecha)
        {
            //Corte del dia y por usuario
            List<Ventas> ventas = new List<Ventas>();
            List<Detalle> detalle = new List<Detalle>();
            ventas = new DAOVentas().GetVentas(fecha);
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
           
            foreach (Ventas venta in ventas)
            {
                cmd.CommandText = "SELECT * FROM detalle_venta WHERE id_venta='" + venta.Id+"'";
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
            }
            return detalle;
        }
        public List<Detalle> GetCorte(string fecha1,string fecha2, int tipo)
        {
            //Corte del dia y por usuario
            List<Ventas> ventas = new List<Ventas>();
            List<Detalle> detalle = new List<Detalle>();
            ventas = new DAOVentas().GetVentas(fecha1,fecha2,1);
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();

            foreach (Ventas venta in ventas)
            {
                cmd.CommandText = "SELECT * FROM detalle_venta WHERE id_venta='" + venta.Id+"'";
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
            }
            return detalle;
        }
    }
}
