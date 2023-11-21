using JoJosInventory.Classes;
using JoJosInventory.Data;

namespace JoJosInventory.Froms
{
    public partial class Login : Form
    {
        DbSingleton myDb = DbSingleton.Instance;
        BcLogin login = BcLogin.Instance;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (login.Login(txtUserName.Text, txtPassword.Text))
            {
                MainForm newMain = new MainForm();
                newMain.FormClosed += new FormClosedEventHandler(NewMain_FormClosed);
                newMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User and password error", "Authentication failured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Cursor = Cursors.Default;
        }
        private void NewMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            recoveryPassword newRecovery = new recoveryPassword();
            newRecovery.FormClosed += new FormClosedEventHandler(NewRecovery_FormClosed);
            newRecovery.Show();
            this.Hide();
        }
        private void NewRecovery_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length > 4 && txtPassword.Text.Length > 4)
            { btnLogin.Enabled = true; }
            else { btnLogin.Enabled = false; }
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (!UtilityClass.CheckInternetConnection())
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("There is no connection to the network,\r\nPlease try again later", "No network connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            string result = await UtilityClass.GetApiDataAsync("http://15.204.8.66/credentials");
            result = EncryptionHelper.DecryptString(result);
            myDb.CreateConnection("Server=15.204.8.66;Database=jojosInventory;User Id=jim;Password=Jim123456++;");
            this.Cursor = Cursors.Default;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            myDb.CloseConnection();
        }
    }
}
