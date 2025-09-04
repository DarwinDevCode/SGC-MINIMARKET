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

namespace SGC_MINIMARKET.Clientes_y_Ventas
{
    public partial class frmVentas : Form
    {
        static private frmVentas instancia = null;
        public static frmVentas Formulario()
        {
            if (instancia == null) { instancia = new frmVentas(); }
            return instancia;
        }

        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
