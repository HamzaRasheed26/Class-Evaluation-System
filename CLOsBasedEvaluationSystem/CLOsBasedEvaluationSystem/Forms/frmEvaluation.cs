using CLOsBasedEvaluationSystem.Utility;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOsBasedEvaluationSystem.Forms
{
    public partial class frmEvaluation : MaterialForm
    {
        string asmtTitle;
        int asmtId;
        DataTable dtStu;
        DataTable dtCmp;

        public frmEvaluation(string asmtTitle, int asmtId)
        {
            this.asmtTitle = asmtTitle;
            this.asmtId = asmtId;
            initalize();

        }

        public frmEvaluation(string asmtTitle, int asmtId,int stId)
        {
            this.asmtTitle = asmtTitle;
            this.asmtId = asmtId;
            initalize();
            cbRegNo.SelectedValue = stId;
            loadPrevResult(stId);
        }

        public void loadPrevResult(int stId)
        {
            for (int i = 0; i < dtCmp.Rows.Count; i++)
            {
                int cmpId = (int)dtCmp.Rows[i][0];
                DataTable prev = Queries.prevResult(stId, cmpId);
                string cbName = "cb" + i;
                ComboBox comboBox = (ComboBox)flowLayoutPanel1.Controls[cbName];
                comboBox.SelectedValue = (int)prev.Rows[0][2];
            }
        }

        public void initalize()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.Text = "Assessment: " + asmtTitle;
            dtStu = Queries.queryActiveStudentsForAttendance("Active");
            dtCmp = Queries.queryGetAsmpCmp(asmtId);
            bind_cbRegNo(dtStu);
            createComponent();
        }

        public void bind_cbRegNo(DataTable dt)
        {
            cbRegNo.DataSource = dt;

            cbRegNo.DisplayMember = "RegistrationNumber";
            cbRegNo.ValueMember = "Id";
            cbRegNo.SelectedIndex = 0;
            lblName.Text = "Name: " + dt.Rows[0][1].ToString();
        }

        public MaterialLabel createLabel(string name, string text)
        {
            MaterialLabel materialLabel = new MaterialLabel();

            materialLabel.AutoSize = true;
            materialLabel.Depth = 0;
            materialLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel.FontType = MaterialSkinManager.fontType.H6;
            materialLabel.Margin = new Padding(10);
            materialLabel.MouseState = MouseState.HOVER;
            materialLabel.Name = name;
            materialLabel.Size = new Size(120, 24);
            materialLabel.TabIndex = 0;
            materialLabel.Text = text;

            this.flowLayoutPanel1.Controls.Add(materialLabel);

            return materialLabel;
        }

        public MaterialComboBox createComboBox(string name, DataTable rubricLevels)
        {
            MaterialComboBox materialComboBox = new MaterialComboBox();

            materialComboBox.AutoResize = false;
            materialComboBox.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            materialComboBox.Depth = 0;
            materialComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox.DropDownHeight = 174;
            materialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox.DropDownWidth = 121;
            materialComboBox.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox.ForeColor = Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialComboBox.FormattingEnabled = true;
            materialComboBox.Hint = "Rubric Levels";
            materialComboBox.IntegralHeight = false;
            materialComboBox.ItemHeight = 43;
            materialComboBox.Location = new Point(10, 54);
            materialComboBox.Margin = new Padding(10);
            materialComboBox.MaxDropDownItems = 4;
            materialComboBox.MouseState = MouseState.OUT;
            materialComboBox.Name = name;
            materialComboBox.Size = new Size(398, 49);
            materialComboBox.StartIndex = 0;
            materialComboBox.TabIndex = 1;
            materialComboBox.DataSource = rubricLevels;
            materialComboBox.DisplayMember = "Details";
            materialComboBox.ValueMember = "Id";
            //materialComboBox.SelectedIndex = 0;

            this.flowLayoutPanel1.Controls.Add(materialComboBox);

            return materialComboBox;
        }

        public void createComponent()
        {
            for (int i = 0; i < dtCmp.Rows.Count; i++)
            {
                string labelName = "lbl" + i;
                string cbName = "cb" + i;
                string cmpName = dtCmp.Rows[i][1].ToString();
                int rubricId = (int)dtCmp.Rows[i][2];

                createLabel(labelName, cmpName);

                DataTable rubricLevels = Queries.queryGetAllRubricLevels(rubricId);
                createComboBox(cbName, rubricLevels);
            }
        }

        private void cbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbRegNo.SelectedIndex;
            lblName.Text = "Name: " + dtStu.Rows[index][1].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int stdId = (int)cbRegNo.SelectedValue;

            if (MessageBox.Show("Are you sure you want to save " + dtStu.Rows[cbRegNo.SelectedIndex][1].ToString() + " Evalution of " + asmtTitle, "Evaluation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dtCmp.Rows.Count; i++)
                {
                    int cmpId = (int)dtCmp.Rows[i][0];

                    // Access the ComboBox control by name
                    string cbName = "cb" + i;
                    ComboBox comboBox = (ComboBox)flowLayoutPanel1.Controls[cbName];

                    // Access the SelectedIndex property of the ComboBox
                    int levelId = (int)comboBox.SelectedValue;

                    // if count 0 thats mean student that assessmmet componenet is not marked prviously
                    if (Queries.ISResultExist(stdId, cmpId) == 0) 
                    {
                        // adding new result 
                        Queries.queryAddStResult(stdId, cmpId, levelId);
                    }
                    else
                    {
                        // updatng  previous result
                        Queries.updateStResult(stdId, cmpId, levelId);
                    }
                }

                clearLevels();
            }
        }



        public void clearLevels()
        {
            for (int i = 0; i < dtCmp.Rows.Count; i++)
            {
                string cbName = "cb" + i;
                // Access the ComboBox control by name
                ComboBox comboBox = (ComboBox)flowLayoutPanel1.Controls[cbName];
                comboBox.SelectedIndex = 0;

            }
        }
    

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
