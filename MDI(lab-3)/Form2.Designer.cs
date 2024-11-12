namespace MDI_lab_3_
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label10 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            listBox1 = new ListBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Acedamic Information";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "I", "II" });
            comboBox2.Location = new Point(180, 191);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 199);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 6;
            label4.Text = "Current Semester : ";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "I", "II", "III", "IV" });
            comboBox1.Location = new Point(180, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 31);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 147);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 3;
            label3.Text = "Current Year : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 99);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 2;
            label2.Text = "Student Name : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 49);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Roll : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(519, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(503, 397);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Personal Information";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(389, 316);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(82, 29);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(290, 316);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(209, 318);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 320);
            label10.Name = "label10";
            label10.Size = new Size(83, 25);
            label10.TabIndex = 11;
            label10.Text = "Gender : ";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(209, 46);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(274, 31);
            textBox7.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(209, 99);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(274, 31);
            textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(209, 155);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(274, 31);
            textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(209, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 31);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(209, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 31);
            textBox3.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 266);
            label9.Name = "label9";
            label9.Size = new Size(181, 25);
            label9.TabIndex = 5;
            label9.Text = "Student Blood Type : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 215);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 4;
            label8.Text = "Student Mail : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 161);
            label7.Name = "label7";
            label7.Size = new Size(147, 25);
            label7.TabIndex = 3;
            label7.Text = "Student Mobile : ";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 108);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 2;
            label6.Text = "Mother Name : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 49);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 1;
            label5.Text = "Father Name : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(24, 286);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(478, 322);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Student Extra Circular Information";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Music Club", "Culanry Club", "Dance Club", "Animation Club", "Martial Arts Club", "Not Interested" });
            listBox1.Location = new Point(125, 152);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(216, 154);
            listBox1.TabIndex = 17;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(125, 103);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(274, 31);
            textBox9.TabIndex = 16;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(125, 51);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(274, 31);
            textBox8.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 152);
            label13.Name = "label13";
            label13.Size = new Size(70, 25);
            label13.TabIndex = 14;
            label13.Text = "Clubs : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 109);
            label12.Name = "label12";
            label12.Size = new Size(96, 25);
            label12.TabIndex = 13;
            label12.Text = "Backlogs : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 57);
            label11.Name = "label11";
            label11.Size = new Size(70, 25);
            label11.TabIndex = 12;
            label11.Text = "CGPA : ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Location = new Point(792, 531);
            button1.Name = "button1";
            button1.Size = new Size(133, 48);
            button1.TabIndex = 3;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1034, 650);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
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
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox3;
        private ComboBox comboBox2;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label10;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label12;
        private Label label11;
        private ListBox listBox1;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label13;
        private Button button1;
    }
}