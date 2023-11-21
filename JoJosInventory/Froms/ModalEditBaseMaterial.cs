using JoJosInventory.Classes;
using JoJosInventory.Data;

namespace JoJosInventory.Froms
{
    public partial class ModalEditBaseMaterial : Form
    {
        LookUp lookup = LookUp.Instance;
        BcRaw Raw = BcRaw.Instance;
        int Id;
        string NamE;
        string Sku;
        public ModalEditBaseMaterial(int id, string name, string sku, DateTime? dtDue, string Qty)
        {
            InitializeComponent();
            cmbCategory.DataSource = lookup.RawCategories;
            cmbSku.DataSource = lookup.RawSku;
            Id = id;
            NamE = name;
            Sku = sku;
            if (dtDue == null) chkDue.Checked = false;
            else
            {
                chkDue.Checked = true;
                dpDue.Value = (DateTime)dtDue;
            }
            
            txtQuantity.Text = Qty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Base bs = Raw.BaseMaterialEdit(Id, cmbCategory.Text, cmbSku.Text, chkDue.Checked ? DateOnly.FromDateTime(dpDue.Value) : null, txtQuantity.Text);
            this.Cursor = Cursors.Default;
            if (!bs.error)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(bs.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ModalEditBaseMaterial_Load(object sender, EventArgs e)
        {
            cmbCategory.Text = NamE;
            cmbSku.Text = Sku;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Length > 0 && cmbSku.Text.Length > 0 && cmbCategory.Text.Length > 0)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void chkDue_CheckedChanged(object sender, EventArgs e)
        {
            dpDue.Enabled = chkDue.Checked;
        }
    }
}
