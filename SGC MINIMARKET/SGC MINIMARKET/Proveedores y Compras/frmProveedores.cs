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
    public partial class frmProveedores : Form
    {
        static private frmProveedores instancia = null;

        public static frmProveedores Formulario()
        {
            if (instancia == null) { instancia = new frmProveedores(); }
            return instancia;
        }
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionProveedores frm = frmGestionProveedores.Formulario();
            frm.ShowDialog();
        }
    }
}
