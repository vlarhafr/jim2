using JoJosInventory.Classes;
namespace JoJosInventory.Froms
{
    public partial class recoveryPassword : Form
    {
        private string idLocal;
        BcLogin login = BcLogin.Instance;

        public recoveryPassword()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (login.ForgotPassword(txtEmail.Text))
            {
                pn01.Visible = false;
                pn02.Visible = true;
                pn03.Visible = false;
            }
            else
            {
                MessageBox.Show("There is no active account associated with this email", "Email problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Cursor = Cursors.Default;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            pn02.Visible = false;
            pn01.Visible = true;
            pn03.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (Classes.UtilityClass.IsValidEmail(txtEmail.Text)) { btnRecovery.Enabled = true; } else { btnRecovery.Enabled = false; }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            idLocal = login.CheckReset(txtEmail.Text, txtCode.Text);
            if (idLocal != "0")
            {
                pn01.Visible = false;
                pn02.Visible = false;
                pn03.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid code", "Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Cursor = Cursors.Default;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 5) { btnReset.Enabled = true; } else { btnReset.Enabled = false; }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtRePassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 5 && txtPassword.Text == TxtRePassword.Text)
            { btnSave.Enabled = true; }
            else { btnSave.Enabled = false; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (login.SetNewPassword(idLocal, txtPassword.Text))
            {
                MessageBox.Show("New password created successfully", "New password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                MessageBox.Show("Problems creating a new password. Please try later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
