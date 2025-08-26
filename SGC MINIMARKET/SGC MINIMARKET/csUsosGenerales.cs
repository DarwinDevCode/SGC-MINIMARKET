using System;
using System.Collections;
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

        public void SeleccionarItem(ComboBox lista, string dato)
        {
            foreach (object item in lista.Items)
                if ((item as DataRowView)[1].ToString() == dato)
                {
                    lista.SelectedItem = item;
                    break;
                }
        }

        public void RellenarLista(ComboBox lista, DataTable datos)
        {
            lista.DataSource = datos;
            lista.ValueMember = datos.Columns[0].ColumnName;
            lista.DisplayMember = datos.Columns[1].ColumnName;
            lista.SelectedIndex = -1;
        }

        public string SeleccionarItemDataTable(DataTable dt, int id)
        {
            string result = null;
            foreach (DataRow row in dt.Rows)
                foreach (DataColumn col in dt.Columns)
                {
                    if (col.ColumnName == "ID_PRODUCTO" && id.ToString() == row[col].ToString())
                    {
                        result = row["PRECIO_COMPRA"].ToString();
                        break;
                    }
                }
            return result;
        }
    }
}
