using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;

using System.Data.SqlServerCe;
using DTO;


namespace DAO
{
    public class DAOProductos
    {
       public List<Productos> GetProducts()
        {
            List<Productos> productos = new List<Productos>();

            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM productos;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                productos.Add(new Productos(
                   reader["id"].ToString(),                    
                    reader["nombre"].ToString(),
                    float.Parse(reader["precio"].ToString()),
                    int.Parse(reader["cantidad"].ToString())
                    ));
            }
            conn.Close();
            return productos;
        }
       public Productos GetProducts(string id)
       {
           Productos productos = null;

           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           //commands represent a query or a stored procedure
           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM productos WHERE id='"+id+"';";
           SqlCeDataReader reader = cmd.ExecuteReader();
           while (reader.Read()) 
           {
               productos = new Productos(
                   reader["id"].ToString(),                  
                   reader["nombre"].ToString(),
                   float.Parse(reader["precio"].ToString()),
                   int.Parse(reader["cantidad"].ToString()));
           }
           conn.Close();
           return productos;
       }
       public Productos GetProduct(string nombre)
       {
           Productos productos = null;

           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           //commands represent a query or a stored procedure
           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM productos WHERE nombre='" + nombre + "';";
           SqlCeDataReader reader = cmd.ExecuteReader();
           while (reader.Read())
           {
               productos = new Productos(
                   reader["id"].ToString(),
                   reader["nombre"].ToString(),
                   float.Parse(reader["precio"].ToString()),
                   int.Parse(reader["cantidad"].ToString()));
           }
           conn.Close();
           return productos;
       }
       public void Aumentarproductos(string codigo, int cantidad)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "UPDATE productos SET cantidad=cantidad+" + cantidad + " WHERE id='" + codigo + "';";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
       public void Modifyproductos(string codigo,int cantidad)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "UPDATE productos SET cantidad=cantidad-" + cantidad + " WHERE id='" + codigo + "';";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }

       public void UpdateProducto(Productos produc)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "UPDATE productos SET nombre='" + produc.Nombre + "',precio=" + produc.Precio + ",cantidad=" + produc.Cantidad + " WHERE id='" + produc.Id + "'";
               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
       public void Modifyproductos(Productos produc) 
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand query = conn.CreateCommand();
               query.CommandText = "SELECT * FROM productos WHERE id='" + produc.Id + "'";
               SqlCeDataReader reader = query.ExecuteReader();
               while (reader.Read())
               {
                   productos = new Productos(
                       reader["id"].ToString(),
                       reader["nombre"].ToString(),
                       float.Parse(reader["precio"].ToString()),
                       int.Parse(reader["cantidad"].ToString()));
               }

               produc.Cantidad += productos.Cantidad;

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "UPDATE productos SET nombre='" + produc.Nombre + "',precio=" + productos.Precio + ",cantidad=" + produc.Cantidad+ " WHERE id='"+produc.Id+"'";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
       public void Insertproductos(Productos produc)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "INSERT INTO productos ([id],[nombre],[precio],[cantidad]) Values('" + produc.Id + "','" + produc.Nombre + "','" + produc.Precio + "','" + produc.Cantidad + "')";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
       public void DeleteProductos(string id)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "DELETE FROM productos WHERE id='" + id+"'";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }


       public Productos productos { get; set; }
    }
}
