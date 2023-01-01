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
    public partial class studentsReadingBooksListForm : Form
    {
        public studentsReadingBooksListForm()
        {
            InitializeComponent();
        }

        databaseHelper databaseHelper = new databaseHelper();
        string isFillTableName = "studentBookFollow";
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void studentsReadingBooksListForm_Load(object sender, EventArgs e)
        {
            databaseHelper.getStudent(cmbBoxStudent);
            databaseHelper.getBook(cmbBoxBook);
            databaseHelper.tableFill(isFillTableName, dgViewFollow);
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

        private void cmbBoxStudent_Enter(object sender, EventArgs e)
        {
            if (cmbBoxStudent.Text == "Öğrenci Seçin")
            {
                cmbBoxStudent.Text = "";
                cmbBoxStudent.ForeColor = Color.Black;
            }
        }

        private void cmbBoxStudent_Leave(object sender, EventArgs e)
        {

            if (cmbBoxStudent.Text == "")
            {
                cmbBoxStudent.Text = "Öğrenci Seçin";
                cmbBoxStudent.ForeColor = Color.Silver;
            }
        }

        private void cmbBoxBook_Enter(object sender, EventArgs e)
        {
            if (cmbBoxBook.Text == "Kitap Seçin")
            {
                cmbBoxBook.Text = "";
                cmbBoxBook.ForeColor = Color.Black;
            }

        }

        private void cmbBoxBook_Leave(object sender, EventArgs e)
        {
            if (cmbBoxBook.Text == "")
            {
                cmbBoxBook.Text = "Kitap Seçin";
                cmbBoxBook.ForeColor = Color.Silver;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            databaseHelper.updateStudentLongName = cmbBoxStudent.Text;
            databaseHelper.updateBookLongName = cmbBoxBook.Text;
            databaseHelper.updateTakenDate = datePickerTaken.Text;
            databaseHelper.updateGivenDate = datePickerGiven.Text;
            databaseHelper.studentBookFollowAdd();
            databaseHelper.tableFill(isFillTableName, dgViewFollow);
        }

        private void dgViewFollow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            databaseHelper.updateID = int.Parse(dgViewFollow.CurrentRow.Cells[0].Value.ToString());
            cmbBoxStudent.Text = dgViewFollow.CurrentRow.Cells[1].Value.ToString();
            cmbBoxBook.Text = dgViewFollow.CurrentRow.Cells[2].Value.ToString();
            //datePickerTaken.Text = dgViewFollow.CurrentRow.Cells[3].Value.ToString();
            //datePickerGiven.Text = dgViewFollow.CurrentRow.Cells[4].Value.ToString();
            cmbBoxStudent.ForeColor = Color.Black;
            cmbBoxBook.ForeColor = Color.Black;
            MessageBox.Show("test id: "+databaseHelper.updateID.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            databaseHelper.updateStudentLongName = cmbBoxStudent.Text;
            databaseHelper.updateBookLongName = cmbBoxBook.Text;
            databaseHelper.updateTakenDate = datePickerTaken.Text;
            databaseHelper.updateGivenDate = datePickerGiven.Text;
            databaseHelper.studentBookFollowUpdate();
            databaseHelper.tableFill(isFillTableName, dgViewFollow);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            databaseHelper.selectRowDelete(isFillTableName, "followID");
            databaseHelper.tableFill(isFillTableName, dgViewFollow);
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (rdoBtnStudent.Checked)
            {
                databaseHelper.tableSearch(isFillTableName, "studentLongName", txtBoxSearch.Text, dgViewFollow);
            }
            else if (rdoBtnBook.Checked)
            {
                databaseHelper.tableSearch(isFillTableName, "bookLongName", txtBoxSearch.Text, dgViewFollow);
            }
            else
            {
                databaseHelper.tableSearch(isFillTableName, "studentLongName", txtBoxSearch.Text, dgViewFollow);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            signedForm signedForm = new signedForm();
            signedForm.Show();
            this.Hide();
        }

        private void studentsReadingBooksListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
