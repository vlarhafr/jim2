

namespace JoJosInventory.Controls
{
    public partial class BaseMaterial : UserControl
    {
        bool expanded = false;
        public BaseMaterial()
        {
            InitializeComponent();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                pnSearch.Height = 36;
                expanded = false;
                btnExpand.ImageIndex = 1;

            }
            else
            {
                pnSearch.Height = 100;
                expanded = true;
                btnExpand.ImageIndex = 0;
            }
            dgv.Height = FlPanel.Height - pnSearch.Height  - 10;

        }

        private void FlPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control child in FlPanel.Controls)
            {
                child.Width = FlPanel.Width - 10;
            }
            dgv.Height = FlPanel.Height - pnSearch.Height  - 10;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // Configurando columnas (4 columnas en este caso)
            dgv.ColumnCount = 4;
            dgv.Columns[0].Name = "Columna 1";
            dgv.Columns[1].Name = "Columna 2";
            dgv.Columns[2].Name = "Columna 3";
            dgv.Columns[3].Name = "Columna 4";
            for (int i = 0; i < 30; i++)
            {
                string[] row = new string[] { $"Dato {i + 1}, 1", $"Dato {i + 1}, 2", $"Dato {i + 1}, 3", $"Dato {i + 1}, 4" };
                dgv.Rows.Add(row);
            }
        }
    }
}
