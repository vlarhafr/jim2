namespace JoJosInventory
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            btnUser = new Button();
            lblTitle = new Label();
            picMain = new PictureBox();
            flMenu = new FlowLayoutPanel();
            pnCo = new Panel();
            btnCO = new Button();
            pnMo = new Panel();
            bntMo = new Button();
            pnDmp = new Panel();
            btnDmp = new Button();
            imageList = new ImageList(components);
            flDamage = new FlowLayoutPanel();
            panel2 = new Panel();
            btnDmPp = new Button();
            panel4 = new Panel();
            btnDmBm = new Button();
            panel3 = new Panel();
            btnPpl = new Button();
            panel5 = new Panel();
            btnBaseMaterial = new Button();
            panel6 = new Panel();
            btnAdmin = new Button();
            timerSubMenuTransition = new System.Windows.Forms.Timer(components);
            timerMenuTransition = new System.Windows.Forms.Timer(components);
            pnMain = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMain).BeginInit();
            flMenu.SuspendLayout();
            pnCo.SuspendLayout();
            pnMo.SuspendLayout();
            pnDmp.SuspendLayout();
            flDamage.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(picMain);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 33);
            panel1.TabIndex = 0;
            // 
            // btnUser
            // 
            btnUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUser.AutoSize = true;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Location = new Point(712, 3);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(78, 27);
            btnUser.TabIndex = 3;
            btnUser.Text = "John Smith";
            btnUser.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(42, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 15);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Jojos Inventory Management";
            // 
            // picMain
            // 
            picMain.BackColor = Color.Transparent;
            picMain.Image = (Image)resources.GetObject("picMain.Image");
            picMain.Location = new Point(9, 6);
            picMain.Name = "picMain";
            picMain.Size = new Size(24, 24);
            picMain.SizeMode = PictureBoxSizeMode.AutoSize;
            picMain.TabIndex = 1;
            picMain.TabStop = false;
            picMain.Click += picMain_Click;
            // 
            // flMenu
            // 
            flMenu.BackColor = Color.WhiteSmoke;
            flMenu.Controls.Add(pnCo);
            flMenu.Controls.Add(pnMo);
            flMenu.Controls.Add(pnDmp);
            flMenu.Controls.Add(flDamage);
            flMenu.Controls.Add(panel3);
            flMenu.Controls.Add(panel5);
            flMenu.Controls.Add(panel6);
            flMenu.Dock = DockStyle.Left;
            flMenu.Location = new Point(0, 33);
            flMenu.Name = "flMenu";
            flMenu.Size = new Size(232, 417);
            flMenu.TabIndex = 1;
            // 
            // pnCo
            // 
            pnCo.Controls.Add(btnCO);
            pnCo.Location = new Point(3, 3);
            pnCo.Name = "pnCo";
            pnCo.Size = new Size(230, 31);
            pnCo.TabIndex = 3;
            // 
            // btnCO
            // 
            btnCO.BackColor = Color.WhiteSmoke;
            btnCO.Dock = DockStyle.Fill;
            btnCO.FlatAppearance.BorderSize = 0;
            btnCO.FlatStyle = FlatStyle.Flat;
            btnCO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCO.ForeColor = Color.Black;
            btnCO.Image = (Image)resources.GetObject("btnCO.Image");
            btnCO.ImageAlign = ContentAlignment.MiddleLeft;
            btnCO.Location = new Point(0, 0);
            btnCO.Name = "btnCO";
            btnCO.Size = new Size(230, 31);
            btnCO.TabIndex = 1;
            btnCO.Tag = "Co";
            btnCO.Text = "            Customer Orders";
            btnCO.TextAlign = ContentAlignment.MiddleLeft;
            btnCO.UseVisualStyleBackColor = false;
            btnCO.Click += btnMenu_Click;
            // 
            // pnMo
            // 
            pnMo.Controls.Add(bntMo);
            pnMo.Location = new Point(3, 40);
            pnMo.Name = "pnMo";
            pnMo.Size = new Size(230, 31);
            pnMo.TabIndex = 4;
            // 
            // bntMo
            // 
            bntMo.BackColor = Color.WhiteSmoke;
            bntMo.Dock = DockStyle.Fill;
            bntMo.FlatAppearance.BorderSize = 0;
            bntMo.FlatStyle = FlatStyle.Flat;
            bntMo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bntMo.ForeColor = Color.Black;
            bntMo.Image = (Image)resources.GetObject("bntMo.Image");
            bntMo.ImageAlign = ContentAlignment.MiddleLeft;
            bntMo.Location = new Point(0, 0);
            bntMo.Name = "bntMo";
            bntMo.Size = new Size(230, 31);
            bntMo.TabIndex = 1;
            bntMo.Tag = "Mo";
            bntMo.Text = "            Manufacturing Orders";
            bntMo.TextAlign = ContentAlignment.MiddleLeft;
            bntMo.UseVisualStyleBackColor = false;
            bntMo.Click += btnMenu_Click;
            // 
            // pnDmp
            // 
            pnDmp.Controls.Add(btnDmp);
            pnDmp.Location = new Point(3, 77);
            pnDmp.Margin = new Padding(3, 3, 3, 0);
            pnDmp.Name = "pnDmp";
            pnDmp.Size = new Size(230, 31);
            pnDmp.TabIndex = 6;
            // 
            // btnDmp
            // 
            btnDmp.BackColor = Color.WhiteSmoke;
            btnDmp.Dock = DockStyle.Fill;
            btnDmp.FlatAppearance.BorderSize = 0;
            btnDmp.FlatStyle = FlatStyle.Flat;
            btnDmp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDmp.ForeColor = Color.Black;
            btnDmp.ImageAlign = ContentAlignment.MiddleLeft;
            btnDmp.ImageIndex = 2;
            btnDmp.ImageList = imageList;
            btnDmp.Location = new Point(0, 0);
            btnDmp.Margin = new Padding(3, 0, 3, 3);
            btnDmp.Name = "btnDmp";
            btnDmp.Size = new Size(230, 31);
            btnDmp.TabIndex = 2;
            btnDmp.Tag = "Dp";
            btnDmp.Text = "            Damaged and missing products";
            btnDmp.TextAlign = ContentAlignment.MiddleLeft;
            btnDmp.UseVisualStyleBackColor = false;
            btnDmp.Click += btnDmp_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "chevron_left_FILL0_wght400_GRAD0_opsz24.png");
            imageList.Images.SetKeyName(1, "expand_less_FILL0_wght400_GRAD0_opsz24.png");
            imageList.Images.SetKeyName(2, "expand_more_FILL0_wght400_GRAD0_opsz24.png");
            imageList.Images.SetKeyName(3, "menu_open_FILL0_wght400_GRAD0_opsz24.png");
            imageList.Images.SetKeyName(4, "menu_FILL0_wght400_GRAD0_opsz24.png");
            // 
            // flDamage
            // 
            flDamage.BackColor = Color.Gainsboro;
            flDamage.Controls.Add(panel2);
            flDamage.Controls.Add(panel4);
            flDamage.Location = new Point(0, 108);
            flDamage.Margin = new Padding(0);
            flDamage.Name = "flDamage";
            flDamage.Size = new Size(230, 74);
            flDamage.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDmPp);
            panel2.Location = new Point(3, 0);
            panel2.Margin = new Padding(3, 0, 0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 31);
            panel2.TabIndex = 7;
            // 
            // btnDmPp
            // 
            btnDmPp.BackColor = Color.Gainsboro;
            btnDmPp.Dock = DockStyle.Fill;
            btnDmPp.FlatAppearance.BorderSize = 0;
            btnDmPp.FlatStyle = FlatStyle.Flat;
            btnDmPp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDmPp.ForeColor = Color.Black;
            btnDmPp.Image = (Image)resources.GetObject("btnDmPp.Image");
            btnDmPp.ImageAlign = ContentAlignment.MiddleLeft;
            btnDmPp.Location = new Point(0, 0);
            btnDmPp.Margin = new Padding(3, 0, 3, 0);
            btnDmPp.Name = "btnDmPp";
            btnDmPp.Size = new Size(230, 31);
            btnDmPp.TabIndex = 2;
            btnDmPp.Tag = "DmPp";
            btnDmPp.Text = "            Printed Products";
            btnDmPp.TextAlign = ContentAlignment.MiddleLeft;
            btnDmPp.UseVisualStyleBackColor = false;
            btnDmPp.Click += btnMenu_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnDmBm);
            panel4.Location = new Point(3, 34);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 31);
            panel4.TabIndex = 8;
            // 
            // btnDmBm
            // 
            btnDmBm.BackColor = Color.Gainsboro;
            btnDmBm.Dock = DockStyle.Fill;
            btnDmBm.FlatAppearance.BorderSize = 0;
            btnDmBm.FlatStyle = FlatStyle.Flat;
            btnDmBm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDmBm.ForeColor = Color.Black;
            btnDmBm.Image = (Image)resources.GetObject("btnDmBm.Image");
            btnDmBm.ImageAlign = ContentAlignment.MiddleLeft;
            btnDmBm.Location = new Point(0, 0);
            btnDmBm.Margin = new Padding(3, 0, 3, 0);
            btnDmBm.Name = "btnDmBm";
            btnDmBm.Size = new Size(230, 31);
            btnDmBm.TabIndex = 2;
            btnDmBm.Tag = "DmBm";
            btnDmBm.Text = "            Base Material";
            btnDmBm.TextAlign = ContentAlignment.MiddleLeft;
            btnDmBm.UseVisualStyleBackColor = false;
            btnDmBm.Click += btnMenu_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPpl);
            panel3.Location = new Point(3, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 31);
            panel3.TabIndex = 4;
            // 
            // btnPpl
            // 
            btnPpl.BackColor = Color.WhiteSmoke;
            btnPpl.Dock = DockStyle.Fill;
            btnPpl.FlatAppearance.BorderSize = 0;
            btnPpl.FlatStyle = FlatStyle.Flat;
            btnPpl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPpl.ForeColor = Color.Black;
            btnPpl.Image = (Image)resources.GetObject("btnPpl.Image");
            btnPpl.ImageAlign = ContentAlignment.MiddleLeft;
            btnPpl.Location = new Point(0, 0);
            btnPpl.Name = "btnPpl";
            btnPpl.Size = new Size(230, 31);
            btnPpl.TabIndex = 1;
            btnPpl.Tag = "Pp";
            btnPpl.Text = "            Printed Product List";
            btnPpl.TextAlign = ContentAlignment.MiddleLeft;
            btnPpl.UseVisualStyleBackColor = false;
            btnPpl.Click += btnMenu_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnBaseMaterial);
            panel5.Location = new Point(3, 222);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 31);
            panel5.TabIndex = 5;
            // 
            // btnBaseMaterial
            // 
            btnBaseMaterial.BackColor = Color.WhiteSmoke;
            btnBaseMaterial.Dock = DockStyle.Fill;
            btnBaseMaterial.FlatAppearance.BorderSize = 0;
            btnBaseMaterial.FlatStyle = FlatStyle.Flat;
            btnBaseMaterial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaseMaterial.ForeColor = Color.Black;
            btnBaseMaterial.Image = (Image)resources.GetObject("btnBaseMaterial.Image");
            btnBaseMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaseMaterial.Location = new Point(0, 0);
            btnBaseMaterial.Name = "btnBaseMaterial";
            btnBaseMaterial.Size = new Size(230, 31);
            btnBaseMaterial.TabIndex = 1;
            btnBaseMaterial.Tag = "Bm";
            btnBaseMaterial.Text = "            Base Material";
            btnBaseMaterial.TextAlign = ContentAlignment.MiddleLeft;
            btnBaseMaterial.UseVisualStyleBackColor = false;
            btnBaseMaterial.Click += btnMenu_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnAdmin);
            panel6.Location = new Point(3, 259);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 31);
            panel6.TabIndex = 5;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.WhiteSmoke;
            btnAdmin.Dock = DockStyle.Fill;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.Black;
            btnAdmin.Image = (Image)resources.GetObject("btnAdmin.Image");
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(0, 0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(230, 31);
            btnAdmin.TabIndex = 1;
            btnAdmin.Tag = "Au";
            btnAdmin.Text = "            Admin User";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnMenu_Click;
            // 
            // timerSubMenuTransition
            // 
            timerSubMenuTransition.Interval = 10;
            timerSubMenuTransition.Tick += timerSubMenuTransition_Tick;
            // 
            // timerMenuTransition
            // 
            timerMenuTransition.Interval = 10;
            timerMenuTransition.Tick += timerMenuTransition_Tick;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(232, 33);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(568, 417);
            pnMain.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pnMain);
            Controls.Add(flMenu);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "JIM";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMain).EndInit();
            flMenu.ResumeLayout(false);
            pnCo.ResumeLayout(false);
            pnMo.ResumeLayout(false);
            pnDmp.ResumeLayout(false);
            flDamage.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox picMain;
        private Label lblTitle;
        private FlowLayoutPanel flMenu;
        private Panel pnCo;
        private Button btnCO;
        private FlowLayoutPanel flDamage;
        private Panel pnMo;
        private Button bntMo;
        private Panel pnDmp;
        private Button btnDmp;
        private Panel panel2;
        private Button btnDmPp;
        private Panel panel4;
        private Button btnDmBm;
        private Button btnUser;
        private Panel panel3;
        private Button btnPpl;
        private Panel panel5;
        private Button btnBaseMaterial;
        private Panel panel6;
        private Button btnAdmin;
        private System.Windows.Forms.Timer timerSubMenuTransition;
        private ImageList imageList;
        private System.Windows.Forms.Timer timerMenuTransition;
        private Panel pnMain;
    }
}