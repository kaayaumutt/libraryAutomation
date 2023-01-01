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
    public partial class signedForm : Form
    {
        public signedForm()
        {
            InitializeComponent();
        }

        private void btnStudentProcess_Click(object sender, EventArgs e)
        {
            studentsListForm studentsListForm = new studentsListForm();
            studentsListForm.Show();
            this.Hide();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            booksListForm booksListForm = new booksListForm();
            booksListForm.Show();
            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            studentsReadingBooksListForm studentsReadingBooksListForm = new studentsReadingBooksListForm();
            studentsReadingBooksListForm.Show();
            this.Hide();
        }

        private void btnBookShow_Click(object sender, EventArgs e)
        {
            booksListForm booksListForm = new booksListForm();
            booksListForm.Show();
            this.Hide();
        }

        private void btnRentFollow_Click(object sender, EventArgs e)
        {
            studentsReadingBooksListForm studentsReadingBooksListForm = new studentsReadingBooksListForm();
            studentsReadingBooksListForm.Show();
            this.Hide();
        }

        private void signedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
