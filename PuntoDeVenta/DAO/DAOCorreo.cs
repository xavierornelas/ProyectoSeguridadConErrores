using DTO;
using PuntoDeVenta.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.DAO
{
    public class DAOCorreo
    {
        /*
         * Cliente SMTP
         * Gmail:  smtp.gmail.com  puerto:587
         * Hotmail: smtp.liva.com  puerto:25
         */
        SmtpClient server = new SmtpClient("mail.cceo.com.mx", 587);
 
        public DAOCorreo()
        {
            server.Credentials = new System.Net.NetworkCredential("tu.corte@cceo.com.mx", "tucorte123");
            //server.EnableSsl = true;
        }
 
        public void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        }
        public void MandarCorreoPrueba(string correo) 
        {
            if (AccesoInternet())
            {

                try
                {

                    MailMessage mnsj = new MailMessage();

                    mnsj.Subject = "Configuración del correo " + string.Format("{0:yyyy-MM-dd HH:mm:ss}", Convert.ToDateTime(DateTime.Now));
                    //Obtengo el correo que hayan configurado por default
                    mnsj.To.Add(new MailAddress(correo));

                    mnsj.From = new MailAddress("tu.corte@cceo.com.mx", "PUNTO DE VENTA CCEO");

                    /* Si deseamos Adjuntar algún archivo*/
                    //mnsj.Attachments.Add(new Attachment("C:\\archivo.pdf"));
                   // mnsj.Attachments.Add(new Attachment(direccion));

                    mnsj.Body = " Se ha realizado con éxito la configuración de tu correo. \nPUNTO DE VENTA CCEO";

                    /* Enviar */
                    MandarCorreo(mnsj);


                    MessageBox.Show("Se ha enviado mensaje de prueba a tu correo.", "Correo enviado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else if (!AccesoInternet() && ObtenerCorreoPorDefault() != null)
            {
                MessageBox.Show("Problemas con la conexión, no se envió el correo electrónico.", "Correo no enviado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CrearCorreoYMandarCompras(string direccion, Usuarios usuario)
        {
            if (AccesoInternet() && ObtenerCorreoPorDefault() != null)
            {

                try
                {

                    MailMessage mnsj = new MailMessage();

                    mnsj.Subject = "Corte de compras del día: " + string.Format("{0:yyyy-MM-dd HH:mm:ss}", Convert.ToDateTime(DateTime.Now));
                    //Obtengo el correo que hayan configurado por default
                    mnsj.To.Add(new MailAddress(ObtenerCorreoPorDefault().correo));

                    mnsj.From = new MailAddress("tu.corte@cceo.com.mx", "PUNTO DE VENTA CCEO");

                    /* Si deseamos Adjuntar algún archivo*/
                    //mnsj.Attachments.Add(new Attachment("C:\\archivo.pdf"));
                    mnsj.Attachments.Add(new Attachment(direccion));

                    mnsj.Body = " Corte realizadó por el usuario: " + usuario.Nombre + " \nPUNTO DE VENTA CCEO";

                    /* Enviar */
                    MandarCorreo(mnsj);


                    MessageBox.Show("Se ha enviado con éxito el correo con el corte adjunto.", "Correo enviado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }
            else if (!AccesoInternet() && ObtenerCorreoPorDefault() != null)
            {
                MessageBox.Show("Problemas con la conexión, no se envió el correo electrónico.", "Correo no enviado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CrearCorreoYMandar(string direccion, Usuarios usuario) 
        {
            if (AccesoInternet() && ObtenerCorreoPorDefault() != null)
            {
                
                    try
                    {

                        MailMessage mnsj = new MailMessage();

                        mnsj.Subject = "Corte del día: " + string.Format("{0:yyyy-MM-dd HH:mm:ss}", Convert.ToDateTime(DateTime.Now));
                        //Obtengo el correo que hayan configurado por default
                        mnsj.To.Add(new MailAddress(ObtenerCorreoPorDefault().correo));

                        mnsj.From = new MailAddress("tu.corte@cceo.com.mx", "PUNTO DE VENTA CCEO");

                        /* Si deseamos Adjuntar algún archivo*/
                        //mnsj.Attachments.Add(new Attachment("C:\\archivo.pdf"));
                        mnsj.Attachments.Add(new Attachment(direccion));

                        mnsj.Body = " Corte realizadó por el usuario: " + usuario.Nombre + " \nPUNTO DE VENTA CCEO";

                        /* Enviar */
                        MandarCorreo(mnsj);


                        MessageBox.Show("Se ha enviado con éxito el correo con el corte adjunto.", "Correo enviado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                
                    
                
            }
            else if (!AccesoInternet() && ObtenerCorreoPorDefault() != null)
            {
                MessageBox.Show("Problemas con la conexión, no se envió el correo electrónico.", "Correo no enviado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Correo GetCorreo(int id)
        {
            Correo correo = null;

            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM correos WHERE id_correo=" + id + ";";
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                correo = new Correo(
                     int.Parse(reader["id_correo"].ToString()),
                    reader["correo"].ToString(),
                    int.Parse(reader["predeterminado"].ToString()));
            }
            conn.Close();
            return correo;
        }
        public List<Correo> GetCorreos()
        {
            List<Correo> correo = new List<Correo>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM correos;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                correo.Add(new Correo(
                    int.Parse(reader["id_correo"].ToString()),
                    reader["correo"].ToString(),
                    int.Parse(reader["predeterminado"].ToString())
                    ));
            }
            return correo;
        }
        public void InsertCorreo(Correo correo)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO correos ([correo],[predeterminado]) Values ('" + correo.correo + "','" + correo.Default +"')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteCorreo(int id)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM correos WHERE id_correo=" + id;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public Correo ObtenerCorreoPorDefault() 
        {
            Correo correo = null;
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM correos WHERE predeterminado=1";
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                correo = new Correo(
                     int.Parse(reader["id_correo"].ToString()),
                    reader["correo"].ToString(),
                    int.Parse(reader["predeterminado"].ToString()));
            }
            conn.Close();
            return correo;
        }
        public void QuitarCorreoPorDefault(int id) 
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE correos SET predeterminado=0 WHERE id_correo=" + id;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        private bool AccesoInternet()       
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com.mx");
                return true;
            }
            catch (Exception es)
            {
                es.ToString();
                return false;
            }
          }
        public void ModificarCorreo(Correo correo) 
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\DB_local.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE correos SET correo='"+ correo.correo+"', predeterminado="+correo.Default+" WHERE id_correo=" + correo.id_correo;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        bool invalid = false;

        public bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,24}))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
