using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.Compartilhado
{
    public static class DataGridViewExtensions
    {
        public static void ConfugrarGrid (this DataGridView grid) 
        {
            grid.AllowUserToResizeColumns = true;
            grid.RowHeadersVisible = false;
            grid.MultiSelect = false;
        }

        public static void ConfigurarGridZebrado (this DataGridView grid)
        {
            DataGridViewCellStyle linhaEscura = new DataGridViewCellStyle
            {
                BackColor = Color.LightBlue,
                ForeColor = Color.White,
                SelectionBackColor = Color.SteelBlue,
                SelectionForeColor = Color.White,
            };

            grid.AlternatingRowsDefaultCellStyle = linhaEscura;
        }

        public static int SelecionarId (this DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0)
            {
                return -1;
            }

            object valorSelecionado = grid
                .SelectedRows[0]
                .Cells[0]
                .Value;

            if (valorSelecionado == null)
                return -1;

            return (int)valorSelecionado;
        }
    }
}
