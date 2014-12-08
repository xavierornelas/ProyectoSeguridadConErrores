using DTO;
using PuntoDeVenta.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.DAO
{
    public class DAOClave_scaner
    {
        public dto_clave_scaner Getclave_scaner(int id)
        {
            dto_clave_scaner usuario = null;

            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuario_clave_scanner WHERE id_usuario=" + id + ";";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                usuario = new dto_clave_scaner(
                    int.Parse(reader["id_usuario"].ToString()),
                    reader["clave"].ToString()
                    );
            }

            return usuario;
        }
        public dto_clave_scaner Getclave_scaner(string id)
        {
            dto_clave_scaner usuario = null;

            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuario_clave_scanner WHERE clave='" + id + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                usuario = new dto_clave_scaner(
                    int.Parse(reader["id_usuario"].ToString()),
                    reader["clave"].ToString()
                    );
            }

            return usuario;
        }
        public List<dto_clave_scaner> Getclave_scaner()
        {
            List<dto_clave_scaner> usuarios = new List<dto_clave_scaner>();

            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM usuario_clave_scanner;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                usuarios.Add(new dto_clave_scaner(
                    int.Parse(reader["id_usuario"].ToString()),
                    reader["clave"].ToString()
                    ));
            }

            return usuarios;
        }
        public void InsertClave_scanner(dto_clave_scaner usuario)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO usuario_clave_scanner ([id_usuario],[clave]) Values("+usuario.id_usuario+",'" + usuario.contrasenia + "')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

        }
        public void Deleteclave_scanner(int id)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM usuario_clave_scanner WHERE id_usuario=" + id;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void AsignarClave(Usuarios usuario) 
        {
            string clave=null;
            int num = 0;
            Random r = new Random(DateTime.Now.Millisecond);
            do
            {
                clave = null;
                for (int i = 0; i < 8; i++)
                {
                    num = r.Next(10);
                    clave = clave + num.ToString();
                    num = 0;
                }
            }while(ClaveRepetida(clave));
           
            dto_clave_scaner scaner = new dto_clave_scaner();
           scaner.id_usuario = usuario.Id;
            scaner.contrasenia = clave;
            InsertClave_scanner(scaner);
           
        }
        public bool ClaveRepetida(string clave) 
        {
            bool repetido = false;

            if (Getclave_scaner(clave)!=null)
                repetido = true;
            else
                repetido = false;
            return repetido;
        }
    }
}
