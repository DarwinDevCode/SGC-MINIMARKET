using SGC_MINIMARKET.Seguridad_y_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_MINIMARKET.Parametros_y_Configuracion
{
    public partial class frmParametros : Form
    {
        static private frmParametros instancia = null;

        public static frmParametros Formulario()
        {
            if (instancia == null) { instancia = new frmParametros(); }
            return instancia;
        }

        public frmParametros()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionParametros frm = frmGestionParametros.Formulario();
            frm.ShowDialog();
        }
    }
}
