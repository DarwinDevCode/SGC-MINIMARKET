using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_MINIMARKET.Productos_e_Inventario
{
    public partial class frmGestionProductos : Form
    {
        static private frmGestionProductos instancia = null;

        public static frmGestionProductos Formulario()
        {
            if (instancia == null) { instancia = new frmGestionProductos(); }
            return instancia;
        }

        public frmGestionProductos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
