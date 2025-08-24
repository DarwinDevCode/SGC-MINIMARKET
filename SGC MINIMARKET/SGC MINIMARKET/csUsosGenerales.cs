using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_MINIMARKET
{
    internal class csUsosGenerales
    {
        public void AjustarTabla(DataGridView tabla, DataTable datos)
        {
            tabla.DataSource = datos;

            int anchodgv = tabla.ClientSize.Width - 21;
            int anchocolumn = anchodgv / tabla.Columns.Count;

            for (int i = 0; i < tabla.ColumnCount - 1; i++)
                tabla.Columns[i].Width = anchocolumn;
            tabla.Columns[tabla.Columns.Count - 1].Width = anchodgv - (anchocolumn * (tabla.Columns.Count - 1));
        }
    }
}
