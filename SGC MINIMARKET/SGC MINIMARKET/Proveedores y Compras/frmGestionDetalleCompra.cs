using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_MINIMARKET.Proveedores_y_Compras
{
    public partial class frmGestionDetalleCompra : Form
    {
        static private frmGestionDetalleCompra instancia = null;
        public static frmGestionDetalleCompra Formulario()
        {
            if (instancia == null) { instancia = new frmGestionDetalleCompra(); }
            return instancia;
        } 
        public frmGestionDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
