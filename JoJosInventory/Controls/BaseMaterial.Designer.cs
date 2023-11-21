namespace JoJosInventory.Controls
{
    partial class BaseMaterial
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseMaterial));
            dgv = new DataGridView();
            pnHeader = new Panel();
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            imageList = new ImageList(components);
            pnSearch = new Panel();
            cmbSku = new ComboBox();
            btnClear = new Button();
            chkDue = new CheckBox();
            btnSearch = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dpDate = new DateTimePicker();
            cmbCategory = new ComboBox();
            label2 = new Label();
            btnExpand = new Button();
            FlPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            pnHeader.SuspendLayout();
            pnSearch.SuspendLayout();
            FlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToOrderColumns = true;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(3, 47);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(583, 100);
            dgv.TabIndex = 0;
            dgv.CellClick += dgv_CellClick;
            dgv.CellValueChanged += dgv_CellValueChanged;
            dgv.CurrentCellDirtyStateChanged += dgv_CurrentCellDirtyStateChanged;
            dgv.Resize += dgv_Resize;
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.Gray;
            pnHeader.Controls.Add(label1);
            pnHeader.Controls.Add(btnAdd);
            pnHeader.Controls.Add(btnDelete);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(620, 41);
            pnHeader.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 3;
            label1.Text = "Base Material";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.Navy;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.ImageIndex = 1;
            btnAdd.Location = new Point(465, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(68, 27);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "&Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.ImageIndex = 1;
            btnDelete.Location = new Point(539, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(61, 27);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "expand_less_FILL0_wght400_GRAD0_opsz24 (1).png");
            imageList.Images.SetKeyName(1, "expand_more_FILL0_wght400_GRAD0_opsz24 (1).png");
            // 
            // pnSearch
            // 
            pnSearch.BackColor = Color.White;
            pnSearch.Controls.Add(cmbSku);
            pnSearch.Controls.Add(btnClear);
            pnSearch.Controls.Add(chkDue);
            pnSearch.Controls.Add(btnSearch);
            pnSearch.Controls.Add(label5);
            pnSearch.Controls.Add(label4);
            pnSearch.Controls.Add(label3);
            pnSearch.Controls.Add(dpDate);
            pnSearch.Controls.Add(cmbCategory);
            pnSearch.Controls.Add(label2);
            pnSearch.Controls.Add(btnExpand);
            pnSearch.Dock = DockStyle.Top;
            pnSearch.Location = new Point(3, 3);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(591, 38);
            pnSearch.TabIndex = 3;
            // 
            // cmbSku
            // 
            cmbSku.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSku.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSku.FormattingEnabled = true;
            cmbSku.Location = new Point(379, 57);
            cmbSku.Name = "cmbSku";
            cmbSku.Size = new Size(164, 23);
            cmbSku.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.AutoSize = true;
            btnClear.BackColor = Color.DarkOrange;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.ImageIndex = 1;
            btnClear.Location = new Point(455, 87);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 27);
            btnClear.TabIndex = 5;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // chkDue
            // 
            chkDue.AutoSize = true;
            chkDue.Location = new Point(326, 62);
            chkDue.Name = "chkDue";
            chkDue.Size = new Size(15, 14);
            chkDue.TabIndex = 3;
            chkDue.UseVisualStyleBackColor = true;
            chkDue.CheckedChanged += chkDue_CheckedChanged;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.Green;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.ImageIndex = 1;
            btnSearch.Location = new Point(522, 87);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(61, 27);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(379, 39);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 7;
            label5.Text = "SKU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 39);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Due Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 39);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // dpDate
            // 
            dpDate.Enabled = false;
            dpDate.Format = DateTimePickerFormat.Short;
            dpDate.Location = new Point(211, 58);
            dpDate.Name = "dpDate";
            dpDate.Size = new Size(109, 23);
            dpDate.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(7, 58);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(164, 23);
            cmbCategory.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Search";
            // 
            // btnExpand
            // 
            btnExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExpand.FlatStyle = FlatStyle.Flat;
            btnExpand.ImageIndex = 1;
            btnExpand.ImageList = imageList;
            btnExpand.Location = new Point(545, 6);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(38, 23);
            btnExpand.TabIndex = 0;
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // FlPanel
            // 
            FlPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlPanel.BackColor = Color.Gray;
            FlPanel.Controls.Add(pnSearch);
            FlPanel.Controls.Add(dgv);
            FlPanel.Location = new Point(14, 47);
            FlPanel.Name = "FlPanel";
            FlPanel.Size = new Size(590, 284);
            FlPanel.TabIndex = 4;
            FlPanel.SizeChanged += FlPanel_SizeChanged;
            // 
            // BaseMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(FlPanel);
            Controls.Add(pnHeader);
            Name = "BaseMaterial";
            Size = new Size(620, 344);
            Load += BaseMaterial_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            FlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private Panel pnHeader;
        private Panel pnSearch;
        private Button btnExpand;
        private FlowLayoutPanel FlPanel;
        private ImageList imageList;
        private Label label2;
        private Button btnAdd;
        private Button btnDelete;
        private Label label1;
        private DateTimePicker dpDate;
        private ComboBox cmbCategory;
        private Button btnSearch;
        private Label label5;
        private Label label4;
        private Label label3;
        private CheckBox chkDue;
        private Button btnClear;
        private ComboBox cmbSku;
    }
}
