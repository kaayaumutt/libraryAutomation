namespace libraryAutomation
{
    partial class studentsReadingBooksListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentsReadingBooksListForm));
            this.cmbBoxStudent = new System.Windows.Forms.ComboBox();
            this.cmbBoxBook = new System.Windows.Forms.ComboBox();
            this.datePickerTaken = new System.Windows.Forms.DateTimePicker();
            this.datePickerGiven = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgViewFollow = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.rdoBtnStudent = new System.Windows.Forms.RadioButton();
            this.rdoBtnBook = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewFollow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxStudent
            // 
            this.cmbBoxStudent.ForeColor = System.Drawing.Color.Silver;
            this.cmbBoxStudent.FormattingEnabled = true;
            this.cmbBoxStudent.Location = new System.Drawing.Point(351, 206);
            this.cmbBoxStudent.Name = "cmbBoxStudent";
            this.cmbBoxStudent.Size = new System.Drawing.Size(240, 28);
            this.cmbBoxStudent.TabIndex = 49;
            this.cmbBoxStudent.Text = "Öğrenci Seçin";
            this.cmbBoxStudent.Enter += new System.EventHandler(this.cmbBoxStudent_Enter);
            this.cmbBoxStudent.Leave += new System.EventHandler(this.cmbBoxStudent_Leave);
            // 
            // cmbBoxBook
            // 
            this.cmbBoxBook.ForeColor = System.Drawing.Color.Silver;
            this.cmbBoxBook.FormattingEnabled = true;
            this.cmbBoxBook.Location = new System.Drawing.Point(351, 292);
            this.cmbBoxBook.Name = "cmbBoxBook";
            this.cmbBoxBook.Size = new System.Drawing.Size(240, 28);
            this.cmbBoxBook.TabIndex = 50;
            this.cmbBoxBook.Text = "Kitap Seçin";
            this.cmbBoxBook.Enter += new System.EventHandler(this.cmbBoxBook_Enter);
            this.cmbBoxBook.Leave += new System.EventHandler(this.cmbBoxBook_Leave);
            // 
            // datePickerTaken
            // 
            this.datePickerTaken.Location = new System.Drawing.Point(351, 383);
            this.datePickerTaken.Name = "datePickerTaken";
            this.datePickerTaken.Size = new System.Drawing.Size(240, 26);
            this.datePickerTaken.TabIndex = 53;
            this.datePickerTaken.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // datePickerGiven
            // 
            this.datePickerGiven.Location = new System.Drawing.Point(351, 482);
            this.datePickerGiven.Name = "datePickerGiven";
            this.datePickerGiven.Size = new System.Drawing.Size(240, 26);
            this.datePickerGiven.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Linen;
            this.label9.Location = new System.Drawing.Point(592, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 52);
            this.label9.TabIndex = 74;
            this.label9.Text = "Ödünç Sistemi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Linen;
            this.label7.Location = new System.Drawing.Point(130, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 29);
            this.label7.TabIndex = 73;
            this.label7.Text = "Verileceği Tarih";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Linen;
            this.label8.Location = new System.Drawing.Point(130, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 29);
            this.label8.TabIndex = 72;
            this.label8.Text = "Alındığı Tarih";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Linen;
            this.label10.Location = new System.Drawing.Point(130, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 29);
            this.label10.TabIndex = 71;
            this.label10.Text = "Kitap";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Linen;
            this.label11.Location = new System.Drawing.Point(130, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 29);
            this.label11.TabIndex = 70;
            this.label11.Text = "Öğrenci";
            // 
            // dgViewFollow
            // 
            this.dgViewFollow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgViewFollow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgViewFollow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewFollow.Location = new System.Drawing.Point(62, 640);
            this.dgViewFollow.Name = "dgViewFollow";
            this.dgViewFollow.RowHeadersWidth = 62;
            this.dgViewFollow.RowTemplate.Height = 28;
            this.dgViewFollow.Size = new System.Drawing.Size(1269, 335);
            this.dgViewFollow.TabIndex = 69;
            this.dgViewFollow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewFollow_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(783, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(381, 68);
            this.btnDelete.TabIndex = 77;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(783, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(381, 71);
            this.btnUpdate.TabIndex = 76;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(783, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(382, 71);
            this.btnAdd.TabIndex = 75;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1216, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 162);
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1276, 572);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 65);
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxSearch.Location = new System.Drawing.Point(974, 580);
            this.txtBoxSearch.Multiline = true;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(294, 35);
            this.txtBoxSearch.TabIndex = 79;
            this.txtBoxSearch.Text = "Veriler İçinde Ara";
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            this.txtBoxSearch.Enter += new System.EventHandler(this.txtBoxSearch_Enter);
            this.txtBoxSearch.Leave += new System.EventHandler(this.txtBoxSearch_Leave);
            // 
            // rdoBtnStudent
            // 
            this.rdoBtnStudent.AutoSize = true;
            this.rdoBtnStudent.BackColor = System.Drawing.Color.Transparent;
            this.rdoBtnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnStudent.Location = new System.Drawing.Point(998, 551);
            this.rdoBtnStudent.Name = "rdoBtnStudent";
            this.rdoBtnStudent.Size = new System.Drawing.Size(140, 26);
            this.rdoBtnStudent.TabIndex = 83;
            this.rdoBtnStudent.TabStop = true;
            this.rdoBtnStudent.Text = "Öğrenci Adı";
            this.rdoBtnStudent.UseVisualStyleBackColor = false;
            // 
            // rdoBtnBook
            // 
            this.rdoBtnBook.AutoSize = true;
            this.rdoBtnBook.BackColor = System.Drawing.Color.Transparent;
            this.rdoBtnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnBook.Location = new System.Drawing.Point(1144, 551);
            this.rdoBtnBook.Name = "rdoBtnBook";
            this.rdoBtnBook.Size = new System.Drawing.Size(116, 26);
            this.rdoBtnBook.TabIndex = 84;
            this.rdoBtnBook.TabStop = true;
            this.rdoBtnBook.Text = "Kitap Adı";
            this.rdoBtnBook.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(597, 200);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 48);
            this.pictureBox3.TabIndex = 85;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(602, 286);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 48);
            this.pictureBox4.TabIndex = 86;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(600, 380);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 48);
            this.pictureBox5.TabIndex = 87;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(597, 478);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 48);
            this.pictureBox6.TabIndex = 88;
            this.pictureBox6.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(136, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 83);
            this.btnBack.TabIndex = 89;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // studentsReadingBooksListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1413, 1008);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.rdoBtnBook);
            this.Controls.Add(this.rdoBtnStudent);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgViewFollow);
            this.Controls.Add(this.datePickerGiven);
            this.Controls.Add(this.datePickerTaken);
            this.Controls.Add(this.cmbBoxBook);
            this.Controls.Add(this.cmbBoxStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "studentsReadingBooksListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kitap İlişkisi İşlemleri Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.studentsReadingBooksListForm_FormClosed);
            this.Load += new System.EventHandler(this.studentsReadingBooksListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewFollow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbBoxStudent;
        private System.Windows.Forms.ComboBox cmbBoxBook;
        private System.Windows.Forms.DateTimePicker datePickerTaken;
        private System.Windows.Forms.DateTimePicker datePickerGiven;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgViewFollow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdoBtnStudent;
        private System.Windows.Forms.RadioButton rdoBtnBook;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnBack;
    }
}