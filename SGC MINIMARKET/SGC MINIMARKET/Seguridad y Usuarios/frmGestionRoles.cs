using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_MINIMARKET.Seguridad_y_Usuarios
{
    public partial class frmGestionRoles : Form
    {
        static private frmGestionRoles instancia = null;
        public static frmGestionRoles Formulario()
        {
            if (instancia == null) { instancia = new frmGestionRoles(); }
            return instancia;
        }

        public frmGestionRoles()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
