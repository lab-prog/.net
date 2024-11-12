using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_lab_3_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String g;
            if (radioButton1.Checked == true)
            {
                g = "Male";
            } else if (radioButton2.Checked == true) {
                g = "Female";
            }
            else
            {
                g = "Other";
            }
            MessageBox.Show("Student Name: "+textBox2.Text+"\nStudent Roll No: "+textBox1.Text+"\nCurrent Year: "+comboBox1.Text+"\nCurrent Semester: "+comboBox2.Text+"\nFather Name: "+textBox7.Text+"\nMother Name: "+textBox6.Text+"\nStudent Mail: "+textBox5.Text+"\nStudent Blood Type: "+textBox4.Text+"\nStudent Gender: "+ g +"\nStudent CGPA: "+textBox8.Text+"\nStudent Backlogs: "+textBox9.Text+"\nClubs: "+listBox1.SelectedItem.ToString());
        }
    }
}
