namespace CLOsBasedEvaluationSystem
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lblCLOCount = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblActiveStd = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageStudent = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddStudent = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.switchStd = new MaterialSkin.Controls.MaterialSwitch();
            this.tabPageAttendance = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.AttendanceEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.AttendanceDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtpick = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddAttendance = new MaterialSkin.Controls.MaterialButton();
            this.btnAttdReport = new MaterialSkin.Controls.MaterialButton();
            this.tabPageCLO = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCLO = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAddCLO = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.dgvCLO = new System.Windows.Forms.DataGridView();
            this.EditCLO = new System.Windows.Forms.DataGridViewImageColumn();
            this.ViewCLO = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteCLO = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.lblCloCount2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageRubric = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.btnAddRubric = new MaterialSkin.Controls.MaterialButton();
            this.txtRubricDetaills = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbCLOs = new MaterialSkin.Controls.MaterialComboBox();
            this.dgvRubric = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditRubirc = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteRubric = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPageAssessment = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAsmtTitle = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblMarks = new MaterialSkin.Controls.MaterialLabel();
            this.lblWeightage = new MaterialSkin.Controls.MaterialLabel();
            this.numMarks = new System.Windows.Forms.NumericUpDown();
            this.numWeightage = new System.Windows.Forms.NumericUpDown();
            this.btnAddAsmt = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelAsmt = new MaterialSkin.Controls.MaterialButton();
            this.dgvAssessment = new System.Windows.Forms.DataGridView();
            this.EditAsmt = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteAsmt = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPageAsmtComponent = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelCmp = new MaterialSkin.Controls.MaterialButton();
            this.btnAddCmp = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCmpName = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cbRubricCmp = new MaterialSkin.Controls.MaterialComboBox();
            this.numMarkCmp = new System.Windows.Forms.NumericUpDown();
            this.cbAsmtCmp = new MaterialSkin.Controls.MaterialComboBox();
            this.dgvAsmpCmp = new System.Windows.Forms.DataGridView();
            this.EditAsmtCmp = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteAsmtCmp = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalMarks = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabPageEvaluation = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.btnEvaluate = new MaterialSkin.Controls.MaterialButton();
            this.cbEvAsmt = new MaterialSkin.Controls.MaterialComboBox();
            this.dgvEvaluate = new System.Windows.Forms.DataGridView();
            this.evEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.evDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalMarks = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.btnResultPDF = new MaterialSkin.Controls.MaterialButton();
            this.btnAsmtReport = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabPageStudent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.tabPageAttendance.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.tabPageCLO.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLO)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.tabPageRubric.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubric)).BeginInit();
            this.tabPageAssessment.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessment)).BeginInit();
            this.tabPageAsmtComponent.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarkCmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsmpCmp)).BeginInit();
            this.tabPageEvaluation.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.materialCard8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluate)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageHome);
            this.materialTabControl1.Controls.Add(this.tabPageStudent);
            this.materialTabControl1.Controls.Add(this.tabPageAttendance);
            this.materialTabControl1.Controls.Add(this.tabPageCLO);
            this.materialTabControl1.Controls.Add(this.tabPageRubric);
            this.materialTabControl1.Controls.Add(this.tabPageAssessment);
            this.materialTabControl1.Controls.Add(this.tabPageAsmtComponent);
            this.materialTabControl1.Controls.Add(this.tabPageEvaluation);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.Click += new System.EventHandler(this.materialTabControl1_Click);
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.White;
            this.tabPageHome.Controls.Add(this.materialCard2);
            this.tabPageHome.Controls.Add(this.materialLabel4);
            this.tabPageHome.Controls.Add(this.materialCard1);
            this.tabPageHome.Controls.Add(this.materialLabel1);
            this.tabPageHome.ImageKey = "icons8-home-page-32.png";
            this.tabPageHome.Location = new System.Drawing.Point(4, 74);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(786, 305);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.Click += new System.EventHandler(this.tabPageHome_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblCLOCount);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(371, 61);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(250, 82);
            this.materialCard2.TabIndex = 3;
            // 
            // lblCLOCount
            // 
            this.lblCLOCount.AutoSize = true;
            this.lblCLOCount.Depth = 0;
            this.lblCLOCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCLOCount.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCLOCount.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCLOCount.Location = new System.Drawing.Point(14, 14);
            this.lblCLOCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCLOCount.Name = "lblCLOCount";
            this.lblCLOCount.Size = new System.Drawing.Size(131, 24);
            this.lblCLOCount.TabIndex = 2;
            this.lblCLOCount.Text = "Total 3 Added.";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(368, 15);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(82, 41);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "CLOs";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel4.UseAccent = true;
            this.materialLabel4.UseMnemonic = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblActiveStd);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(30, 61);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(313, 82);
            this.materialCard1.TabIndex = 0;
            // 
            // lblActiveStd
            // 
            this.lblActiveStd.AutoSize = true;
            this.lblActiveStd.Depth = 0;
            this.lblActiveStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveStd.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblActiveStd.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblActiveStd.Location = new System.Drawing.Point(14, 14);
            this.lblActiveStd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblActiveStd.Name = "lblActiveStd";
            this.lblActiveStd.Size = new System.Drawing.Size(276, 24);
            this.lblActiveStd.TabIndex = 2;
            this.lblActiveStd.Text = "Total 50 Students are enrolled.";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(27, 15);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 41);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Students";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel1.UseAccent = true;
            this.materialLabel1.UseMnemonic = false;
            // 
            // tabPageStudent
            // 
            this.tabPageStudent.BackColor = System.Drawing.Color.White;
            this.tabPageStudent.Controls.Add(this.tableLayoutPanel1);
            this.tabPageStudent.ImageKey = "icons8-user-account-32.png";
            this.tabPageStudent.Location = new System.Drawing.Point(4, 74);
            this.tabPageStudent.Name = "tabPageStudent";
            this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudent.Size = new System.Drawing.Size(786, 305);
            this.tabPageStudent.TabIndex = 1;
            this.tabPageStudent.Text = "Students";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.02564F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.38462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddStudent, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvStudent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.switchStd, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.05389F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.94611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 299);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel5.HighEmphasis = true;
            this.materialLabel5.Location = new System.Drawing.Point(5, 0);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 29);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Students";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel5.UseAccent = true;
            this.materialLabel5.UseMnemonic = false;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddStudent.Depth = 0;
            this.btnAddStudent.HighEmphasis = true;
            this.btnAddStudent.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Icon")));
            this.btnAddStudent.ImageKey = "icons8-plus-32.png";
            this.btnAddStudent.ImageList = this.imageList1;
            this.btnAddStudent.Location = new System.Drawing.Point(629, 6);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddStudent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddStudent.Size = new System.Drawing.Size(147, 36);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddStudent.UseAccentColor = true;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-attendance-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-home-page-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-menu-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-open-book-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-pass-fail-32.png");
            this.imageList1.Images.SetKeyName(5, "icons8-plus-32.png");
            this.imageList1.Images.SetKeyName(6, "icons8-settings.gif");
            this.imageList1.Images.SetKeyName(7, "icons8-user-account-32.png");
            this.imageList1.Images.SetKeyName(8, "icons8-attendance-32.png");
            this.imageList1.Images.SetKeyName(9, "icons8-active-directory-32.png");
            this.imageList1.Images.SetKeyName(10, "icons8-delete-32.png");
            this.imageList1.Images.SetKeyName(11, "icons8-edit-32.png");
            this.imageList1.Images.SetKeyName(12, "icons8-edit-property-32.png");
            this.imageList1.Images.SetKeyName(13, "icons8-no-connection-32.png");
            this.imageList1.Images.SetKeyName(14, "icons8-scorecard-32.png");
            this.imageList1.Images.SetKeyName(15, "icons8-certificate-32.png");
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToOrderColumns = true;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvStudent, 3);
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.GridColor = System.Drawing.Color.Gray;
            this.dgvStudent.Location = new System.Drawing.Point(13, 81);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(13);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.Size = new System.Drawing.Size(754, 205);
            this.dgvStudent.TabIndex = 3;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 31;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 44;
            // 
            // switchStd
            // 
            this.switchStd.AutoSize = true;
            this.switchStd.Checked = true;
            this.switchStd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.switchStd.Depth = 0;
            this.switchStd.Location = new System.Drawing.Point(164, 0);
            this.switchStd.Margin = new System.Windows.Forms.Padding(0);
            this.switchStd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchStd.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchStd.Name = "switchStd";
            this.switchStd.Ripple = true;
            this.switchStd.Size = new System.Drawing.Size(137, 37);
            this.switchStd.TabIndex = 5;
            this.switchStd.Text = "Active Only";
            this.switchStd.UseVisualStyleBackColor = true;
            this.switchStd.CheckedChanged += new System.EventHandler(this.switchStd_CheckedChanged);
            // 
            // tabPageAttendance
            // 
            this.tabPageAttendance.BackColor = System.Drawing.Color.White;
            this.tabPageAttendance.Controls.Add(this.tableLayoutPanel2);
            this.tabPageAttendance.ImageKey = "icons8-attendance-32.png";
            this.tabPageAttendance.Location = new System.Drawing.Point(4, 74);
            this.tabPageAttendance.Name = "tabPageAttendance";
            this.tabPageAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAttendance.Size = new System.Drawing.Size(786, 305);
            this.tabPageAttendance.TabIndex = 2;
            this.tabPageAttendance.Text = "Attendance";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.02564F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.97436F));
            this.tableLayoutPanel2.Controls.Add(this.dgvAttendance, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpick, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddAttendance, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAttdReport, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.23221F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.43446F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 299);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToOrderColumns = true;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceEdit,
            this.AttendanceDelete});
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendance.Location = new System.Drawing.Point(283, 3);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.tableLayoutPanel2.SetRowSpan(this.dgvAttendance, 4);
            this.dgvAttendance.Size = new System.Drawing.Size(494, 293);
            this.dgvAttendance.TabIndex = 9;
            this.dgvAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellClick);
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellContentClick);
            // 
            // AttendanceEdit
            // 
            this.AttendanceEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AttendanceEdit.HeaderText = "Edit";
            this.AttendanceEdit.Image = ((System.Drawing.Image)(resources.GetObject("AttendanceEdit.Image")));
            this.AttendanceEdit.Name = "AttendanceEdit";
            this.AttendanceEdit.ReadOnly = true;
            this.AttendanceEdit.Width = 31;
            // 
            // AttendanceDelete
            // 
            this.AttendanceDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AttendanceDelete.HeaderText = "Delete";
            this.AttendanceDelete.Image = ((System.Drawing.Image)(resources.GetObject("AttendanceDelete.Image")));
            this.AttendanceDelete.Name = "AttendanceDelete";
            this.AttendanceDelete.ReadOnly = true;
            this.AttendanceDelete.Width = 44;
            // 
            // dtpick
            // 
            this.dtpick.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpick.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpick.Location = new System.Drawing.Point(3, 88);
            this.dtpick.Name = "dtpick";
            this.dtpick.Size = new System.Drawing.Size(181, 26);
            this.dtpick.TabIndex = 8;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(5, 0);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(125, 29);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Attendance";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel2.UseAccent = true;
            this.materialLabel2.UseMnemonic = false;
            // 
            // btnAddAttendance
            // 
            this.btnAddAttendance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddAttendance.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddAttendance.Depth = 0;
            this.btnAddAttendance.HighEmphasis = true;
            this.btnAddAttendance.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddAttendance.Icon")));
            this.btnAddAttendance.Location = new System.Drawing.Point(4, 127);
            this.btnAddAttendance.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddAttendance.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddAttendance.Name = "btnAddAttendance";
            this.btnAddAttendance.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddAttendance.Size = new System.Drawing.Size(180, 36);
            this.btnAddAttendance.TabIndex = 6;
            this.btnAddAttendance.Text = "New Attendance";
            this.btnAddAttendance.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddAttendance.UseAccentColor = false;
            this.btnAddAttendance.UseVisualStyleBackColor = true;
            this.btnAddAttendance.Click += new System.EventHandler(this.btnAddAttendance_Click);
            // 
            // btnAttdReport
            // 
            this.btnAttdReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttdReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAttdReport.Depth = 0;
            this.btnAttdReport.HighEmphasis = true;
            this.btnAttdReport.Icon = null;
            this.btnAttdReport.Location = new System.Drawing.Point(4, 261);
            this.btnAttdReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAttdReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAttdReport.Name = "btnAttdReport";
            this.btnAttdReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAttdReport.Size = new System.Drawing.Size(107, 32);
            this.btnAttdReport.TabIndex = 10;
            this.btnAttdReport.Text = "PDF Report";
            this.btnAttdReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAttdReport.UseAccentColor = false;
            this.btnAttdReport.UseVisualStyleBackColor = true;
            this.btnAttdReport.Click += new System.EventHandler(this.btnAttdReport_Click);
            // 
            // tabPageCLO
            // 
            this.tabPageCLO.Controls.Add(this.tableLayoutPanel3);
            this.tabPageCLO.ImageKey = "icons8-active-directory-32.png";
            this.tabPageCLO.Location = new System.Drawing.Point(4, 74);
            this.tabPageCLO.Name = "tabPageCLO";
            this.tabPageCLO.Size = new System.Drawing.Size(786, 305);
            this.tabPageCLO.TabIndex = 3;
            this.tabPageCLO.Text = "CLOs";
            this.tabPageCLO.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.26209F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.15013F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.materialCard3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvCLO, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.52941F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.176471F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 305);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel3.SetColumnSpan(this.materialCard3, 2);
            this.materialCard3.Controls.Add(this.tableLayoutPanel4);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(244, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(528, 74);
            this.materialCard3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.97222F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.02778F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel4.Controls.Add(this.txtCLO, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddCLO, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(500, 46);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // txtCLO
            // 
            this.txtCLO.AnimateReadOnly = false;
            this.txtCLO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCLO.Depth = 0;
            this.txtCLO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCLO.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCLO.Hint = "CLO Name";
            this.txtCLO.LeadingIcon = null;
            this.txtCLO.Location = new System.Drawing.Point(3, 3);
            this.txtCLO.MaxLength = 50;
            this.txtCLO.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCLO.Multiline = false;
            this.txtCLO.Name = "txtCLO";
            this.txtCLO.Size = new System.Drawing.Size(233, 50);
            this.txtCLO.TabIndex = 1;
            this.txtCLO.Text = "";
            this.txtCLO.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtCLO.TrailingIcon")));
            // 
            // btnAddCLO
            // 
            this.btnAddCLO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCLO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCLO.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddCLO.Depth = 0;
            this.btnAddCLO.HighEmphasis = true;
            this.btnAddCLO.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddCLO.Icon")));
            this.btnAddCLO.Location = new System.Drawing.Point(280, 6);
            this.btnAddCLO.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCLO.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCLO.Name = "btnAddCLO";
            this.btnAddCLO.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddCLO.Size = new System.Drawing.Size(78, 34);
            this.btnAddCLO.TabIndex = 0;
            this.btnAddCLO.Text = "Add";
            this.btnAddCLO.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddCLO.UseAccentColor = false;
            this.btnAddCLO.UseVisualStyleBackColor = true;
            this.btnAddCLO.Click += new System.EventHandler(this.btnAddCLO_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancel.Icon")));
            this.btnCancel.Location = new System.Drawing.Point(391, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(105, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvCLO
            // 
            this.dgvCLO.AllowUserToAddRows = false;
            this.dgvCLO.AllowUserToOrderColumns = true;
            this.dgvCLO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCLO.BackgroundColor = System.Drawing.Color.White;
            this.dgvCLO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCLO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvCLO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCLO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditCLO,
            this.ViewCLO,
            this.DeleteCLO});
            this.tableLayoutPanel3.SetColumnSpan(this.dgvCLO, 3);
            this.dgvCLO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCLO.Location = new System.Drawing.Point(30, 120);
            this.dgvCLO.Margin = new System.Windows.Forms.Padding(30, 0, 30, 20);
            this.dgvCLO.Name = "dgvCLO";
            this.dgvCLO.ReadOnly = true;
            this.tableLayoutPanel3.SetRowSpan(this.dgvCLO, 3);
            this.dgvCLO.Size = new System.Drawing.Size(726, 165);
            this.dgvCLO.TabIndex = 8;
            this.dgvCLO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCLO_CellContentClick);
            // 
            // EditCLO
            // 
            this.EditCLO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditCLO.HeaderText = "Edit";
            this.EditCLO.Image = ((System.Drawing.Image)(resources.GetObject("EditCLO.Image")));
            this.EditCLO.Name = "EditCLO";
            this.EditCLO.ReadOnly = true;
            this.EditCLO.Width = 31;
            // 
            // ViewCLO
            // 
            this.ViewCLO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ViewCLO.HeaderText = "View";
            this.ViewCLO.Image = ((System.Drawing.Image)(resources.GetObject("ViewCLO.Image")));
            this.ViewCLO.Name = "ViewCLO";
            this.ViewCLO.ReadOnly = true;
            this.ViewCLO.Width = 36;
            // 
            // DeleteCLO
            // 
            this.DeleteCLO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteCLO.HeaderText = "Delete";
            this.DeleteCLO.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCLO.Image")));
            this.DeleteCLO.Name = "DeleteCLO";
            this.DeleteCLO.ReadOnly = true;
            this.DeleteCLO.Width = 44;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.materialLabel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.materialCard4, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.18518F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.81481F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(224, 96);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.HighEmphasis = true;
            this.materialLabel6.Location = new System.Drawing.Point(5, 0);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(59, 29);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "CLOs";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel6.UseAccent = true;
            this.materialLabel6.UseMnemonic = false;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.lblCloCount2);
            this.materialCard4.Depth = 0;
            this.materialCard4.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(14, 47);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(196, 35);
            this.materialCard4.TabIndex = 8;
            // 
            // lblCloCount2
            // 
            this.lblCloCount2.AutoSize = true;
            this.lblCloCount2.Depth = 0;
            this.lblCloCount2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCloCount2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblCloCount2.HighEmphasis = true;
            this.lblCloCount2.Location = new System.Drawing.Point(17, 9);
            this.lblCloCount2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCloCount2.Name = "lblCloCount2";
            this.lblCloCount2.Size = new System.Drawing.Size(83, 17);
            this.lblCloCount2.TabIndex = 0;
            this.lblCloCount2.Text = "Total 3 CLOs";
            this.lblCloCount2.UseAccent = true;
            // 
            // tabPageRubric
            // 
            this.tabPageRubric.BackColor = System.Drawing.Color.White;
            this.tabPageRubric.Controls.Add(this.tableLayoutPanel6);
            this.tabPageRubric.ImageKey = "icons8-edit-property-32.png";
            this.tabPageRubric.Location = new System.Drawing.Point(4, 74);
            this.tabPageRubric.Name = "tabPageRubric";
            this.tabPageRubric.Size = new System.Drawing.Size(786, 305);
            this.tabPageRubric.TabIndex = 4;
            this.tabPageRubric.Text = "Rubric";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.24427F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.75572F));
            this.tableLayoutPanel6.Controls.Add(this.materialLabel8, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.materialCard5, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.dgvRubric, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(786, 305);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.HighEmphasis = true;
            this.materialLabel8.Location = new System.Drawing.Point(5, 0);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(81, 29);
            this.materialLabel8.TabIndex = 8;
            this.materialLabel8.Text = "Rubrics";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel8.UseAccent = true;
            this.materialLabel8.UseMnemonic = false;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.btnAddRubric);
            this.materialCard5.Controls.Add(this.txtRubricDetaills);
            this.materialCard5.Controls.Add(this.cbCLOs);
            this.materialCard5.Depth = 0;
            this.materialCard5.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(235, 14);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(537, 128);
            this.materialCard5.TabIndex = 0;
            // 
            // btnAddRubric
            // 
            this.btnAddRubric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRubric.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddRubric.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddRubric.Depth = 0;
            this.btnAddRubric.HighEmphasis = true;
            this.btnAddRubric.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddRubric.Icon")));
            this.btnAddRubric.Location = new System.Drawing.Point(386, 84);
            this.btnAddRubric.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddRubric.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddRubric.Name = "btnAddRubric";
            this.btnAddRubric.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddRubric.Size = new System.Drawing.Size(133, 36);
            this.btnAddRubric.TabIndex = 2;
            this.btnAddRubric.Text = "Add Rubric";
            this.btnAddRubric.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddRubric.UseAccentColor = false;
            this.btnAddRubric.UseVisualStyleBackColor = true;
            this.btnAddRubric.Click += new System.EventHandler(this.btnAddRubric_Click);
            // 
            // txtRubricDetaills
            // 
            this.txtRubricDetaills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRubricDetaills.AnimateReadOnly = false;
            this.txtRubricDetaills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRubricDetaills.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRubricDetaills.Depth = 0;
            this.txtRubricDetaills.ErrorMessage = "Error";
            this.txtRubricDetaills.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRubricDetaills.HideSelection = true;
            this.txtRubricDetaills.Hint = "Rubric Details";
            this.txtRubricDetaills.LeadingIcon = null;
            this.txtRubricDetaills.Location = new System.Drawing.Point(17, 72);
            this.txtRubricDetaills.MaxLength = 32767;
            this.txtRubricDetaills.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRubricDetaills.Name = "txtRubricDetaills";
            this.txtRubricDetaills.PasswordChar = '\0';
            this.txtRubricDetaills.PrefixSuffixText = null;
            this.txtRubricDetaills.ReadOnly = false;
            this.txtRubricDetaills.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRubricDetaills.SelectedText = "";
            this.txtRubricDetaills.SelectionLength = 0;
            this.txtRubricDetaills.SelectionStart = 0;
            this.txtRubricDetaills.ShortcutsEnabled = true;
            this.txtRubricDetaills.Size = new System.Drawing.Size(346, 48);
            this.txtRubricDetaills.TabIndex = 1;
            this.txtRubricDetaills.TabStop = false;
            this.txtRubricDetaills.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRubricDetaills.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtRubricDetaills.TrailingIcon")));
            this.txtRubricDetaills.UseSystemPasswordChar = false;
            // 
            // cbCLOs
            // 
            this.cbCLOs.AutoResize = false;
            this.cbCLOs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCLOs.Depth = 0;
            this.cbCLOs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCLOs.DropDownHeight = 174;
            this.cbCLOs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCLOs.DropDownWidth = 121;
            this.cbCLOs.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCLOs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCLOs.FormattingEnabled = true;
            this.cbCLOs.Hint = "CLOs";
            this.cbCLOs.IntegralHeight = false;
            this.cbCLOs.ItemHeight = 43;
            this.cbCLOs.Location = new System.Drawing.Point(17, 17);
            this.cbCLOs.MaxDropDownItems = 4;
            this.cbCLOs.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCLOs.Name = "cbCLOs";
            this.cbCLOs.Size = new System.Drawing.Size(121, 49);
            this.cbCLOs.StartIndex = 0;
            this.cbCLOs.TabIndex = 0;
            // 
            // dgvRubric
            // 
            this.dgvRubric.AllowUserToAddRows = false;
            this.dgvRubric.AllowUserToOrderColumns = true;
            this.dgvRubric.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRubric.BackgroundColor = System.Drawing.Color.White;
            this.dgvRubric.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRubric.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvRubric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.EditRubirc,
            this.DeleteRubric});
            this.tableLayoutPanel6.SetColumnSpan(this.dgvRubric, 2);
            this.dgvRubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRubric.Location = new System.Drawing.Point(3, 161);
            this.dgvRubric.Name = "dgvRubric";
            this.dgvRubric.ReadOnly = true;
            this.dgvRubric.Size = new System.Drawing.Size(780, 141);
            this.dgvRubric.TabIndex = 1;
            this.dgvRubric.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRubric_CellContentClick);
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.View.HeaderText = "View";
            this.View.Image = ((System.Drawing.Image)(resources.GetObject("View.Image")));
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 36;
            // 
            // EditRubirc
            // 
            this.EditRubirc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditRubirc.HeaderText = "Edit";
            this.EditRubirc.Image = ((System.Drawing.Image)(resources.GetObject("EditRubirc.Image")));
            this.EditRubirc.Name = "EditRubirc";
            this.EditRubirc.ReadOnly = true;
            this.EditRubirc.Width = 31;
            // 
            // DeleteRubric
            // 
            this.DeleteRubric.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteRubric.HeaderText = "Delete";
            this.DeleteRubric.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRubric.Image")));
            this.DeleteRubric.Name = "DeleteRubric";
            this.DeleteRubric.ReadOnly = true;
            this.DeleteRubric.Width = 44;
            // 
            // tabPageAssessment
            // 
            this.tabPageAssessment.BackColor = System.Drawing.Color.White;
            this.tabPageAssessment.Controls.Add(this.tableLayoutPanel7);
            this.tabPageAssessment.ImageKey = "icons8-scorecard-32.png";
            this.tabPageAssessment.Location = new System.Drawing.Point(4, 74);
            this.tabPageAssessment.Name = "tabPageAssessment";
            this.tabPageAssessment.Size = new System.Drawing.Size(786, 305);
            this.tabPageAssessment.TabIndex = 5;
            this.tabPageAssessment.Text = "Assessment";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.24427F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.75572F));
            this.tableLayoutPanel7.Controls.Add(this.materialLabel3, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.materialCard6, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.dgvAssessment, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(786, 305);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(5, 0);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(145, 29);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Assessments";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel3.UseAccent = true;
            this.materialLabel3.UseMnemonic = false;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.tableLayoutPanel8);
            this.materialCard6.Depth = 0;
            this.materialCard6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(226, 5);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(10);
            this.materialCard6.Size = new System.Drawing.Size(555, 148);
            this.materialCard6.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.41573F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.77903F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.8427F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.96255F));
            this.tableLayoutPanel8.Controls.Add(this.txtAsmtTitle, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblMarks, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblWeightage, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.numMarks, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.numWeightage, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnAddAsmt, 3, 2);
            this.tableLayoutPanel8.Controls.Add(this.btnCancelAsmt, 2, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(535, 128);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // txtAsmtTitle
            // 
            this.txtAsmtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsmtTitle.AnimateReadOnly = false;
            this.txtAsmtTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAsmtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel8.SetColumnSpan(this.txtAsmtTitle, 4);
            this.txtAsmtTitle.Depth = 0;
            this.txtAsmtTitle.ErrorMessage = "Error";
            this.txtAsmtTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAsmtTitle.HideSelection = true;
            this.txtAsmtTitle.Hint = "Assessment Title";
            this.txtAsmtTitle.LeadingIcon = null;
            this.txtAsmtTitle.Location = new System.Drawing.Point(3, 39);
            this.txtAsmtTitle.MaxLength = 32767;
            this.txtAsmtTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAsmtTitle.Name = "txtAsmtTitle";
            this.txtAsmtTitle.PasswordChar = '\0';
            this.txtAsmtTitle.PrefixSuffixText = null;
            this.txtAsmtTitle.ReadOnly = false;
            this.txtAsmtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAsmtTitle.SelectedText = "";
            this.txtAsmtTitle.SelectionLength = 0;
            this.txtAsmtTitle.SelectionStart = 0;
            this.txtAsmtTitle.ShortcutsEnabled = true;
            this.txtAsmtTitle.Size = new System.Drawing.Size(529, 48);
            this.txtAsmtTitle.TabIndex = 2;
            this.txtAsmtTitle.TabStop = false;
            this.txtAsmtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAsmtTitle.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtAsmtTitle.TrailingIcon")));
            this.txtAsmtTitle.UseSystemPasswordChar = false;
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Depth = 0;
            this.lblMarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMarks.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblMarks.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblMarks.Location = new System.Drawing.Point(3, 0);
            this.lblMarks.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(87, 36);
            this.lblMarks.TabIndex = 3;
            this.lblMarks.Text = "Marks";
            // 
            // lblWeightage
            // 
            this.lblWeightage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeightage.AutoSize = true;
            this.lblWeightage.Depth = 0;
            this.lblWeightage.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWeightage.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblWeightage.Location = new System.Drawing.Point(274, 0);
            this.lblWeightage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWeightage.Name = "lblWeightage";
            this.lblWeightage.Size = new System.Drawing.Size(97, 24);
            this.lblWeightage.TabIndex = 3;
            this.lblWeightage.Text = "Weightage";
            // 
            // numMarks
            // 
            this.numMarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMarks.Location = new System.Drawing.Point(96, 3);
            this.numMarks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMarks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMarks.Name = "numMarks";
            this.numMarks.Size = new System.Drawing.Size(137, 29);
            this.numMarks.TabIndex = 4;
            this.numMarks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numWeightage
            // 
            this.numWeightage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWeightage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWeightage.Location = new System.Drawing.Point(377, 3);
            this.numWeightage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWeightage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWeightage.Name = "numWeightage";
            this.numWeightage.Size = new System.Drawing.Size(155, 29);
            this.numWeightage.TabIndex = 4;
            this.numWeightage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddAsmt
            // 
            this.btnAddAsmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAsmt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddAsmt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddAsmt.Depth = 0;
            this.btnAddAsmt.HighEmphasis = true;
            this.btnAddAsmt.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddAsmt.Icon")));
            this.btnAddAsmt.Location = new System.Drawing.Point(453, 90);
            this.btnAddAsmt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddAsmt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddAsmt.Name = "btnAddAsmt";
            this.btnAddAsmt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddAsmt.Size = new System.Drawing.Size(78, 32);
            this.btnAddAsmt.TabIndex = 5;
            this.btnAddAsmt.Text = "Add";
            this.btnAddAsmt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddAsmt.UseAccentColor = false;
            this.btnAddAsmt.UseVisualStyleBackColor = true;
            this.btnAddAsmt.Click += new System.EventHandler(this.btnAddAsmt_Click);
            // 
            // btnCancelAsmt
            // 
            this.btnCancelAsmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAsmt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelAsmt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelAsmt.Depth = 0;
            this.btnCancelAsmt.HighEmphasis = true;
            this.btnCancelAsmt.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancelAsmt.Icon")));
            this.btnCancelAsmt.Location = new System.Drawing.Point(265, 90);
            this.btnCancelAsmt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelAsmt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelAsmt.Name = "btnCancelAsmt";
            this.btnCancelAsmt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelAsmt.Size = new System.Drawing.Size(105, 32);
            this.btnCancelAsmt.TabIndex = 5;
            this.btnCancelAsmt.Text = "Cancel";
            this.btnCancelAsmt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancelAsmt.UseAccentColor = false;
            this.btnCancelAsmt.UseVisualStyleBackColor = true;
            this.btnCancelAsmt.Click += new System.EventHandler(this.btnCancelAsmt_Click);
            // 
            // dgvAssessment
            // 
            this.dgvAssessment.AllowUserToAddRows = false;
            this.dgvAssessment.AllowUserToOrderColumns = true;
            this.dgvAssessment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssessment.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssessment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAssessment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvAssessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssessment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditAsmt,
            this.DeleteAsmt});
            this.tableLayoutPanel7.SetColumnSpan(this.dgvAssessment, 2);
            this.dgvAssessment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssessment.Location = new System.Drawing.Point(3, 161);
            this.dgvAssessment.Name = "dgvAssessment";
            this.dgvAssessment.ReadOnly = true;
            this.dgvAssessment.Size = new System.Drawing.Size(780, 141);
            this.dgvAssessment.TabIndex = 1;
            this.dgvAssessment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssessment_CellContentClick);
            // 
            // EditAsmt
            // 
            this.EditAsmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditAsmt.HeaderText = "Edit";
            this.EditAsmt.Image = ((System.Drawing.Image)(resources.GetObject("EditAsmt.Image")));
            this.EditAsmt.Name = "EditAsmt";
            this.EditAsmt.ReadOnly = true;
            this.EditAsmt.Width = 31;
            // 
            // DeleteAsmt
            // 
            this.DeleteAsmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteAsmt.HeaderText = "Delete";
            this.DeleteAsmt.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAsmt.Image")));
            this.DeleteAsmt.Name = "DeleteAsmt";
            this.DeleteAsmt.ReadOnly = true;
            this.DeleteAsmt.Width = 44;
            // 
            // tabPageAsmtComponent
            // 
            this.tabPageAsmtComponent.BackColor = System.Drawing.Color.White;
            this.tabPageAsmtComponent.Controls.Add(this.tableLayoutPanel9);
            this.tabPageAsmtComponent.ImageKey = "icons8-no-connection-32.png";
            this.tabPageAsmtComponent.Location = new System.Drawing.Point(4, 74);
            this.tabPageAsmtComponent.Name = "tabPageAsmtComponent";
            this.tabPageAsmtComponent.Size = new System.Drawing.Size(786, 305);
            this.tabPageAsmtComponent.TabIndex = 6;
            this.tabPageAsmtComponent.Text = "Assessment Component";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 5;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.3944F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.55725F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.98574F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.01018F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.01018F));
            this.tableLayoutPanel9.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.materialCard7, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.cbAsmtCmp, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.dgvAsmpCmp, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.materialLabel11, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.txtTotalMarks, 1, 3);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 5;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.45161F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.54839F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(786, 305);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.tableLayoutPanel9.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Assessment";
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel9.SetColumnSpan(this.materialCard7, 3);
            this.materialCard7.Controls.Add(this.tableLayoutPanel10);
            this.materialCard7.Depth = 0;
            this.materialCard7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(264, 5);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel9.SetRowSpan(this.materialCard7, 4);
            this.materialCard7.Size = new System.Drawing.Size(517, 148);
            this.materialCard7.TabIndex = 9;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.95906F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.74074F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.66277F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.02729F));
            this.tableLayoutPanel10.Controls.Add(this.btnCancelCmp, 2, 2);
            this.tableLayoutPanel10.Controls.Add(this.btnAddCmp, 3, 2);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel7, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel9, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.materialLabel10, 2, 1);
            this.tableLayoutPanel10.Controls.Add(this.txtCmpName, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.cbRubricCmp, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.numMarkCmp, 3, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.0303F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.30303F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(513, 144);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // btnCancelCmp
            // 
            this.btnCancelCmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelCmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelCmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelCmp.Depth = 0;
            this.btnCancelCmp.HighEmphasis = true;
            this.btnCancelCmp.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancelCmp.Icon")));
            this.btnCancelCmp.Location = new System.Drawing.Point(298, 110);
            this.btnCancelCmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelCmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelCmp.Name = "btnCancelCmp";
            this.btnCancelCmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelCmp.Size = new System.Drawing.Size(97, 28);
            this.btnCancelCmp.TabIndex = 6;
            this.btnCancelCmp.Text = "Cancel";
            this.btnCancelCmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancelCmp.UseAccentColor = false;
            this.btnCancelCmp.UseVisualStyleBackColor = true;
            this.btnCancelCmp.Click += new System.EventHandler(this.btnCancelCmp_Click);
            // 
            // btnAddCmp
            // 
            this.btnAddCmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddCmp.Depth = 0;
            this.btnAddCmp.HighEmphasis = true;
            this.btnAddCmp.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddCmp.Icon")));
            this.btnAddCmp.Location = new System.Drawing.Point(431, 110);
            this.btnAddCmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCmp.Name = "btnAddCmp";
            this.btnAddCmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddCmp.Size = new System.Drawing.Size(78, 28);
            this.btnAddCmp.TabIndex = 6;
            this.btnAddCmp.Text = "Add";
            this.btnAddCmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddCmp.UseAccentColor = false;
            this.btnAddCmp.UseVisualStyleBackColor = true;
            this.btnAddCmp.Click += new System.EventHandler(this.btnAddCmp_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(3, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(80, 24);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "Name";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(3, 61);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(80, 24);
            this.materialLabel9.TabIndex = 7;
            this.materialLabel9.Text = "Rubric";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel10.Location = new System.Drawing.Point(297, 61);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(99, 24);
            this.materialLabel10.TabIndex = 7;
            this.materialLabel10.Text = "Marks";
            this.materialLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCmpName
            // 
            this.txtCmpName.AnimateReadOnly = false;
            this.txtCmpName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCmpName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel10.SetColumnSpan(this.txtCmpName, 3);
            this.txtCmpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCmpName.Depth = 0;
            this.txtCmpName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCmpName.HideSelection = true;
            this.txtCmpName.Hint = "Component Name";
            this.txtCmpName.Location = new System.Drawing.Point(89, 3);
            this.txtCmpName.MaxLength = 32767;
            this.txtCmpName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCmpName.Name = "txtCmpName";
            this.txtCmpName.PasswordChar = '\0';
            this.txtCmpName.ReadOnly = false;
            this.txtCmpName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCmpName.SelectedText = "";
            this.txtCmpName.SelectionLength = 0;
            this.txtCmpName.SelectionStart = 0;
            this.txtCmpName.ShortcutsEnabled = true;
            this.txtCmpName.Size = new System.Drawing.Size(421, 55);
            this.txtCmpName.TabIndex = 8;
            this.txtCmpName.TabStop = false;
            this.txtCmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCmpName.UseSystemPasswordChar = false;
            // 
            // cbRubricCmp
            // 
            this.cbRubricCmp.AutoResize = false;
            this.cbRubricCmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbRubricCmp.Depth = 0;
            this.cbRubricCmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRubricCmp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbRubricCmp.DropDownHeight = 174;
            this.cbRubricCmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRubricCmp.DropDownWidth = 121;
            this.cbRubricCmp.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbRubricCmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbRubricCmp.FormattingEnabled = true;
            this.cbRubricCmp.Hint = "Rubric";
            this.cbRubricCmp.IntegralHeight = false;
            this.cbRubricCmp.ItemHeight = 43;
            this.cbRubricCmp.Location = new System.Drawing.Point(89, 64);
            this.cbRubricCmp.MaxDropDownItems = 4;
            this.cbRubricCmp.MouseState = MaterialSkin.MouseState.OUT;
            this.cbRubricCmp.Name = "cbRubricCmp";
            this.cbRubricCmp.Size = new System.Drawing.Size(202, 49);
            this.cbRubricCmp.StartIndex = 0;
            this.cbRubricCmp.TabIndex = 9;
            // 
            // numMarkCmp
            // 
            this.numMarkCmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMarkCmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMarkCmp.Location = new System.Drawing.Point(402, 64);
            this.numMarkCmp.Name = "numMarkCmp";
            this.numMarkCmp.Size = new System.Drawing.Size(108, 31);
            this.numMarkCmp.TabIndex = 10;
            // 
            // cbAsmtCmp
            // 
            this.cbAsmtCmp.AutoResize = false;
            this.cbAsmtCmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel9.SetColumnSpan(this.cbAsmtCmp, 2);
            this.cbAsmtCmp.Depth = 0;
            this.cbAsmtCmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAsmtCmp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbAsmtCmp.DropDownHeight = 174;
            this.cbAsmtCmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsmtCmp.DropDownWidth = 121;
            this.cbAsmtCmp.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbAsmtCmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbAsmtCmp.FormattingEnabled = true;
            this.cbAsmtCmp.Hint = "Assessment";
            this.cbAsmtCmp.IntegralHeight = false;
            this.cbAsmtCmp.ItemHeight = 43;
            this.cbAsmtCmp.Location = new System.Drawing.Point(3, 35);
            this.cbAsmtCmp.MaxDropDownItems = 4;
            this.cbAsmtCmp.MouseState = MaterialSkin.MouseState.OUT;
            this.cbAsmtCmp.Name = "cbAsmtCmp";
            this.cbAsmtCmp.Size = new System.Drawing.Size(253, 49);
            this.cbAsmtCmp.StartIndex = 0;
            this.cbAsmtCmp.TabIndex = 10;
            this.cbAsmtCmp.SelectedIndexChanged += new System.EventHandler(this.cbAsmtCmp_SelectedIndexChanged);
            // 
            // dgvAsmpCmp
            // 
            this.dgvAsmpCmp.AllowUserToAddRows = false;
            this.dgvAsmpCmp.AllowUserToOrderColumns = true;
            this.dgvAsmpCmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsmpCmp.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsmpCmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAsmpCmp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvAsmpCmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsmpCmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditAsmtCmp,
            this.DeleteAsmtCmp});
            this.tableLayoutPanel9.SetColumnSpan(this.dgvAsmpCmp, 5);
            this.dgvAsmpCmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsmpCmp.Location = new System.Drawing.Point(3, 161);
            this.dgvAsmpCmp.Name = "dgvAsmpCmp";
            this.dgvAsmpCmp.ReadOnly = true;
            this.dgvAsmpCmp.Size = new System.Drawing.Size(780, 141);
            this.dgvAsmpCmp.TabIndex = 11;
            this.dgvAsmpCmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsmpCmp_CellContentClick);
            // 
            // EditAsmtCmp
            // 
            this.EditAsmtCmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditAsmtCmp.HeaderText = "Edit";
            this.EditAsmtCmp.Image = ((System.Drawing.Image)(resources.GetObject("EditAsmtCmp.Image")));
            this.EditAsmtCmp.Name = "EditAsmtCmp";
            this.EditAsmtCmp.ReadOnly = true;
            this.EditAsmtCmp.ToolTipText = "Edit";
            this.EditAsmtCmp.Width = 31;
            // 
            // DeleteAsmtCmp
            // 
            this.DeleteAsmtCmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteAsmtCmp.HeaderText = "Delete";
            this.DeleteAsmtCmp.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAsmtCmp.Image")));
            this.DeleteAsmtCmp.Name = "DeleteAsmtCmp";
            this.DeleteAsmtCmp.ReadOnly = true;
            this.DeleteAsmtCmp.ToolTipText = "Delete";
            this.DeleteAsmtCmp.Width = 44;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel11.Location = new System.Drawing.Point(3, 92);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(115, 24);
            this.materialLabel11.TabIndex = 12;
            this.materialLabel11.Text = "Total Marks:";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.AnimateReadOnly = false;
            this.txtTotalMarks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalMarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalMarks.Depth = 0;
            this.txtTotalMarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalMarks.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalMarks.HideSelection = true;
            this.txtTotalMarks.Hint = "Total Marks";
            this.txtTotalMarks.LeadingIcon = null;
            this.txtTotalMarks.Location = new System.Drawing.Point(124, 95);
            this.txtTotalMarks.MaxLength = 32767;
            this.txtTotalMarks.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.PasswordChar = '\0';
            this.txtTotalMarks.PrefixSuffixText = null;
            this.txtTotalMarks.ReadOnly = true;
            this.txtTotalMarks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalMarks.SelectedText = "";
            this.txtTotalMarks.SelectionLength = 0;
            this.txtTotalMarks.SelectionStart = 0;
            this.txtTotalMarks.ShortcutsEnabled = true;
            this.txtTotalMarks.Size = new System.Drawing.Size(132, 48);
            this.txtTotalMarks.TabIndex = 13;
            this.txtTotalMarks.TabStop = false;
            this.txtTotalMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalMarks.TrailingIcon = null;
            this.txtTotalMarks.UseSystemPasswordChar = false;
            // 
            // tabPageEvaluation
            // 
            this.tabPageEvaluation.BackColor = System.Drawing.Color.White;
            this.tabPageEvaluation.Controls.Add(this.tableLayoutPanel11);
            this.tabPageEvaluation.ImageKey = "icons8-certificate-32.png";
            this.tabPageEvaluation.Location = new System.Drawing.Point(4, 74);
            this.tabPageEvaluation.Name = "tabPageEvaluation";
            this.tabPageEvaluation.Size = new System.Drawing.Size(786, 305);
            this.tabPageEvaluation.TabIndex = 7;
            this.tabPageEvaluation.Text = "Evluation";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.73028F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.26972F));
            this.tableLayoutPanel11.Controls.Add(this.materialCard8, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.dgvEvaluate, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(786, 305);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // materialCard8
            // 
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.btnEvaluate);
            this.materialCard8.Controls.Add(this.cbEvAsmt);
            this.materialCard8.Depth = 0;
            this.materialCard8.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(342, 14);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(430, 77);
            this.materialCard8.TabIndex = 0;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEvaluate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEvaluate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEvaluate.Depth = 0;
            this.btnEvaluate.HighEmphasis = true;
            this.btnEvaluate.Icon = ((System.Drawing.Image)(resources.GetObject("btnEvaluate.Icon")));
            this.btnEvaluate.Location = new System.Drawing.Point(290, 20);
            this.btnEvaluate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEvaluate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEvaluate.Size = new System.Drawing.Size(122, 36);
            this.btnEvaluate.TabIndex = 2;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEvaluate.UseAccentColor = false;
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // cbEvAsmt
            // 
            this.cbEvAsmt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEvAsmt.AutoResize = false;
            this.cbEvAsmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEvAsmt.Depth = 0;
            this.cbEvAsmt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEvAsmt.DropDownHeight = 174;
            this.cbEvAsmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvAsmt.DropDownWidth = 121;
            this.cbEvAsmt.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbEvAsmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEvAsmt.FormattingEnabled = true;
            this.cbEvAsmt.Hint = "Assessments";
            this.cbEvAsmt.IntegralHeight = false;
            this.cbEvAsmt.ItemHeight = 43;
            this.cbEvAsmt.Location = new System.Drawing.Point(17, 17);
            this.cbEvAsmt.MaxDropDownItems = 4;
            this.cbEvAsmt.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEvAsmt.Name = "cbEvAsmt";
            this.cbEvAsmt.Size = new System.Drawing.Size(255, 49);
            this.cbEvAsmt.StartIndex = 0;
            this.cbEvAsmt.TabIndex = 0;
            this.cbEvAsmt.SelectedIndexChanged += new System.EventHandler(this.cbEvAsmt_SelectedIndexChanged);
            // 
            // dgvEvaluate
            // 
            this.dgvEvaluate.AllowUserToAddRows = false;
            this.dgvEvaluate.AllowUserToOrderColumns = true;
            this.dgvEvaluate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvaluate.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvaluate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEvaluate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvEvaluate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evEdit,
            this.evDelete});
            this.tableLayoutPanel11.SetColumnSpan(this.dgvEvaluate, 2);
            this.dgvEvaluate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvaluate.Location = new System.Drawing.Point(3, 122);
            this.dgvEvaluate.Name = "dgvEvaluate";
            this.dgvEvaluate.ReadOnly = true;
            this.dgvEvaluate.Size = new System.Drawing.Size(780, 180);
            this.dgvEvaluate.TabIndex = 1;
            this.dgvEvaluate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvaluate_CellContentClick);
            // 
            // evEdit
            // 
            this.evEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.evEdit.HeaderText = "Edit";
            this.evEdit.Image = ((System.Drawing.Image)(resources.GetObject("evEdit.Image")));
            this.evEdit.Name = "evEdit";
            this.evEdit.ReadOnly = true;
            this.evEdit.Width = 31;
            // 
            // evDelete
            // 
            this.evDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.evDelete.HeaderText = "Delete";
            this.evDelete.Image = ((System.Drawing.Image)(resources.GetObject("evDelete.Image")));
            this.evDelete.Name = "evDelete";
            this.evDelete.ReadOnly = true;
            this.evDelete.Width = 44;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.materialLabel12, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.lblTotalMarks, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 2);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(322, 113);
            this.tableLayoutPanel12.TabIndex = 2;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel12.HighEmphasis = true;
            this.materialLabel12.Location = new System.Drawing.Point(5, 0);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(113, 29);
            this.materialLabel12.TabIndex = 9;
            this.materialLabel12.Text = "Evaluation";
            this.materialLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel12.UseAccent = true;
            this.materialLabel12.UseMnemonic = false;
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Depth = 0;
            this.lblTotalMarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalMarks.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalMarks.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTotalMarks.Location = new System.Drawing.Point(3, 40);
            this.lblTotalMarks.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(316, 24);
            this.lblTotalMarks.TabIndex = 10;
            this.lblTotalMarks.Text = "Total Marks: 50";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.btnResultPDF, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.btnAsmtReport, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(316, 39);
            this.tableLayoutPanel13.TabIndex = 11;
            // 
            // btnResultPDF
            // 
            this.btnResultPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResultPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnResultPDF.Depth = 0;
            this.btnResultPDF.HighEmphasis = true;
            this.btnResultPDF.Icon = null;
            this.btnResultPDF.Location = new System.Drawing.Point(4, 6);
            this.btnResultPDF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResultPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResultPDF.Name = "btnResultPDF";
            this.btnResultPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnResultPDF.Size = new System.Drawing.Size(74, 27);
            this.btnResultPDF.TabIndex = 0;
            this.btnResultPDF.Text = "Result";
            this.btnResultPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnResultPDF.UseAccentColor = false;
            this.btnResultPDF.UseVisualStyleBackColor = true;
            this.btnResultPDF.Click += new System.EventHandler(this.btnResultPDF_Click);
            // 
            // btnAsmtReport
            // 
            this.btnAsmtReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsmtReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsmtReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAsmtReport.Depth = 0;
            this.btnAsmtReport.HighEmphasis = true;
            this.btnAsmtReport.Icon = null;
            this.btnAsmtReport.Location = new System.Drawing.Point(195, 6);
            this.btnAsmtReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsmtReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsmtReport.Name = "btnAsmtReport";
            this.btnAsmtReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAsmtReport.Size = new System.Drawing.Size(117, 27);
            this.btnAsmtReport.TabIndex = 0;
            this.btnAsmtReport.Text = "Save Report";
            this.btnAsmtReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAsmtReport.UseAccentColor = false;
            this.btnAsmtReport.UseVisualStyleBackColor = true;
            this.btnAsmtReport.Click += new System.EventHandler(this.btnAsmtReport_Click_1);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluation System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabPageStudent.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.tabPageAttendance.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.tabPageCLO.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLO)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.tabPageRubric.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubric)).EndInit();
            this.tabPageAssessment.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessment)).EndInit();
            this.tabPageAsmtComponent.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarkCmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsmpCmp)).EndInit();
            this.tabPageEvaluation.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.materialCard8.ResumeLayout(false);
            this.materialCard8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluate)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageStudent;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblActiveStd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblCLOCount;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnAddStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TabPage tabPageAttendance;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpick;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnAddAttendance;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.TabPage tabPageCLO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox txtCLO;
        private MaterialSkin.Controls.MaterialButton btnAddCLO;
        private System.Windows.Forms.DataGridView dgvCLO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel lblCloCount2;
        private System.Windows.Forms.TabPage tabPageRubric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private System.Windows.Forms.DataGridView dgvRubric;
        private MaterialSkin.Controls.MaterialButton btnAddRubric;
        private MaterialSkin.Controls.MaterialTextBox2 txtRubricDetaills;
        private MaterialSkin.Controls.MaterialComboBox cbCLOs;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewImageColumn EditRubirc;
        private System.Windows.Forms.DataGridViewImageColumn DeleteRubric;
        private System.Windows.Forms.DataGridViewImageColumn EditCLO;
        private System.Windows.Forms.DataGridViewImageColumn ViewCLO;
        private System.Windows.Forms.DataGridViewImageColumn DeleteCLO;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private System.Windows.Forms.TabPage tabPageAssessment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private System.Windows.Forms.DataGridView dgvAssessment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private MaterialSkin.Controls.MaterialTextBox2 txtAsmtTitle;
        private MaterialSkin.Controls.MaterialLabel lblMarks;
        private MaterialSkin.Controls.MaterialLabel lblWeightage;
        private System.Windows.Forms.NumericUpDown numMarks;
        private System.Windows.Forms.NumericUpDown numWeightage;
        private MaterialSkin.Controls.MaterialButton btnAddAsmt;
        private MaterialSkin.Controls.MaterialButton btnCancelAsmt;
        private System.Windows.Forms.TabPage tabPageAsmtComponent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialButton btnAddCmp;
        private MaterialSkin.Controls.MaterialButton btnCancelCmp;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCmpName;
        private MaterialSkin.Controls.MaterialComboBox cbRubricCmp;
        private System.Windows.Forms.NumericUpDown numMarkCmp;
        private MaterialSkin.Controls.MaterialComboBox cbAsmtCmp;
        private System.Windows.Forms.DataGridView dgvAsmpCmp;
        private System.Windows.Forms.DataGridViewImageColumn EditAsmt;
        private System.Windows.Forms.DataGridViewImageColumn DeleteAsmt;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotalMarks;
        private System.Windows.Forms.DataGridViewImageColumn EditAsmtCmp;
        private System.Windows.Forms.DataGridViewImageColumn DeleteAsmtCmp;
        private System.Windows.Forms.TabPage tabPageEvaluation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private MaterialSkin.Controls.MaterialButton btnEvaluate;
        private MaterialSkin.Controls.MaterialComboBox cbEvAsmt;
        private System.Windows.Forms.DataGridView dgvEvaluate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel lblTotalMarks;
        private System.Windows.Forms.DataGridViewImageColumn evEdit;
        private System.Windows.Forms.DataGridViewImageColumn evDelete;
        private MaterialSkin.Controls.MaterialButton btnAttdReport;
        private System.Windows.Forms.DataGridViewImageColumn AttendanceEdit;
        private System.Windows.Forms.DataGridViewImageColumn AttendanceDelete;
        private MaterialSkin.Controls.MaterialSwitch switchStd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private MaterialSkin.Controls.MaterialButton btnResultPDF;
        private MaterialSkin.Controls.MaterialButton btnAsmtReport;
    }
}

