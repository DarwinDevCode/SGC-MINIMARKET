using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGC_MINIMARKET.Clientes_y_Ventas;

namespace SGC_MINIMARKET.Proveedores_y_Compras
{
    public partial class frmGestionProveedores : Form
    {
        static private frmGestionProveedores instancia = null;

        public static frmGestionProveedores Formulario()
        {
            if (instancia == null) { instancia = new frmGestionProveedores(); }
            return instancia;
        }
        public frmGestionProveedores()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
