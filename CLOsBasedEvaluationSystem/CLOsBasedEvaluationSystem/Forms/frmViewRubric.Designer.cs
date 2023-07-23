namespace CLOsBasedEvaluationSystem.Forms
{
    partial class frmViewRubric
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewRubric));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCLO = new MaterialSkin.Controls.MaterialLabel();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtClo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRubric = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgvLevels = new System.Windows.Forms.DataGridView();
            this.btnPrev = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.92829F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.41506F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.65666F));
            this.tableLayoutPanel1.Controls.Add(this.lblCLO, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialDivider1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtClo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRubric, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvLevels, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnPrev, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64359F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.211207F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.64925F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.64925F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.14332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.70338F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 383);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCLO
            // 
            this.lblCLO.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCLO, 2);
            this.lblCLO.Depth = 0;
            this.lblCLO.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCLO.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCLO.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblCLO.HighEmphasis = true;
            this.lblCLO.Location = new System.Drawing.Point(3, 0);
            this.lblCLO.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCLO.Name = "lblCLO";
            this.lblCLO.Size = new System.Drawing.Size(396, 41);
            this.lblCLO.TabIndex = 4;
            this.lblCLO.Text = "Rubric Details:";
            this.lblCLO.UseAccent = true;
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(4, 339);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(66, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext.Depth = 0;
            this.btnNext.HighEmphasis = true;
            this.btnNext.Icon = ((System.Drawing.Image)(resources.GetObject("btnNext.Icon")));
            this.btnNext.Location = new System.Drawing.Point(445, 339);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNext.Size = new System.Drawing.Size(86, 36);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNext.UseAccentColor = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.SetColumnSpan(this.materialDivider1, 3);
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(3, 70);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(529, 2);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(3, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 56);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "CLO Name:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(3, 131);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 56);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Rubric:";
            // 
            // txtClo
            // 
            this.txtClo.AnimateReadOnly = false;
            this.txtClo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClo.Depth = 0;
            this.txtClo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClo.HideSelection = true;
            this.txtClo.Hint = "CLO Name";
            this.txtClo.LeadingIcon = null;
            this.txtClo.Location = new System.Drawing.Point(120, 78);
            this.txtClo.MaxLength = 32767;
            this.txtClo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClo.Name = "txtClo";
            this.txtClo.PasswordChar = '\0';
            this.txtClo.PrefixSuffixText = null;
            this.txtClo.ReadOnly = true;
            this.txtClo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClo.SelectedText = "";
            this.txtClo.SelectionLength = 0;
            this.txtClo.SelectionStart = 0;
            this.txtClo.ShortcutsEnabled = true;
            this.txtClo.Size = new System.Drawing.Size(279, 48);
            this.txtClo.TabIndex = 7;
            this.txtClo.TabStop = false;
            this.txtClo.Text = "CLO 1";
            this.txtClo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClo.TrailingIcon = null;
            this.txtClo.UseSystemPasswordChar = false;
            this.txtClo.Click += new System.EventHandler(this.materialTextBox21_Click);
            // 
            // txtRubric
            // 
            this.txtRubric.AnimateReadOnly = false;
            this.txtRubric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRubric.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel1.SetColumnSpan(this.txtRubric, 2);
            this.txtRubric.Depth = 0;
            this.txtRubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRubric.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRubric.HideSelection = true;
            this.txtRubric.Hint = "Rubric Name";
            this.txtRubric.LeadingIcon = null;
            this.txtRubric.Location = new System.Drawing.Point(120, 134);
            this.txtRubric.MaxLength = 32767;
            this.txtRubric.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRubric.Name = "txtRubric";
            this.txtRubric.PasswordChar = '\0';
            this.txtRubric.PrefixSuffixText = null;
            this.txtRubric.ReadOnly = true;
            this.txtRubric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRubric.SelectedText = "";
            this.txtRubric.SelectionLength = 0;
            this.txtRubric.SelectionStart = 0;
            this.txtRubric.ShortcutsEnabled = true;
            this.txtRubric.Size = new System.Drawing.Size(412, 48);
            this.txtRubric.TabIndex = 7;
            this.txtRubric.TabStop = false;
            this.txtRubric.Text = "Rubric 1";
            this.txtRubric.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRubric.TrailingIcon = null;
            this.txtRubric.UseSystemPasswordChar = false;
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
            this.tableLayoutPanel1.SetColumnSpan(this.dgvLevels, 3);
            this.dgvLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLevels.Location = new System.Drawing.Point(3, 190);
            this.dgvLevels.Name = "dgvLevels";
            this.dgvLevels.ReadOnly = true;
            this.dgvLevels.Size = new System.Drawing.Size(529, 140);
            this.dgvLevels.TabIndex = 8;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrev.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrev.Depth = 0;
            this.btnPrev.HighEmphasis = true;
            this.btnPrev.Icon = ((System.Drawing.Image)(resources.GetObject("btnPrev.Icon")));
            this.btnPrev.Location = new System.Drawing.Point(279, 339);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrev.Size = new System.Drawing.Size(119, 36);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Previous";
            this.btnPrev.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrev.UseAccentColor = false;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // frmViewRubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmViewRubric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Rubric";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lblCLO;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtClo;
        private MaterialSkin.Controls.MaterialTextBox2 txtRubric;
        private System.Windows.Forms.DataGridView dgvLevels;
        private MaterialSkin.Controls.MaterialButton btnPrev;
    }
}