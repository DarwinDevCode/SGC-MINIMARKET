using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGC_MINIMARKET.Productos_e_Inventario;

namespace SGC_MINIMARKET.Clientes_y_Ventas
{
    public partial class frmClientes : Form
    {
        static private frmClientes instancia = null;

        public static frmClientes Formulario()
        {
            if (instancia == null) { instancia = new frmClientes(); }
            return instancia;
        }

        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionClientes frm = frmGestionClientes.Formulario();
            frm.ShowDialog();
        }
    }
}
