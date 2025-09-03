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

namespace SGC_MINIMARKET.Productos_e_Inventario
{
    public partial class frmProductos : Form
    {
        static private frmProductos instancia = null;

        public static frmProductos Formulario()
        {
            if (instancia == null) { instancia = new frmProductos(); }
            return instancia;
        }

        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionProductos frm = frmGestionProductos.Formulario();
            frm.ShowDialog();
        }
    }
}
