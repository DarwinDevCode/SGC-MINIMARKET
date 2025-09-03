using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIACION.Proveedores_y_Compras;

namespace SGC_MINIMARKET.Proveedores_y_Compras
{
    public partial class frmGestionDetalleCompra : Form
    {
        static private frmGestionDetalleCompra instancia = null;
        csComprasProveedoresN clase_compras_proveedores = new csComprasProveedoresN();
        csUsosGenerales clase_usos_generales = new csUsosGenerales();
        public List<(int id, string nombre, decimal precio_unitario, int cantidad)> productos = new List<(int, string, decimal, int)>();
        public DataTable dt_productos = new DataTable();

        public static frmGestionDetalleCompra Formulario()
        {
            if (instancia == null) { instancia = new frmGestionDetalleCompra(); }
            return instancia;
        } 

        public frmGestionDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmGestionCompras frm = frmGestionCompras.Formulario();
            decimal total = 0, subtotal = 0;  string result = "";
            
            foreach (var item in productos)
            {
                result += item.cantidad + ", " + item.nombre + ", " + "$" + item.precio_unitario + '\n';
                subtotal = item.cantidad * item.precio_unitario;
                total += subtotal;
            }

            frm.rtbProductos.Text = result;
            frm.txtTotal.Text = total.ToString();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionCompras frm = frmGestionCompras.Formulario();
            if(cbxProductos.SelectedIndex!= -1 && txtCantidad.Text != string.Empty && txtPrecioUnitario.Text != string.Empty)
            {
                productos.Add(((int)cbxProductos.SelectedValue, cbxProductos.Text, Convert.ToDecimal(txtPrecioUnitario.Text), Convert.ToInt32(txtCantidad.Text)));
                LimpiarControles();    
            }

        }

        public void LimpiarControles()
        {
            cbxProductos.SelectedIndex = -1;
            txtPrecioUnitario.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }

        public void CargarCombobox()
        {
            dt_productos = clase_compras_proveedores.ComboboxListarProductos().Item1;
            clase_usos_generales.RellenarLista(cbxProductos, dt_productos);
        }

        private void frmGestionDetalleCompra_Load(object sender, EventArgs e)
        {
            CargarCombobox();
        }

        private void cbxProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string resultado = clase_usos_generales.SeleccionarItemDataTable(dt_productos, (int)cbxProductos.SelectedValue);
            txtPrecioUnitario.Text = resultado;
        }
    }
}
