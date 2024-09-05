namespace 计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        float a = 0;
        float b = 0;
        float result = 0;
        string operation = "";

        private void button11_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "+";
            label1.Text += "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "-";
            label1.Text += "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "*";
            label1.Text += "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "/";
            label1.Text += "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "";
        }

        private void PerformOperation()
        {
            string c = label1.Text;
            char[] operators = { '+', '-', '*', '/' };
            int operatorIndex = -1;
            char currentOperation = '\0';

            foreach (char op in operators)
            {
                operatorIndex = c.IndexOf(op);
                if (operatorIndex != -1)
                {
                    currentOperation = op;
                    break;
                }
            }

            if (operatorIndex == -1)
            {
                return;
            }

            try
            {
                a = float.Parse(c.Substring(0, operatorIndex));
                b = float.Parse(c.Substring(operatorIndex + 1));
                result = currentOperation switch
                {
                    '+' => a + b,
                    '-' => a - b,
                    '*' => a * b,
                    '/' => a / b,
                    _ => throw new InvalidOperationException("未知符号")
                };
                label1.Text = result.ToString();
            }
            catch (FormatException)
            {
                label1.Text = "数字格式无效";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            a = 0;
            b = 0;
            result = 0;
            operation = "";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
        }
    }
}
