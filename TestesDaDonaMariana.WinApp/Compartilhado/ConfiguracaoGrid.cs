﻿namespace TestesDaDonaMariana.WinApp.Compartilhado
{
    public static class ConfiguracaoGrid
    {
        public static void ConfigurarGridZebrado(this DataGridView grid)
        {
            Font font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

            DataGridViewCellStyle linhaEscura = new DataGridViewCellStyle
            {
                BackColor = Color.RosyBrown,
                Font = font,
                ForeColor = Color.Black,
                SelectionBackColor = Color.Gray,
                SelectionForeColor = Color.Black
            };

            grid.AlternatingRowsDefaultCellStyle = linhaEscura;

            DataGridViewCellStyle linhaClara = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = font,
                ForeColor = Color.Black,
                SelectionBackColor = Color.Gray,
                SelectionForeColor = Color.Black
            };

            grid.RowsDefaultCellStyle = linhaClara;
        }

        public static void ConfigurarGridSomenteLeitura(this DataGridView grid)
        {
            grid.RowHeadersVisible = false;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.RosyBrown;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.RosyBrown;

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            grid.BorderStyle = BorderStyle.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            grid.MultiSelect = false;
            grid.ReadOnly = true;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoGenerateColumns = false;

            grid.AllowUserToResizeRows = false;

            grid.RowsAdded += (sender, e) =>
            {
                grid.ClearSelection();
            };

            grid.RowsRemoved += (sender, e) =>
            {
                grid.ClearSelection();
            };
        }

        public static T SelecionarNumero<T>(this DataGridView grid)
        {
            const int firstLine = 0, firstColumn = 0;
            if (grid.SelectedRows.Count == 0)
                return default(T);

            object value = grid.SelectedRows[firstLine].Cells[firstColumn].Value;
            
            if (value == null)
                return default(T);

            return (T)Convert.ChangeType(value, typeof(T));
        }

        public static T SelecionarLetra<T>(this DataGridView grid)
        {
            const int firstLine = 0, firstColumn = 0;
            if (grid.SelectedRows.Count == 0)
                return default(T);

            Dictionary<string, int> meuDicionario = new Dictionary<string, int>()
            {
                { "a.", 1 },
                { "b.", 2 },
                { "c.", 3 },
                { "d.", 4 },
                { "e.", 5 }
            };

            object value = grid.SelectedRows[firstLine].Cells[firstColumn].Value;

            object num = meuDicionario[value.ToString()];

            if (num == null)
                return default(T);

            return (T)Convert.ChangeType(num, typeof(T));
        }
    }
}