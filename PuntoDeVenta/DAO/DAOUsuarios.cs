using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Xml;


namespace DAO
{
    public class DAOUsuarios
    {
        
        public Usuarios GetUser(string nombre, string pass)
        {
            Usuarios usuario = new Usuarios();

            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuarios WHERE nombre='" + nombre + "' AND contrasena='"+pass+"';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                usuario = new Usuarios(
                    int.Parse(reader["id"].ToString()),
                    reader["nombre"].ToString(),
                    reader["contrasena"].ToString(),
                    reader["privilegios"].ToString()
                    );
            }
            
            return usuario;
        }

        public Usuarios GetUser(int id)
        {
            Usuarios usuario = null;

            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuarios WHERE id=" + id +";";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                usuario = new Usuarios(
                    int.Parse(reader["id"].ToString()),
                    reader["nombre"].ToString(),
                    reader["contrasena"].ToString(),
                    reader["privilegios"].ToString()
                    );
            }

            return usuario;
        }
        public Usuarios GetUser(string id)
        {
            Usuarios usuario = null;

            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuarios WHERE nombre='" + id + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                usuario = new Usuarios(
                    int.Parse(reader["id"].ToString()),
                    reader["nombre"].ToString(),
                    reader["contrasena"].ToString(),
                    reader["privilegios"].ToString()
                    );
            }

            return usuario;
        }
        public List<Usuarios> GetUsers()
        {
            List<Usuarios> usuarios = new List<Usuarios>();

            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuarios;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                usuarios.Add(new Usuarios(
                    int.Parse(reader["id"].ToString()),
                    reader["nombre"].ToString(),
                    reader["contrasena"].ToString(),
                    reader["privilegios"].ToString()
                    ));
            }

            return usuarios;
        }

        public void ModifyUser(Usuarios usuario)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE usuarios SET contrasena='" + usuario.Contrasenia + "',privilegios='" + usuario.Privilegios + "', nombre='" + usuario.Nombre + "' WHERE id=" + usuario.Id;
                //cmd.CommandText = "UPDATE usuarios SET nombre='" + usuario.Nombre + "', contrasena='" + usuario.Contrasenia + "',privilegios='" + usuario.Privilegios + "' WHERE id=" + usuario.Id;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

        }

        public void InsertUser(Usuarios usuario)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO usuarios ([nombre],[contrasena],[privilegios]) Values('"+usuario.Nombre+"','"+usuario.Contrasenia+"','"+usuario.Privilegios+"')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
                        
        }

        public void DeleteUsuario(int id)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM usuarios WHERE id=" + id;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
