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
    public partial class frmCompras : Form
    {
        static private frmCompras instancia = null;
        public static frmCompras Formulario()
        {
            if (instancia == null) { instancia = new frmCompras(); }
            return instancia;
        }

        public frmCompras()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionCompras frm = frmGestionCompras.Formulario();
            frm.ShowDialog();
        }
    }
}
