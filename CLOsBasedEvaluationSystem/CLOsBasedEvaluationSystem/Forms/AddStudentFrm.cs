using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using CLOsBasedEvaluationSystem.Utility;

namespace CLOsBasedEvaluationSystem.Forms
{
    public partial class AddStudentFrm : MaterialForm
    {
        public AddStudentFrm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            loadLoopUpValues();
        }

        public void loadLoopUpValues()
        {
            cbStatus.DataSource = Queries.queryLookUpValues("STUDENT_STATUS");

            cbStatus.DisplayMember = "Name";
            cbStatus.ValueMember = "Name";
            cbStatus.SelectedValue = "Name";
            cbStatus.SelectedIndex = 0;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if(checkValidInputs(firstNametxt.Text, lastNametxt.Text, contacttxt.Text, emailtxt.Text, regNotxt.Text))
            {
                Queries.queryAddStudent(firstNametxt.Text, lastNametxt.Text, contacttxt.Text, emailtxt.Text, regNotxt.Text.ToUpper(), cbStatus.Text);

                MessageBox.Show("Successfully Added \n Student: " + firstNametxt.Text + " " + lastNametxt.Text);
                clearFields();
            }
        }

        public bool checkValidInputs(string firstName, string lastName, string contact, string email, string regNo)
        {
            if(firstName == "" || lastName ==  "" || firstName[0] == ' ' || lastName[0] == ' ')
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

            if(regNo == "" || regNo[0] == ' ' || Queries.isRegNoExist(regNo.ToUpper()))
            {
                MessageBox.Show("Invalid Registration Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void clearFields()
        {
            firstNametxt.Text = "";
            lastNametxt.Text = "";
            regNotxt.Text = "";
            contacttxt.Text = "";
            emailtxt.Text = "";
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
