using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIACION.Productos_e_Inventario;

namespace SGC_MINIMARKET.Productos_e_Inventario
{
    public partial class frmGestionCategorias : Form
    {
        static private frmGestionCategorias instancia = null;
        csGestionCategoriasN clase_gestion_categorias = new csGestionCategoriasN();
        public bool bandera = false, resultado;
        public int id_categoria;

        public static frmGestionCategorias Formulario()
        {
            if (instancia == null) { instancia = new frmGestionCategorias(); }
            return instancia;
        }

        public frmGestionCategorias()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCategorias frm = frmCategorias.Formulario();

            if (bandera)
            {
                if (txtNombreCategoria.Text != string.Empty)
                {
                    resultado = clase_gestion_categorias.ActualizarCategoria(id_categoria, txtNombreCategoria.Text, txtDescripcionCategoria.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Categoria actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.AjustarDgv(); LimpiarControles(); this.Close();
                    }
                }
            }
            else
            {
                if (txtNombreCategoria.Text != string.Empty)
                {
                    resultado = clase_gestion_categorias.InsertarCategoria(txtNombreCategoria.Text, txtDescripcionCategoria.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Categoria agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.AjustarDgv(); LimpiarControles();
                    }
                }
            }
        }

        public void LimpiarControles()
        {
            txtDescripcionCategoria.Text = string.Empty;
            txtNombreCategoria.Text = string.Empty;
        }
    }
}
