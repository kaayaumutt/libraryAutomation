using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace libraryAutomation
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new splashScreen());
        }

        databaseHelper databaseHelper = new databaseHelper();

        private void loginForm_Load(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {}

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "E-Mail")
            {
                txtBoxEmail.Text = "";
                txtBoxEmail.ForeColor = Color.Black;
            }
        }
        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "")
            {
                txtBoxEmail.Text = "E-Mail";
                txtBoxEmail.ForeColor = Color.Silver;
            }
        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "Şifre")
            {
                txtBoxPassword.Text = "";
                txtBoxPassword.ForeColor = Color.Black;
            }
        }

        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "")
            {
                txtBoxPassword.Text = "Şifre";
                txtBoxPassword.ForeColor = Color.Silver;
            }
        }

        private void txtBoxName_Enter_1(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "Ad")
            {
                txtBoxName.Text = "";
                txtBoxName.ForeColor = Color.Black;
            }
        }

        private void txtBoxName_Leave_1(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "")
            {
                txtBoxName.Text = "Ad";
                txtBoxName.ForeColor = Color.Silver;
            }
        }

        private void txtBoxSurname_Enter(object sender, EventArgs e)
        {
            if (txtBoxSurname.Text == "Soyad")
            {
                txtBoxSurname.Text = "";
                txtBoxSurname.ForeColor = Color.Black;
            }
        }

        private void txtBoxSurname_Leave(object sender, EventArgs e)
        {
            if (txtBoxSurname.Text == "")
            {
                txtBoxSurname.Text = "Soyad";
                txtBoxSurname.ForeColor = Color.Silver;
            }
        }

        private void txtBoxREmail_Enter(object sender, EventArgs e)
        {
            if (txtBoxREmail.Text == "E-Mail")
            {
                txtBoxREmail.Text = "";
                txtBoxREmail.ForeColor = Color.Black;
            }
        }

        private void txtBoxREmail_Leave(object sender, EventArgs e)
        {
            if (txtBoxREmail.Text == "")
            {
                txtBoxREmail.Text = "E-Mail";
                txtBoxREmail.ForeColor = Color.Silver;
            }
        }

        private void txtBoxRPassword_Enter(object sender, EventArgs e)
        {
            if (txtBoxRPassword.Text == "Şifre")
            {
                txtBoxRPassword.Text = "";
                txtBoxRPassword.ForeColor = Color.Black;
            }
        }

        private void txtBoxRPassword_Leave(object sender, EventArgs e)
        {
            if (txtBoxRPassword.Text == "")
            {
                txtBoxRPassword.Text = "Şifre";
                txtBoxRPassword.ForeColor = Color.Silver;
            }
        }

        private void txtBoxDepartment_Enter(object sender, EventArgs e)
        {
            if (txtBoxDepartment.Text == "Departman")
            {
                txtBoxDepartment.Text = "";
                txtBoxDepartment.ForeColor = Color.Black;
            }
        }

        private void txtBoxDepartment_Leave(object sender, EventArgs e)
        {
            if (txtBoxDepartment.Text == "")
            {
                txtBoxDepartment.Text = "Departman";
                txtBoxDepartment.ForeColor = Color.Silver;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            databaseHelper.updateName = txtBoxName.Text;
            databaseHelper.updateSurname = txtBoxSurname.Text;
            databaseHelper.updateEmail = txtBoxREmail.Text;
            databaseHelper.updatePassword = txtBoxRPassword.Text;
            databaseHelper.updateDepartment = txtBoxDepartment.Text;
            databaseHelper.registerPerson();
            txtBoxName.Text = "Ad";
            txtBoxName.ForeColor = Color.Silver;
            txtBoxSurname.Text = "Soyad";
            txtBoxSurname.ForeColor = Color.Silver;
            txtBoxREmail.Text = "E-Mail";
            txtBoxREmail.ForeColor = Color.Silver;
            txtBoxRPassword.Text = "Şifre";
            txtBoxRPassword.ForeColor = Color.Silver;
            txtBoxDepartment.Text = "Departman";
            txtBoxDepartment.ForeColor = Color.Silver;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            databaseHelper.updateEmail = txtBoxEmail.Text;
            databaseHelper.updatePassword = txtBoxPassword.Text;
            if (databaseHelper.signPerson())
            {
                signedForm signedForm = new signedForm();
                signedForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email veya şifre yanlış");
            }
        }
    }
}
