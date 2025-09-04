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
    public partial class frmGestionClientes : Form
    {
        static private frmGestionClientes instancia = null;

        public static frmGestionClientes Formulario()
        {
            if (instancia == null) { instancia = new frmGestionClientes(); }
            return instancia;
        }
        public frmGestionClientes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
