using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryAutomation
{
    public partial class studentsListForm : Form
    {
        public studentsListForm()
        {
            InitializeComponent();
        }

        databaseHelper databaseHelper = new databaseHelper();
        string isFillTableName = "students";  
        private void studentsListForm_Load(object sender, EventArgs e)
        {
            databaseHelper.tableFill(isFillTableName, dgViewStudents);
        }

        private void txtBoxName_Enter(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "Öğrenci Adı")
            {
                txtBoxName.Text = "";
                txtBoxName.ForeColor = Color.Black;
            }
        }

        private void txtBoxName_Leave(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "")
            {
                txtBoxName.Text = "Öğrenci Adı";
                txtBoxName.ForeColor = Color.Silver;
            }
        }

        private void txtBoxSurname_Enter(object sender, EventArgs e)
        {
            if (txtBoxSurname.Text == "Öğrenci Soyadı")
            {
                txtBoxSurname.Text = "";
                txtBoxSurname.ForeColor = Color.Black;
            }
        }

        private void txtBoxSurname_Leave(object sender, EventArgs e)
        {
            if (txtBoxSurname.Text == "")
            {
                txtBoxSurname.Text = "Öğrenci Soyadı";
                txtBoxSurname.ForeColor = Color.Silver;
            }
        }

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "Öğrenci E-Maili")
            {
                txtBoxEmail.Text = "";
                txtBoxEmail.ForeColor = Color.Black;
            }
        }

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "")
            {
                txtBoxEmail.Text = "Öğrenci E-Maili";
                txtBoxEmail.ForeColor = Color.Silver;
            }
        }

        private void txtBoxStudentNo_Enter(object sender, EventArgs e)
        {
            if (txtBoxStudentNo.Text == "Öğrenci Numarası")
            {
                txtBoxStudentNo.Text = "";
                txtBoxStudentNo.ForeColor = Color.Black;
            }
        }

        private void txtBoxStudentNo_Leave(object sender, EventArgs e)
        {
            if (txtBoxStudentNo.Text == "")
            {
                txtBoxStudentNo.Text = "Öğrenci Numarası";
                txtBoxStudentNo.ForeColor = Color.Silver;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            databaseHelper.updateName = txtBoxName.Text;
            databaseHelper.updateSurname = txtBoxSurname.Text;
            databaseHelper.updateEmail = txtBoxEmail.Text;
            databaseHelper.updateStudentNo = txtBoxStudentNo.Text;
            databaseHelper.studentAdd();
            databaseHelper.tableFill(isFillTableName, dgViewStudents);
        }

        private void dgViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            databaseHelper.updateID = int.Parse(dgViewStudents.CurrentRow.Cells[0].Value.ToString());
            txtBoxName.Text = dgViewStudents.CurrentRow.Cells[1].Value.ToString();
            txtBoxSurname.Text = dgViewStudents.CurrentRow.Cells[2].Value.ToString();
            txtBoxEmail.Text = dgViewStudents.CurrentRow.Cells[3].Value.ToString();
            txtBoxStudentNo.Text = dgViewStudents.CurrentRow.Cells[4].Value.ToString();
            txtBoxName.ForeColor = Color.Black;
            txtBoxSurname.ForeColor = Color.Black;
            txtBoxEmail.ForeColor = Color.Black;
            txtBoxStudentNo.ForeColor = Color.Black;
            MessageBox.Show("test id: "+databaseHelper.updateID.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            databaseHelper.selectRowDelete(isFillTableName,"studentID");
            databaseHelper.tableFill(isFillTableName, dgViewStudents);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            databaseHelper.updateName = txtBoxName.Text;
            databaseHelper.updateSurname = txtBoxSurname.Text;
            databaseHelper.updateEmail = txtBoxEmail.Text;
            databaseHelper.updateStudentNo = txtBoxStudentNo.Text;
            databaseHelper.studentUpdate();
            databaseHelper.tableFill(isFillTableName,dgViewStudents);
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            databaseHelper.tableSearch(isFillTableName,"studentName",txtBoxSearch.Text, dgViewStudents);
        }

        private void txtBoxSearch_Enter(object sender, EventArgs e)
        {

            if (txtBoxSearch.Text == "Veriler İçinde Ara")
            {
                txtBoxSearch.Text = "";
                txtBoxSearch.ForeColor = Color.Black;
            }
        }

        private void txtBoxSearch_Leave(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "")
            {
                txtBoxSearch.Text = "Veriler İçinde Ara";
                txtBoxSearch.ForeColor = Color.Silver;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            signedForm signedForm = new signedForm();
            signedForm.Show();
            this.Hide();
        }

        private void studentsListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
