using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGC_MINIMARKET.Proveedores_y_Compras;
using SGC_MINIMARKET.Seguridad_y_Usuarios;
using static System.Net.WebRequestMethods;

namespace SGC_MINIMARKET.Parametros_y_Configuracion
{
    public partial class frmPantallaPrincipal : Form
    {
        int bandera = 0;
        bool ExpansionMenuLateral = true;
        static bool transicionMenu1 = false;
        static bool transicionMenu2 = false;
        static bool transicionMenu3 = false;
        static bool transicionMenu4 = false;
        static bool transicionMenu5 = false;
        static bool transicionMenu6 = false;


        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void frmConfiguracionPC_Load(object sender, EventArgs e)
        {
        }
        
        private void mnTransicion_Tick(object sender, EventArgs e)
        {
            switch (bandera)
            {
                case 1:
                    DesplegarSubOpciones(flpTransacciones, 150, 50, ref transicionMenu1);
                    break;
                case 2:
                    DesplegarSubOpciones(flpInventario, 150, 50, ref transicionMenu2);
                    break;
                case 3:
                    DesplegarSubOpciones(flpPersonas, 150, 50, ref transicionMenu3);
                    break;
                case 4:
                    DesplegarSubOpciones(flpAdministracion, 200, 50, ref transicionMenu4);
                    break;
                case 5:
                    DesplegarSubOpciones(flpReportes, 200, 50, ref transicionMenu5);
                    break;
                case 6:
                    DesplegarSubOpciones(flpConfiguracion, 150, 50, ref transicionMenu6);
                    break;
            }
        }

        public void DesplegarSubOpciones(FlowLayoutPanel flp, int maximo, int minimo, ref bool transicionMenu)
        {

            if (!transicionMenu)
            {
                flp.Height += 10;
                if (flp.Height >= maximo)
                {
                    tmTransicion.Stop();
                    transicionMenu = true;
                }
            }
            else
            {
                flp.Height -= 10;
                if (flp.Height <= minimo)
                {
                    tmTransicion.Stop();
                    transicionMenu = false;
                }
            }
        }

        private void tmMenuLateral_Tick(object sender, EventArgs e)
        {
            if (ExpansionMenuLateral)
            {
                flpMenuLateral.Width -= 10;
                if (flpMenuLateral.Width <= 64)
                {
                    ExpansionMenuLateral = false;
                    tmMenuLateral.Stop();
                }
            }
            else 
            {
                flpMenuLateral.Width += 10;
                if(flpMenuLateral.Width >= 220)
                {
                    ExpansionMenuLateral = true;
                    tmMenuLateral.Stop();
                }
            }
        }

        private void btnDesplegarMenuLatera_Click(object sender, EventArgs e)
        {
            tmMenuLateral.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            tmTransicion.Start();
            bandera = 1;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            tmTransicion.Start();
            bandera = 2;
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            tmTransicion.Start();
            bandera = 3;
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            tmTransicion.Start();
            bandera = 4;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            tmTransicion.Start();
            bandera = 5;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            tmTransicion.Start();
            bandera = 6;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras frm = frmCompras.Formulario();
            LlamarFormulario(frm);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRoles frm = frmRoles.Formulario();
            LlamarFormulario(frm);
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {

        }

        private void btnVentasFechas_Click(object sender, EventArgs e)
        {

        }

        private void btnComprasProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnInventarioActual_Click(object sender, EventArgs e)
        {

        }

        private void btnPreferenciasSistema_Click(object sender, EventArgs e)
        {

        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {

        }

        public void LlamarFormulario(Form formulario)
        {
            pnlFormularios.Controls.Clear();
            formulario.TopLevel = false;
            pnlFormularios.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
