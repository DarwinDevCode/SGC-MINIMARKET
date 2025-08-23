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
    }
}
