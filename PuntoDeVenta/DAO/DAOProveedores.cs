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
   public class DAOProveedores
    {
       public List<Proveedores> GetProvider()
       {
           List<Proveedores> prov = new List<Proveedores>();
           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           //commands represent a query or a stored procedure
           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM proveedores;";
           SqlCeDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               prov.Add(new Proveedores(
                   int.Parse(reader["id"].ToString()),
                   reader["nombre"].ToString(),
                   reader["domicilio"].ToString(),
                   reader["ciudad"].ToString(),
                   reader["estado"].ToString()));
           }
           
           return prov;
       }
       public Proveedores GetProvider(int id)
       {
           Proveedores prov = null;
           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           //commands represent a query or a stored procedure
           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM proveedores WHERE id="+id+";";
           SqlCeDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               prov=new Proveedores(
                   int.Parse(reader["id"].ToString()),
                   reader["nombre"].ToString(),
                   reader["domicilio"].ToString(),
                   reader["ciudad"].ToString(),
                   reader["estado"].ToString());
           }

           return prov;
       }
       public Proveedores GetProvider(string nombre)
       {
           Proveedores prov = null;
           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           //commands represent a query or a stored procedure
           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM proveedores WHERE nombre='" + nombre + "';";
           SqlCeDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               prov = new Proveedores(
                   int.Parse(reader["id"].ToString()),
                   reader["nombre"].ToString(),
                   reader["domicilio"].ToString(),
                   reader["ciudad"].ToString(),
                   reader["estado"].ToString());
           }

           return prov;
       }
       public void InsertProv(Proveedores prov)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "INSERT INTO proveedores ([nombre],[domicilio],[ciudad],[estado]) Values('" + prov.Nombre + "','" +prov.Domicilio+ "','" + prov.Ciudad + "','" + prov.Estado + "')";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }

           List<Proveedores> proveedores = new DAOProveedores().GetProvider();
           
           
           conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "INSERT INTO proveedor_deuda ([id],[nombre],[deuda]) Values('" + proveedores[proveedores.Count - 1].Id + "','" + proveedores[proveedores.Count - 1].Nombre + "','" + 0 + "')";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
       public void ModifyProv(Proveedores prov)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "UPDATE proveedores SET nombre='" + prov.Nombre + "',domicilio='" + prov.Domicilio + "',ciudad='" + prov.Ciudad +"',estado='"+ prov.Estado+"' WHERE id='" + prov.Id + "'";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
       public void DeleteProveedores(int id)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "DELETE FROM proveedores WHERE id=" + id;

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
       public void DeleteCreditoProveedor(int id)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "DELETE FROM proveedor_deuda WHERE id=" + id;

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
       
       public List<ProveedoresDeudas> GetAllProviderDeuda()
       {
           List<ProveedoresDeudas> prov = new List<ProveedoresDeudas>();
           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           //commands represent a query or a stored procedure
           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM proveedor_deuda;";
           SqlCeDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               prov.Add(new ProveedoresDeudas(
                   int.Parse(reader["id"].ToString()),
                   reader["nombre"].ToString(),
                   float.Parse(reader["deuda"].ToString())
                   ));
           }

           return prov;
       }
       public ProveedoresDeudas SeleccionarDeudaProveedor(int id)
       {
           ProveedoresDeudas prov = new ProveedoresDeudas();
           SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
           conn.Open();

           SqlCeCommand cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM proveedor_deuda WHERE id=" + id + ";";
           SqlCeDataReader reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               prov = new ProveedoresDeudas(
                   int.Parse(reader["id"].ToString()),
                   reader["nombre"].ToString(),
                   float.Parse(reader["deuda"].ToString())
               );
           }

           return prov;
       }
       public void CrearDeudaProveedor(Proveedores prov)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "INSERT INTO proveedor_deuda ([id],[nombre],[deuda]) Values('" + prov.Id + "','" + prov.Nombre + "','" + 0 + "')";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }
       public void ModifyDeuda(ProveedoresDeudas prov)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = "UPDATE proveedor_deuda SET deuda='" + prov.Deuda + "' WHERE id='" + prov.Id + "'";

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }
       }

       public void InsertProveedorXLS(string sql)
       {
           SqlCeConnection conn = null;
           try
           {
               conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
               conn.Open();

               SqlCeCommand cmd = conn.CreateCommand();
               cmd.CommandText = sql;

               cmd.ExecuteNonQuery();
           }
           finally
           {
               conn.Close();
           }

           conn = null;
       }
   }
}
