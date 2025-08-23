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

namespace SGC_MINIMARKET.Seguridad_y_Usuarios
{
    public partial class frmRoles : Form
    {
        static private frmRoles instancia = null;
        public static frmRoles Formulario()
        {
            if (instancia == null) { instancia = new frmRoles(); }
            return instancia;
        }

        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionRoles frm = frmGestionRoles.Formulario();
            frm.ShowDialog();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
