using Evaluator.Core;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn7_Click_1(object sender, EventArgs e)
        {
            txtDispley.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDispley.Text += ".";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "/";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "-";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtDispley.Text = txtDispley.Text.Substring(0, txtDispley.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDispley.Text = string.Empty;
        }

        private void btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "(";
        }

        private void btnCloseParenthesis_Click(object sender, EventArgs e)
        {
            txtDispley.Text += ")";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtDispley.Text += "^";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            txtDispley.Text += $"={ExpressionEvaluator.Evaluate(txtDispley.Text)}";
        }
    }
}
