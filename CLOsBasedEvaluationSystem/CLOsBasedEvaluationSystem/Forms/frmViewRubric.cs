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
    public partial class frmViewRubric : MaterialForm
    {
        DataGridView RowsRubric;
        DataGridViewRow row;
        int index;

        public frmViewRubric(DataGridView RowsRubric, int index)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.RowsRubric = RowsRubric;
            this.index = index;
            row = RowsRubric.Rows[index];

            loadValues();
        }

        public void loadValues()
        {
            int cloId = (int)row.Cells[5].Value;
            txtClo.Text = Queries.queryGetCLO(cloId).Rows[0][1].ToString();

            txtRubric.Text = row.Cells[4].Value.ToString();
            int rubricID = (int)row.Cells[3].Value;
            bind_RubricLevels(rubricID);
        }

        public void bind_RubricLevels(int rubricID)
        {
            DataTable dt = Queries.queryGetAllRubricLevels(rubricID);

            dgvLevels.DataSource = dt;


            dgvLevels.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvLevels.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvLevels.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;*/
        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(index+1 < RowsRubric.RowCount)
            {
                index++;
                row = RowsRubric.Rows[index];
                loadValues();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (index - 1 >= 0)
            {
                index--;
                row = RowsRubric.Rows[index];
                loadValues();
            }
        }
    }
}
