using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace libraryAutomation
{
    public class databaseHelper : person
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; Initial Catalog=libraryAutomation;Integrated Security = True");
        public void connectionOpen()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    //MessageBox.Show("Bağlantı Sağlandı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void connectionClose()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    //MessageBox.Show("Bağlantı Kesildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void registerPerson()
        {
            try
            {
                string[] controlValues = { "persons", updateEmail, "personEmail" };
                if (controlData(controlValues, 1))
                {
                    string[] values = { "persons", "personName", "personSurname", "personEmail", "personPassword", "personDepartment", updateName, updateSurname, updateEmail, updatePassword, updateDepartment };
                    processData(values, "insert", 5);
                    MessageBox.Show("Kayıt başarılı");
                }
                else
                {
                    MessageBox.Show("Bu email hesabına ait hesap bulunmaktadır.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz!\n"+ex.Message);
            }
        }

        public bool signPerson()
        {
            bool control = false;
            try
            {
                connectionOpen();
                string record = "select * from persons";
                SqlCommand command = new SqlCommand(record, connection);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    if (updateEmail == read["personEmail"].ToString() && updatePassword == read["personPassword"].ToString())
                    {
                        control = true;
                        break;
                    }
                }
                connectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return control;
        }

        public void studentAdd()
        {
            try
            {
                string[] controlValues = { "students", updateStudentNo, "studentNo" };
                if (controlData(controlValues, 1))
                {
                    string[] values = { "students", "studentName", "studentSurname", "studentEmail", "studentNo", updateName, updateSurname, updateEmail, updateStudentNo };
                    processData(values, "insert", 4);
                    MessageBox.Show("Kayıt başarılı");
                }
                else
                {
                    MessageBox.Show("Bu öğrenci numarasına kayıtlı öğrenci bulunmaktadır.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz!\n"+ex.Message);
            }
        }

        public void tableFill(string selectTable, DataGridView table)
        {
            try
            {
                connectionOpen();
                string record = "select * from "+selectTable;
                SqlDataAdapter students = new SqlDataAdapter(record, connection);
                DataSet dataSet = new DataSet();
                students.Fill(dataSet, selectTable);
                table.DataSource = dataSet.Tables[selectTable];
                connectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void selectRowDelete(string selectTable, string selectRow)
        {
            try
            {
                connectionOpen();
                string record = "delete from "+selectTable+" where "+selectRow+"=@"+selectRow+"";
                SqlCommand command = new SqlCommand(record, connection);
                command.Parameters.AddWithValue("@"+selectRow+"", updateID);
                command.ExecuteNonQuery();
                connectionClose();
                MessageBox.Show("Veri silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void studentUpdate()
        {
            try
            {
                string[] values = { "students", "studentName", "studentSurname", "studentEmail", "studentNo", "studentID", updateName, updateSurname, updateEmail, updateStudentNo, updateID.ToString() };
                processData(values, "update", 5);
                MessageBox.Show("Öğrenci Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz!\n"+ex.Message);
            }
        }

        public void tableSearch(string selectTable, string selectSearchColumn, string value, DataGridView table)
        {
            try
            {
                connectionOpen();
                string record = "select * from "+selectTable+" where "+selectSearchColumn+" like'"+value+"%'";
                SqlDataAdapter students = new SqlDataAdapter(record, connection);
                DataSet dataSet = new DataSet();
                students.Fill(dataSet, selectTable);
                table.DataSource = dataSet.Tables[selectTable];
                connectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void bookAdd()
        {
            try
            {
                string[] controlValues = { "books", updateName, "bookName" };
                if (controlData(controlValues, 1))
                {
                    string[] values = { "books", "bookName", "bookType", "bookAuthor", "bookPageCount", updateName, updateType, updateAuthor, updatePageCount };
                    processData(values, "insert", 4);
                    MessageBox.Show("Kayıt başarılı");
                }
                else
                {
                    MessageBox.Show("Bu isimde kayıtlı kitap bulunmaktadır.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz!\n"+ex.Message);
            }
        }
        public void bookUpdate()
        {
            try
            {
                string[] values = { "books", "bookName", "bookType", "bookAuthor", "bookPageCount", "bookID", updateName, updateType, updateAuthor, updatePageCount, updateID.ToString() };
                processData(values, "update", 5);
                MessageBox.Show("Kitap Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz!\n"+ex.Message);
            }
        }

        public void getStudent(System.Windows.Forms.ComboBox comboBox)
        {
            string[] values = { "students", "studentName", "studentSurname" };
            addComboBoxData(values, 2, comboBox);
        }

        public void getBook(System.Windows.Forms.ComboBox comboBox)
        {
            string[] values = { "books", "bookName" };
            addComboBoxData(values, 1, comboBox);
        }

        public void studentBookFollowAdd()
        {
            try
            {
                string[] controlValues = { "studentBookFollow", updateStudentLongName, "studentLongName", updateBookLongName, "bookLongName" };
                if (controlData(controlValues, 2))
                {
                    if (controlEqual(updateTakenDate, updateGivenDate))
                    {
                        string[] values = { "studentBookFollow", "studentLongName", "bookLongName", "takenDate", "givenDate", updateStudentLongName, updateBookLongName, updateTakenDate, updateGivenDate };
                        processData(values, "insert", 4);
                        connectionClose();
                        MessageBox.Show("Kayıt başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Tarihler eşit olamaz");
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz öğrenci ile kitap zaten ilişkili!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz!\n"+ex.Message);
            }
        }

        public void studentBookFollowUpdate()
        {
            try
            {
                if (controlEqual(updateTakenDate, updateGivenDate))
                {
                    string[] values = { "studentBookFollow", "studentLongName", "bookLongName", "takenDate", "givenDate", "followID", updateStudentLongName, updateBookLongName, updateTakenDate, updateGivenDate, updateID.ToString() };
                    processData(values, "update", 5);
                    MessageBox.Show("Takip Güncellendi");
                }
                else
                {
                    MessageBox.Show("Tarihler eşit olamaz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz!\n"+ex.Message);
            }
        }

        public bool controlData(string[] values, int processLength)
        {
            bool control = true;
            connectionOpen();
            string record = "select * from "+values[0];
            SqlCommand command = new SqlCommand(record, connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                if (values[1] == read[values[2]].ToString() && processLength == 1)
                {
                    control = false;
                    break;
                }
                else if (values[1] == read[values[2]].ToString() &&
                    values[3] == read[values[4]].ToString() && processLength == 2)
                {
                    control = false;
                    break;
                }
            }
            connectionClose();
            return control;
        }

        public void processData(string[] values, string selectProcess, int tableLength)
        {
            connectionOpen();
            string record2="";
            if (selectProcess == "insert")
            {
                record2 = "insert into "+values[0]+"(";
                for (int i = 1; i <= tableLength; i++)
                {
                    if (i!=tableLength)
                    {
                        record2 += values[i]+",";
                    }
                    else
                    {
                        record2 += values[i]+") values (";
                        for (int x = 1; x <= tableLength; x++)
                        {
                            if (x!=tableLength)
                            {
                                record2 += "@"+values[x]+",";
                            }
                            else
                            {
                                record2 += "@"+values[x]+")";
                            }
                        }
                    }
                }
            }
            else if (selectProcess == "update")
            {
                record2 = "update "+values[0]+" set ";
                for (int i = 1; i <= tableLength; i++)
                {
                    if (i!=tableLength)
                    {
                        record2+=values[i]+"=@"+values[i];
                        if (i!=tableLength-1)
                        {
                            record2+=",";
                        }
                    }
                    else
                    {
                        record2+=" where "+values[i]+"=@"+values[i];
                    }
                }
            }
            SqlCommand command2 = new SqlCommand(record2, connection);
            for (int i = 1; i <= tableLength; i++)
            {
                command2.Parameters.AddWithValue("@"+values[i], values[i+tableLength]);
            }
            command2.ExecuteNonQuery();
            connectionClose();
        }

        public void addComboBoxData(string[] values, int processLength, System.Windows.Forms.ComboBox comboBox)
        {
            try
            {
                connectionOpen();
                string record = "select * from "+values[0];
                SqlCommand command = new SqlCommand(record, connection);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    if (processLength==1)
                    {
                        comboBox.Items.Add(read[values[1]].ToString());
                    }
                    else if (processLength==2)
                    {
                        comboBox.Items.Add(read[values[1]].ToString()+" "+read[values[2]].ToString());
                    }
                }
                connectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
