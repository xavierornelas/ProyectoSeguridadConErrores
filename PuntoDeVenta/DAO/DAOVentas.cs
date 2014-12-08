using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.Xml;
using DTO;
using System.Data.SqlServerCe;

namespace DAO
{
   public class DAOVentas
    {
       public List<Ventas> GetVentas(string fecha1, string fecha2, int tipo)
       {
           List<Ventas> ventas = new List<Ventas>();
           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           //commands represent a query or a stored procedure
           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM ventas WHERE fecha > '" + fecha1 + "' AND fecha < '" + fecha2+"'";
           SqlCeDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               ventas.Add(new Ventas(
                   reader["id"].ToString(),
                   reader["fecha"].ToString(),
                   float.Parse(reader["total"].ToString()),
                   reader["usuario"].ToString(),
                   reader["tipo"].ToString(),
                   reader["hora"].ToString()
                   ));
           }
           return ventas;
       }
       public List<Ventas> GetVentas(string fecha,string usuario)
       {
           List<Ventas> ventas = new List<Ventas>();
           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           //commands represent a query or a stored procedure
           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM ventas WHERE fecha='" + fecha+"' AND usuario='"+usuario+"'";
           SqlCeDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               ventas.Add(new Ventas(
                   reader["id"].ToString(),
                   reader["fecha"].ToString(),
                   float.Parse(reader["total"].ToString()),
                   reader["usuario"].ToString(),
                   reader["tipo"].ToString(),
                   reader["hora"].ToString()
                   ));
           }
           return ventas;
       }
       public List<Ventas> GetVentas(string fecha)
       {
           List<Ventas> ventas = new List<Ventas>();
           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           //commands represent a query or a stored procedure
           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM ventas WHERE fecha='"+fecha+"'";
           SqlCeDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               ventas.Add(new Ventas(
                   reader["id"].ToString(),
                   reader["fecha"].ToString(),
                   float.Parse(reader["total"].ToString()),
                   reader["usuario"].ToString(),
                   reader["tipo"].ToString(),
                   reader["hora"].ToString()
                   ));
           }
           return ventas;
       }
       public List<Ventas> GetVentasXId(string id)
       {
           List<Ventas> ventas = new List<Ventas>();
           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           //commands represent a query or a stored procedure
           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM ventas WHERE id='" + id + "'";
           SqlCeDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               ventas.Add(new Ventas(
                   reader["id"].ToString(),
                   reader["fecha"].ToString(),
                   float.Parse(reader["total"].ToString()),
                   reader["usuario"].ToString(),
                   reader["tipo"].ToString(),
                   reader["hora"].ToString()
                   ));
           }
           return ventas;
       }
       public List<Ventas> GetVentas()
       {
           List<Ventas> ventas = new List<Ventas>();
           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           //commands represent a query or a stored procedure
           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM ventas;";
           SqlCeDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               ventas.Add(new Ventas(
                   reader["id"].ToString(),
                   reader["fecha"].ToString(),
                   float.Parse(reader["total"].ToString()),
                   reader["usuario"].ToString(),
                   reader["tipo"].ToString(),
                   reader["hora"].ToString()
                   ));
           }
           return ventas;
       }
       public void InsertVenta(Ventas venta)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "INSERT INTO ventas ([id],[fecha],[total],[usuario],[tipo],[hora]) Values ('" + venta.Id + "','" + venta.Fecha + "','" + venta.Total + "','" + venta.Usuario + "','" + venta.Tipo + "','"+venta.Hora+"')";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
       public void DeleteVenta(int id)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "DELETE FROM ventas WHERE id=" + id;

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
       public void ModificarVenta(Ventas correo)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "UPDATE ventas SET total='" + correo.Total + "' WHERE id='" + correo.Id + "'";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
    }
}
