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
        int idCompra; bool resultado1, resultado2 = false;

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionDetalleCompra frm = frmGestionDetalleCompra.Formulario();
            frmCompras frm1 = frmCompras.Formulario();

            if(cbxProveedor.SelectedIndex!= -1 && rtbProductos.Text != string.Empty && txtTotal.Text != string.Empty)
            {
                (resultado1, idCompra) = clase_compras_proveedores.InsertarCompra((int)cbxProveedor.SelectedValue, DateTime.Now, Convert.ToDecimal(txtTotal.Text));
                if (resultado1)
                {
                    foreach (var item in frm.productos)
                        resultado2 = clase_compras_proveedores.InsertarDetalleCompra(idCompra, item.id, item.cantidad, item.precio_unitario);
                    if (resultado2)
                    {
                        MessageBox.Show("Compra realizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                        frm1.AjustarDgv();
                    }

                }
            }
        }

        public void LimpiarControles()
        {
            cbxProveedor.SelectedIndex = -1;
            rtbProductos.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtTotal.Text = string.Empty;
        }
    }
}
