namespace calculator
{
    public partial class calculator : Form
    {
        int a = 0;
        int b, c;
        String msg;

        public calculator()
        {
            InitializeComponent();
        }


        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_1.Text;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_2.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_3.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_4.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_5.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_6.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_8.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_9.Text;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_1.Text += btn_0.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_1.Text = "";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (msg == "+")
            {
                b = Convert.ToInt32(tb_1.Text);
                c = a + b;
                tb_1.Text = c.ToString();
            }
            if (msg == "-")
            {
                b = Convert.ToInt32(tb_1.Text);
                c = a - b;
                tb_1.Text = c.ToString();
            }
            if (msg == "*")
            {
                b = Convert.ToInt32(tb_1.Text);
                c = a * b;
                tb_1.Text = c.ToString();
            }
            if (msg == "/")
            {
                b = Convert.ToInt32(tb_1.Text);
                c = a / b;
                tb_1.Text = c.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            msg = "+";
            a = Convert.ToInt32(tb_1.Text);
            tb_1.Text = "";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            msg = "-";
            a = Convert.ToInt32(tb_1.Text);
            tb_1.Text = "";
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            msg = "*";
            a = Convert.ToInt32(tb_1.Text);
            tb_1.Text = "";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            msg = "/";
            a = Convert.ToInt32(tb_1.Text);
            tb_1.Text = "";
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
