using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
namespace Student_Information_lab_2_
{
    public partial class Form1 : Form
    {
        string g;
        public Form1()
        {
            InitializeComponent();
        }







        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


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
                string cs = "Data Source=PATTAPU\\SQLEXPRESS;Initial Catalog=STUDENTINFORMATIONFORM;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string insertQuery = "INSERT INTO STUDENTINFORMATION VALUES (@STU_ROLL, @STU_NAME, @STU_YEAR, @STU_SEM, @FATHER_NAME, @MOTHER_NAME, @STU_PHN, @STU_MAIL, @STU_BLOOD, @STU_GENDER, @STU_CGPA, @STU_BACKLOGS, @CLUBS)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@STU_ROLL", sturoll.Text);
                cmd.Parameters.AddWithValue("@STU_NAME", stuname.Text);
                cmd.Parameters.AddWithValue("@STU_YEAR", stuyear.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@STU_SEM", stusem.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@FATHER_NAME", fathername.Text);
                cmd.Parameters.AddWithValue("@MOTHER_NAME", mothername.Text);
                cmd.Parameters.AddWithValue("@STU_PHN", stuphn.Text);
                cmd.Parameters.AddWithValue("@STU_MAIL", stumail.Text);
                cmd.Parameters.AddWithValue("@STU_BLOOD", stublood.Text);
                cmd.Parameters.AddWithValue("@STU_GENDER", g);
                cmd.Parameters.AddWithValue("@STU_CGPA", stucgpa.Text);
                cmd.Parameters.AddWithValue("@STU_BACKLOGS", stubacklogs.Text);
                cmd.Parameters.AddWithValue("@CLUBS", clubs_list.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Submission Complete", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);



                ClearForm();

                

            }


        }
        private void ClearForm()
        {
            /*foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    control.Text = string.Empty;
                }
                else if (control is System.Windows.Forms.ComboBox)
                {
                    ((System.Windows.Forms.ComboBox)(control)).SelectedIndex = -1;
                }
                else if (control is ListBox)
                {
                    ((ListBox)(control)).ClearSelected();
                }
                else if (control is RadioButton)
                {
                    ((RadioButton)(control)).Checked = false;
                }
            }*/
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
    }
}

