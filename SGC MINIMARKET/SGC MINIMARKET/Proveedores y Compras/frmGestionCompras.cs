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
using NEGOCIACION.Proveedores_y_Compras;

namespace SGC_MINIMARKET.Proveedores_y_Compras
{
    public partial class frmGestionCompras : Form
    {
        csUsosGenerales clase_usos_generales = new csUsosGenerales();
        csComprasProveedoresN clase_compras_proveedores = new csComprasProveedoresN();
        static private frmGestionCompras instancia = null;
        public List<(int id, string nombre)> productos = new List<(int, string)>();

        public static frmGestionCompras Formulario()
        {
            if (instancia == null) { instancia = new frmGestionCompras(); }
            return instancia;
        }
        public frmGestionCompras()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            frmGestionDetalleCompra frm = frmGestionDetalleCompra.Formulario();
            frm.ShowDialog();
        }

        public void CargarCombobox()
        {
            clase_usos_generales.RellenarLista(cbxProveedor, clase_compras_proveedores.ComboboxListarProveedores().Item1);
        }

        private void frmGestionCompras_Load(object sender, EventArgs e)
        {
            CargarCombobox();
        }
    }
}
