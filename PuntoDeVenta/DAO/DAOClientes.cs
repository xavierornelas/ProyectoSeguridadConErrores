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
    public class DAOClientes
    {
        public List<Clientes> GetCustomer()
        {
            List<Clientes> cliente = new List<Clientes>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Clientes;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cliente.Add(new Clientes(
                    int.Parse(reader["id"].ToString()),
                    reader["nombre"].ToString(),
                   reader["domicilio"].ToString(),
                   reader["ciudad"].ToString(),
                   reader["estado"].ToString(),
                   reader["rfc"].ToString()
                   ));
            }
            return cliente;
        }
        public Clientes GetCustomer(int id)
        {
            Clientes cliente = null;
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Clientes WHERE id = "+id+";";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cliente = new Clientes(
                    int.Parse(reader["id"].ToString()),
                    reader["nombre"].ToString(),
                   reader["domicilio"].ToString(),
                   reader["ciudad"].ToString(),
                   reader["estado"].ToString(),
                   reader["rfc"].ToString()
                   );
            }
            
            return cliente;
        }



        public void InsertCustomer(Clientes cliente)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Clientes ([nombre],[domicilio],[ciudad],[estado],[rfc]) Values('" + cliente.Nombre + "','" + cliente.Domicilio + "','" + cliente.Ciudad + "','" + cliente.Estado + "','" +cliente.Rfc+"')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void ModifyCustomer(Clientes cliente)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Clientes SET nombre='"+ cliente.Nombre + "',domicilio='" + cliente.Domicilio + "',ciudad='" + cliente.Ciudad + "',estado='" + cliente.Estado + "',rfc='" + cliente.Rfc + "' WHERE id="+cliente.Id;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }


        public void DeleteCustomer(int id)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM clientes WHERE id="+id;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
