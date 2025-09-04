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
    public partial class frmGestionCategorias : Form
    {
        static private frmGestionCategorias instancia = null;

        public static frmGestionCategorias Formulario()
        {
            if (instancia == null) { instancia = new frmGestionCategorias(); }
            return instancia;
        }

        public frmGestionCategorias()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
