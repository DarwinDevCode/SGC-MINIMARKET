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
using NEGOCIACION.Seguridad_y_Usuarios;

namespace SGC_MINIMARKET.Seguridad_y_Usuarios
{
    public partial class frmRoles : Form
    {
        csUsosGenerales clase_uso_generales = new csUsosGenerales();
        csGestionRolesN clase_gestion_roles = new csGestionRolesN();
        static frmGestionRoles frm = frmGestionRoles.Formulario();

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

        public void AjustarDgv()
        {
            clase_uso_generales.AjustarTabla(dgvRoles, clase_gestion_roles.ObtenerRoles().Item1);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;

            if (f >= 0) 
            {
                frm.ID = (int)dgvRoles.Rows[f].Cells[0].Value;
                frm.bandera = true;
                frm.txtRol.Text = dgvRoles.Rows[f].Cells[1].Value.ToString();
                frm.ShowDialog();
            }


        }
    }
}
