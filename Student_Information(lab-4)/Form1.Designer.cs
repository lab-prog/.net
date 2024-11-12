namespace Student_Information_lab_2_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            stusem = new ComboBox();
            stuyear = new ComboBox();
            stu_sem = new Label();
            stu_year = new Label();
            stuname = new TextBox();
            stu_name = new Label();
            sturoll = new TextBox();
            stu_roll = new Label();
            groupBox2 = new GroupBox();
            stu_gender_other = new RadioButton();
            stu_gender_female = new RadioButton();
            stu_gender_male = new RadioButton();
            stu_gender = new Label();
            stublood = new TextBox();
            stumail = new TextBox();
            stuphn = new TextBox();
            mothername = new TextBox();
            fathername = new TextBox();
            stu_blood = new Label();
            stu_mail = new Label();
            stu_phn = new Label();
            mother_name = new Label();
            father_name = new Label();
            groupBox3 = new GroupBox();
            clubs_list = new ListBox();
            stubacklogs = new TextBox();
            stucgpa = new TextBox();
            clubs = new Label();
            stu_backlogs = new Label();
            stu_cgpa = new Label();
            submit_btn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stusem);
            groupBox1.Controls.Add(stuyear);
            groupBox1.Controls.Add(stu_sem);
            groupBox1.Controls.Add(stu_year);
            groupBox1.Controls.Add(stuname);
            groupBox1.Controls.Add(stu_name);
            groupBox1.Controls.Add(sturoll);
            groupBox1.Controls.Add(stu_roll);
            groupBox1.Location = new Point(34, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Academic Information";
            // 
            // stusem
            // 
            stusem.FormattingEnabled = true;
            stusem.Items.AddRange(new object[] { "I", "II" });
            stusem.Location = new Point(198, 224);
            stusem.Name = "stusem";
            stusem.Size = new Size(182, 33);
            stusem.TabIndex = 7;
            // 
            // stuyear
            // 
            stuyear.FormattingEnabled = true;
            stuyear.Items.AddRange(new object[] { "I", "II", "III", "IV" });
            stuyear.Location = new Point(198, 177);
            stuyear.Name = "stuyear";
            stuyear.Size = new Size(182, 33);
            stuyear.TabIndex = 6;
            stuyear.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // stu_sem
            // 
            stu_sem.AutoSize = true;
            stu_sem.Location = new Point(24, 232);
            stu_sem.Name = "stu_sem";
            stu_sem.Size = new Size(157, 25);
            stu_sem.TabIndex = 5;
            stu_sem.Text = "Current Semester :";
            stu_sem.Click += label4_Click;
            // 
            // stu_year
            // 
            stu_year.AutoSize = true;
            stu_year.Location = new Point(24, 177);
            stu_year.Name = "stu_year";
            stu_year.Size = new Size(116, 25);
            stu_year.TabIndex = 4;
            stu_year.Text = "Current Year :";
            // 
            // stuname
            // 
            stuname.Location = new Point(198, 114);
            stuname.Name = "stuname";
            stuname.Size = new Size(311, 31);
            stuname.TabIndex = 3;
            // 
            // stu_name
            // 
            stu_name.AutoSize = true;
            stu_name.Location = new Point(24, 117);
            stu_name.Name = "stu_name";
            stu_name.Size = new Size(134, 25);
            stu_name.TabIndex = 2;
            stu_name.Text = "Student Name :";
            // 
            // sturoll
            // 
            sturoll.Location = new Point(198, 57);
            sturoll.Name = "sturoll";
            sturoll.Size = new Size(311, 31);
            sturoll.TabIndex = 1;
            // 
            // stu_roll
            // 
            stu_roll.AutoSize = true;
            stu_roll.Location = new Point(24, 63);
            stu_roll.Name = "stu_roll";
            stu_roll.Size = new Size(149, 25);
            stu_roll.TabIndex = 0;
            stu_roll.Text = "Student Roll No. :";
            stu_roll.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(stu_gender_other);
            groupBox2.Controls.Add(stu_gender_female);
            groupBox2.Controls.Add(stu_gender_male);
            groupBox2.Controls.Add(stu_gender);
            groupBox2.Controls.Add(stublood);
            groupBox2.Controls.Add(stumail);
            groupBox2.Controls.Add(stuphn);
            groupBox2.Controls.Add(mothername);
            groupBox2.Controls.Add(fathername);
            groupBox2.Controls.Add(stu_blood);
            groupBox2.Controls.Add(stu_mail);
            groupBox2.Controls.Add(stu_phn);
            groupBox2.Controls.Add(mother_name);
            groupBox2.Controls.Add(father_name);
            groupBox2.Location = new Point(596, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(528, 329);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Personal Information";
            // 
            // stu_gender_other
            // 
            stu_gender_other.AutoSize = true;
            stu_gender_other.Location = new Point(426, 285);
            stu_gender_other.Name = "stu_gender_other";
            stu_gender_other.Size = new Size(82, 29);
            stu_gender_other.TabIndex = 13;
            stu_gender_other.TabStop = true;
            stu_gender_other.Text = "Other";
            stu_gender_other.UseVisualStyleBackColor = true;
            // 
            // stu_gender_female
            // 
            stu_gender_female.AutoSize = true;
            stu_gender_female.Location = new Point(298, 285);
            stu_gender_female.Name = "stu_gender_female";
            stu_gender_female.Size = new Size(93, 29);
            stu_gender_female.TabIndex = 12;
            stu_gender_female.TabStop = true;
            stu_gender_female.Text = "Female";
            stu_gender_female.UseVisualStyleBackColor = true;
            // 
            // stu_gender_male
            // 
            stu_gender_male.AutoSize = true;
            stu_gender_male.Location = new Point(197, 285);
            stu_gender_male.Name = "stu_gender_male";
            stu_gender_male.Size = new Size(75, 29);
            stu_gender_male.TabIndex = 11;
            stu_gender_male.TabStop = true;
            stu_gender_male.Text = "Male";
            stu_gender_male.UseVisualStyleBackColor = true;
            // 
            // stu_gender
            // 
            stu_gender.AutoSize = true;
            stu_gender.Location = new Point(23, 289);
            stu_gender.Name = "stu_gender";
            stu_gender.Size = new Size(135, 25);
            stu_gender.TabIndex = 1;
            stu_gender.Text = "Student Gender";
            // 
            // stublood
            // 
            stublood.Location = new Point(197, 241);
            stublood.Name = "stublood";
            stublood.Size = new Size(311, 31);
            stublood.TabIndex = 10;
            // 
            // stumail
            // 
            stumail.Location = new Point(197, 194);
            stumail.Name = "stumail";
            stumail.Size = new Size(311, 31);
            stumail.TabIndex = 9;
            // 
            // stuphn
            // 
            stuphn.Location = new Point(197, 150);
            stuphn.Name = "stuphn";
            stuphn.Size = new Size(311, 31);
            stuphn.TabIndex = 8;
            // 
            // mothername
            // 
            mothername.Location = new Point(197, 102);
            mothername.Name = "mothername";
            mothername.Size = new Size(311, 31);
            mothername.TabIndex = 7;
            // 
            // fathername
            // 
            fathername.Location = new Point(197, 54);
            fathername.Name = "fathername";
            fathername.Size = new Size(311, 31);
            fathername.TabIndex = 6;
            // 
            // stu_blood
            // 
            stu_blood.AutoSize = true;
            stu_blood.Location = new Point(23, 247);
            stu_blood.Name = "stu_blood";
            stu_blood.Size = new Size(176, 25);
            stu_blood.TabIndex = 5;
            stu_blood.Text = "Student Blood Type :";
            stu_blood.Click += label9_Click;
            // 
            // stu_mail
            // 
            stu_mail.AutoSize = true;
            stu_mail.Location = new Point(23, 200);
            stu_mail.Name = "stu_mail";
            stu_mail.Size = new Size(143, 25);
            stu_mail.TabIndex = 4;
            stu_mail.Text = "Student Mail ID :";
            stu_mail.Click += label8_Click;
            // 
            // stu_phn
            // 
            stu_phn.AutoSize = true;
            stu_phn.Location = new Point(23, 156);
            stu_phn.Name = "stu_phn";
            stu_phn.Size = new Size(175, 25);
            stu_phn.TabIndex = 3;
            stu_phn.Text = "Student Mobile No. :";
            // 
            // mother_name
            // 
            mother_name.AutoSize = true;
            mother_name.Location = new Point(23, 108);
            mother_name.Name = "mother_name";
            mother_name.Size = new Size(131, 25);
            mother_name.TabIndex = 2;
            mother_name.Text = "Mother Name :";
            // 
            // father_name
            // 
            father_name.AutoSize = true;
            father_name.Location = new Point(23, 60);
            father_name.Name = "father_name";
            father_name.Size = new Size(121, 25);
            father_name.TabIndex = 1;
            father_name.Text = "Father Name :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(clubs_list);
            groupBox3.Controls.Add(stubacklogs);
            groupBox3.Controls.Add(stucgpa);
            groupBox3.Controls.Add(clubs);
            groupBox3.Controls.Add(stu_backlogs);
            groupBox3.Controls.Add(stu_cgpa);
            groupBox3.Location = new Point(34, 373);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(528, 329);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Student Extra Circular Information";
            // 
            // clubs_list
            // 
            clubs_list.FormattingEnabled = true;
            clubs_list.ItemHeight = 25;
            clubs_list.Items.AddRange(new object[] { "Dance Club", "Music Club", "Culanry Club", "Animation Club", "Painting Club", "Not Interested" });
            clubs_list.Location = new Point(200, 122);
            clubs_list.Name = "clubs_list";
            clubs_list.Size = new Size(267, 154);
            clubs_list.TabIndex = 13;
            // 
            // stubacklogs
            // 
            stubacklogs.Location = new Point(198, 85);
            stubacklogs.Name = "stubacklogs";
            stubacklogs.Size = new Size(311, 31);
            stubacklogs.TabIndex = 12;
            // 
            // stucgpa
            // 
            stucgpa.Location = new Point(198, 48);
            stucgpa.Name = "stucgpa";
            stucgpa.Size = new Size(311, 31);
            stucgpa.TabIndex = 11;
            // 
            // clubs
            // 
            clubs.AutoSize = true;
            clubs.Location = new Point(24, 142);
            clubs.Name = "clubs";
            clubs.Size = new Size(65, 25);
            clubs.TabIndex = 10;
            clubs.Text = "Clubs :";
            clubs.Click += label13_Click;
            // 
            // stu_backlogs
            // 
            stu_backlogs.AutoSize = true;
            stu_backlogs.Location = new Point(24, 97);
            stu_backlogs.Name = "stu_backlogs";
            stu_backlogs.Size = new Size(157, 25);
            stu_backlogs.TabIndex = 9;
            stu_backlogs.Text = "Student Backlogs :";
            // 
            // stu_cgpa
            // 
            stu_cgpa.AutoSize = true;
            stu_cgpa.Location = new Point(24, 54);
            stu_cgpa.Name = "stu_cgpa";
            stu_cgpa.Size = new Size(65, 25);
            stu_cgpa.TabIndex = 8;
            stu_cgpa.Text = "CGPA :";
            // 
            // submit_btn
            // 
            submit_btn.BackColor = SystemColors.GradientActiveCaption;
            submit_btn.BackgroundImageLayout = ImageLayout.Center;
            submit_btn.Location = new Point(541, 721);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(142, 34);
            submit_btn.TabIndex = 2;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = false;
            submit_btn.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 784);
            Controls.Add(submit_btn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label stu_roll;
        private TextBox sturoll;
        private Label stu_sem;
        private Label stu_year;
        private TextBox stuname;
        private Label stu_name;
        private ComboBox stuyear;
        private ComboBox stusem;
        private Label stu_phn;
        private Label mother_name;
        private Label father_name;
        private Label stu_mail;
        private TextBox mothername;
        private TextBox fathername;
        private Label stu_blood;
        private TextBox stublood;
        private TextBox stumail;
        private TextBox stuphn;
        private Label stu_gender;
        private RadioButton stu_gender_other;
        private RadioButton stu_gender_female;
        private RadioButton stu_gender_male;
        private Label clubs;
        private Label stu_backlogs;
        private Label stu_cgpa;
        private ListBox clubs_list;
        private TextBox stubacklogs;
        private TextBox stucgpa;
        private Button submit_btn;
    }
}
