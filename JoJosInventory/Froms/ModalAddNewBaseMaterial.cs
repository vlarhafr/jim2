using JoJosInventory.Classes;
using JoJosInventory.Data;
using Microsoft.VisualBasic;


namespace JoJosInventory.Froms
{
    public partial class ModalAddNewBaseMaterial : Form
    {
        LookUp lookup = LookUp.Instance;
        BcRaw Raw = BcRaw.Instance;
        public ModalAddNewBaseMaterial()
        {
            InitializeComponent();
            cmbCategory.DataSource = lookup.RawCategories;
            cmbSku.DataSource = lookup.RawSku;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Base bs = Raw.BaseMaterialAdd(cmbCategory.Text, cmbSku.Text, chkDue.Checked ? DateOnly.FromDateTime(dpDue.Value) : null, txtQuantity.Text);
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

        private void ModalAddNewBaseMaterial_Load(object sender, EventArgs e)
        {
            cmbCategory.Text = "";
            cmbSku.Text = "";
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
