using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace libraryAutomation
{
    public partial class booksListForm : Form
    {
        public booksListForm()
        {
            InitializeComponent();
        }

        databaseHelper databaseHelper = new databaseHelper();
        string isFillTableName = "books";

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void booksListForm_Load(object sender, EventArgs e)
        {
            databaseHelper.tableFill(isFillTableName, dgViewBooks);
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

        private void txtBoxName_Enter(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "Kitap Adı")
            {
                txtBoxName.Text = "";
                txtBoxName.ForeColor = Color.Black;
            }
        }

        private void txtBoxName_Leave(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "")
            {
                txtBoxName.Text = "Kitap Adı";
                txtBoxName.ForeColor = Color.Silver;
            }
        }

        private void txtBoxType_Enter(object sender, EventArgs e)
        {
            if (txtBoxType.Text == "Kitap Türü")
            {
                txtBoxType.Text = "";
                txtBoxType.ForeColor = Color.Black;
            }
        }

        private void txtBoxType_Leave(object sender, EventArgs e)
        {
            if (txtBoxType.Text == "")
            {
                txtBoxType.Text = "Kitap Türü";
                txtBoxType.ForeColor = Color.Silver;
            }
        }

        private void txtBoxAuthor_Enter(object sender, EventArgs e)
        {
            if (txtBoxAuthor.Text == "Kitap Yazarı")
            {
                txtBoxAuthor.Text = "";
                txtBoxAuthor.ForeColor = Color.Black;
            }
        }

        private void txtBoxAuthor_Leave(object sender, EventArgs e)
        {
            if (txtBoxAuthor.Text == "")
            {
                txtBoxAuthor.Text = "Kitap Yazarı";
                txtBoxAuthor.ForeColor = Color.Silver;
            }
        }

        private void txtBoxPageCount_Enter(object sender, EventArgs e)
        {
            if (txtBoxPageCount.Text == "Sayfa Sayısı")
            {
                txtBoxPageCount.Text = "";
                txtBoxPageCount.ForeColor = Color.Black;
            }
        }

        private void txtBoxPageCount_Leave(object sender, EventArgs e)
        {
            if (txtBoxPageCount.Text == "")
            {
                txtBoxPageCount.Text = "Sayfa Sayısı";
                txtBoxPageCount.ForeColor = Color.Silver;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            databaseHelper.updateName = txtBoxName.Text;
            databaseHelper.updateType = txtBoxType.Text;
            databaseHelper.updateAuthor = txtBoxAuthor.Text;
            databaseHelper.updatePageCount = txtBoxPageCount.Text;
            databaseHelper.bookAdd();
            databaseHelper.tableFill(isFillTableName, dgViewBooks);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            databaseHelper.selectRowDelete(isFillTableName, "bookID");
            databaseHelper.tableFill(isFillTableName, dgViewBooks);
        }

        private void dgViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            databaseHelper.updateID = int.Parse(dgViewBooks.CurrentRow.Cells[0].Value.ToString());
            txtBoxName.Text = dgViewBooks.CurrentRow.Cells[1].Value.ToString();
            txtBoxType.Text = dgViewBooks.CurrentRow.Cells[2].Value.ToString();
            txtBoxAuthor.Text = dgViewBooks.CurrentRow.Cells[3].Value.ToString();
            txtBoxPageCount.Text = dgViewBooks.CurrentRow.Cells[4].Value.ToString();
            txtBoxName.ForeColor = Color.Black;
            txtBoxType.ForeColor = Color.Black;
            txtBoxAuthor.ForeColor = Color.Black;
            txtBoxPageCount.ForeColor = Color.Black;
            MessageBox.Show("test id: "+databaseHelper.updateID.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            databaseHelper.updateName = txtBoxName.Text;
            databaseHelper.updateType = txtBoxType.Text;
            databaseHelper.updateAuthor = txtBoxAuthor.Text;
            databaseHelper.updatePageCount = txtBoxPageCount.Text;
            databaseHelper.bookUpdate();
            databaseHelper.tableFill(isFillTableName, dgViewBooks);
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            databaseHelper.tableSearch(isFillTableName, "bookName", txtBoxSearch.Text, dgViewBooks);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            signedForm signedForm = new signedForm();
            signedForm.Show();
            this.Hide();
        }

        private void booksListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
