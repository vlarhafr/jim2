using JoJosInventory.Classes;
using System.Data;
using JoJosInventory.Data;
using JoJosInventory.Froms;
using Microsoft.VisualBasic;

namespace JoJosInventory.Controls
{
    public partial class BaseMaterial : UserControl
    {
        BcRaw Raw = BcRaw.Instance;
        Base bc;
        bool expanded = false;
        LookUp lookup = LookUp.Instance;

        public BaseMaterial()
        {
            InitializeComponent();
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            searchFilters();
            cmbCategory.DataSource = lookup.RawCategories;
            cmbSku.DataSource = lookup.RawSku;
        }

        private void Formatdgv()
        {
            dgv.Columns.Clear();
            DataTable dt = (DataTable)bc.objet;
            dgv.DataSource = bc.objet;

            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.Name = "ToDelete";
            chkColumn.HeaderText = "To delete";
            dgv.Columns.Add(chkColumn);
            dgv.Columns["ToDelete"].DisplayIndex = 0;

            dgv.Columns["Id"].Visible = false;
            dgv.Columns["Name"].HeaderText = "Category";
            dgv.Columns["Sku"].HeaderText = "SKU";
            dgv.Columns["DueDate"].HeaderText = "Due date";
            dgv.Columns["CurrentAmount"].HeaderText = "Qty on hand";
            dgv.Columns["AmountLocked"].HeaderText = "Qty reserved";
            dgv.Columns["QtyAvailable"].HeaderText = "Qty Available";

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Edit";
            btnColumn.HeaderText = "Edit";
            btnColumn.Text = "Edit";
            btnColumn.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(btnColumn);

            dgv.Columns["ToDelete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["DueDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["CurrentAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["AmountLocked"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["QtyAvailable"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.Columns["ToDelete"].ReadOnly = false;
            dgv.Columns["Name"].ReadOnly = true;
            dgv.Columns["Sku"].ReadOnly = true;
            dgv.Columns["CurrentAmount"].ReadOnly = true;
            dgv.Columns["AmountLocked"].ReadOnly = true;
            dgv.Columns["QtyAvailable"].ReadOnly = true;
            dgv.Columns["Edit"].ReadOnly = false;

            dgv_Resize();
        }
        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                pnSearch.Height = 38;
                expanded = false;
                btnExpand.ImageIndex = 1;

            }
            else
            {
                pnSearch.Height = 120;
                expanded = true;
                btnExpand.ImageIndex = 0;
            }
            dgv.Height = FlPanel.Height - pnSearch.Height - 10;

        }

        private void FlPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control child in FlPanel.Controls)
            {
                child.Width = FlPanel.Width - 10;
            }
            dgv.Height = FlPanel.Height - pnSearch.Height - 10;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModalAddNewBaseMaterial f1 = new ModalAddNewBaseMaterial();
            DialogResult result = f1.ShowDialog();

            if (result == DialogResult.OK)
            {
                searchFilters();
            }
            else
            {
                //click on cancel
            }
        }
        private void dgv_Resize()
        {
            if (dgv.Columns.Count > 0)
            {
                int width = dgv.Width - 21;
                dgv.Columns["ToDelete"].Width = width / 11;
                dgv.Columns["Id"].Width = 1;
                dgv.Columns["Name"].Width = width / 6;
                dgv.Columns["Sku"].Width = width / 8;
                dgv.Columns["DueDate"].Width = width / 9;
                dgv.Columns["CurrentAmount"].Width = width / 7;
                dgv.Columns["AmountLocked"].Width = width / 7;
                dgv.Columns["QtyAvailable"].Width = width / 7;
                dgv.Columns["Edit"].Width = width / 12;
            }
        }

        private void dgv_Resize(object sender, EventArgs e)
        {
            dgv_Resize();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit buttons
            if (e.ColumnIndex == dgv.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int Id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);
                string Name = dgv.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string Sku = dgv.Rows[e.RowIndex].Cells["Sku"].Value.ToString();
                DateTime? dueDate = null;
                if (dgv.Rows[e.RowIndex].Cells["DueDate"].Value != null)
                {
                    try
                    {
                        dueDate = DateTime.Parse(dgv.Rows[e.RowIndex].Cells["DueDate"].Value.ToString());
                    }catch(Exception) { }
                 
                }
                string Qty = dgv.Rows[e.RowIndex].Cells["CurrentAmount"].Value.ToString();


                ModalEditBaseMaterial f1 = new ModalEditBaseMaterial(Id, Name, Sku, dueDate, Qty);
                DialogResult result = f1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Update Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    searchFilters();
                }
                else
                {
                    //click on cancel
                }
            }
        }

        private void searchFilters()
        {
            this.Cursor = Cursors.WaitCursor;
            bc = Raw.BaseMaterialSearch(cmbCategory.Text, chkDue.Checked ? DateOnly.FromDateTime(dpDate.Value) : null, cmbSku.Text);
            if (!bc.error)
            {
                Formatdgv();
            }
            this.Cursor = Cursors.Default;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchFilters();
        }

        private void chkDue_CheckedChanged(object sender, EventArgs e)
        {
            dpDate.Enabled = chkDue.Checked;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCategory.Text = "";
            chkDue.Checked = false;
            cmbSku.Text = string.Empty;
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Check to delete            
            if (e.ColumnIndex == dgv.Columns["ToDelete"].Index && e.RowIndex >= 0)
            {
                //bool isCheckeo = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells["ToDelete"].Value);
                bool test = false;

                foreach (DataGridViewRow row in dgv.Rows)
                {

                    if (row.Cells["todelete"] != null && row.Cells["toDelete"].Value != null && !row.IsNewRow)
                    {
                        bool isChecked = Convert.ToBoolean(row.Cells["toDelete"].Value);
                        if (isChecked)
                        {
                            int rowIndex = row.Index;
                            test = true;
                        }
                    }
                }
                if (test) { btnDelete.Enabled = true; } else { btnDelete.Enabled = false; }
            }

        }

        private void dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv.IsCurrentCellDirty)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var resp = MessageBox.Show("This operation cannot be reversed, do you wish to delete the selected materials?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resp.ToString() == "Yes")
            {
                this.Cursor = Cursors.WaitCursor;
                List<string> markedIds = new List<string>();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells["ToDelete"] != null && row.Cells["ToDelete"].Value != null && !row.IsNewRow)
                    {
                        bool isChecked = Convert.ToBoolean(row.Cells["ToDelete"].Value);
                        if (isChecked)
                        {
                            string id = row.Cells["Id"].Value.ToString();
                            markedIds.Add(id);
                        }
                    }
                }
                string formattedIds = "(" + string.Join(",", markedIds) + ")";
                Base bs = Raw.BaseMaterialDelete(formattedIds);
                if (bs.error == false) { searchFilters(); } else { MessageBox.Show(bs.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                this.Cursor = Cursors.Default;
            }
        }

        private void BaseMaterial_Load(object sender, EventArgs e)
        {
            cmbSku.Text = "";
            cmbCategory.Text = "";
        }
    }
}
