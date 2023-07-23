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
    public partial class frmEditStudent : MaterialForm
    {
        DataGridViewRow row;
        public frmEditStudent(DataGridViewRow row)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.row = row;

            loadStatusValues();
            loadValues(row);
        }

        public void loadStatusValues()
        {
            cbStatus.DataSource = Queries.queryLookUpValues("STUDENT_STATUS");

            cbStatus.DisplayMember = "Name";
            cbStatus.ValueMember = "Name";
            cbStatus.SelectedValue = "Name";
            cbStatus.SelectedIndex = 0;
        }

        public void loadValues(DataGridViewRow row)
        {
            firstNametxt.Text = row.Cells[3].Value.ToString();
            lastNametxt.Text = row.Cells[4].Value.ToString();
            contacttxt.Text = row.Cells[5].Value.ToString();
            emailtxt.Text = row.Cells[6].Value.ToString();
            regNotxt.Text = row.Cells[7].Value.ToString();
            cbStatus.SelectedText = row.Cells[8].Value.ToString();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkValidInputs(firstNametxt.Text, lastNametxt.Text, contacttxt.Text, emailtxt.Text, regNotxt.Text))
            {
                if(MessageBox.Show("Confirm Edit! ", "Edit Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string id = row.Cells[2].Value.ToString();
                    Queries.queryEditStudent(id, firstNametxt.Text, lastNametxt.Text, contacttxt.Text, emailtxt.Text, regNotxt.Text.ToUpper(), cbStatus.Text);
                    this.Close();
                }
            }
        }

        public bool checkValidInputs(string firstName, string lastName, string contact, string email, string regNo)
        {
            if (firstName == "" || lastName == "" || firstName[0] == ' ' || lastName[0] == ' ')
            {
                MessageBox.Show("Invalid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (contact.Length != 11 || contact[0] != '0' || contact[1] != '3')
            {
                MessageBox.Show("Invalid Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!email.EndsWith("@gmail.com") || email[0] == ' ' || email == "@gmail.com" || email == "")
            {
                MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (regNo == "" || regNo[0] == ' ' || Queries.isRegNoExist(regNo.ToUpper()))
            {
                MessageBox.Show("Invalid Registration Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
