using DAO;
using DTO;
using LibPrintTicket;
using punto_venta.DTO;
using PuntoDeVenta.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.DAO
{
    public class DAOImpresion
    {
        public void ImprimirTicket(Ventas ventaActual,string recibido,string cambio,List<PantallaVenta>pantalla)
        {
            if (MessageBox.Show("¿Desea imprimir ticket?", "Ventas",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                Ticket ticket = new Ticket();
                // ticket.FontSize = 14;
                Tickets configuracion = new Tickets();
                configuracion = new DAOTicket().GetTicket();
                if (configuracion.impresora != null)
                {
                    ticket.FontSize = configuracion.tamanoFuenta;
                    
                    ticket.AddHeaderLine(configuracion.nombreDeLaEmpresa);
                    ticket.AddHeaderLine("Lo atendió: "+ventaActual.Usuario);
                    ticket.AddHeaderLine("EXPEDIDO EN:");
                    ticket.AddHeaderLine(configuracion.direccionDeLaEmpresa);
                    ticket.AddHeaderLine(configuracion.municipio + ", " + configuracion.estado);

                    ticket.AddSubHeaderLine("Clave de venta: "+Convert.ToString(ventaActual.Id));
                    ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                    foreach (PantallaVenta temp in pantalla)
                    {
                        ticket.AddItem(temp.Cantidad, temp.Producto, temp.Precio);
                    }
                    ticket.AddTotal("TOTAL", ventaActual.Total.ToString());
                    ticket.AddTotal("", "");
                    ticket.AddTotal("RECIBIDO", recibido);
                    ticket.AddTotal("CAMBIO", cambio);
                    ticket.AddTotal("", "");

                    ticket.AddFooterLine(configuracion.mensaje);
                    ticket.PrintTicket(configuracion.impresora); //Nombre de la impresora de tickets
                }
                else
                {
                    MessageBox.Show("Debes configurar una impresora", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        public void ImprimirTicketCredito(string recibido, string cambio,string aportacion,string usuarioActual) 
        {
            if (MessageBox.Show("¿Desea imprimir ticket?", "Crédito",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        == DialogResult.Yes)
            {
                Ticket ticket = new Ticket();
                //List<Tickets> configuracion = new DAOTicket().GetTicket();
                Tickets ticketsito = new Tickets();
                ticket.FontSize = ticketsito.tamanoFuenta;                
                ticket.AddHeaderLine(ticketsito.nombreDeLaEmpresa);
                ticket.AddHeaderLine("EXPEDIDO EN:");
                ticket.AddHeaderLine(ticketsito.direccionDeLaEmpresa);
                ticket.AddHeaderLine(ticketsito.municipio + ", " + ticketsito.estado);
                ticket.AddHeaderLine("Lo atendió: "+usuarioActual);

                //ticket.AddSubHeaderLine("Ticket # 1");//Poner el contador de las ventas
                ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

                ticket.AddItem("Cantidad", "Producto", "Pago");
                ticket.AddItem("1", "Crédito", aportacion);

                ticket.AddTotal("Total", aportacion);
                ticket.AddTotal("", "");
                ticket.AddTotal("RECIBIDO", recibido);
                ticket.AddTotal("CAMBIO", cambio);
                ticket.AddTotal("", "");

                ticket.AddFooterLine(ticketsito.mensaje);
                ticket.PrintTicket(ticketsito.impresora); //Nombre de la impresora de tickets
            }
        }
        public void ImprimirTicketCorte(Usuarios usuarioActual, string UsuariodelCorte, string fecha, string total, List<CorteVentas> listaDeCortes) 
        {
            if (MessageBox.Show("¿Desea imprimir ticket?", "Cortes",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
            {
                Ticket ticket = new Ticket();

                Tickets ticketsito = new Tickets();
                ticketsito = new DAOTicket().GetTicket();
                if (ticketsito.impresora != null)
                {

                    ticket.FontSize = ticketsito.tamanoFuenta;
                   
                    ticket.AddHeaderLine(ticketsito.nombreDeLaEmpresa);
                    ticket.AddHeaderLine("EXPEDIDO EN:");
                    ticket.AddHeaderLine(ticketsito.direccionDeLaEmpresa);
                    ticket.AddHeaderLine(ticketsito.municipio + ", " + ticketsito.estado);
                    ticket.AddHeaderLine("Corte del usuario: " + UsuariodelCorte);
                    ticket.AddFooterLine("CORTE GENERADO POR " + usuarioActual.Nombre);
                    ticket.AddFooterLine("TOTAL $" + total);
                    ticket.AddFooterLine("Corte del día " + fecha);
                    //ticket.AddSubHeaderLine(Convert.ToString());
                    ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());


                    foreach (CorteVentas corte in listaDeCortes)
                    {
                        ticket.AddItem(Convert.ToString(corte.cantidad), corte.producto, Convert.ToString(corte.total));
                    }


                    ticket.PrintTicket(ticketsito.impresora); //Nombre de la impresora de tickets
                }
                else
                {
                    MessageBox.Show("Debes configurar una impresora", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ImprimirTicketCompra(Compras compra,List<PantallaCompras>pantalla) 
        {
            if (MessageBox.Show("¿Desea imprimir ticket?", "Compras",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
               == DialogResult.Yes)
            {
                Ticket ticket = new Ticket();
                // ticket.FontSize = 14;
                Tickets configuracion = new Tickets();
                configuracion = new DAOTicket().GetTicket();
                if (configuracion.impresora != null)
                {
                    ticket.FontSize = configuracion.tamanoFuenta;

                    ticket.AddHeaderLine(configuracion.nombreDeLaEmpresa);
                    ticket.AddHeaderLine("Realizado por: " + compra.usuario);
                    ticket.AddHeaderLine("EXPEDIDO EN:");
                    ticket.AddHeaderLine(configuracion.direccionDeLaEmpresa);
                    ticket.AddHeaderLine(configuracion.municipio + ", " + configuracion.estado);
                    ticket.AddHeaderLine("TIPO DE COMPRA: "+compra.tipo);
                    ticket.AddSubHeaderLine("Clave de compra: " + Convert.ToString(compra.id_compra));
                    ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                    foreach (PantallaCompras temp in pantalla)
                    {
                        ticket.AddItem(temp.cantidad.ToString(), temp.Producto, temp.precio.ToString());
                    }
                    ticket.AddTotal("TOTAL", compra.total.ToString());
                    ticket.AddTotal("", "");                   
                    ticket.AddTotal("", "");

                    ticket.AddFooterLine("FIN DE COMPRAS");
                    ticket.PrintTicket(configuracion.impresora); //Nombre de la impresora de tickets
                }
                else
                {
                    MessageBox.Show("Debes configurar una impresora", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
