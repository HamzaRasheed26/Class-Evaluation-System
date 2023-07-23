namespace CLOsBasedEvaluationSystem.Forms
{
    partial class frmEditRubric
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditRubric));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCLO = new MaterialSkin.Controls.MaterialLabel();
            this.txtRubricName = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRubric = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescrption = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddLevel = new MaterialSkin.Controls.MaterialButton();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.dgvLevels = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.94262F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.46721F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.59017F));
            this.tableLayoutPanel1.Controls.Add(this.lblCLO, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRubricName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.materialDivider1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvLevels, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.46883F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.917706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.09324F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.63403F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.67082F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 429);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCLO
            // 
            this.lblCLO.AutoSize = true;
            this.lblCLO.Depth = 0;
            this.lblCLO.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCLO.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCLO.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblCLO.HighEmphasis = true;
            this.lblCLO.Location = new System.Drawing.Point(3, 0);
            this.lblCLO.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCLO.Name = "lblCLO";
            this.lblCLO.Size = new System.Drawing.Size(144, 29);
            this.lblCLO.TabIndex = 4;
            this.lblCLO.Text = "CLO";
            this.lblCLO.UseAccent = true;
            // 
            // txtRubricName
            // 
            this.txtRubricName.AnimateReadOnly = false;
            this.txtRubricName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRubricName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel1.SetColumnSpan(this.txtRubricName, 2);
            this.txtRubricName.Depth = 0;
            this.txtRubricName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRubricName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRubricName.HideSelection = true;
            this.txtRubricName.Hint = "Rubric Name";
            this.txtRubricName.LeadingIcon = null;
            this.txtRubricName.Location = new System.Drawing.Point(153, 3);
            this.txtRubricName.MaxLength = 32767;
            this.txtRubricName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRubricName.Name = "txtRubricName";
            this.txtRubricName.PasswordChar = '\0';
            this.txtRubricName.PrefixSuffixText = null;
            this.txtRubricName.ReadOnly = false;
            this.txtRubricName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRubricName.SelectedText = "";
            this.txtRubricName.SelectionLength = 0;
            this.txtRubricName.SelectionStart = 0;
            this.txtRubricName.ShortcutsEnabled = true;
            this.txtRubricName.Size = new System.Drawing.Size(331, 48);
            this.txtRubricName.TabIndex = 3;
            this.txtRubricName.TabStop = false;
            this.txtRubricName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRubricName.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtRubricName.TrailingIcon")));
            this.txtRubricName.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(285, 383);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(419, 383);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(64, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.SetColumnSpan(this.materialDivider1, 3);
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(3, 56);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(481, 6);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.14553F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.85447F));
            this.tableLayoutPanel2.Controls.Add(this.lblRubric, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDescrption, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAddLevel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.numLevel, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12707F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.13253F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.87952F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.51807F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(481, 166);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lblRubric
            // 
            this.lblRubric.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblRubric, 2);
            this.lblRubric.Depth = 0;
            this.lblRubric.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRubric.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRubric.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblRubric.HighEmphasis = true;
            this.lblRubric.Location = new System.Drawing.Point(3, 0);
            this.lblRubric.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRubric.Name = "lblRubric";
            this.lblRubric.Size = new System.Drawing.Size(475, 28);
            this.lblRubric.TabIndex = 4;
            this.lblRubric.Text = "Rubric Levels";
            this.lblRubric.UseAccent = true;
            // 
            // txtDescrption
            // 
            this.txtDescrption.AnimateReadOnly = false;
            this.txtDescrption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescrption.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescrption.Depth = 0;
            this.txtDescrption.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescrption.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescrption.HideSelection = true;
            this.txtDescrption.Hint = "Descritpion";
            this.txtDescrption.LeadingIcon = null;
            this.txtDescrption.Location = new System.Drawing.Point(148, 31);
            this.txtDescrption.MaxLength = 32767;
            this.txtDescrption.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescrption.Name = "txtDescrption";
            this.txtDescrption.PasswordChar = '\0';
            this.txtDescrption.PrefixSuffixText = null;
            this.txtDescrption.ReadOnly = false;
            this.txtDescrption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescrption.SelectedText = "";
            this.txtDescrption.SelectionLength = 0;
            this.txtDescrption.SelectionStart = 0;
            this.txtDescrption.ShortcutsEnabled = true;
            this.txtDescrption.Size = new System.Drawing.Size(330, 48);
            this.txtDescrption.TabIndex = 0;
            this.txtDescrption.TabStop = false;
            this.txtDescrption.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescrption.TrailingIcon = null;
            this.txtDescrption.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(3, 28);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(139, 24);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Description";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(3, 83);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(139, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Measurmennt";
            // 
            // btnAddLevel
            // 
            this.btnAddLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddLevel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddLevel.Depth = 0;
            this.btnAddLevel.HighEmphasis = true;
            this.btnAddLevel.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddLevel.Icon")));
            this.btnAddLevel.Location = new System.Drawing.Point(353, 122);
            this.btnAddLevel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddLevel.Name = "btnAddLevel";
            this.btnAddLevel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddLevel.Size = new System.Drawing.Size(124, 36);
            this.btnAddLevel.TabIndex = 1;
            this.btnAddLevel.Text = "Add Level";
            this.btnAddLevel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddLevel.UseAccentColor = false;
            this.btnAddLevel.UseVisualStyleBackColor = true;
            this.btnAddLevel.Click += new System.EventHandler(this.btnAddLevel_Click);
            // 
            // numLevel
            // 
            this.numLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLevel.Location = new System.Drawing.Point(148, 86);
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(234, 26);
            this.numLevel.TabIndex = 5;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvLevels
            // 
            this.dgvLevels.AllowUserToAddRows = false;
            this.dgvLevels.AllowUserToOrderColumns = true;
            this.dgvLevels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLevels.BackgroundColor = System.Drawing.Color.White;
            this.dgvLevels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLevels.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLevels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvLevels, 3);
            this.dgvLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLevels.Location = new System.Drawing.Point(3, 240);
            this.dgvLevels.Name = "dgvLevels";
            this.dgvLevels.ReadOnly = true;
            this.dgvLevels.Size = new System.Drawing.Size(481, 134);
            this.dgvLevels.TabIndex = 7;
            this.dgvLevels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLevels_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.ToolTipText = "Edit";
            this.Edit.Width = 31;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.ToolTipText = "Delete";
            this.Delete.Width = 44;
            // 
            // frmEditRubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEditRubric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Rubric";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel lblCLO;
        private MaterialSkin.Controls.MaterialTextBox2 txtRubricName;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtDescrption;
        private MaterialSkin.Controls.MaterialLabel lblRubric;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnAddLevel;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.DataGridView dgvLevels;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}