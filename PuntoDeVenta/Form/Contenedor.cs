using DAO;
using DTO;
using OrnelasInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class Contenedor : Form
    {
        public Usuarios usuario = null;
        public Paquetes paquete = null;
        Ventas_Form mensaje = new Ventas_Form();
        public bool isEmpleado=false;
        public Contenedor()
        {
            InitializeComponent();
        }

        public Contenedor(Usuarios usuario)
        {            
            InitializeComponent();
            this.usuario = usuario;
            frmPrinc = new Principalito_form(usuario);
            frmPrinc.MdiParent = this;
            frmPrinc.Show();
            isPrinc = true;
                     

            frmVentas = new Ventas_Form(this.usuario,this.paquete);
            frmVentas.Disposed += new EventHandler(frmVentas_Disposed);

            frmVentas2 = new Ventas_Form(this.usuario,this.paquete);
            frmVentas2.Disposed += new EventHandler(frmVentas_Disposed2);

            frmofertas = new Ofertas_form(usuario);
            frmofertas.Disposed += new EventHandler(frmOfertas_Disposed);

            frmClientes = new Clientes_Form(usuario);
            frmClientes.Disposed += new EventHandler(frmClientes_Disposed);

            frmCredito = new Credito_form(usuario);
            frmCredito.Disposed += new EventHandler(frmCredito_Disposed);

            frmUsuarios = new Usuarios_Form(usuario);
            frmUsuarios.Disposed += new EventHandler(frmUsuarios_Disposed);

            frmProveedores = new Proveedores_Form();
            frmProveedores.Disposed += new EventHandler(frmProveedores_Disposed);

            frmCreditoProve = new Proveedor_Credito_form_(this.usuario);
            frmCreditoProve.Disposed += new EventHandler(frmCreditoProve_Disposed);

            frmBuscaCodigo = new Buscador_form();
            frmBuscaCodigo.Disposed += new EventHandler(frmBuscaCodigo_Disposed);

            frmCompras = new Compras_form(usuario,this.paquete);
            frmCompras.Disposed += new EventHandler(frmCompras_Disposed);

            frmBuscaNombre = new Buscador_form_nombre();
            frmBuscaNombre.Disposed += new EventHandler(frmBuscaNombre_Disposed);

            frmInventario = new Inventario_Form(usuario,this.paquete);
            frmInventario.Disposed += new EventHandler(frmInventario_Disposed);

            frmCorteRango = new Corte_por_rango_form(usuario);
            frmCorteRango.Disposed += new EventHandler(frmCorteRango_Disposed);

            frmGenCodi = new Generar_codigos_form(usuario);
            frmGenCodi.Disposed += new EventHandler(frmGenCodi_Disposed);

            frmConfig = new Configuracion();
            frmConfig.Disposed += new EventHandler(frmConfig_Disposed);

            frmCorteDia = new Corte_por_dia_form(usuario);
            frmCorteDia.Disposed += new EventHandler(frmCorteDia_Disposed);

            frmCorteCompras = new CorteCompas(this.usuario);
            frmCorteCompras.Disposed += new EventHandler(frmCorteCompras_Disposed);

            frmImporExp = new Importar_Exportar_form();
            frmImporExp.Disposed += new EventHandler(frmImporExp_Disposed);

            frmCorteDiaEspecifico = new Corte_Dia_especifico_form(this.usuario);
            frmCorteDiaEspecifico.Disposed += new EventHandler(frmCorteDiaEspecifico_Disposed);

            frmPaquete = new Paquetes_form();
            frmPaquete.Disposed += new EventHandler(frmComercial_Disposed);
            
            frmCorreo = new correos_form();
            frmCorreo.Disposed += new EventHandler(frmCorreo_Disposed);

            frmResumenComprasID = new resumen_compras_id_form(usuario);
            frmResumenComprasID.Disposed += new EventHandler(frmResumenCompraId_Disposed);

            frmResumenComprasDias = new resumen_compras_dia_form(usuario);
            frmResumenComprasDias.Disposed += new EventHandler(frmResumenCompraDia_Disposed);

            Paquetes paquete = new DAOPaquetes().GetPaqueteActivado();
            if(paquete==null)
            {
                ofertasToolStripMenuItem.Enabled = true;
                clientesToolStripMenuItem1.Enabled = true;
                créditosToolStripMenuItem.Enabled = true;
                corteDeUnDíaEspecificoToolStripMenuItem.Enabled = true;
                cortePorRangoToolStripMenuItem.Enabled = true;
                //corteDeCompraToolStripMenuItem.Enabled = true;
                usuariosToolStripMenuItem.Enabled = true;
                proveedoresToolStripMenuItem.Enabled = true;
                créditoAProveedoresToolStripMenuItem.Enabled = true;
                corteDelDíaToolStripMenuItem.Enabled = true;
                generarCódigosToolStripMenuItem.Enabled = true;
                importarExportarToolStripMenuItem.Enabled = true;
                correosToolStripMenuItem.Enabled = true;
                this.paquete = new Paquetes();
                this.paquete.nombre = "Limitado";
                this.paquete.activado = "1";
            }
            else if(paquete.Id==1)
            {
                ofertasToolStripMenuItem.Enabled = true;
                clientesToolStripMenuItem1.Enabled = false;
                créditosToolStripMenuItem.Enabled = false;
                corteDeUnDíaEspecificoToolStripMenuItem.Enabled = false;
                cortePorRangoToolStripMenuItem.Enabled = false;
                correosToolStripMenuItem.Enabled = true;
                //corteDeCompraToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = true;
                proveedoresToolStripMenuItem.Enabled = false;
                créditoAProveedoresToolStripMenuItem.Enabled = false;
                generarCódigosToolStripMenuItem.Enabled = false;
                importarExportarToolStripMenuItem.Enabled = true;
                this.paquete = paquete;
            }
            else if(paquete.Id==2)
            {
                ofertasToolStripMenuItem.Enabled = true;
                clientesToolStripMenuItem1.Enabled = true;
                créditosToolStripMenuItem.Enabled = true;
                corteDeUnDíaEspecificoToolStripMenuItem.Enabled = true;
                cortePorRangoToolStripMenuItem.Enabled = false;
                //corteDeCompraToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = true;
                proveedoresToolStripMenuItem.Enabled = false;
                créditoAProveedoresToolStripMenuItem.Enabled = false;
                generarCódigosToolStripMenuItem.Enabled = false;
                importarExportarToolStripMenuItem.Enabled = true;
                this.paquete = paquete;
            }
            else if (paquete.Id == 3) 
            {
                ofertasToolStripMenuItem.Enabled = true;
                clientesToolStripMenuItem1.Enabled = true;
                créditosToolStripMenuItem.Enabled = true;
                corteDeUnDíaEspecificoToolStripMenuItem.Enabled = true;
                cortePorRangoToolStripMenuItem.Enabled = true;
                //corteDeCompraToolStripMenuItem.Enabled = true;
                usuariosToolStripMenuItem.Enabled = true;
                proveedoresToolStripMenuItem.Enabled = true;
                créditoAProveedoresToolStripMenuItem.Enabled = true;
                generarCódigosToolStripMenuItem.Enabled = true;
                importarExportarToolStripMenuItem.Enabled = true;
                this.paquete = paquete;
            }
        }

        Proveedor_Credito_form_ frmCreditoProve = null;
        Configuracion frmConfig = null;
        Ventas_Form frmVentas = null;
        Ventas_Form frmVentas2 = null;
        Ofertas_form frmofertas = null;
        Clientes_Form frmClientes = null;
        Credito_form frmCredito = null;
        Usuarios_Form frmUsuarios = null;
        Proveedores_Form frmProveedores = null;
        Compras_form frmCompras = null;
        Buscador_form frmBuscaCodigo = null;
        Buscador_form_nombre frmBuscaNombre = null;
        Inventario_Form frmInventario = null;
        Generar_codigos_form frmGenCodi = null;
        Principalito_form frmPrinc = null;
        Corte_por_dia_form frmCorteDia = null;
        Corte_por_rango_form frmCorteRango = null;
        CorteCompas frmCorteCompras = null;
        Importar_Exportar_form frmImporExp = null;
        Corte_Dia_especifico_form frmCorteDiaEspecifico = null;
        Paquetes_form frmPaquete = null;
        resumen_compras_id_form frmResumenComprasID = null;
        resumen_compras_dia_form frmResumenComprasDias = null;
        correos_form frmCorreo = null;
        public bool isResumenComprasDias = false;
        public bool isResumenComprasID = false;
        public bool isVentasShow = false;
        public bool isVentasShow2 = false;
        public bool isOfertasShow = false;
        public bool isClientesShow = false;
        public bool isCreditosShow = false;
        public bool isUsuariosShow = false;
        public bool isProveedoresShow = false;
        public bool isComprasShow = false;
        public bool isBuscaCodigoShow = false;
        public bool isBuscaNombreShow = false;
        public bool isInventarioShow = false;
        public bool isGenCodiShow = false;
        public bool isLoginShow = false;
        public bool isPrinc = false;
        public bool isCorteDiaShow = false;
        public bool isConfigShow = false;
        public bool isCreditoProveShow = false;
        public bool isCorteRangoShow = false;
        public bool isCorteComprasShow = false;
        public bool isImpExpShow = false;
        public bool isCorteDiaEspecificoShow = false;
        public bool isComercialShow = false;
        public bool isCorreoShow = false;

        private void Contenedor_Load(object sender, EventArgs e)
        {
            
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void frmResumenCompraId_Disposed(object sender, EventArgs e)
        {
            isResumenComprasID = false;

            frmResumenComprasID = new resumen_compras_id_form(usuario);
            frmResumenComprasID.Disposed += new EventHandler(frmResumenCompraId_Disposed);
        }
        private void frmResumenCompraDia_Disposed(object sender, EventArgs e)
        {
            isResumenComprasDias = false;

            frmResumenComprasDias = new resumen_compras_dia_form(usuario);
            frmResumenComprasDias.Disposed += new EventHandler(frmResumenCompraDia_Disposed);
        }
        public bool VerificarAdmin(Usuarios usuario) 
        {
            bool empleado = false;
            if(usuario.Privilegios.Equals("Empleado"))
            {
                empleado = true;
            }
            return empleado;
        }
        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {       
            if(!isVentasShow && !isVentasShow2)
            {
                mensaje.MostrarMensaje(this.paquete);
                frmVentas.MdiParent = this;
                frmVentas.Show();
                isVentasShow = true;
            }
            else if(isVentasShow && !isVentasShow2)
            {
                frmVentas2.MdiParent = this;
                frmVentas2.Show();
                isVentasShow2 = true;
                frmVentas2.Focus();
            }
            else if (!isVentasShow && isVentasShow2)
            {
                frmVentas.MdiParent = this;
                frmVentas.Show();
                isVentasShow = true;
                frmVentas.Focus();
            }
            else if(isVentasShow && isVentasShow2)
            {

                if (frmVentas.Focus())
                {
                    frmVentas2.Focus();
                }
                else if(!frmVentas.Focus())
                {
                    frmVentas.Focus();
                }
            }
            
         
        }

        private void frmVentas_Disposed(object sender, EventArgs e)
        {
            isVentasShow = false;
            frmVentas = new Ventas_Form(this.usuario,this.paquete);
            frmVentas.Disposed += new EventHandler(frmVentas_Disposed);
        }
        private void frmVentas_Disposed2(object sender, EventArgs e)
        {
            isVentasShow2 = false;
            frmVentas2 = new Ventas_Form(this.usuario, this.paquete);
            frmVentas2.Disposed += new EventHandler(frmVentas_Disposed2);
        }
        public bool contraseniaCorrecta() 
        {
            List<Usuarios> usuarios = new DAOUsuarios().GetUsers();
            string contrasenia = InputDialog.mostrar("Por favor ingresa la contraseña de un administrador", "Advertencia", InputDialog.ACEPTAR_BOTON, InputDialog.MENSAJE_CON_CONTRASENIA);
            bool correcto = false;
            foreach (Usuarios temp in usuarios)
            {
                if (contrasenia.Equals(temp.Contrasenia) && temp.Privilegios.Equals("Administrador"))
                {
                    correcto = true;
                    break;
                }
            }
            if (!correcto)
            {                
                return correcto;
            }
            else
                return correcto;
        }
        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (isOfertasShow)
            {
                frmofertas.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmofertas.MdiParent = this;
                            frmofertas.Show();
                            isOfertasShow = true;
                        }
                    }

                }
                else
                {
                    frmofertas.MdiParent = this;
                    frmofertas.Show();
                    isOfertasShow = true;
                }
            }
            
        }

        private void frmOfertas_Disposed(object sender, EventArgs e)
        {
            isOfertasShow = false;

            frmofertas = new Ofertas_form(this.usuario);
            frmofertas.Disposed += new EventHandler(frmOfertas_Disposed);
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (isClientesShow)
            {
                frmClientes.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmClientes.MdiParent = this;
                            frmClientes.Show();
                            isClientesShow = true;
                        }
                    }
                }
                else
                {
                    frmClientes.MdiParent = this;
                    frmClientes.Show();
                    isClientesShow = true;
                }
            }
            
        }

        private void frmClientes_Disposed(object sender, EventArgs e)
        {
            isClientesShow = false;

            frmClientes = new Clientes_Form(this.usuario);
            frmClientes.Disposed += new EventHandler(frmClientes_Disposed);
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isCreditosShow)
            {
                frmCredito.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmCredito.MdiParent = this;
                            frmCredito.Show();
                            isCreditosShow = true;
                        }
                    }
                }
                else
                {
                    frmCredito.MdiParent = this;
                    frmCredito.Show();
                    isCreditosShow = true;
                }
            }
            
        }

        private void frmCredito_Disposed(object sender, EventArgs e)
        {
            isCreditosShow = false;

            frmCredito = new Credito_form(this.usuario);
            frmCredito.Disposed += new EventHandler(frmCredito_Disposed);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isUsuariosShow)
            {
                frmUsuarios.Focus();
            }
            else
            {
                if(VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmUsuarios.MdiParent = this;
                            frmUsuarios.Show();
                            isUsuariosShow = true;
                        }
                    }
                }
                else
                {   
                    frmUsuarios.MdiParent = this;
                    frmUsuarios.Show();
                    isUsuariosShow = true;
                }
            }
            
        }

        private void frmUsuarios_Disposed(object sender, EventArgs e)
        {
            isUsuariosShow = false;

            frmUsuarios = new Usuarios_Form(this.usuario);
            frmUsuarios.Disposed += new EventHandler(frmUsuarios_Disposed);
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isProveedoresShow)
            {
                frmProveedores.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmProveedores.MdiParent = this;
                            frmProveedores.Show();
                            isProveedoresShow = true;
                        }
                    }
                }
                else
                {
                    frmProveedores.MdiParent = this;
                    frmProveedores.Show();
                    isProveedoresShow = true;
                }
            }
            
        }

        private void frmProveedores_Disposed(object sender, EventArgs e)
        {
            isProveedoresShow = false;

            frmProveedores = new Proveedores_Form();
            frmProveedores.Disposed += new EventHandler(frmProveedores_Disposed);
        }

        private void créditoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isCreditoProveShow)
            {
                frmCreditoProve.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmCreditoProve.MdiParent = this;
                            frmCreditoProve.Show();
                            isCreditoProveShow = true;
                        }
                    }
                }
                else 
                {
                    frmCreditoProve.MdiParent = this;
                    frmCreditoProve.Show();
                    isCreditoProveShow = true;
                }
                
            }
        }

        private void frmCreditoProve_Disposed(object sender, EventArgs e)
        {
            isCreditoProveShow = false;

            frmCreditoProve = new Proveedor_Credito_form_(this.usuario);
            frmCreditoProve.Disposed += new EventHandler(frmCreditoProve_Disposed);
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isComprasShow)
            {
                frmCompras.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmCompras.MdiParent = this;
                            frmCompras.Show();
                            isComprasShow = true;
                        }
                    }
                }
                else
                {

                    frmCompras.MdiParent = this;
                    frmCompras.Show();
                    isComprasShow = true;
                }
            }
            

           
        }

        private void frmCompras_Disposed(object sender, EventArgs e)
        {
            isComprasShow = false;

            frmCompras = new Compras_form(this.usuario,this.paquete);
            frmCompras.Disposed += new EventHandler(frmCompras_Disposed);
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isBuscaCodigoShow)
            {
                frmBuscaCodigo.Focus();
            }
            else
            {
                frmBuscaCodigo.MdiParent = this;
                frmBuscaCodigo.Show();
                isBuscaCodigoShow = true;
            }            
        }

        private void frmBuscaCodigo_Disposed(object sender, EventArgs e)
        {
            isBuscaCodigoShow = false;

            frmBuscaCodigo = new Buscador_form();
            frmBuscaCodigo.Disposed += new EventHandler(frmBuscaCodigo_Disposed);
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isBuscaNombreShow)
            {
                frmBuscaNombre.Focus();
            }
            else
            {
                frmBuscaNombre.MdiParent = this;
                frmBuscaNombre.Show();
                isBuscaNombreShow = true;
            }            
        }

        private void frmBuscaNombre_Disposed(object sender, EventArgs e)
        {
            isBuscaNombreShow = false;

            frmBuscaNombre = new Buscador_form_nombre();
            frmBuscaNombre.Disposed += new EventHandler(frmBuscaNombre_Disposed);
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isInventarioShow)
            {
                frmInventario.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmInventario.MdiParent = this;
                            frmInventario.Show();
                            isInventarioShow = true;
                        }
                    }
                }
                else
                {
                   
                    frmInventario.MdiParent = this;
                    frmInventario.Show();
                    isInventarioShow = true;
                }
            }            
        }

        private void frmInventario_Disposed(object sender, EventArgs e)
        {
            isInventarioShow = false;

            frmInventario = new Inventario_Form(this.usuario,this.paquete);
            frmInventario.Disposed += new EventHandler(frmInventario_Disposed);
        }

        private void generarCódigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isGenCodiShow)
            {
                frmGenCodi.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmGenCodi.MdiParent = this;
                            frmGenCodi.Show();
                            isGenCodiShow = true;
                        }
                    }        
                }
                else
                {
                    frmGenCodi.MdiParent = this;
                    frmGenCodi.Show();
                    isGenCodiShow = true;
                }
            }            
        }

        private void frmGenCodi_Disposed(object sender, EventArgs e)
        {
            isGenCodiShow = false;

            frmGenCodi = new Generar_codigos_form(this.usuario);
            frmGenCodi.Disposed += new EventHandler(frmGenCodi_Disposed);
        }

        private void datosDelTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isConfigShow)
            {
                frmConfig.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmConfig.MdiParent = this;
                            frmConfig.Show();
                            isConfigShow = true;
                        }
                    }       
                }
                else 
                {
                    frmConfig.MdiParent = this;
                    frmConfig.Show();
                    isConfigShow = true;
                }                
            } 
        }

        private void frmConfig_Disposed(object sender, EventArgs e)
        {
            isConfigShow = false;

            frmConfig = new Configuracion();
            frmConfig.Disposed += new EventHandler(frmConfig_Disposed);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login frmlog = new login();
            frmlog.Show();
            this.Dispose();
            
        }

        private void corteDelDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isCorteDiaShow)
            {
                frmCorteDia.Focus();
            }
            else
            {
                frmCorteDia.MdiParent = this;
                frmCorteDia.Show();
                isCorteDiaShow = true;
            }
        }

        private void frmCorteDia_Disposed(object sender, EventArgs e)
        {
            isCorteDiaShow = false;

            frmCorteDia = new Corte_por_dia_form(this.usuario);
            frmCorteDia.Disposed += new EventHandler(frmCorteDia_Disposed);
        }

        private void cortePorRangoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isCorteRangoShow)
            {
                frmCorteRango.Focus();
            }
            else
            {              
                    frmCorteRango.MdiParent = this;
                    frmCorteRango.Show();
                    isCorteRangoShow = true;  
            }
        }

        private void frmCorteRango_Disposed(object sender, EventArgs e)
        {
            isCorteRangoShow = false;

            frmCorteRango = new Corte_por_rango_form(this.usuario);
            frmCorteRango.Disposed += new EventHandler(frmCorteRango_Disposed);
        }

        private void corteDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isCorteComprasShow)
            {
                frmCorteCompras.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    if (contraseniaCorrecta())
                    {
                        frmCorteCompras.MdiParent = this;
                        frmCorteCompras.Show();
                        isCorteComprasShow = true;
                    }
                    else
                        MessageBox.Show("Contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else 
                {
                    frmCorteCompras.MdiParent = this;
                    frmCorteCompras.Show();
                    isCorteComprasShow = true;
                }                
            }
        }

        private void frmCorteCompras_Disposed(object sender, EventArgs e)
        {
            isCorteComprasShow = false;

            frmCorteCompras = new CorteCompas(this.usuario);
            frmCorteCompras.Disposed += new EventHandler(frmCorteCompras_Disposed);
        }

        private void importarExportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (isImpExpShow)
            {
                frmImporExp.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmImporExp.MdiParent = this;
                            frmImporExp.Show();
                            isImpExpShow = true;
                        }
                    }     
                }
                else 
                {
                    frmImporExp.MdiParent = this;
                    frmImporExp.Show();
                    isImpExpShow = true;
                }                
            }
        }
        private void frmImporExp_Disposed(object sender, EventArgs e)
        {
            isImpExpShow = false;

            frmImporExp = new Importar_Exportar_form();
            frmImporExp.Disposed += new EventHandler(frmImporExp_Disposed);
        }


        private void frmCorteDiaEspecifico_Disposed(object sender, EventArgs e)
        {
            isCorteDiaEspecificoShow = false;

            frmCorteDiaEspecifico = new Corte_Dia_especifico_form(this.usuario);
            frmCorteDiaEspecifico.Disposed += new EventHandler(frmCorteDiaEspecifico_Disposed);
        }

        private void corteDeUnDíaEspecificoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isCorteDiaEspecificoShow)
            {
                frmImporExp.Focus();
            }
            else
            {
                    frmCorteDiaEspecifico.MdiParent = this;
                    frmCorteDiaEspecifico.Show();
                    isCorteDiaEspecificoShow = true; 
            }
        }

        private void frmComercial_Disposed(object sender, EventArgs e)
        {
            isComercialShow = false;

            frmPaquete = new Paquetes_form();
            frmPaquete.Disposed += new EventHandler(frmComercial_Disposed);
        }

        private void paquetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isComercialShow)
            {
                frmPaquete.Focus();
            }
            else 
            {
                frmPaquete.MdiParent = this;
                frmPaquete.Show();
                isComercialShow = true;
            }
        }

        private void Contenedor_Activated(object sender, EventArgs e)
        {
            mensaje.MostrarMensaje(this.paquete);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    
      
        private void frmCorreo_Disposed(object sender, EventArgs e)
        {
            isCorreoShow = false;
            frmCorreo = new correos_form();
            frmCorreo.Disposed += new EventHandler(frmCorreo_Disposed);
        }
        private void correosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isResumenComprasID)
            {
                frmCorreo.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmCorreo.MdiParent = this;
                            frmCorreo.Show();
                            isCorreoShow = true;
                        }
                    }
                }
                else
                {
                    frmCorreo.MdiParent = this;
                    frmCorreo.Show();
                    isCorreoShow = true;
                }
            }
        }

        private void porClaveDeLaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isComprasShow)
            {
                frmResumenComprasID.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmResumenComprasID.MdiParent = this;
                            frmResumenComprasID.Show();
                            isResumenComprasID = true;
                        }
                    }
                }
                else
                {

                    frmResumenComprasID.MdiParent = this;
                    frmResumenComprasID.Show();
                    isResumenComprasID = true;
                }
            }
           
           
           
        }

        private void porDíaDeLaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isResumenComprasDias)
            {
                frmResumenComprasDias.Focus();
            }
            else
            {
                if (VerificarAdmin(this.usuario))
                {
                    autorizacion_form form = new autorizacion_form();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.ValorRetorno)
                        {
                            frmResumenComprasDias.MdiParent = this;
                            frmResumenComprasDias.Show();
                            isResumenComprasDias = true;
                        }
                    }
                }
                else
                {

                    frmResumenComprasDias.MdiParent = this;
                    frmResumenComprasDias.Show();
                    isResumenComprasDias = true;
                }
            }
           
           
        }

        private void buscadorDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
