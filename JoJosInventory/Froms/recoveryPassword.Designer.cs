namespace JoJosInventory.Froms
{
    partial class recoveryPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            btnBack = new Button();
            txtEmail = new TextBox();
            label1 = new Label();
            btnRecovery = new Button();
            pn01 = new Panel();
            pn02 = new Panel();
            btnReset = new Button();
            label2 = new Label();
            button1 = new Button();
            btnUp = new Button();
            label3 = new Label();
            txtCode = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pn03 = new Panel();
            label7 = new Label();
            TxtRePassword = new TextBox();
            btnSave = new Button();
            label5 = new Label();
            bntCancel = new Button();
            label6 = new Label();
            txtPassword = new TextBox();
            pn01.SuspendLayout();
            pn02.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pn03.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(47, 14);
            label4.Name = "label4";
            label4.Size = new Size(320, 30);
            label4.TabIndex = 15;
            label4.Text = "JoJos Inventory Management";
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBack.BackColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(308, 125);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 27);
            btnBack.TabIndex = 13;
            btnBack.Text = "&Back to login";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(5, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email";
            txtEmail.Size = new Size(391, 23);
            txtEmail.TabIndex = 8;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 69);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 9;
            label1.Text = "Email";
            // 
            // btnRecovery
            // 
            btnRecovery.AutoSize = true;
            btnRecovery.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRecovery.BackColor = Color.White;
            btnRecovery.Enabled = false;
            btnRecovery.FlatStyle = FlatStyle.Flat;
            btnRecovery.Location = new Point(200, 125);
            btnRecovery.Name = "btnRecovery";
            btnRecovery.Size = new Size(100, 27);
            btnRecovery.TabIndex = 12;
            btnRecovery.Text = "&Reset password";
            btnRecovery.UseVisualStyleBackColor = false;
            btnRecovery.Click += btnRecovery_Click;
            // 
            // pn01
            // 
            pn01.Controls.Add(label4);
            pn01.Controls.Add(btnRecovery);
            pn01.Controls.Add(btnBack);
            pn01.Controls.Add(label1);
            pn01.Controls.Add(txtEmail);
            pn01.Location = new Point(0, 0);
            pn01.Margin = new Padding(0);
            pn01.Name = "pn01";
            pn01.Size = new Size(400, 166);
            pn01.TabIndex = 16;
            // 
            // pn02
            // 
            pn02.Controls.Add(btnReset);
            pn02.Controls.Add(label2);
            pn02.Controls.Add(button1);
            pn02.Controls.Add(btnUp);
            pn02.Controls.Add(label3);
            pn02.Controls.Add(txtCode);
            pn02.Location = new Point(0, 166);
            pn02.Margin = new Padding(0);
            pn02.Name = "pn02";
            pn02.Size = new Size(400, 169);
            pn02.TabIndex = 17;
            pn02.Visible = false;
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReset.BackColor = Color.White;
            btnReset.Enabled = false;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(246, 125);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 27);
            btnReset.TabIndex = 16;
            btnReset.Text = "&Reset password";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 14);
            label2.Name = "label2";
            label2.Size = new Size(320, 30);
            label2.TabIndex = 15;
            label2.Text = "JoJos Inventory Management";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(154, 125);
            button1.Name = "button1";
            button1.Size = new Size(86, 27);
            button1.TabIndex = 12;
            button1.Text = "&Resend code";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // btnUp
            // 
            btnUp.AutoSize = true;
            btnUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUp.BackColor = Color.White;
            btnUp.FlatStyle = FlatStyle.Flat;
            btnUp.Location = new Point(352, 125);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(44, 27);
            btnUp.TabIndex = 13;
            btnUp.Text = "&Back";
            btnUp.UseVisualStyleBackColor = false;
            btnUp.Click += btnUp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 69);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 9;
            label3.Text = "Code sent to your email";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(5, 87);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Code";
            txtCode.Size = new Size(391, 23);
            txtCode.TabIndex = 8;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pn01);
            flowLayoutPanel1.Controls.Add(pn02);
            flowLayoutPanel1.Controls.Add(pn03);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(402, 187);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // pn03
            // 
            pn03.Controls.Add(label7);
            pn03.Controls.Add(TxtRePassword);
            pn03.Controls.Add(btnSave);
            pn03.Controls.Add(label5);
            pn03.Controls.Add(bntCancel);
            pn03.Controls.Add(label6);
            pn03.Controls.Add(txtPassword);
            pn03.Location = new Point(0, 335);
            pn03.Margin = new Padding(0);
            pn03.Name = "pn03";
            pn03.Size = new Size(400, 184);
            pn03.TabIndex = 18;
            pn03.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(5, 98);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 18;
            label7.Text = "Re-Password";
            // 
            // TxtRePassword
            // 
            TxtRePassword.Location = new Point(5, 116);
            TxtRePassword.Name = "TxtRePassword";
            TxtRePassword.PlaceholderText = "Re-Password";
            TxtRePassword.Size = new Size(391, 23);
            TxtRePassword.TabIndex = 17;
            TxtRePassword.TextChanged += TxtRePassword_TextChanged;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.BackColor = Color.White;
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(215, 151);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 27);
            btnSave.TabIndex = 16;
            btnSave.Text = "&Save new password";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 14);
            label5.Name = "label5";
            label5.Size = new Size(320, 30);
            label5.TabIndex = 15;
            label5.Text = "JoJos Inventory Management";
            // 
            // bntCancel
            // 
            bntCancel.AutoSize = true;
            bntCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bntCancel.BackColor = Color.White;
            bntCancel.FlatStyle = FlatStyle.Flat;
            bntCancel.Location = new Point(342, 151);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(55, 27);
            bntCancel.TabIndex = 13;
            bntCancel.Text = "&Cancel";
            bntCancel.UseVisualStyleBackColor = false;
            bntCancel.Click += bntCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(5, 47);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 9;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(5, 65);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(391, 23);
            txtPassword.TabIndex = 8;
            // 
            // recoveryPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(425, 212);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "recoveryPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "recoveryPassword";
            pn01.ResumeLayout(false);
            pn01.PerformLayout();
            pn02.ResumeLayout(false);
            pn02.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            pn03.ResumeLayout(false);
            pn03.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Button btnBack;
        private TextBox txtEmail;
        private Label label1;
        private Button btnRecovery;
        private Panel pn01;
        private Panel pn02;
        private Label label2;
        private Button button1;
        private Button btnUp;
        private Label label3;
        private TextBox txtCode;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnReset;
        private Panel pn03;
        private Button btnSave;
        private Label label5;
        private Button bntCancel;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;
        private TextBox TxtRePassword;
    }
}