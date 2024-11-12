namespace MDI_lab_3_
{
    public partial class Form1 : Form
    {
        int a = 0;
        int b, c;
        String msg;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tb1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tb1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tb1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tb1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tb1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tb1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tb1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tb1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tb1.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tb1.Text += btn0.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            msg = "+";
            a = Convert.ToInt32(tb1.Text);
            tb1.Text = "";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            msg = "-";
            a = Convert.ToInt32(tb1.Text);
            tb1.Text = "";
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            msg = "*";
            a = Convert.ToInt32(tb1.Text);
            tb1.Text = "";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            msg = "/";
            a = Convert.ToInt32(tb1.Text);
            tb1.Text = "";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (msg == "+")
            {
                b = Convert.ToInt32(tb1.Text);
                c = a + b;
                tb1.Text = c.ToString();
            }
            if (msg == "-")
            {
                b = Convert.ToInt32(tb1.Text);
                c = a - b;
                tb1.Text = c.ToString();
            }
            if (msg == "*")
            {
                b = Convert.ToInt32(tb1.Text);
                c = a * b;
                tb1.Text = c.ToString();
            }
            if (msg == "/")
            {
                b = Convert.ToInt32(tb1.Text);
                c = a / b;
                tb1.Text = c.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
