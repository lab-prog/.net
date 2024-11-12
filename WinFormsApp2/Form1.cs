namespace WinFormsApp2 {
    public partial class Form1 : Form {
        string g;
        public Form1() {
            InitializeComponent();
        }private void Form1_Load(object sender, EventArgs e){ }

        private void groupBox1_Enter(object sender, EventArgs e){ }
        private void ClearForm() {
            sturoll.Text = string.Empty;
            stuname.Text = string.Empty;
            stuyear.SelectedIndex = -1;
            stusem.SelectedIndex = -1;
            fathername.Text = string.Empty;
            mothername.Text = string.Empty;
            stuphn.Text = string.Empty;
            stumail.Text = string.Empty;
            stublood.Text = string.Empty;
            stucgpa.Text = string.Empty;
            stubacklogs.Text = string.Empty;
            clubs_list.ClearSelected();

            stu_gender_male.Checked = false;
            stu_gender_female.Checked = false;
            stu_gender_other.Checked = false;
        }
        private void submit_btn_Click(object sender, EventArgs e) {

            if (stu_gender_male.Checked == true)
            {
                g = "Male";
            }
            else if (stu_gender_female.Checked == true)
            {
                g = "Female";
            }
            else
            {
                g = "Other";
            }

            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
                else if (control is System.Windows.Forms.ComboBox)
                {
                    if (((System.Windows.Forms.ComboBox)control).SelectedIndex == -1)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
                else if (control is ListBox)
                {
                    if (((ListBox)control).SelectedIndex == -1)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }

            }
            if (!stu_gender_male.Checked && !stu_gender_female.Checked && !stu_gender_other.Checked)
            {
                isAnyEmpty = true;
            }
            if (isAnyEmpty)
            {
                MessageBox.Show("One or more fields are empty, fill it before submit");
            }
            else
            {
                MessageBox.Show("Submission Completed. \n" + "Student Name : " + stuname.Text + "\nStudent RollNo: " + sturoll.Text + "\nStudent Semester: " + stuyear.Text + "\nStudent Semester: " + stusem.Text + "\nFather Name: " + fathername.Text + "\nMother Name: " + mothername.Text + "\nStudent Phone: " + stuphn.Text + "\nStudent Email: " + stumail.Text + "\nStudent Blood Group: " + stublood.Text + "\nStudent Gender: " + g + "\nStudent CGPA: " + stucgpa.Text + "\nStudent Backlogs: " + stubacklogs.Text + "\nClubs Interested: " + clubs_list.Text);
                ClearForm();
            }
        }
    }
}
