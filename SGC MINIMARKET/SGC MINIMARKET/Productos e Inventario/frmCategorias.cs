using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGC_MINIMARKET.Seguridad_y_Usuarios;

namespace SGC_MINIMARKET.Productos_e_Inventario
{
    public partial class frmCategorias : Form
    {
        static private frmCategorias instancia = null;

        public static frmCategorias Formulario()
        {
            if (instancia == null) { instancia = new frmCategorias(); }
            return instancia;
        }

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionCategorias frm = frmGestionCategorias.Formulario();
            frm.ShowDialog();
        }
    }
}
