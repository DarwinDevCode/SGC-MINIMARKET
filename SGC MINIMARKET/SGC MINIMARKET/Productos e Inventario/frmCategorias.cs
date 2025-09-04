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
using SGC_MINIMARKET.Seguridad_y_Usuarios;

namespace SGC_MINIMARKET.Productos_e_Inventario
{
    public partial class frmCategorias : Form
    {
        static private frmCategorias instancia = null;
        csUsosGenerales clase_usos_generales = new csUsosGenerales();
        csGestionCategoriasN clase_gestion_categorias = new csGestionCategoriasN();

        public static frmCategorias Formulario()
        {
            if (instancia == null) { instancia = new frmCategorias(); }
            return instancia;
        }

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionCategorias frm = frmGestionCategorias.Formulario();
            frm.bandera = false;
            frm.ShowDialog();
        }

        public void AjustarDgv()
        {
            clase_usos_generales.AjustarTabla(dgvCategorias, clase_gestion_categorias.ObtenerCategorias().Item1);
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            AjustarDgv();
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if(f >= 0)
            {
                frmGestionCategorias frm = frmGestionCategorias.Formulario();

                int id_categoria = (int)dgvCategorias.Rows[f].Cells[0].Value;
                string nombre_categoria = dgvCategorias.Rows[f].Cells[1].Value.ToString();
                string descripcion_categoria = dgvCategorias.Rows[f].Cells[2].Value.ToString();
                frm.id_categoria = id_categoria;
                frm.txtNombreCategoria.Text = nombre_categoria;
                frm.txtDescripcionCategoria.Text = descripcion_categoria;
                frm.bandera = true;
                frm.ShowDialog();
            }
        }
    }
}
