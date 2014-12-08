using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DTO;
using System.Data.SqlServerCe;
using LibPrintTicket;

namespace DAO
{
    public class DAOTicket
    {
        public Tickets GetTicket()
        {
            Tickets tickets = new Tickets();

            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM datos_tickets WHERE id=" + 1 + ";";
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tickets = new Tickets(
                    int.Parse(reader["id"].ToString()),
                    reader["nombre"].ToString(),
                   reader["direccion"].ToString(),
                   reader["municipio"].ToString(),
                   reader["estado"].ToString(),
                   reader["impresora"].ToString(),
                   int.Parse(reader["tamano"].ToString()),
                   reader["mensaje"].ToString()
                   );
            }
            

            return tickets;
        }
       
        public void ModifyTicket(Tickets tickets)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE datos_tickets SET nombre='" + tickets.nombreDeLaEmpresa + "',direccion='" + tickets.direccionDeLaEmpresa + "',municipio='" + tickets.municipio + "' ,estado='"+ tickets.estado+ "' ,impresora='"+ tickets.impresora+"', tamano='"+tickets.tamanoFuenta+"' WHERE id=" + tickets.id;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

        }

        public void ImprimirPrueba(Tickets ticketsito) 
        {
           
            Ticket ticket = new Ticket();
            ticket.FontSize = ticketsito.tamanoFuenta;
            ticketsito = GetTicket();

            ticket.AddHeaderLine(ticketsito.nombreDeLaEmpresa);
            ticket.AddHeaderLine("EXPEDIDO EN:");
            ticket.AddHeaderLine(ticketsito.direccionDeLaEmpresa);
            ticket.AddHeaderLine(ticketsito.municipio + ", " + ticketsito.estado);


            ticket.AddSubHeaderLine("PRUEBA");
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

            ticket.AddItem("Cantidad", "Producto", "Pago");
            ticket.AddItem("10","Cervezas","$100");
            ticket.AddItem("20", "Tequilas", "$1000");
            ticket.AddItem("1", "Papas fritas", "$10");
            ticket.AddTotal("Total", "1110");
            ticket.AddTotal("", "");
            ticket.AddTotal("RECIBIDO", "1200");
            ticket.AddTotal("CAMBIO", "90");
            ticket.AddTotal("", "");
            ticket.AddFooterLine("VUELVA PRONTO");
            ticket.PrintTicket(ticketsito.impresora); //Nombre de la impresora de tickets
        }

        public void InsertTicket(Tickets tickets)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO datos_tickets ([id], [nombre],[direccion],[municipio],[estado],[impresora],[tamano],[mensaje]) Values('" + tickets.id + "','" + tickets.nombreDeLaEmpresa + "','" + tickets.direccionDeLaEmpresa + "','" + tickets.municipio +"','"+tickets.estado+"','"+tickets.impresora+"','"+tickets.tamanoFuenta+"','"+tickets.mensaje+ "');";
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
