using DAO;
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
    public class DAODetalles_credito_cliente
    {
        public List<Detalles_credito_cliente> GetDetallesCredito(int id_cliente)
        {
            List<Detalles_credito_cliente> detalle = new List<Detalles_credito_cliente>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM detalles_credito_cliente WHERE id_cliente=" + id_cliente + ";";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                detalle.Add(new Detalles_credito_cliente(
                    int.Parse(reader["id_cliente"].ToString()),
                    reader["id_venta"].ToString()
                    
                    ));
            }
            return detalle;
        }
        public Detalles_credito_cliente GetDetallesCredito(string id_venta)
        {
            Detalles_credito_cliente detalle = null;
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM detalles_credito_cliente WHERE id_venta='" + id_venta + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                detalle = new Detalles_credito_cliente(
                    int.Parse(reader["id_cliente"].ToString()),
                    reader["id_venta"].ToString()

                    );
            }
            return detalle;
        }

        public List<Detalle> ObtenerListaDetallesCredito(int id_cliente) 
        {
            List<Detalles_credito_cliente> detalles = null;
            detalles=GetDetallesCredito(id_cliente);
            //Obtengo toda la informacion con una lista de detalles tomando en cuenta
            List<Detalle> DetallesCreditos = new List<Detalle>();
            foreach(Detalles_credito_cliente temp in detalles)
            {
                List<Detalle> temporal = new List<Detalle>();
                temporal = new DAODetalle().GetDetails(temp.id_venta);
                //Agrego los elementos de temporal a la lista de detallescreditos
                foreach(Detalle tmp in temporal)
                {
                    DetallesCreditos.Add(tmp);
                }
            }
            return DetallesCreditos;
        }
        public void InsertDetalleCredito(Detalles_credito_cliente detalle)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();
                //Checar tabla de abonos cliente
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO detalles_credito_cliente ([id_cliente],[id_venta]) Values ('" + detalle.id_cliente + "','" + detalle.id_venta + "')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteDetalleCredito(int id_cliente,string id_venta)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM detalles_credito_cliente WHERE id_cliente=" + id_cliente + " AND id_venta=" + id_venta;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
