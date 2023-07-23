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
using CLOsBasedEvaluationSystem.Utility;

namespace CLOsBasedEvaluationSystem.Forms
{
    public partial class frmEditRubric : MaterialForm
    {
        int rubricID;
        int cloId;
        int rLevelId;
        DataGridViewRow row;

        public frmEditRubric(int rubricID, DataGridViewRow row)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.rubricID = rubricID;
            this.row = row;
            cloId = Queries.queryGetloId_byRubricLevelID(rubricID);
            txtRubricName.Text = row.Cells[4].Value.ToString();
            lblRubric.Text = "Rubric ID : " + rubricID.ToString();
            DataTable dt = Queries.queryGetCLO(cloId);
            lblCLO.Text = dt.Rows[0][1].ToString();

            bind_RubricLevels();
        }


        public void bind_RubricLevels()
        {
            DataTable dt = Queries.queryGetAllRubricLevels(rubricID);

            dgvLevels.DataSource = dt;

            dgvLevels.Columns[0].DisplayIndex = 5;
            dgvLevels.Columns[1].DisplayIndex = 5;

            dgvLevels.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvLevels.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvLevels.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLevel_Click(object sender, EventArgs e)
        {
            string desc = txtDescrption.Text;
            int level = (int)numLevel.Value;
            int count = Queries.queryIsRubricLevelExist(rubricID, level);

            if (count == 0)
            {
                if (btnAddLevel.Text == "Edit Level")
                {
                    Queries.queryUpdateRubricLevel(rLevelId, desc, level, cloId);
                    btnAddLevel.Text = "Add Level";
                }
                else // add level
                {
                    Queries.queryAddRubricLevel(rubricID, desc, level, cloId);
                }
                txtDescrption.Text = "";
                numLevel.Value = level + 1;

                bind_RubricLevels();

            }
            else
            {
                MessageBox.Show("Measurment Level Already Exist!", "Rubric Level", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtRubricName.Text != "")
            {
                
                string Details = txtRubricName.Text;
                Queries.queryUpdateRubricName(rubricID, Details, cloId);
                MessageBox.Show("Rubric Successfully Updated.", "Edit Rubric", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
        }

        private void dgvLevels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvLevels.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvLevels.Rows[e.RowIndex];

            if (colName == "Delete")
            {
                MessageBox.Show("Delete level!");
            }
            else if (colName == "Edit")
            {
                btnAddLevel.Text = "Edit Level";

                txtDescrption.Text = row.Cells[4].Value.ToString();
                numLevel.Value = Convert.ToInt32(row.Cells[5].Value);
                rLevelId = Convert.ToInt32(row.Cells[2].Value);

                bind_RubricLevels();
            }
        }
    }
}
