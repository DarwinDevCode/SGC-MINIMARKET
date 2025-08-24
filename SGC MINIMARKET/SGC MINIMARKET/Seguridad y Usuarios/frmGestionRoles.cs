using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIACION.Seguridad_y_Usuarios;

namespace SGC_MINIMARKET.Seguridad_y_Usuarios
{
    public partial class frmGestionRoles : Form
    {
        static private frmGestionRoles instancia = null;
        csGestionRolesN clase_gestion_roles = new csGestionRolesN();

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRoles frm = frmRoles.Formulario();
            if (txtRol.Text != string.Empty)
            {
                clase_gestion_roles.InsertarRol(txtRol.Text);
                frm.AjustarDgv();
            }
        }
    }
}
