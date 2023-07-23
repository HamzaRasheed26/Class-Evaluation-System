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
using System.Data.SqlClient;
using CLOsBasedEvaluationSystem.Utility;

namespace CLOsBasedEvaluationSystem
{
    public partial class MainFrm : MaterialForm
    {
        int cloID;
        int assessmentID;
        int assessmentCmpID;
        public MainFrm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            bindData();
            activeStudents();
            bind_dgvAttendance();
            bindData_CLO();
            bind_cbCLOs();
            bindData_Rubric();
            totalCLos();
            bindData_Assessment();
            bind_cbAsmp();
            bind_cbRubricCmp();
            bindData_AsmpCmp((int)cbAsmtCmp.SelectedValue);
            bind_EvAsmtCb();
            bind_evaluationTable();
        }


        public void activeStudents()
        {
            int count = Queries.queryCountActiveStudents();

            lblActiveStd.Text = "Total " + count + " Students are Active.";
        }

        public void totalCLos()
        {
            
            int count = Queries.queryCountCLOs();

            lblCLOCount.Text = "Total " + count + " CLOs Added.";
            lblCloCount2.Text = "Total " + count + " CLOs Added.";

        }

        public void bindData()
        {
            if(switchStd.Checked == true)
            {
                dgvStudent.DataSource = Queries.querySelectActiveStudents();
            }
            else
            {
                dgvStudent.DataSource = Queries.querySelectAllStudents();
            }

            dgvStudent.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStudent.Columns[0].DisplayIndex = 8;
            dgvStudent.Columns[1].DisplayIndex = 8;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Forms.AddStudentFrm addStfrm = new Forms.AddStudentFrm();
            addStfrm.ShowDialog();
            bindData();
        }

        private void tabPageHome_Click(object sender, EventArgs e)
        {
            activeStudents();
        }

        private void materialTabControl1_Click(object sender, EventArgs e)
        {
            activeStudents();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string colName = dgvStudent.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvStudent.Rows[e.RowIndex];

            if (colName == "Edit")
            {
                
                Forms.frmEditStudent frm = new Forms.frmEditStudent(row);
                frm.ShowDialog();
                bindData();
            }
            else if (colName == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete!","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = row.Cells[2].Value.ToString();
                    if (Queries.isStdExistInResultAndAtd(int.Parse(id)))
                    {
                        Queries.queryDeleteStudent(id);
                        bindData();
                    }
                    else
                    {
                        MessageBox.Show("Sorry! You can not delete student instead that you can make him inactive.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            Forms.frmAttendance frm = new Forms.frmAttendance(dtpick.Value);
            frm.ShowDialog();
            bind_dgvAttendance();
        }


        public void addAtdColoumns(DataTable dt)
        {
            DataTable dtNames = dt;

            dgvAttendance.ColumnCount = dtNames.Rows.Count + 3;
            dgvAttendance.Columns[2].Name = "Date";
            dgvAttendance.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            int x = 3;
            for (int i = 0; i < dtNames.Rows.Count; i++)
            {
                dgvAttendance.Columns[x].Name = dtNames.Rows[i][0].ToString();
                
                x++;
            }

            dgvAttendance.Columns[0].DisplayIndex = 6;
            dgvAttendance.Columns[1].DisplayIndex = 6;
        }

        public void bind_dgvAttendance()
        {
            DataTable dtNames = Queries.queryLookUpValues("ATTENDANCE_STATUS");
            DataTable dates = Queries.queryAttendanceDates();
            addAtdColoumns(dtNames);

            List<int> statusIds = new List<int>();

            // finding ids for each attendance status
            foreach(DataRow row in dtNames.Rows)
            {
                string status = row[0].ToString();
                statusIds.Add(Queries.findLookUpId(status));
            }

            dgvAttendance.RowCount = dates.Rows.Count;

            for (int i = 0; i < dates.Rows.Count; i++)
            {
                DataRow date = dates.Rows[i];
                DateTime dateTime = Convert.ToDateTime(date[0].ToString());

                // finding count of each status for specific date
                List<int> counts = new List<int>();
                foreach(int id in statusIds)
                {
                    counts.Add(Queries.queryStudentAttendanceCountByStatus(id, dateTime));
                }
                dgvAttendance.Rows[i].Cells[2].Value = dateTime;
                int x = 3;
                foreach (int count in counts)
                {
                    dgvAttendance.Rows[i].Cells[x].Value = count;
                    x++;
                }

            }

        }

        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string colName = dgvAttendance.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvAttendance.Rows[e.RowIndex];

            if (colName == "AttendanceEdit")
            {
                Forms.frmAttendance frm = new Forms.frmAttendance(row);
                frm.ShowDialog();
                bind_dgvAttendance();
            }
            else if(colName == "AttendanceDelete")
            {
                if(MessageBox.Show("Are you sure you want to delete Attendance!", "Delete Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DateTime dateTime = (DateTime)row.Cells[2].Value;
                    int attdId = Queries.queryGetAttdId(dateTime);
                    Queries.queryDeletePrevAttd(attdId);
                    Queries.queryDeleteAttdDate(attdId);
                    bind_dgvAttendance();
                }
            }
        }


        private void btnAddCLO_Click(object sender, EventArgs e)
        {
            string cloName = txtCLO.Text;
            if (cloName == "" || txtCLO.Text[0] == ' ')
            {
                MessageBox.Show("CLO Name cannot be empty!", "CLO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnAddCLO.Text == "Edit")
                {
                    if(MessageBox.Show("Are you sure you want to edit!", "Edit CLO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Queries.queryUpadateCLO(cloID, cloName);
                    }
                    btnAddCLO.Text = "Add";
                    txtCLO.Text = "";
                }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    Queries.queryAddCLO(dateTime, cloName);
                }
                bindData_CLO();
                bind_cbCLOs();
                totalCLos();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAddCLO.Text = "Add";
            txtCLO.Text = "";
        }

        public void bindData_CLO()
        {
            DataTable dt = Queries.queryGetCLOs();
            dgvCLO.DataSource = dt;

            dgvCLO.Columns[0].DisplayIndex = 6;
            dgvCLO.Columns[1].DisplayIndex = 6;
            dgvCLO.Columns[2].DisplayIndex = 6;

            dgvCLO.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnAddRubric_Click(object sender, EventArgs e)
        {
            if (txtRubricDetaills.Text == "" || txtRubricDetaills.Text[0] == ' ')
            {
                MessageBox.Show("Rubric Details cannot be empty!", "Rubirc Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int cloId = (int)cbCLOs.SelectedValue;
                string details = txtRubricDetaills.Text;

                Queries.queryAddRubric(details, cloId);
                bindData_Rubric();
                bindData_CLO();
                bind_cbRubricCmp();
            }
        }

        public void bindData_Rubric()
        {
            DataTable dt = Queries.queryGetAllRubrics();
            dgvRubric.DataSource = dt;

            dgvRubric.Columns[0].DisplayIndex = 5;
            dgvRubric.Columns[1].DisplayIndex = 5;
            dgvRubric.Columns[2].DisplayIndex = 5;

            dgvCLO.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void bind_cbCLOs()
        {
            DataTable dt = Queries.queryGetCLOs();

            cbCLOs.DataSource = dt;

            cbCLOs.DisplayMember = "Name";
            cbCLOs.ValueMember = "Id";
            cbCLOs.SelectedIndex = 0;
        }

        private void dgvCLO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string colName = dgvCLO.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvCLO.Rows[e.RowIndex];
            cloID = (int)row.Cells[3].Value;

            if (colName == "EditCLO")
            {
                btnAddCLO.Text = "Edit";
                txtCLO.Text = row.Cells[4].Value.ToString();
                
            }
            else if (colName == "DeleteCLO")
            {
                if(MessageBox.Show("Are you sure you want to delete CLO!", "DELETE CLO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(Queries.isCLOExistInRubric(cloID))
                    {
                        Queries.deleteCLO(cloID);

                        bindData_CLO();
                        bind_cbCLOs();
                        totalCLos();
                    }
                    else
                    {
                        MessageBox.Show("Sorry! You can not delete the CLO beacuse it have Rubrics.", "Delete Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            else if (colName == "ViewCLO")
            {
                MessageBox.Show("View!");
            }
        }

        private void dgvRubric_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string colName = dgvRubric.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvRubric.Rows[e.RowIndex];
            int rubricID = (int)row.Cells[3].Value;

            if (colName == "DeleteRubric")
            {
                if (MessageBox.Show("Are you sure you want to delete Rubric!", "Delete Rubric", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Queries.isRubricExistInCmp(rubricID) && Queries.isRubricExistInRubbricLevel(rubricID))
                    {
                        Queries.deleteRubric(rubricID);
                    }
                    else
                    {
                        MessageBox.Show("Sorry! You can not delete this Rubric because it may be used in Assessment Component or may it have Rubric Levels.", "Delete Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else if (colName == "View")
            {
                Forms.frmViewRubric frm = new Forms.frmViewRubric(dgvRubric, e.RowIndex);
                frm.ShowDialog();
            }
            else if (colName == "EditRubirc")
            {
                Forms.frmEditRubric frm = new Forms.frmEditRubric((int)row.Cells[3].Value, row);
                frm.ShowDialog();
            }
            else
            {
                return;
            }
            bindData_CLO();
            bindData_Rubric();
            bind_cbRubricCmp();
        }

        private void btnAddAsmt_Click(object sender, EventArgs e)
        {
            int marks = (int)numMarks.Value;
            int weightage = (int)numWeightage.Value;
            string title = txtAsmtTitle.Text;

            if (title == "" || txtAsmtTitle.Text[0] == ' ')
            {
                MessageBox.Show("Assessment Title cannot be empty!", "Assessment Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnAddAsmt.Text == "Add")
                {
                    Queries.queryAddAssessment(title, marks, weightage);
                }
                else if (btnAddAsmt.Text == "Edit")
                {
                    if (MessageBox.Show("Are you sure you want to Edit!", "Edit Assessment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataTable dt = Queries.queryGetAsmpCmpMarks(assessmentID);
                        if (dt.Rows.Count != 0)
                        {
                            int AsmtCmpMarks = (int)dt.Rows[0][1];
                            int AsmtMarks = (int)dt.Rows[0][2];
                            if ( AsmtCmpMarks > marks)
                            {
                                numMarks.Value = AsmtCmpMarks;
                                MessageBox.Show("Assessment Marks cannot be less than the Total Assessment Component Marks \n Assessment Components Total Marks: " + AsmtCmpMarks, "Assessment Marks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        Queries.queryUpdateAssessment(assessmentID, title, marks, weightage);
                        btnAddAsmt.Text = "Add";
                    }
                    else
                    {
                        return;
                    }
                }

                numMarks.Value = 1;
                numWeightage.Value = 1;
                txtAsmtTitle.Text = "";

                bindData_Assessment();
                bind_cbAsmp();
                bind_EvAsmtCb();
            }
        }

        private void btnCancelAsmt_Click(object sender, EventArgs e)
        {
            btnAddAsmt.Text = "Add";
            numMarks.Value = 1;
            numWeightage.Value = 1;
            txtAsmtTitle.Text = "";
        }

        public void bindData_Assessment()
        {
            dgvAssessment.DataSource = Queries.queryGetAllAssessments();

            dgvAssessment.Columns[0].DisplayIndex = 6;
            dgvAssessment.Columns[1].DisplayIndex = 6;

            dgvAssessment.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dgvAssessment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string colName = dgvAssessment.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvAssessment.Rows[e.RowIndex];
            assessmentID = (int)row.Cells[2].Value;

            if (colName == "DeleteAsmt")
            {
                if(MessageBox.Show("Are you sure you want to delete Assessment!", "Delete Assessment!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(Queries.isAsmtExistInCmp(assessmentID))
                    {
                        Queries.deleteAsmt(assessmentID);

                        bindData_Assessment();
                        bind_cbAsmp();
                        bind_EvAsmtCb();
                    }
                    else
                    {
                        MessageBox.Show("Sorry! You can not delete the Assessment because this Assessment contains Component.", "Delete Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            else if (colName == "EditAsmt")
            {
                //load values
                btnAddAsmt.Text = "Edit";
                txtAsmtTitle.Text = row.Cells[3].Value.ToString();
                numMarks.Value = (int)row.Cells[5].Value;
                numWeightage.Value = (int)row.Cells[6].Value;
            }
        }

        public void bindData_AsmpCmp(int id)
        {
            DataTable dt = Queries.queryGetAsmpCmp(id);
            dgvAsmpCmp.DataSource = dt;

            txtTotalMarks.Text = Queries.queryGetAsmpMarks(id).ToString();

            dgvAsmpCmp.Columns[0].DisplayIndex = 8;
            dgvAsmpCmp.Columns[1].DisplayIndex = 8;

            dgvAsmpCmp.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void bind_cbAsmp()
        {
            DataTable dt = Queries.queryGetAllAssessments();
            cbAsmtCmp.DataSource = dt;

            cbAsmtCmp.DisplayMember = "Title";
            cbAsmtCmp.ValueMember = "Id";
            cbAsmtCmp.SelectedIndex = 0;
        }

        public void bind_cbRubricCmp()
        {
            cbRubricCmp.DataSource = Queries.queryGetGoodRubrics();

            cbRubricCmp.DisplayMember = "Details";
            cbRubricCmp.ValueMember = "Id";
            cbRubricCmp.SelectedIndex = 0;
        }


        private void btnAddCmp_Click(object sender, EventArgs e)
        {
            int asmtId = (int)cbAsmtCmp.SelectedValue;
            int rubricId = (int)cbRubricCmp.SelectedValue;

            string cmpName = txtCmpName.Text;
            int marks = (int)numMarkCmp.Value;

            if (txtCmpName.Text == "" || txtCmpName.Text[0] == ' ')
            {
                MessageBox.Show("Assessment Component Name cannot be empty!", "Assessment Component Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dt = Queries.queryGetAsmpCmpMarks(asmtId, (marks- prevCmpMarks));

                if (dt.Rows.Count != 0)
                {
                    int total = (int)dt.Rows[0][2];
                    int AsmtTMarks = (int)dt.Rows[0][1];
                    numMarkCmp.Value = total - (AsmtTMarks- prevCmpMarks);
                    MessageBox.Show("Assessment Component Marks Sum cannot be greater than Assessment Total Marks", "Assessment Component Marks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if(btnAddCmp.Text == "Edit")
                {
                    if(MessageBox.Show("Are you sure you want to Edit Assessment Component!", "Assessment Component Edit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Queries.queryUpdateAsmtComp(assessmentCmpID, cmpName, rubricId, marks, asmtId);
                        btnAddCmp.Text = "Add";
                    }
                    else
                    {
                        return;
                    }
                }
                else if (btnAddCmp.Text == "Add")
                {
                    Queries.queryAddAsmtComp(cmpName, rubricId, marks, asmtId);
                }

                txtCmpName.Text = "";
                numMarkCmp.Value = 1;
                prevCmpMarks = 0;

                bindData_AsmpCmp(asmtId);
                bind_EvAsmtCb();
            }
        }

        private void cbAsmtCmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbAsmtCmp.SelectedValue.ToString();
            if (id != "System.Data.DataRowView")
            {
                bindData_AsmpCmp(int.Parse(id));
            }
        }

        int prevCmpMarks = 0;

        private void dgvAsmpCmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }

            string colName = dgvAsmpCmp.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvAsmpCmp.Rows[e.RowIndex];
            assessmentCmpID = (int)row.Cells[2].Value;

            if (colName == "DeleteAsmtCmp")
            {
                if(MessageBox.Show("Are you sure you want to delete!", "Delete Assessment Component", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    if(Queries.isAsmtCmpExistInResult(assessmentCmpID))
                    {
                        Queries.deleteAsmtCmp(assessmentCmpID);
                        int asmtID = (int)cbAsmtCmp.SelectedValue;
                        bindData_AsmpCmp(asmtID);
                        bind_EvAsmtCb();
                    }
                    else
                    {
                        MessageBox.Show("Sorry! you can not delete this assessment component because it is used in evaluation.", "Error delete!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                
            }
            else if (colName == "EditAsmtCmp")
            {
                //load values
                btnAddCmp.Text = "Edit";
                txtCmpName.Text = row.Cells[3].Value.ToString();
                prevCmpMarks = (int)row.Cells[5].Value;
                numMarkCmp.Value = prevCmpMarks;
                cbRubricCmp.SelectedValue = (int)row.Cells[4].Value;
            }
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
        }

        private void btnCancelCmp_Click(object sender, EventArgs e)
        {
            btnAddCmp.Text = "Add";
            txtCmpName.Text = "";
            numMarkCmp.Value = 1;
            prevCmpMarks = 0;
        }

        public void bind_EvAsmtCb()
        {
            DataTable dt = Queries.selectGoodAsmt();
            cbEvAsmt.DataSource = dt;

            cbEvAsmt.DisplayMember = "Title";
            cbEvAsmt.ValueMember = "Id";
            cbEvAsmt.SelectedIndex = 0;

            lblTotalMarks.Text = "Total Marks: " + dt.Rows[0][1];
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            string title = cbEvAsmt.Text;
            int id = (int)cbEvAsmt.SelectedValue;
            Forms.frmEvaluation frm = new Forms.frmEvaluation(title, id);
            frm.ShowDialog();

            bind_evaluationTable();
        }

        public void bind_evaluationTable()
        {
            string id = cbEvAsmt.SelectedValue.ToString();
            
            if(id != "System.Data.DataRowView")
            {
                DataTable dt = Queries.assessmentResult(int.Parse(id));
                dgvEvaluate.DataSource = dt;
                lblTotalMarks.Text = "Total Marks: " + Queries.queryGetAsmpMarks(int.Parse(id));

                dgvEvaluate.Columns[0].DisplayIndex = 6;
                dgvEvaluate.Columns[1].DisplayIndex = 6;

                dgvEvaluate.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            
        }

        private void cbEvAsmt_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind_evaluationTable();
        }

        private void dgvEvaluate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string colName = dgvEvaluate.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvEvaluate.Rows[e.RowIndex];
            string title = cbEvAsmt.Text;
            int id = (int)cbEvAsmt.SelectedValue;
            int stId = (int)row.Cells[2].Value;

            if (colName == "evDelete")
            {
                if (MessageBox.Show("Are you sure you want to Delete!", "Delete Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Queries.DELETEStResult(stId, id);
                    bind_evaluationTable();
                }
            }
            else if (colName == "evEdit")
            {
                if (MessageBox.Show("Are you sure you want to edit!", "Edit Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Forms.frmEvaluation frm = new Forms.frmEvaluation(title, id, stId);
                    frm.ShowDialog();

                    bind_evaluationTable();
                }
            }
        }

        private void btnAttdReport_Click(object sender, EventArgs e)
        {
            Reports.GenerateAttendancePDF();
        }

        private void switchStd_CheckedChanged(object sender, EventArgs e)
        {
            bindData();
        }

        private void btnAsmtReport_Click_1(object sender, EventArgs e)
        {
            Reports.GenerateResultPDF(dgvEvaluate, cbEvAsmt.Text, lblTotalMarks.Text);
        }

        private void btnResultPDF_Click(object sender, EventArgs e)
        {
            Reports.GenerateCLOResultPDF();
        }
    }
}
