using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLOsBasedEvaluationSystem.Utility;

namespace CLOsBasedEvaluationSystem.Forms
{
    public partial class frmAttendance : MaterialForm
    {
        DateTime date_time;
        DataGridViewRow attendance;
        public frmAttendance(DateTime date_time)
        {
            initialize();

            bindcbStatus();
            loadStudents();
            this.date_time = date_time;
            dateTimePicker.Value = date_time;
        }

        public frmAttendance(DataGridViewRow attendance)
        {
            initialize();

            bindcbStatus();
            loadStudents();
            this.attendance = attendance;
            DateTime dt = Convert.ToDateTime(attendance.Cells[1].Value.ToString());
            dateTimePicker.Value = dt;
            loadPrevAttd();
            btnSave.Text = "Edit";
        }

        public void initialize()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        

        public void loadPrevAttd()
        {
            int attdId = Queries.queryGetAttdId(dateTimePicker.Value);
            DataTable stdData = Queries.queryGetStddIdsStatus(attdId);

            for ( int idx = 0; idx < dgvAttendance.Rows.Count; idx++)
            {
                DataGridViewRow row = dgvAttendance.Rows[idx];
                for (int i =0; i < stdData.Rows.Count; i++)
                {
                    string stdID = row.Cells[1].Value.ToString();
                    string dbstdID = stdData.Rows[i][0].ToString();

                    if (stdID == dbstdID)
                    {
                        int ID = Convert.ToInt32(stdData.Rows[i][1]);
                        row.Cells[0].Value = Queries.queryGetStatusName(ID); /// -------------------------- here
                        break;
                    }
                }
            }
        }
       

        public void loadStudents()
        {
            dgvAttendance.DataSource = Queries.queryActiveStudentsForAttendance("Active");

            /*foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                row.Cells[0].Value = "Present";
            }*/

            /*int i = 0;
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)row.Cells["cbStatus"];
                dgvAttendance.Rows[i].Cells[0].Value = cell.Items[0];
                i++;
            }*/
        }

        public void bindcbStatus()
        {
            DataTable dt = Queries.queryLookUpValues("ATTENDANCE_STATUS");


            cbStatus.DataSource = dt;
            cbStatus.DisplayMember = "Name";
            cbStatus.ValueMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(btnSave.Text == "Save")
            {
                saveAttd();
            }
            else if(btnSave.Text == "Edit")
            {
                editAttd();
            }

        }

        

        public void editAttd()
        {
            if (MessageBox.Show("Confirm Edit Attendance", "Edit Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DateTime datetime = dateTimePicker.Value;
                Queries.queryAddAttendanceDate(datetime);
                int id = Queries.queryGetAttendanceID(datetime);
                Queries.queryDeletePrevAttd(id);

                attdendance(id);
            }
        }

        public void attdendance(int id)
        {
            for (int i = 0; i < dgvAttendance.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dgvAttendance.Rows[i];
                
                int statusID;
                if (row.Cells[0].Value == null)
                {
                    statusID = Queries.findLookUpId("Absent");
                }
                else
                {
                    string status = row.Cells[0].Value.ToString();
                    statusID = Queries.findLookUpId(status);
                }
                string st = row.Cells[1].Value.ToString();
                int stID = Convert.ToInt32(st);
                Queries.queryMarkAttendance(id, stID, statusID);

                this.Close();
            }
        }

        public void saveAttd()
        {
            if (MessageBox.Show("Confirm Attendance!\nAny unmarked attendance will be consider as Absent", "Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var datetime = dateTimePicker.Value;
                bool isAdded = Queries.queryAddAttendanceDate(datetime);
                int id = Queries.queryGetAttendanceID(datetime);

                if (!isAdded)
                {
                    Queries.queryDeletePrevAttd(id);
                    
                }
                attdendance(id);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
        }
    }
}
