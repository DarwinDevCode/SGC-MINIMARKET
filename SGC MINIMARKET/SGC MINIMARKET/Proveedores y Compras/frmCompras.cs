using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTILIDADES;
using NEGOCIACION.Proveedores_y_Compras;

namespace SGC_MINIMARKET.Proveedores_y_Compras
{
    public partial class frmCompras : Form
    {
        static private frmCompras instancia = null;
        csComprasProveedoresN clase_compras_proveedores = new csComprasProveedoresN();
        csUsosGenerales clase_uso_generales = new csUsosGenerales();

        public static frmCompras Formulario()
        {
            if (instancia == null) { instancia = new frmCompras(); }
            return instancia;
        }

        public frmCompras()
        {
            InitializeComponent();
        }
        public void AjustarDgv()
        {
            clase_uso_generales.AjustarTabla(dgvCompras, clase_compras_proveedores.ListarCompras().Item1);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionCompras frm = frmGestionCompras.Formulario();
            frm.ShowDialog();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            AjustarDgv();
        }
    }
}
