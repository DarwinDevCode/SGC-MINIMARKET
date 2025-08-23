using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGC_MINIMARKET.Seguridad_y_Usuarios;

namespace SGC_MINIMARKET.Proveedores_y_Compras
{
    public partial class frmGestionCompras : Form
    {
        static private frmGestionCompras instancia = null;
        public static frmGestionCompras Formulario()
        {
            if (instancia == null) { instancia = new frmGestionCompras(); }
            return instancia;
        }
        public frmGestionCompras()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            frmGestionDetalleCompra frm = frmGestionDetalleCompra.Formulario();
            frm.ShowDialog();
        }
    }
}
