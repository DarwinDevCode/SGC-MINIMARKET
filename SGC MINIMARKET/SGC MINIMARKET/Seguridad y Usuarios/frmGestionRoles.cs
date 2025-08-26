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
        csGestionRolesN clase_gestion_roles = new csGestionRolesN();
        frmRoles frm = frmRoles.Formulario();
        static private frmGestionRoles instancia = null;
        public int ID = 0;
        public bool bandera = false;

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
            if (bandera)
                if (txtRol.Text != string.Empty)
                {
                    bool resultado = clase_gestion_roles.ActualizarRol(ID, txtRol.Text);
                    if (resultado) 
                        MessageBox.Show("Rol actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    frm.AjustarDgv(); LimpiarControles();
                }
            else
                if (txtRol.Text != string.Empty)
                {
                    bool resultado = clase_gestion_roles.InsertarRol(txtRol.Text);
                    if (resultado)
                        MessageBox.Show("Rol agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm.AjustarDgv(); LimpiarControles();
                }

        }

        public void LimpiarControles()
        {
            txtRol.Clear();
        }
    }
}
